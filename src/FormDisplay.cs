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
        private IntPtr blankcanvusDc = IntPtr.Zero;
        private Graphics gCanvus;
        public Graphics gOneStrokeCanvus;

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

        public DateTime TickStartTime1 { get; set; }

        public FormDisplay(Root root)
        {
            Root = root;
            InitializeComponent();

            Left = SystemInformation.VirtualScreen.Left;
            Top = SystemInformation.VirtualScreen.Top;
            Width = SystemInformation.VirtualScreen.Width;
            Height = SystemInformation.VirtualScreen.Height - 2;

            Bitmap InitCanvus = new Bitmap(Width, Height);
            Canvus = InitCanvus.GetHbitmap(Color.FromArgb(0));
            OneStrokeCanvus = InitCanvus.GetHbitmap(Color.FromArgb(0));

            IntPtr screenDc = WinApi.GetDC(IntPtr.Zero);
            canvusDc = WinApi.CreateCompatibleDC(screenDc);
            WinApi.SelectObject(canvusDc, Canvus);
            onestrokeDc = WinApi.CreateCompatibleDC(screenDc);
            WinApi.SelectObject(onestrokeDc, OneStrokeCanvus);
            gCanvus = Graphics.FromHdc(canvusDc);
            gCanvus.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            gOneStrokeCanvus = Graphics.FromHdc(onestrokeDc);
            gOneStrokeCanvus.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            if (Root.AutoScroll)
            {
                hScreenBitmap = InitCanvus.GetHbitmap(Color.FromArgb(0));
                memscreenDc = WinApi.CreateCompatibleDC(screenDc);
                WinApi.SelectObject(memscreenDc, hScreenBitmap);
                screenbits = new byte[50000000];
                lastscreenbits = new byte[50000000];
            }
            WinApi.ReleaseDC(IntPtr.Zero, screenDc);
            InitCanvus.Dispose();

            int gpheight = (int)(Screen.PrimaryScreen.Bounds.Height * Root.ToolbarHeight);
            gpButtonsImage = new Bitmap(2400, gpheight);
            gpPenWidthImage = new Bitmap(200, gpheight);
            TransparentBrush = new SolidBrush(Color.Transparent);
            SemiTransparentBrush = new SolidBrush(Color.FromArgb(120, 255, 255, 255));

            ToTopMostThrough();
        }

        public void ToTopMostThrough()
        {
            uint dwExStyle = WinApi.GetWindowLong(Handle, -20);
            WinApi.SetWindowLong(Handle, -20, dwExStyle | 0x00080000);
            WinApi.SetWindowPos(Handle, (IntPtr)0, 0, 0, 0, 0, 0x0002 | 0x0001 | 0x0004 | 0x0010 | 0x0020);
            WinApi.SetWindowLong(Handle, -20, dwExStyle | 0x00080000 | 0x00000020);
            WinApi.SetWindowPos(Handle, (IntPtr)(-1), 0, 0, 0, 0, 0x0002 | 0x0001 | 0x0010 | 0x0020);
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
                IntPtr screenDc = WinApi.GetDC(IntPtr.Zero);

                const int VERTRES = 10;
                const int DESKTOPVERTRES = 117;
                int LogicalScreenHeight = WinApi.GetDeviceCaps(screenDc, VERTRES);
                int PhysicalScreenHeight = WinApi.GetDeviceCaps(screenDc, DESKTOPVERTRES);
                float ScreenScalingFactor = PhysicalScreenHeight / (float)LogicalScreenHeight;

                rect.X = (int)(rect.X * ScreenScalingFactor);
                rect.Y = (int)(rect.Y * ScreenScalingFactor);
                rect.Width = (int)(rect.Width * ScreenScalingFactor);
                rect.Height = (int)(rect.Height * ScreenScalingFactor);

                Bitmap tempbmp = new Bitmap(rect.Width, rect.Height);
                Graphics g = Graphics.FromImage(tempbmp);
                g.Clear(Color.Red);

                IntPtr hDest = WinApi.CreateCompatibleDC(screenDc);
                IntPtr hBmp = tempbmp.GetHbitmap();
                WinApi.SelectObject(hDest, hBmp);
                bool b = WinApi.BitBlt(hDest, 0, 0, rect.Width, rect.Height, screenDc, rect.Left, rect.Top, (uint)(CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt));
                tempbmp = Image.FromHbitmap(hBmp);

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
                WinApi.DeleteObject(hBmp);
                WinApi.ReleaseDC(IntPtr.Zero, screenDc);
                WinApi.DeleteDC(hDest);

                Root.UponBalloonSnap = true;
            }
        }

        public int Test()
        {
            IntPtr screenDc = WinApi.GetDC(IntPtr.Zero);

            // big time consuming, but not CPU consuming
            WinApi.BitBlt(memscreenDc, Width / 4, 0, Width / 2, Height, screenDc, Width / 4, 0, 0x00CC0020);
            // <1% CPU
            WinApi.GetBitmapBits(hScreenBitmap, Width * Height * 4, screenbits);

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
                        if (Lnext() == Nnext2())
                            idpixels++;
                    }
                }

                if (idpixels > maxidpixels)
                {
                    maxidpixels = idpixels;
                    maxdj = dj;
                }
            }

            if (maxidpixels < 100)
                maxdj = 0;

            // 2% CPU
            IntPtr pscreenbits = Marshal.UnsafeAddrOfPinnedArrayElement(screenbits, (int)(Width * Height * 4 * 0.375));
            IntPtr plastscreenbits = Marshal.UnsafeAddrOfPinnedArrayElement(lastscreenbits, (int)(Width * Height * 4 * 0.375));
            WinApi.memcpy(plastscreenbits, pscreenbits, Width * Height * 4 / 4);

            WinApi.ReleaseDC(IntPtr.Zero, screenDc);
            return maxdj;
        }

        public void UpdateFormDisplay(bool draw)
        {
            IntPtr screenDc = WinApi.GetDC(IntPtr.Zero);

            //Display-rectangle
            Size size = new Size(Width, Height);
            Point pointSource = new Point(0, 0);
            Point topPos = new Point(Left, Top);

            //Set up blending options
            WinApi.BLENDFUNCTION blend = new WinApi.BLENDFUNCTION();
            blend.BlendOp = WinApi.AC_SRC_OVER;
            blend.BlendFlags = 0;
            blend.SourceConstantAlpha = 255;  // additional alpha multiplier to the whole image. value 255 means multiply with 1.
            blend.AlphaFormat = WinApi.AC_SRC_ALPHA;

            if (draw)
                WinApi.UpdateLayeredWindow(Handle, screenDc, ref topPos, ref size, canvusDc, ref pointSource, 0, ref blend, WinApi.ULW_ALPHA);
            else
                WinApi.UpdateLayeredWindow(Handle, screenDc, ref topPos, ref size, blankcanvusDc, ref pointSource, 0, ref blend, WinApi.ULW_ALPHA);

            //Clean-up
            WinApi.ReleaseDC(IntPtr.Zero, screenDc);
        }

        private int stackmove = 0;
        private int Tick = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick++;
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
                        WinApi.BitBlt(canvusDc, lt.X, lt.Y, rb.X - lt.X, rb.Y - lt.Y, onestrokeDc, lt.X, lt.Y, (uint)CopyPixelOperation.SourceCopy);
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
            WinApi.DeleteObject(Canvus);
            WinApi.DeleteDC(canvusDc);
            if (Root.AutoScroll)
            {
                WinApi.DeleteObject(hScreenBitmap);
                WinApi.DeleteDC(memscreenDc);
            }
        }
    }
}