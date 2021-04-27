namespace gInk
{
	partial class FormAbout
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
			textBox1 = new System.Windows.Forms.TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			textBox1.Location = new System.Drawing.Point(14, 15);
			textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new System.Drawing.Size(329, 129);
			textBox1.TabIndex = 0;
			// 
			// FormAbout
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(331, 162);
			Controls.Add(textBox1);
			Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormAbout";
			ShowInTaskbar = false;
			Text = "About";
			Load += new System.EventHandler(FormAbout_Load);
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
	}
}