using Microsoft.Ink;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace gInk
{
    public partial class FormDisplay : Form
    {
        public Root Root;
        private IntPtr Canvus;
        private IntPtr canvusDc;
        private IntPtr OneStrokeCanvus;
        private IntPtr onestrokeDc;
        private IntPtr blankcanvusDc=IntPtr.Zero;
        private Graphics gCanvus;
        public Graphics gOneStrokeCanvus;

        //Bitmap ScreenBitmap;
        private IntPtr hScreenBitmap;

        private IntPtr memscreenDc;

        private Bitmap gpButtonsImage;
        private Bitmap gpPenWidthImage;
        private SolidBrush TransparentBrush;
        private SolidBrush SemiTransparentBrush;

        private byte[] screenbits;
        private byte[] lastscreenbits;

        // http://www.csharp411.com/hide-form-from-alttab/
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        public DateTime TickStartTime1 { get => TickStartTime; set => TickStartTime = value; }

        public FormDisplay(Root root)
        {
            Root = root;
            InitializeComponent();

            Left = SystemInformation.VirtualScreen.Left;
            Top = SystemInformation.VirtualScreen.Top;
            //int targetbottom = 0;
            //foreach (Screen screen in Screen.AllScreens)
            //{
            //	if (screen.WorkingArea.Bottom > targetbottom)
            //		targetbottom = screen.WorkingArea.Bottom;
            //}
            //int virwidth = SystemInformation.VirtualScreen.Width;
            //this.Width = virwidth;
            //this.Height = targetbottom - this.Top;
            Width = SystemInformation.VirtualScreen.Width;
            Height = SystemInformation.VirtualScreen.Height - 2;

            Bitmap InitCanvus = new Bitmap(Width, Height);
            Canvus = InitCanvus.GetHbitmap(Color.FromArgb(0));
            OneStrokeCanvus = InitCanvus.GetHbitmap(Color.FromArgb(0));
            //BlankCanvus = InitCanvus.GetHbitmap(Color.FromArgb(0));

            IntPtr screenDc = GetDC(IntPtr.Zero);
            canvusDc = CreateCompatibleDC(screenDc);
            SelectObject(canvusDc, Canvus);
            onestrokeDc = CreateCompatibleDC(screenDc);
            SelectObject(onestrokeDc, OneStrokeCanvus);
            //blankcanvusDc = CreateCompatibleDC(screenDc);
            //SelectObject(blankcanvusDc, BlankCanvus);
            gCanvus = Graphics.FromHdc(canvusDc);
            gCanvus.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            gOneStrokeCanvus = Graphics.FromHdc(onestrokeDc);
            gOneStrokeCanvus.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            if (Root.AutoScroll)
            {
                hScreenBitmap = InitCanvus.GetHbitmap(Color.FromArgb(0));
                memscreenDc = CreateCompatibleDC(screenDc);
                SelectObject(memscreenDc, hScreenBitmap);
                screenbits = new byte[50000000];
                lastscreenbits = new byte[50000000];
            }
            ReleaseDC(IntPtr.Zero, screenDc);
            InitCanvus.Dispose();

            //this.DoubleBuffered = true;

            int gpheight = (int)(Screen.PrimaryScreen.Bounds.Height * Root.ToolbarHeight);
            gpButtonsImage = new Bitmap(2400, gpheight);
            gpPenWidthImage = new Bitmap(200, gpheight);
            TransparentBrush = new SolidBrush(Color.Transparent);
            SemiTransparentBrush = new SolidBrush(Color.FromArgb(120, 255, 255, 255));

            ToTopMostThrough();
        }

        public void ToTopMostThrough()
        {
            UInt32 dwExStyle = GetWindowLong(Handle, -20);
            SetWindowLong(Handle, -20, dwExStyle | 0x00080000);
            SetWindowPos(Handle, (IntPtr)0, 0, 0, 0, 0, 0x0002 | 0x0001 | 0x0004 | 0x0010 | 0x0020);
            //SetLayeredWindowAttributes(this.Handle, 0x00FFFFFF, 1, 0x2);
            SetWindowLong(Handle, -20, dwExStyle | 0x00080000 | 0x00000020);
            SetWindowPos(Handle, (IntPtr)(-1), 0, 0, 0, 0, 0x0002 | 0x0001 | 0x0010 | 0x0020);
        }

        public void ClearCanvus()
        {
            gCanvus.Clear(Color.Transparent);
        }

        public void ClearCanvus(Graphics g)
        {
            g.Clear(Color.Transparent);
        }

        public void DrawSnapping(Rectangle rect)
        {
            gCanvus.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            if (rect.Width > 0 && rect.Height > 0)
            {
                gCanvus.FillRectangle(SemiTransparentBrush, new Rectangle(0, 0, rect.Left, Height));
                gCanvus.FillRectangle(SemiTransparentBrush, new Rectangle(rect.Right, 0, Width - rect.Right, Height));
                gCanvus.FillRectangle(SemiTransparentBrush, new Rectangle(rect.Left, 0, rect.Width, rect.Top));
                gCanvus.FillRectangle(SemiTransparentBrush, new Rectangle(rect.Left, rect.Bottom, rect.Width, Height - rect.Bottom));
                Pen pen = new Pen(Color.FromArgb(200, 80, 80, 80));
                pen.Width = 3;
                gCanvus.DrawRectangle(pen, rect);
            }
            else
            {
                gCanvus.FillRectangle(SemiTransparentBrush, new Rectangle(0, 0, Width, Height));
            }
            gCanvus.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
        }

        public void DrawButtons(bool redrawbuttons, bool exiting = false)
        {
            if (Root.AlwaysHideToolbar)
                return;

            int top, height, left, width;
            int fullwidth;
            int gpbl;
            int drawwidth;

            top = Root.FormCollection.gpButtons.Top;
            height = Root.FormCollection.gpButtons.Height;
            left = Root.FormCollection.gpButtons.Left;
            width = Root.FormCollection.gpButtons.Width;
            fullwidth = Root.FormCollection.gpButtonsWidth;
            drawwidth = width;
            gpbl = Root.FormCollection.gpButtonsLeft;
            if (left + width > gpbl + fullwidth)
                drawwidth = gpbl + fullwidth - left;

            if (redrawbuttons)
                Root.FormCollection.gpButtons.DrawToBitmap(gpButtonsImage, new Rectangle(0, 0, width, height));

            if (exiting)
            {
                int clearleft = Math.Max(left - 120, gpbl);
                //gCanvus.FillRectangle(TransparentBrush, clearleft, top, fullwidth * 2, height);
                gCanvus.FillRectangle(TransparentBrush, clearleft, top, drawwidth, height);
            }
            gCanvus.DrawImage(gpButtonsImage, left, top, new Rectangle(0, 0, drawwidth, height), GraphicsUnit.Pixel);

            if (Root.gpPenWidthVisible)
            {
                top = Root.FormCollection.gpPenWidth.Top;
                height = Root.FormCollection.gpPenWidth.Height;
                left = Root.FormCollection.gpPenWidth.Left;
                width = Root.FormCollection.gpPenWidth.Width;
                if (redrawbuttons)
                    Root.FormCollection.gpPenWidth.DrawToBitmap(gpPenWidthImage, new Rectangle(0, 0, width, height));

                gCanvus.DrawImage(gpPenWidthImage, left, top);
            }
        }

        public void DrawButtons(Graphics g, bool redrawbuttons, bool exiting = false)
        {
            int top, height, left, width;
            int fullwidth;
            int gpbl;
            int drawwidth;

            top = Root.FormCollection.gpButtons.Top;
            height = Root.FormCollection.gpButtons.Height;
            left = Root.FormCollection.gpButtons.Left;
            width = Root.FormCollection.gpButtons.Width;
            fullwidth = Root.FormCollection.gpButtonsWidth;
            drawwidth = width;
            gpbl = Root.FormCollection.gpButtonsLeft;
            if (left + width > gpbl + fullwidth)
                drawwidth = gpbl + fullwidth - left;

            if (redrawbuttons)
                Root.FormCollection.gpButtons.DrawToBitmap(gpButtonsImage, new Rectangle(0, 0, width, height));

            if (exiting)
            {
                int clearleft = Math.Max(left - 120, gpbl);
                //g.FillRectangle(TransparentBrush, clearleft, top, width + 80, height);
                g.FillRectangle(TransparentBrush, clearleft, top, drawwidth, height);
            }
            g.DrawImage(gpButtonsImage, left, top);

            if (Root.gpPenWidthVisible)
            {
                top = Root.FormCollection.gpPenWidth.Top;
                height = Root.FormCollection.gpPenWidth.Height;
                left = Root.FormCollection.gpPenWidth.Left;
                width = Root.FormCollection.gpPenWidth.Width;
                if (redrawbuttons)
                    Root.FormCollection.gpPenWidth.DrawToBitmap(gpPenWidthImage, new Rectangle(0, 0, width, height));

                g.DrawImage(gpPenWidthImage, left, top);
            }
        }

        public void DrawStrokes()
        {
            if (Root.InkVisible)
                Root.FormCollection.IC.Renderer.Draw(gCanvus, Root.FormCollection.IC.Ink.Strokes);
        }

        public void DrawStrokes(Graphics g)
        {
            if (Root.InkVisible)
                Root.FormCollection.IC.Renderer.Draw(g, Root.FormCollection.IC.Ink.Strokes);
        }

        public void MoveStrokes(int dy)
        {
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, 100);
            Root.FormCollection.IC.Renderer.PixelToInkSpace(gCanvus, ref pt1);
            Root.FormCollection.IC.Renderer.PixelToInkSpace(gCanvus, ref pt2);
            float unitperpixel = (pt2.Y - pt1.Y) / 100.0f;
            float shouldmove = dy * unitperpixel;
            foreach (Stroke stroke in Root.FormCollection.IC.Ink.Strokes)
                if (!stroke.Deleted)
                    stroke.Move(0, shouldmove);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateFormDisplay(true);
        }

        public uint N1(int i, int j)
        {
            //return BitConverter.ToUInt32(screenbits, (this.Width * j + i) * 4);
            Nlastp1 = (Width * j + i) * 4 + 1;
            return screenbits[Nlastp1];
        }

        public uint N2(int i, int j)
        {
            //return BitConverter.ToUInt32(screenbits, (this.Width * j + i) * 4);
            Nlastp2 = (Width * j + i) * 4 + 1;
            return screenbits[Nlastp2];
        }

        public uint L(int i, int j)
        {
            //return BitConverter.ToUInt32(lastscreenbits, (this.Width * j + i) * 4);
            Llastp = (Width * j + i) * 4 + 1;
            return lastscreenbits[Llastp];
        }

        private int Nlastp1, Nlastp2, Llastp;

        public uint Nnext1()
        {
            Nlastp1 += 40;
            return screenbits[Nlastp1];
        }

        public uint Nnext2()
        {
            Nlastp2 += 40;
            return screenbits[Nlastp2];
        }

        public uint Lnext()
        {
            Llastp += 40;
            return lastscreenbits[Llastp];
        }

        public void SnapShot(Rectangle rect)
        {
            string snapbasepath = Root.SnapshotBasePath;
            snapbasepath = Environment.ExpandEnvironmentVariables(snapbasepath);
            if (Root.SnapshotBasePath == "%USERPROFILE%/Pictures/gInk/")
                if (!System.IO.Directory.Exists(snapbasepath))
                    System.IO.Directory.CreateDirectory(snapbasepath);

            if (System.IO.Directory.Exists(snapbasepath))
            {
                IntPtr screenDc = GetDC(IntPtr.Zero);

                const int VERTRES = 10;
                const int DESKTOPVERTRES = 117;
                int LogicalScreenHeight = GetDeviceCaps(screenDc, VERTRES);
                int PhysicalScreenHeight = GetDeviceCaps(screenDc, DESKTOPVERTRES);
                float ScreenScalingFactor = PhysicalScreenHeight / (float)LogicalScreenHeight;

                rect.X = (int)(rect.X * ScreenScalingFactor);
                rect.Y = (int)(rect.Y * ScreenScalingFactor);
                rect.Width = (int)(rect.Width * ScreenScalingFactor);
                rect.Height = (int)(rect.Height * ScreenScalingFactor);

                Bitmap tempbmp = new Bitmap(rect.Width, rect.Height);
                Graphics g = Graphics.FromImage(tempbmp);
                g.Clear(Color.Red);

                IntPtr hDest = CreateCompatibleDC(screenDc);
                IntPtr hBmp = tempbmp.GetHbitmap();
                SelectObject(hDest, hBmp);
                bool b = BitBlt(hDest, 0, 0, rect.Width, rect.Height, screenDc, rect.Left, rect.Top, (uint)(CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt));
                tempbmp = Bitmap.FromHbitmap(hBmp);

                if (!b)
                {
                    g = Graphics.FromImage(tempbmp);
                    g.Clear(Color.Blue);
                    g.CopyFromScreen(rect.Left, rect.Top, 0, 0, new Size(rect.Width, rect.Height));
                }

                Clipboard.SetImage(tempbmp);
                DateTime now = DateTime.Now;
                string nowstr = now.Year.ToString() + "-" + now.Month.ToString("D2") + "-" + now.Day.ToString("D2") + " " + now.Hour.ToString("D2") + "-" + now.Minute.ToString("D2") + "-" + now.Second.ToString("D2");
                string savefilename = nowstr + ".png";
                Root.SnapshotFileFullPath = snapbasepath + savefilename;

                tempbmp.Save(Root.SnapshotFileFullPath, System.Drawing.Imaging.ImageFormat.Png);

                tempbmp.Dispose();
                DeleteObject(hBmp);
                ReleaseDC(IntPtr.Zero, screenDc);
                DeleteDC(hDest);

                Root.UponBalloonSnap = true;
            }
        }

        public int Test()
        {
            IntPtr screenDc = GetDC(IntPtr.Zero);

            // big time consuming, but not CPU consuming
            BitBlt(memscreenDc, Width / 4, 0, Width / 2, Height, screenDc, Width / 4, 0, 0x00CC0020);
            // <1% CPU
            GetBitmapBits(hScreenBitmap, Width * Height * 4, screenbits);

            int dj;
            int maxidpixels = 0;
            int maxdj = 0;

            // 25% CPU with 1x10x10 sample rate?
            int istart = Width / 2 - Width / 4;
            int iend = Width / 2 + Width / 4;
            for (dj = -Height * 3 / 8 + 1; dj < Height * 3 / 8 - 1; dj++)
            {
                int idpixels = 0;
                for (int j = Height / 2 - Height / 8; j < Height / 2 + Height / 8; j += 10)
                {
                    L(istart - 10, j);
                    N1(istart - 10, j);
                    N2(istart - 10, j + dj);
                    for (int i = istart; i < iend; i += 10)
                    {
                        //uint l = Lnext();
                        //uint n1 = Nnext1();
                        //uint n2 = Nnext2();
                        //if (l != n1)
                        //{
                        //	chdpixels++;
                        //	if (l == n2)
                        //		idpixels++;
                        //}

                        if (Lnext() == Nnext2())
                            idpixels++;
                    }
                }

                //float idchdrio = (float)idpixels / chdpixels;
                if (idpixels > maxidpixels)
                //if (idchdrio > maxidchdrio)
                {
                    //maxidchdrio = idchdrio;
                    maxidpixels = idpixels;
                    maxdj = dj;
                }
            }

            //if (maxidchdrio < 0.1 || maxidpixels < 30)
            if (maxidpixels < 100)
                maxdj = 0;

            // 2% CPU
            IntPtr pscreenbits = Marshal.UnsafeAddrOfPinnedArrayElement(screenbits, (int)(Width * Height * 4 * 0.375));
            IntPtr plastscreenbits = Marshal.UnsafeAddrOfPinnedArrayElement(lastscreenbits, (int)(Width * Height * 4 * 0.375));
            memcpy(plastscreenbits, pscreenbits, Width * Height * 4 / 4);

            ReleaseDC(IntPtr.Zero, screenDc);
            return maxdj;
        }

        public void UpdateFormDisplay(bool draw)
        {
            IntPtr screenDc = GetDC(IntPtr.Zero);

            //Display-rectangle
            Size size = new Size(Width, Height);
            Point pointSource = new Point(0, 0);
            Point topPos = new Point(Left, Top);

            //Set up blending options
            BLENDFUNCTION blend = new BLENDFUNCTION();
            blend.BlendOp = AC_SRC_OVER;
            blend.BlendFlags = 0;
            blend.SourceConstantAlpha = 255;  // additional alpha multiplier to the whole image. value 255 means multiply with 1.
            blend.AlphaFormat = AC_SRC_ALPHA;

            if (draw)
                UpdateLayeredWindow(Handle, screenDc, ref topPos, ref size, canvusDc, ref pointSource, 0, ref blend, ULW_ALPHA);
            else
                UpdateLayeredWindow(Handle, screenDc, ref topPos, ref size, blankcanvusDc, ref pointSource, 0, ref blend, ULW_ALPHA);

            //Clean-up
            ReleaseDC(IntPtr.Zero, screenDc);
        }

        private int stackmove = 0;
        private int Tick = 0;
        private DateTime TickStartTime;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick++;

            /*
			if (Tick == 1)
				TickStartTime = DateTime.Now;
			else if (Tick % 60 == 0)
			{
				Console.WriteLine(60 / (DateTime.Now - TickStartTime).TotalMilliseconds * 1000);
				TickStartTime = DateTime.Now;
			}
			*/

            if (Root.UponAllDrawingUpdate)
            {
                ClearCanvus();
                DrawStrokes();
                DrawButtons(true);
                if (Root.Snapping > 0)
                    DrawSnapping(Root.SnappingRect);
                UpdateFormDisplay(true);
                Root.UponAllDrawingUpdate = false;
            }
            else if (Root.UponTakingSnap)
            {
                if (Root.SnappingRect.Width == Width && Root.SnappingRect.Height == Height)
                    System.Threading.Thread.Sleep(200);
                ClearCanvus();
                DrawStrokes();
                //DrawButtons(false);
                UpdateFormDisplay(true);
                SnapShot(Root.SnappingRect);
                Root.UponTakingSnap = false;
                if (Root.CloseOnSnap == "true")
                {
                    Root.FormCollection.RetreatAndExit();
                }
                else if (Root.CloseOnSnap == "blankonly")
                {
                    if ((Root.FormCollection.IC.Ink.Strokes.Count == 0))
                        Root.FormCollection.RetreatAndExit();
                }
            }
            else if (Root.Snapping == 2)
            {
                if (Root.MouseMovedUnderSnapshotDragging)
                {
                    ClearCanvus();
                    DrawStrokes();
                    DrawButtons(false);
                    DrawSnapping(Root.SnappingRect);
                    UpdateFormDisplay(true);
                    Root.MouseMovedUnderSnapshotDragging = false;
                }
            }
            else if (Root.FormCollection.IC.CollectingInk && Root.EraserMode == false && Root.InkVisible)
            {
                //ClearCanvus();
                //DrawStrokes();
                //DrawButtons(false);
                //UpdateFormDisplay();
                if (Root.FormCollection.IC.Ink.Strokes.Count > 0)
                {
                    Stroke stroke = Root.FormCollection.IC.Ink.Strokes[Root.FormCollection.IC.Ink.Strokes.Count - 1];
                    if (!stroke.Deleted)
                    {
                        Rectangle box = stroke.GetBoundingBox();
                        Point lt = new Point(box.Left, box.Top);
                        Point rb = new Point(box.Right + 1, box.Bottom + 1);
                        Root.FormCollection.IC.Renderer.InkSpaceToPixel(gCanvus, ref lt);
                        Root.FormCollection.IC.Renderer.InkSpaceToPixel(gCanvus, ref rb);
                        BitBlt(canvusDc, lt.X, lt.Y, rb.X - lt.X, rb.Y - lt.Y, onestrokeDc, lt.X, lt.Y, (uint)CopyPixelOperation.SourceCopy);
                        Root.FormCollection.IC.Renderer.Draw(gCanvus, stroke, Root.FormCollection.IC.DefaultDrawingAttributes);
                    }
                    UpdateFormDisplay(true);
                }
            }
            else if (Root.FormCollection.IC.CollectingInk && Root.EraserMode == true)
            {
                ClearCanvus();
                DrawStrokes();
                DrawButtons(false);
                UpdateFormDisplay(true);
            }
            else if (Root.Snapping < -58)
            {
                ClearCanvus();
                DrawStrokes();
                DrawButtons(false);
                UpdateFormDisplay(true);
            }
            else if (Root.UponButtonsUpdate > 0)
            {
                if ((Root.UponButtonsUpdate & 0x2) > 0)
                    DrawButtons(true, (Root.UponButtonsUpdate & 0x4) > 0);
                else if ((Root.UponButtonsUpdate & 0x1) > 0)
                    DrawButtons(false, (Root.UponButtonsUpdate & 0x4) > 0);
                UpdateFormDisplay(true);
                Root.UponButtonsUpdate = 0;
            }
            else if (Root.UponSubPanelUpdate)
            {
                ClearCanvus();
                DrawStrokes();
                DrawButtons(false);
                UpdateFormDisplay(true);
                Root.UponSubPanelUpdate = false;
            }

            if (Root.AutoScroll && Root.PointerMode)
            {
                int moved = Test();
                stackmove += moved;

                if (stackmove != 0 && Tick % 10 == 1)
                {
                    MoveStrokes(stackmove);
                    ClearCanvus();
                    DrawStrokes();
                    DrawButtons(false);
                    UpdateFormDisplay(true);
                    stackmove = 0;
                }
            }
        }

        private void FormDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteObject(Canvus);
            //DeleteObject(BlankCanvus);
            DeleteDC(canvusDc);
            if (Root.AutoScroll)
            {
                DeleteObject(hScreenBitmap);
                DeleteDC(memscreenDc);
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
        public static extern bool DeleteDC([In] IntPtr hdc);

        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC", SetLastError = true)]
        private static extern IntPtr CreateCompatibleDC([In] IntPtr hdc);

        [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
        public static extern IntPtr SelectObject([In] IntPtr hdc, [In] IntPtr hgdiobj);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr hObject);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, uint crKey, [In] ref BLENDFUNCTION pblend, uint dwFlags);

        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

        [DllImport("gdi32.dll")]
        public static extern bool StretchBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int nWidthSrc, int nHeightSrc, long dwRop);

        [StructLayout(LayoutKind.Sequential)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;

            public BLENDFUNCTION(byte op, byte flags, byte alpha, byte format)
            {
                BlendOp = op;
                BlendFlags = flags;
                SourceConstantAlpha = alpha;
                AlphaFormat = format;
            }
        }

        private const int ULW_ALPHA = 2;
        private const int AC_SRC_OVER = 0x00;
        private const int AC_SRC_ALPHA = 0x01;

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);

        [DllImport("user32.dll")]
        public extern static bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("gdi32.dll")]
        private static extern int GetBitmapBits(IntPtr hbmp, int cbBuffer, [Out] byte[] lpvBits);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("gdi32.dll")]
        private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        [DllImport("msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern IntPtr memcpy(IntPtr dest, IntPtr src, int count);
    }
}