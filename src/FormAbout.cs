using System;
using System.Text;
using System.Windows.Forms;

namespace gInk
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon_red;
            string version = Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2);
            StringBuilder about = new StringBuilder();
            about.AppendLine();
            about.AppendLine("  gInk v" + version);
            about.AppendLine("  (c) 2016-2020 Weizhi Nai");
            about.AppendLine("  Licensed under MIT");
            about.AppendLine("  https://github.com/geovens/gInk");
            about.AppendLine();
            about.AppendLine("  此版本维护者：wingsummer（Wing-summer）:");
            about.AppendLine("  https://github.com/Wing-summer/glnk-fixed");
            about.AppendLine();
            about.AppendLine("  Credits:");
            about.AppendLine("  Some button icons are designed by Freepik.com.");
            textBox1.Text = about.ToString();
            textBox1.Select(textBox1.Text.Length, 0);
        }
    }
}