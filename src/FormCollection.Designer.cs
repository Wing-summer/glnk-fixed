namespace gInk
{
	partial class FormCollection
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
            this.components = new System.ComponentModel.Container();
            this.gpButtons = new System.Windows.Forms.Panel();
            this.btInkVisible = new System.Windows.Forms.Button();
            this.btPan = new System.Windows.Forms.Button();
            this.btDock = new System.Windows.Forms.Button();
            this.btPenWidth = new System.Windows.Forms.Button();
            this.btEraser = new System.Windows.Forms.Button();
            this.btSnap = new System.Windows.Forms.Button();
            this.btPointer = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btUndo = new System.Windows.Forms.Button();
            this.tiSlide = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pboxPenWidthIndicator = new System.Windows.Forms.PictureBox();
            this.gpPenWidth = new System.Windows.Forms.PictureBox();
            this.gpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPenWidthIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // gpButtons
            // 
            this.gpButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpButtons.Controls.Add(this.btInkVisible);
            this.gpButtons.Controls.Add(this.btPan);
            this.gpButtons.Controls.Add(this.btDock);
            this.gpButtons.Controls.Add(this.btPenWidth);
            this.gpButtons.Controls.Add(this.btEraser);
            this.gpButtons.Controls.Add(this.btSnap);
            this.gpButtons.Controls.Add(this.btPointer);
            this.gpButtons.Controls.Add(this.btStop);
            this.gpButtons.Controls.Add(this.btClear);
            this.gpButtons.Controls.Add(this.btUndo);
            this.gpButtons.Location = new System.Drawing.Point(30, 60);
            this.gpButtons.Margin = new System.Windows.Forms.Padding(2);
            this.gpButtons.Name = "gpButtons";
            this.gpButtons.Size = new System.Drawing.Size(1035, 67);
            this.gpButtons.TabIndex = 3;
            this.gpButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.gpButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.gpButtons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btInkVisible
            // 
            this.btInkVisible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btInkVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInkVisible.FlatAppearance.BorderSize = 0;
            this.btInkVisible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btInkVisible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btInkVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInkVisible.Image = Properties.Resources.visible;
            this.btInkVisible.Location = new System.Drawing.Point(877, 3);
            this.btInkVisible.Margin = new System.Windows.Forms.Padding(2);
            this.btInkVisible.Name = "btInkVisible";
            this.btInkVisible.Size = new System.Drawing.Size(57, 57);
            this.btInkVisible.TabIndex = 3;
            this.toolTip.SetToolTip(this.btInkVisible, "Ink visible");
            this.btInkVisible.UseVisualStyleBackColor = true;
            this.btInkVisible.Click += new System.EventHandler(this.btInkVisible_Click);
            this.btInkVisible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btInkVisible.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btInkVisible.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btPan
            // 
            this.btPan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPan.FlatAppearance.BorderSize = 0;
            this.btPan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btPan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btPan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPan.Image = Properties.Resources.pan;
            this.btPan.Location = new System.Drawing.Point(815, 3);
            this.btPan.Margin = new System.Windows.Forms.Padding(2);
            this.btPan.Name = "btPan";
            this.btPan.Size = new System.Drawing.Size(57, 57);
            this.btPan.TabIndex = 2;
            this.toolTip.SetToolTip(this.btPan, "Pan");
            this.btPan.UseVisualStyleBackColor = true;
            this.btPan.Click += new System.EventHandler(this.btPan_Click);
            this.btPan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btPan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btPan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btDock
            // 
            this.btDock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btDock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.btDock.FlatAppearance.BorderSize = 0;
            this.btDock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btDock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btDock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btDock.Image = Properties.Resources.dock;
            this.btDock.Location = new System.Drawing.Point(0, 0);
            this.btDock.Margin = new System.Windows.Forms.Padding(2);
            this.btDock.Name = "btDock";
            this.btDock.Size = new System.Drawing.Size(42, 67);
            this.btDock.TabIndex = 0;
            this.toolTip.SetToolTip(this.btDock, "Dock / Undock");
            this.btDock.UseVisualStyleBackColor = false;
            this.btDock.Click += new System.EventHandler(this.btDock_Click);
            this.btDock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btDock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btDock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btPenWidth
            // 
            this.btPenWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btPenWidth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPenWidth.FlatAppearance.BorderSize = 0;
            this.btPenWidth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btPenWidth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btPenWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPenWidth.Image = Properties.Resources.penwidth;
            this.btPenWidth.Location = new System.Drawing.Point(332, 3);
            this.btPenWidth.Margin = new System.Windows.Forms.Padding(2);
            this.btPenWidth.Name = "btPenWidth";
            this.btPenWidth.Size = new System.Drawing.Size(57, 57);
            this.btPenWidth.TabIndex = 0;
            this.toolTip.SetToolTip(this.btPenWidth, "Pen width");
            this.btPenWidth.UseVisualStyleBackColor = true;
            this.btPenWidth.Click += new System.EventHandler(this.btPenWidth_Click);
            this.btPenWidth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btPenWidth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btPenWidth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btEraser
            // 
            this.btEraser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btEraser.FlatAppearance.BorderSize = 0;
            this.btEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEraser.ForeColor = System.Drawing.Color.Transparent;
            this.btEraser.Image = Properties.Resources.eraser;
            this.btEraser.Location = new System.Drawing.Point(407, 3);
            this.btEraser.Margin = new System.Windows.Forms.Padding(2);
            this.btEraser.Name = "btEraser";
            this.btEraser.Size = new System.Drawing.Size(57, 57);
            this.btEraser.TabIndex = 0;
            this.toolTip.SetToolTip(this.btEraser, "Eraser");
            this.btEraser.UseVisualStyleBackColor = false;
            this.btEraser.Click += new System.EventHandler(this.btEraser_Click);
            this.btEraser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btEraser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btEraser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btSnap
            // 
            this.btSnap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btSnap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSnap.FlatAppearance.BorderSize = 0;
            this.btSnap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btSnap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btSnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSnap.Image = Properties.Resources.snap;
            this.btSnap.Location = new System.Drawing.Point(587, 3);
            this.btSnap.Margin = new System.Windows.Forms.Padding(2);
            this.btSnap.Name = "btSnap";
            this.btSnap.Size = new System.Drawing.Size(57, 57);
            this.btSnap.TabIndex = 0;
            this.toolTip.SetToolTip(this.btSnap, "Snapshot");
            this.btSnap.UseVisualStyleBackColor = true;
            this.btSnap.Click += new System.EventHandler(this.btSnap_Click);
            this.btSnap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btSnap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btSnap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btPointer
            // 
            this.btPointer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btPointer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPointer.FlatAppearance.BorderSize = 0;
            this.btPointer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btPointer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btPointer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPointer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btPointer.Image = Properties.Resources.pointer;
            this.btPointer.Location = new System.Drawing.Point(478, 3);
            this.btPointer.Margin = new System.Windows.Forms.Padding(2);
            this.btPointer.Name = "btPointer";
            this.btPointer.Size = new System.Drawing.Size(57, 57);
            this.btPointer.TabIndex = 0;
            this.toolTip.SetToolTip(this.btPointer, "Mouse pointer");
            this.btPointer.UseVisualStyleBackColor = true;
            this.btPointer.Click += new System.EventHandler(this.btPointer_Click);
            this.btPointer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btPointer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btPointer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btStop.FlatAppearance.BorderSize = 0;
            this.btStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.Image = Properties.Resources.exit;
            this.btStop.Location = new System.Drawing.Point(950, 3);
            this.btStop.Margin = new System.Windows.Forms.Padding(2);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(57, 57);
            this.btStop.TabIndex = 0;
            this.toolTip.SetToolTip(this.btStop, "Exit drawing");
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            this.btStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btStop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Image = Properties.Resources.garbage;
            this.btClear.Location = new System.Drawing.Point(728, 3);
            this.btClear.Margin = new System.Windows.Forms.Padding(2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(57, 57);
            this.btClear.TabIndex = 1;
            this.toolTip.SetToolTip(this.btClear, "Clear");
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            this.btClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btClear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // btUndo
            // 
            this.btUndo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUndo.FlatAppearance.BorderSize = 0;
            this.btUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUndo.Image = Properties.Resources.undo;
            this.btUndo.Location = new System.Drawing.Point(657, 3);
            this.btUndo.Margin = new System.Windows.Forms.Padding(2);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(57, 57);
            this.btUndo.TabIndex = 1;
            this.toolTip.SetToolTip(this.btUndo, "Undo");
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            this.btUndo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseDown);
            this.btUndo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseMove);
            this.btUndo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gpButtons_MouseUp);
            // 
            // tiSlide
            // 
            this.tiSlide.Interval = 15;
            this.tiSlide.Tick += new System.EventHandler(this.tiSlide_Tick);
            // 
            // pboxPenWidthIndicator
            // 
            this.pboxPenWidthIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pboxPenWidthIndicator.BackColor = System.Drawing.Color.Orange;
            this.pboxPenWidthIndicator.Location = new System.Drawing.Point(476, 311);
            this.pboxPenWidthIndicator.Name = "pboxPenWidthIndicator";
            this.pboxPenWidthIndicator.Size = new System.Drawing.Size(7, 53);
            this.pboxPenWidthIndicator.TabIndex = 5;
            this.pboxPenWidthIndicator.TabStop = false;
            this.pboxPenWidthIndicator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pboxPenWidthIndicator_MouseDown);
            this.pboxPenWidthIndicator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxPenWidthIndicator_MouseMove);
            this.pboxPenWidthIndicator.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pboxPenWidthIndicator_MouseUp);
            // 
            // gpPenWidth
            // 
            this.gpPenWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpPenWidth.Image = Properties.Resources.penwidthpanel;
            this.gpPenWidth.Location = new System.Drawing.Point(437, 311);
            this.gpPenWidth.Name = "gpPenWidth";
            this.gpPenWidth.Size = new System.Drawing.Size(200, 53);
            this.gpPenWidth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gpPenWidth.TabIndex = 5;
            this.gpPenWidth.TabStop = false;
            // 
            // FormCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 657);
            this.Controls.Add(this.pboxPenWidthIndicator);
            this.Controls.Add(this.gpPenWidth);
            this.Controls.Add(this.gpButtons);
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCollection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCollection_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPenWidthIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpPenWidth)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Button btStop;
		public System.Windows.Forms.Button btClear;
		public System.Windows.Forms.Button btUndo;
		public System.Windows.Forms.Panel gpButtons;
		public System.Windows.Forms.Button btEraser;
		private System.Windows.Forms.Timer tiSlide;
		public System.Windows.Forms.Button btDock;
		public System.Windows.Forms.Button btSnap;
		public System.Windows.Forms.Button btPointer;
		public System.Windows.Forms.Button btPenWidth;
		public System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.PictureBox pboxPenWidthIndicator;
		public System.Windows.Forms.Button btPan;
		public System.Windows.Forms.Button btInkVisible;
        public System.Windows.Forms.PictureBox gpPenWidth;
    }
}

