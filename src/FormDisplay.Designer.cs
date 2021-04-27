namespace gInk
{
	partial class FormDisplay
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 15;
			timer1.Tick += new System.EventHandler(timer1_Tick);
			// 
			// FormDisplay
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1410, 921);
			ForeColor = System.Drawing.Color.Transparent;
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormDisplay";
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			Text = "Form1";
			FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormDisplay_FormClosed);
			ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.Timer timer1;
	}
}

