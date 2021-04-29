﻿namespace gInk
{
	partial class FormOptions
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
            gInk.Hotkey hotkey1 = new gInk.Hotkey();
            gInk.Hotkey hotkey2 = new gInk.Hotkey();
            gInk.Hotkey hotkey3 = new gInk.Hotkey();
            gInk.Hotkey hotkey4 = new gInk.Hotkey();
            gInk.Hotkey hotkey5 = new gInk.Hotkey();
            gInk.Hotkey hotkey6 = new gInk.Hotkey();
            gInk.Hotkey hotkey7 = new gInk.Hotkey();
            gInk.Hotkey hotkey8 = new gInk.Hotkey();
            gInk.Hotkey hotkey9 = new gInk.Hotkey();
            this.cbEraserEnabled = new System.Windows.Forms.CheckBox();
            this.cbPointerEnabled = new System.Windows.Forms.CheckBox();
            this.cbSnapEnabled = new System.Windows.Forms.CheckBox();
            this.cbUndoEnabled = new System.Windows.Forms.CheckBox();
            this.cbClearEnabled = new System.Windows.Forms.CheckBox();
            this.cbWidthEnabled = new System.Windows.Forms.CheckBox();
            this.cbWhiteIcon = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbSnapPath = new System.Windows.Forms.TextBox();
            this.lbSnapshotsavepath = new System.Windows.Forms.Label();
            this.btSnapPath = new System.Windows.Forms.Button();
            this.lbNote = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.cbInkVisibleEnabled = new System.Windows.Forms.CheckBox();
            this.cbPanEnabled = new System.Windows.Forms.CheckBox();
            this.cbAllowDragging = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbAllowHotkeyInPointer = new System.Windows.Forms.CheckBox();
            this.lbHkInkVisible = new System.Windows.Forms.Label();
            this.lbHkSnapshot = new System.Windows.Forms.Label();
            this.lbHkClear = new System.Windows.Forms.Label();
            this.lbHkPan = new System.Windows.Forms.Label();
            this.lbHkPointer = new System.Windows.Forms.Label();
            this.lbHkRedo = new System.Windows.Forms.Label();
            this.lbHkUndo = new System.Windows.Forms.Label();
            this.lbHkEraser = new System.Windows.Forms.Label();
            this.lbGlobalHotkey = new System.Windows.Forms.Label();
            this.hiInkVisible = new gInk.HotkeyInputBox();
            this.hiSnapshot = new gInk.HotkeyInputBox();
            this.hiClear = new gInk.HotkeyInputBox();
            this.hiPan = new gInk.HotkeyInputBox();
            this.hiPointer = new gInk.HotkeyInputBox();
            this.hiRedo = new gInk.HotkeyInputBox();
            this.hiUndo = new gInk.HotkeyInputBox();
            this.hiEraser = new gInk.HotkeyInputBox();
            this.hiGlobal = new gInk.HotkeyInputBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEraserEnabled
            // 
            this.cbEraserEnabled.AutoSize = true;
            this.cbEraserEnabled.Location = new System.Drawing.Point(52, 94);
            this.cbEraserEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbEraserEnabled.Name = "cbEraserEnabled";
            this.cbEraserEnabled.Size = new System.Drawing.Size(18, 17);
            this.cbEraserEnabled.TabIndex = 0;
            this.cbEraserEnabled.UseVisualStyleBackColor = true;
            this.cbEraserEnabled.CheckedChanged += new System.EventHandler(this.cbEraserEnabled_CheckedChanged);
            // 
            // cbPointerEnabled
            // 
            this.cbPointerEnabled.AutoSize = true;
            this.cbPointerEnabled.Location = new System.Drawing.Point(183, 94);
            this.cbPointerEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbPointerEnabled.Name = "cbPointerEnabled";
            this.cbPointerEnabled.Size = new System.Drawing.Size(18, 17);
            this.cbPointerEnabled.TabIndex = 0;
            this.cbPointerEnabled.UseVisualStyleBackColor = true;
            this.cbPointerEnabled.CheckedChanged += new System.EventHandler(this.cbPointerEnabled_CheckedChanged);
            // 
            // cbSnapEnabled
            // 
            this.cbSnapEnabled.AutoSize = true;
            this.cbSnapEnabled.Location = new System.Drawing.Point(434, 94);
            this.cbSnapEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbSnapEnabled.Name = "cbSnapEnabled";
            this.cbSnapEnabled.Size = new System.Drawing.Size(18, 17);
            this.cbSnapEnabled.TabIndex = 0;
            this.cbSnapEnabled.UseVisualStyleBackColor = true;
            this.cbSnapEnabled.CheckedChanged += new System.EventHandler(this.cbSnapEnabled_CheckedChanged);
            // 
            // cbUndoEnabled
            // 
            this.cbUndoEnabled.AutoSize = true;
            this.cbUndoEnabled.Location = new System.Drawing.Point(503, 94);
            this.cbUndoEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbUndoEnabled.Name = "cbUndoEnabled";
            this.cbUndoEnabled.Size = new System.Drawing.Size(18, 17);
            this.cbUndoEnabled.TabIndex = 0;
            this.cbUndoEnabled.UseVisualStyleBackColor = true;
            this.cbUndoEnabled.CheckedChanged += new System.EventHandler(this.cbUndoEnabled_CheckedChanged);
            // 
            // cbClearEnabled
            // 
            this.cbClearEnabled.AutoSize = true;
            this.cbClearEnabled.Location = new System.Drawing.Point(568, 94);
            this.cbClearEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbClearEnabled.Name = "cbClearEnabled";
            this.cbClearEnabled.Size = new System.Drawing.Size(18, 17);
            this.cbClearEnabled.TabIndex = 0;
            this.cbClearEnabled.UseVisualStyleBackColor = true;
            this.cbClearEnabled.CheckedChanged += new System.EventHandler(this.cbClearEnabled_CheckedChanged);
            // 
            // cbWidthEnabled
            // 
            this.cbWidthEnabled.AutoSize = true;
            this.cbWidthEnabled.Location = new System.Drawing.Point(296, 96);
            this.cbWidthEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbWidthEnabled.Name = "cbWidthEnabled";
            this.cbWidthEnabled.Size = new System.Drawing.Size(18, 17);
            this.cbWidthEnabled.TabIndex = 0;
            this.cbWidthEnabled.UseVisualStyleBackColor = true;
            this.cbWidthEnabled.CheckedChanged += new System.EventHandler(this.cbWidthEnabled_CheckedChanged);
            // 
            // cbWhiteIcon
            // 
            this.cbWhiteIcon.AutoSize = true;
            this.cbWhiteIcon.Location = new System.Drawing.Point(14, 250);
            this.cbWhiteIcon.Margin = new System.Windows.Forms.Padding(4);
            this.cbWhiteIcon.Name = "cbWhiteIcon";
            this.cbWhiteIcon.Size = new System.Drawing.Size(181, 19);
            this.cbWhiteIcon.TabIndex = 0;
            this.cbWhiteIcon.Text = "Use white tray icon";
            this.cbWhiteIcon.UseVisualStyleBackColor = true;
            this.cbWhiteIcon.CheckedChanged += new System.EventHandler(this.cbWhiteIcon_CheckedChanged);
            // 
            // tbSnapPath
            // 
            this.tbSnapPath.Location = new System.Drawing.Point(236, 197);
            this.tbSnapPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbSnapPath.Name = "tbSnapPath";
            this.tbSnapPath.Size = new System.Drawing.Size(335, 25);
            this.tbSnapPath.TabIndex = 1;
            this.tbSnapPath.ModifiedChanged += new System.EventHandler(this.tbSnapPath_ModifiedChanged);
            // 
            // lbSnapshotsavepath
            // 
            this.lbSnapshotsavepath.AutoSize = true;
            this.lbSnapshotsavepath.Location = new System.Drawing.Point(11, 203);
            this.lbSnapshotsavepath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSnapshotsavepath.Name = "lbSnapshotsavepath";
            this.lbSnapshotsavepath.Size = new System.Drawing.Size(151, 15);
            this.lbSnapshotsavepath.TabIndex = 2;
            this.lbSnapshotsavepath.Text = "Snapshot save path";
            // 
            // btSnapPath
            // 
            this.btSnapPath.Location = new System.Drawing.Point(580, 196);
            this.btSnapPath.Margin = new System.Windows.Forms.Padding(4);
            this.btSnapPath.Name = "btSnapPath";
            this.btSnapPath.Size = new System.Drawing.Size(41, 26);
            this.btSnapPath.TabIndex = 3;
            this.btSnapPath.Text = "...";
            this.btSnapPath.UseVisualStyleBackColor = true;
            this.btSnapPath.Click += new System.EventHandler(this.btSnapPath_Click);
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(12, 344);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(527, 15);
            this.lbNote.TabIndex = 4;
            this.lbNote.Text = "Note: pen width panel overides each individual pen width settings";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1269, 529);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.lbLanguage);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.comboLanguage);
            this.tabPage1.Controls.Add(this.cbInkVisibleEnabled);
            this.tabPage1.Controls.Add(this.cbPanEnabled);
            this.tabPage1.Controls.Add(this.cbEraserEnabled);
            this.tabPage1.Controls.Add(this.cbWidthEnabled);
            this.tabPage1.Controls.Add(this.lbNote);
            this.tabPage1.Controls.Add(this.cbPointerEnabled);
            this.tabPage1.Controls.Add(this.btSnapPath);
            this.tabPage1.Controls.Add(this.cbSnapEnabled);
            this.tabPage1.Controls.Add(this.cbUndoEnabled);
            this.tabPage1.Controls.Add(this.cbClearEnabled);
            this.tabPage1.Controls.Add(this.lbSnapshotsavepath);
            this.tabPage1.Controls.Add(this.cbAllowDragging);
            this.tabPage1.Controls.Add(this.cbWhiteIcon);
            this.tabPage1.Controls.Add(this.tbSnapPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1261, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(12, 150);
            this.lbLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(71, 15);
            this.lbLanguage.TabIndex = 8;
            this.lbLanguage.Text = "Language";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::gInk.Properties.Resources.paneloption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 61);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // comboLanguage
            // 
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Location = new System.Drawing.Point(236, 146);
            this.comboLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(335, 23);
            this.comboLanguage.TabIndex = 6;
            this.comboLanguage.SelectedIndexChanged += new System.EventHandler(this.comboLanguage_SelectedIndexChanged);
            // 
            // cbInkVisibleEnabled
            // 
            this.cbInkVisibleEnabled.AutoSize = true;
            this.cbInkVisibleEnabled.Location = new System.Drawing.Point(366, 94);
            this.cbInkVisibleEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbInkVisibleEnabled.Name = "cbInkVisibleEnabled";
            this.cbInkVisibleEnabled.Size = new System.Drawing.Size(18, 17);
            this.cbInkVisibleEnabled.TabIndex = 0;
            this.cbInkVisibleEnabled.UseVisualStyleBackColor = true;
            this.cbInkVisibleEnabled.CheckedChanged += new System.EventHandler(this.cbInkVisibleEnabled_CheckedChanged);
            // 
            // cbPanEnabled
            // 
            this.cbPanEnabled.AutoSize = true;
            this.cbPanEnabled.Location = new System.Drawing.Point(116, 94);
            this.cbPanEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbPanEnabled.Name = "cbPanEnabled";
            this.cbPanEnabled.Size = new System.Drawing.Size(18, 17);
            this.cbPanEnabled.TabIndex = 0;
            this.cbPanEnabled.UseVisualStyleBackColor = true;
            this.cbPanEnabled.CheckedChanged += new System.EventHandler(this.cbPanEnabled_CheckedChanged);
            // 
            // cbAllowDragging
            // 
            this.cbAllowDragging.AutoSize = true;
            this.cbAllowDragging.Location = new System.Drawing.Point(14, 285);
            this.cbAllowDragging.Margin = new System.Windows.Forms.Padding(4);
            this.cbAllowDragging.Name = "cbAllowDragging";
            this.cbAllowDragging.Size = new System.Drawing.Size(325, 19);
            this.cbAllowDragging.TabIndex = 0;
            this.cbAllowDragging.Text = "Allow dragging toolbar (experimental)";
            this.cbAllowDragging.UseVisualStyleBackColor = true;
            this.cbAllowDragging.CheckedChanged += new System.EventHandler(this.cbAllowDragging_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1261, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pens";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Controls.Add(this.cbAllowHotkeyInPointer);
            this.tabPage3.Controls.Add(this.lbHkInkVisible);
            this.tabPage3.Controls.Add(this.lbHkSnapshot);
            this.tabPage3.Controls.Add(this.lbHkClear);
            this.tabPage3.Controls.Add(this.lbHkPan);
            this.tabPage3.Controls.Add(this.lbHkPointer);
            this.tabPage3.Controls.Add(this.lbHkRedo);
            this.tabPage3.Controls.Add(this.lbHkUndo);
            this.tabPage3.Controls.Add(this.lbHkEraser);
            this.tabPage3.Controls.Add(this.lbGlobalHotkey);
            this.tabPage3.Controls.Add(this.hiInkVisible);
            this.tabPage3.Controls.Add(this.hiSnapshot);
            this.tabPage3.Controls.Add(this.hiClear);
            this.tabPage3.Controls.Add(this.hiPan);
            this.tabPage3.Controls.Add(this.hiPointer);
            this.tabPage3.Controls.Add(this.hiRedo);
            this.tabPage3.Controls.Add(this.hiUndo);
            this.tabPage3.Controls.Add(this.hiEraser);
            this.tabPage3.Controls.Add(this.hiGlobal);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1261, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hotkeys";
            // 
            // cbAllowHotkeyInPointer
            // 
            this.cbAllowHotkeyInPointer.AutoSize = true;
            this.cbAllowHotkeyInPointer.Location = new System.Drawing.Point(25, 100);
            this.cbAllowHotkeyInPointer.Margin = new System.Windows.Forms.Padding(4);
            this.cbAllowHotkeyInPointer.Name = "cbAllowHotkeyInPointer";
            this.cbAllowHotkeyInPointer.Size = new System.Drawing.Size(581, 19);
            this.cbAllowHotkeyInPointer.TabIndex = 18;
            this.cbAllowHotkeyInPointer.Text = "Allow all following hotkeys in mouse pointer mode (may cause a mess):";
            this.cbAllowHotkeyInPointer.UseVisualStyleBackColor = true;
            this.cbAllowHotkeyInPointer.CheckedChanged += new System.EventHandler(this.cbAllowHotkeyInPointer_CheckedChanged);
            // 
            // lbHkInkVisible
            // 
            this.lbHkInkVisible.AutoSize = true;
            this.lbHkInkVisible.Location = new System.Drawing.Point(315, 233);
            this.lbHkInkVisible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHkInkVisible.Name = "lbHkInkVisible";
            this.lbHkInkVisible.Size = new System.Drawing.Size(79, 15);
            this.lbHkInkVisible.TabIndex = 16;
            this.lbHkInkVisible.Text = "View/Hide";
            // 
            // lbHkSnapshot
            // 
            this.lbHkSnapshot.AutoSize = true;
            this.lbHkSnapshot.Location = new System.Drawing.Point(315, 264);
            this.lbHkSnapshot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHkSnapshot.Name = "lbHkSnapshot";
            this.lbHkSnapshot.Size = new System.Drawing.Size(71, 15);
            this.lbHkSnapshot.TabIndex = 12;
            this.lbHkSnapshot.Text = "Snapshot";
            // 
            // lbHkClear
            // 
            this.lbHkClear.AutoSize = true;
            this.lbHkClear.Location = new System.Drawing.Point(315, 358);
            this.lbHkClear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHkClear.Name = "lbHkClear";
            this.lbHkClear.Size = new System.Drawing.Size(47, 15);
            this.lbHkClear.TabIndex = 13;
            this.lbHkClear.Text = "Clear";
            // 
            // lbHkPan
            // 
            this.lbHkPan.AutoSize = true;
            this.lbHkPan.Location = new System.Drawing.Point(315, 170);
            this.lbHkPan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHkPan.Name = "lbHkPan";
            this.lbHkPan.Size = new System.Drawing.Size(31, 15);
            this.lbHkPan.TabIndex = 10;
            this.lbHkPan.Text = "Pan";
            // 
            // lbHkPointer
            // 
            this.lbHkPointer.AutoSize = true;
            this.lbHkPointer.Location = new System.Drawing.Point(315, 202);
            this.lbHkPointer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHkPointer.Name = "lbHkPointer";
            this.lbHkPointer.Size = new System.Drawing.Size(111, 15);
            this.lbHkPointer.TabIndex = 6;
            this.lbHkPointer.Text = "Mouse pointer";
            // 
            // lbHkRedo
            // 
            this.lbHkRedo.AutoSize = true;
            this.lbHkRedo.Location = new System.Drawing.Point(315, 326);
            this.lbHkRedo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHkRedo.Name = "lbHkRedo";
            this.lbHkRedo.Size = new System.Drawing.Size(39, 15);
            this.lbHkRedo.TabIndex = 7;
            this.lbHkRedo.Text = "Redo";
            // 
            // lbHkUndo
            // 
            this.lbHkUndo.AutoSize = true;
            this.lbHkUndo.Location = new System.Drawing.Point(315, 296);
            this.lbHkUndo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHkUndo.Name = "lbHkUndo";
            this.lbHkUndo.Size = new System.Drawing.Size(39, 15);
            this.lbHkUndo.TabIndex = 4;
            this.lbHkUndo.Text = "Undo";
            // 
            // lbHkEraser
            // 
            this.lbHkEraser.AutoSize = true;
            this.lbHkEraser.Location = new System.Drawing.Point(315, 139);
            this.lbHkEraser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHkEraser.Name = "lbHkEraser";
            this.lbHkEraser.Size = new System.Drawing.Size(55, 15);
            this.lbHkEraser.TabIndex = 4;
            this.lbHkEraser.Text = "Eraser";
            // 
            // lbGlobalHotkey
            // 
            this.lbGlobalHotkey.AutoSize = true;
            this.lbGlobalHotkey.Location = new System.Drawing.Point(23, 21);
            this.lbGlobalHotkey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGlobalHotkey.Name = "lbGlobalHotkey";
            this.lbGlobalHotkey.Size = new System.Drawing.Size(575, 15);
            this.lbGlobalHotkey.TabIndex = 4;
            this.lbGlobalHotkey.Text = "Global hotkey (start drawing, switch between mouse pointer and drawing)";
            // 
            // hiInkVisible
            // 
            this.hiInkVisible.BackColor = System.Drawing.Color.White;
            this.hiInkVisible.ExternalConflictFlag = false;
            this.hiInkVisible.Hotkey = hotkey1;
            this.hiInkVisible.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiInkVisible.Location = new System.Drawing.Point(453, 233);
            this.hiInkVisible.Margin = new System.Windows.Forms.Padding(4);
            this.hiInkVisible.Name = "hiInkVisible";
            this.hiInkVisible.RequireModifier = false;
            this.hiInkVisible.Size = new System.Drawing.Size(159, 25);
            this.hiInkVisible.TabIndex = 17;
            this.hiInkVisible.Text = "None";
            this.hiInkVisible.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiSnapshot
            // 
            this.hiSnapshot.BackColor = System.Drawing.Color.White;
            this.hiSnapshot.ExternalConflictFlag = false;
            this.hiSnapshot.Hotkey = hotkey2;
            this.hiSnapshot.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiSnapshot.Location = new System.Drawing.Point(453, 264);
            this.hiSnapshot.Margin = new System.Windows.Forms.Padding(4);
            this.hiSnapshot.Name = "hiSnapshot";
            this.hiSnapshot.RequireModifier = false;
            this.hiSnapshot.Size = new System.Drawing.Size(159, 25);
            this.hiSnapshot.TabIndex = 14;
            this.hiSnapshot.Text = "None";
            this.hiSnapshot.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiClear
            // 
            this.hiClear.BackColor = System.Drawing.Color.White;
            this.hiClear.ExternalConflictFlag = false;
            this.hiClear.Hotkey = hotkey3;
            this.hiClear.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiClear.Location = new System.Drawing.Point(453, 358);
            this.hiClear.Margin = new System.Windows.Forms.Padding(4);
            this.hiClear.Name = "hiClear";
            this.hiClear.RequireModifier = false;
            this.hiClear.Size = new System.Drawing.Size(159, 25);
            this.hiClear.TabIndex = 15;
            this.hiClear.Text = "None";
            this.hiClear.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiPan
            // 
            this.hiPan.BackColor = System.Drawing.Color.White;
            this.hiPan.ExternalConflictFlag = false;
            this.hiPan.Hotkey = hotkey4;
            this.hiPan.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiPan.Location = new System.Drawing.Point(453, 170);
            this.hiPan.Margin = new System.Windows.Forms.Padding(4);
            this.hiPan.Name = "hiPan";
            this.hiPan.RequireModifier = false;
            this.hiPan.Size = new System.Drawing.Size(159, 25);
            this.hiPan.TabIndex = 11;
            this.hiPan.Text = "None";
            this.hiPan.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiPointer
            // 
            this.hiPointer.BackColor = System.Drawing.Color.White;
            this.hiPointer.ExternalConflictFlag = false;
            this.hiPointer.Hotkey = hotkey5;
            this.hiPointer.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiPointer.Location = new System.Drawing.Point(453, 202);
            this.hiPointer.Margin = new System.Windows.Forms.Padding(4);
            this.hiPointer.Name = "hiPointer";
            this.hiPointer.RequireModifier = false;
            this.hiPointer.Size = new System.Drawing.Size(159, 25);
            this.hiPointer.TabIndex = 8;
            this.hiPointer.Text = "None";
            this.hiPointer.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiRedo
            // 
            this.hiRedo.BackColor = System.Drawing.Color.White;
            this.hiRedo.ExternalConflictFlag = false;
            this.hiRedo.Hotkey = hotkey6;
            this.hiRedo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiRedo.Location = new System.Drawing.Point(453, 326);
            this.hiRedo.Margin = new System.Windows.Forms.Padding(4);
            this.hiRedo.Name = "hiRedo";
            this.hiRedo.RequireModifier = false;
            this.hiRedo.Size = new System.Drawing.Size(159, 25);
            this.hiRedo.TabIndex = 9;
            this.hiRedo.Text = "None";
            this.hiRedo.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiUndo
            // 
            this.hiUndo.BackColor = System.Drawing.Color.White;
            this.hiUndo.ExternalConflictFlag = false;
            this.hiUndo.Hotkey = hotkey7;
            this.hiUndo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiUndo.Location = new System.Drawing.Point(453, 296);
            this.hiUndo.Margin = new System.Windows.Forms.Padding(4);
            this.hiUndo.Name = "hiUndo";
            this.hiUndo.RequireModifier = false;
            this.hiUndo.Size = new System.Drawing.Size(159, 25);
            this.hiUndo.TabIndex = 5;
            this.hiUndo.Text = "None";
            this.hiUndo.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiEraser
            // 
            this.hiEraser.BackColor = System.Drawing.Color.White;
            this.hiEraser.ExternalConflictFlag = false;
            this.hiEraser.Hotkey = hotkey8;
            this.hiEraser.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiEraser.Location = new System.Drawing.Point(453, 139);
            this.hiEraser.Margin = new System.Windows.Forms.Padding(4);
            this.hiEraser.Name = "hiEraser";
            this.hiEraser.RequireModifier = false;
            this.hiEraser.Size = new System.Drawing.Size(159, 25);
            this.hiEraser.TabIndex = 5;
            this.hiEraser.Text = "None";
            this.hiEraser.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiGlobal
            // 
            this.hiGlobal.BackColor = System.Drawing.Color.White;
            this.hiGlobal.ExternalConflictFlag = false;
            this.hiGlobal.Hotkey = hotkey9;
            this.hiGlobal.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiGlobal.Location = new System.Drawing.Point(25, 45);
            this.hiGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.hiGlobal.Name = "hiGlobal";
            this.hiGlobal.RequireModifier = true;
            this.hiGlobal.Size = new System.Drawing.Size(159, 25);
            this.hiGlobal.TabIndex = 5;
            this.hiGlobal.Text = "None";
            this.hiGlobal.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(649, 523);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options - gInk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOptions_FormClosing);
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox cbEraserEnabled;
		private System.Windows.Forms.CheckBox cbPointerEnabled;
		private System.Windows.Forms.CheckBox cbSnapEnabled;
		private System.Windows.Forms.CheckBox cbUndoEnabled;
		private System.Windows.Forms.CheckBox cbClearEnabled;
		private System.Windows.Forms.CheckBox cbWidthEnabled;
		private System.Windows.Forms.CheckBox cbWhiteIcon;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox tbSnapPath;
		private System.Windows.Forms.Label lbSnapshotsavepath;
		private System.Windows.Forms.Button btSnapPath;
		private System.Windows.Forms.Label lbNote;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label lbGlobalHotkey;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox cbInkVisibleEnabled;
		private System.Windows.Forms.CheckBox cbPanEnabled;
		private System.Windows.Forms.CheckBox cbAllowDragging;
		private HotkeyInputBox hiGlobal;
		private HotkeyInputBox hiEraser;
		private System.Windows.Forms.Label lbHkEraser;
		private HotkeyInputBox hiUndo;
		private System.Windows.Forms.Label lbHkUndo;
		private HotkeyInputBox hiPointer;
		private HotkeyInputBox hiRedo;
		private System.Windows.Forms.Label lbHkPointer;
		private System.Windows.Forms.Label lbHkRedo;
		private HotkeyInputBox hiSnapshot;
		private HotkeyInputBox hiClear;
		private System.Windows.Forms.Label lbHkSnapshot;
		private System.Windows.Forms.Label lbHkClear;
		private HotkeyInputBox hiPan;
		private System.Windows.Forms.Label lbHkPan;
		private HotkeyInputBox hiInkVisible;
		private System.Windows.Forms.Label lbHkInkVisible;
		private System.Windows.Forms.CheckBox cbAllowHotkeyInPointer;
		private System.Windows.Forms.ComboBox comboLanguage;
		private System.Windows.Forms.Label lbLanguage;
	}
}