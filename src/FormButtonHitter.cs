using System;
using System.Windows.Forms;

namespace gInk
{
    public partial class FormButtonHitter : Form
    {
        private Root Root;
        private FormCollection FC;

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

        public FormButtonHitter(Root root)
        {
            Root = root;
            FC = Root.FormCollection;
            InitializeComponent();

            Left = FC.gpButtons.Left + FC.Left;
            Top = FC.gpButtons.Top + FC.Top;
            Width = FC.gpButtons.Width;
            Height = FC.gpButtons.Height;
        }

        private void FormButtonHitter_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            foreach (Control control in FC.gpButtons.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    if (m.X >= control.Left && m.X <= control.Right)
                        ((Button)control).PerformClick();
                }
            }
        }

        public void ToTopMost()
        {
            uint dwExStyle = WinApi.GetWindowLong(Handle, -20);
            WinApi.SetWindowLong(Handle, -20, dwExStyle | 0x00080000);
            WinApi.SetWindowPos(Handle, (IntPtr)(-1), 0, 0, 0, 0, 0x0002 | 0x0001 | 0x0020);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Visible)
            {
                Left = FC.gpButtons.Left + FC.Left;
                Top = FC.gpButtons.Top + FC.Top;
                Width = FC.gpButtons.Width;
                Height = FC.gpButtons.Height;
            }
        }
    }
}