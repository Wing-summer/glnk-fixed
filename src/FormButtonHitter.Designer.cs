namespace gInk
{
	partial class FormButtonHitter
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
			timer1.Tick += new System.EventHandler(timer1_Tick);
			// 
			// FormButtonHitter
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			BackColor = System.Drawing.Color.WhiteSmoke;
			ClientSize = new System.Drawing.Size(60, 80);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormButtonHitter";
			Opacity = 0.01D;
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			Text = "FormButtonHitter";
			TopMost = true;
			Click += new System.EventHandler(FormButtonHitter_Click);
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
	}
}