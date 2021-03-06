﻿namespace MemoryPINGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param systemCallname="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.libraryRebaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEntryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.histogramEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.regionMonitorCheckBox = new System.Windows.Forms.CheckBox();
            this.alternateResultsCheckbox = new System.Windows.Forms.CheckBox();
            this.instructionTracingCheckbox = new System.Windows.Forms.CheckBox();
            this.libraryLoadMonitoringCheckbox = new System.Windows.Forms.CheckBox();
            this.regionStartBox = new System.Windows.Forms.TextBox();
            this.regionEndBox = new System.Windows.Forms.TextBox();
            this.resultsFileBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memoryPINDllPath = new System.Windows.Forms.TextBox();
            this.pinPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.traceOnStartCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.snapshotStatusLabel = new System.Windows.Forms.Label();
            this.tracingStatusLabel = new System.Windows.Forms.Label();
            this.startManualTracingButton = new System.Windows.Forms.Button();
            this.snapshotButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loadedLibraryList = new System.Windows.Forms.ListBox();
            this.librariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processInstructionFileButton = new System.Windows.Forms.Button();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.instructionnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemCallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threadidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadedThreadList = new System.Windows.Forms.ListBox();
            this.threadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lowDepthTextBox = new System.Windows.Forms.TextBox();
            this.highDepthTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.histogramDataView = new System.Windows.Forms.DataGridView();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histogramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramEntryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramEntryBindingSource)).BeginInit();
            this.tabContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryRebaseMenuItem});
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // libraryRebaseMenuItem
            // 
            this.libraryRebaseMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.libraryRebaseMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.libraryRebaseMenuItem.Name = "libraryRebaseMenuItem";
            this.libraryRebaseMenuItem.Size = new System.Drawing.Size(127, 22);
            this.libraryRebaseMenuItem.Text = "Library Rebase";
            this.libraryRebaseMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // histogramEntryBindingSource1
            // 
            this.histogramEntryBindingSource1.DataSource = typeof(MemoryPINGui.HistogramEntry);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(6, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(947, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Execute PIN tool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // regionMonitorCheckBox
            // 
            this.regionMonitorCheckBox.AutoSize = true;
            this.regionMonitorCheckBox.Location = new System.Drawing.Point(13, 101);
            this.regionMonitorCheckBox.Name = "regionMonitorCheckBox";
            this.regionMonitorCheckBox.Size = new System.Drawing.Size(112, 17);
            this.regionMonitorCheckBox.TabIndex = 3;
            this.regionMonitorCheckBox.Text = "Region Monitoring";
            this.regionMonitorCheckBox.UseVisualStyleBackColor = true;
            this.regionMonitorCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // alternateResultsCheckbox
            // 
            this.alternateResultsCheckbox.AutoSize = true;
            this.alternateResultsCheckbox.Location = new System.Drawing.Point(13, 128);
            this.alternateResultsCheckbox.Name = "alternateResultsCheckbox";
            this.alternateResultsCheckbox.Size = new System.Drawing.Size(125, 17);
            this.alternateResultsCheckbox.TabIndex = 6;
            this.alternateResultsCheckbox.Text = "Alternate Results File";
            this.alternateResultsCheckbox.UseVisualStyleBackColor = true;
            this.alternateResultsCheckbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // instructionTracingCheckbox
            // 
            this.instructionTracingCheckbox.AutoSize = true;
            this.instructionTracingCheckbox.Location = new System.Drawing.Point(13, 153);
            this.instructionTracingCheckbox.Name = "instructionTracingCheckbox";
            this.instructionTracingCheckbox.Size = new System.Drawing.Size(114, 17);
            this.instructionTracingCheckbox.TabIndex = 8;
            this.instructionTracingCheckbox.Text = "Instruction Tracing";
            this.instructionTracingCheckbox.UseVisualStyleBackColor = true;
            this.instructionTracingCheckbox.CheckedChanged += new System.EventHandler(this.instructionTracingCheckbox_CheckedChanged);
            // 
            // libraryLoadMonitoringCheckbox
            // 
            this.libraryLoadMonitoringCheckbox.AutoSize = true;
            this.libraryLoadMonitoringCheckbox.Location = new System.Drawing.Point(13, 176);
            this.libraryLoadMonitoringCheckbox.Name = "libraryLoadMonitoringCheckbox";
            this.libraryLoadMonitoringCheckbox.Size = new System.Drawing.Size(136, 17);
            this.libraryLoadMonitoringCheckbox.TabIndex = 11;
            this.libraryLoadMonitoringCheckbox.Text = "Library Load Monitoring";
            this.libraryLoadMonitoringCheckbox.UseVisualStyleBackColor = true;
            // 
            // regionStartBox
            // 
            this.regionStartBox.Enabled = false;
            this.regionStartBox.Location = new System.Drawing.Point(150, 98);
            this.regionStartBox.Name = "regionStartBox";
            this.regionStartBox.Size = new System.Drawing.Size(175, 20);
            this.regionStartBox.TabIndex = 4;
            // 
            // regionEndBox
            // 
            this.regionEndBox.Enabled = false;
            this.regionEndBox.Location = new System.Drawing.Point(331, 98);
            this.regionEndBox.Name = "regionEndBox";
            this.regionEndBox.Size = new System.Drawing.Size(175, 20);
            this.regionEndBox.TabIndex = 5;
            // 
            // resultsFileBox
            // 
            this.resultsFileBox.Enabled = false;
            this.resultsFileBox.Location = new System.Drawing.Point(150, 125);
            this.resultsFileBox.Name = "resultsFileBox";
            this.resultsFileBox.Size = new System.Drawing.Size(356, 20);
            this.resultsFileBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Executable to Instrument";
            // 
            // memoryPINDllPath
            // 
            this.memoryPINDllPath.AllowDrop = true;
            this.memoryPINDllPath.Location = new System.Drawing.Point(13, 38);
            this.memoryPINDllPath.Name = "memoryPINDllPath";
            this.memoryPINDllPath.Size = new System.Drawing.Size(306, 20);
            this.memoryPINDllPath.TabIndex = 1;
            this.memoryPINDllPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.memorypinBox_DragDrop);
            this.memoryPINDllPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.memorypinBox_DragEnter);
            // 
            // pinPathBox
            // 
            this.pinPathBox.AllowDrop = true;
            this.pinPathBox.Location = new System.Drawing.Point(13, 64);
            this.pinPathBox.Name = "pinPathBox";
            this.pinPathBox.Size = new System.Drawing.Size(306, 20);
            this.pinPathBox.TabIndex = 2;
            this.pinPathBox.Text = "pin";
            this.pinPathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pinpath_DragDrop);
            this.pinPathBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pinpath_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MemoryPIN DLL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Intel PIN Executable";
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tabPage1);
            this.tabContainer.Controls.Add(this.tabPage2);
            this.tabContainer.Controls.Add(this.tabPage3);
            this.tabContainer.Controls.Add(this.tabPage4);
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(1262, 392);
            this.tabContainer.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.traceOnStartCheckbox);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.memoryPINDllPath);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pinPathBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.regionMonitorCheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.alternateResultsCheckbox);
            this.tabPage1.Controls.Add(this.resultsFileBox);
            this.tabPage1.Controls.Add(this.instructionTracingCheckbox);
            this.tabPage1.Controls.Add(this.regionEndBox);
            this.tabPage1.Controls.Add(this.libraryLoadMonitoringCheckbox);
            this.tabPage1.Controls.Add(this.regionStartBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // traceOnStartCheckbox
            // 
            this.traceOnStartCheckbox.AutoSize = true;
            this.traceOnStartCheckbox.Location = new System.Drawing.Point(150, 153);
            this.traceOnStartCheckbox.Name = "traceOnStartCheckbox";
            this.traceOnStartCheckbox.Size = new System.Drawing.Size(190, 17);
            this.traceOnStartCheckbox.TabIndex = 13;
            this.traceOnStartCheckbox.Text = "Enable Instruction Tracing on Start";
            this.traceOnStartCheckbox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.snapshotStatusLabel);
            this.tabPage2.Controls.Add(this.tracingStatusLabel);
            this.tabPage2.Controls.Add(this.startManualTracingButton);
            this.tabPage2.Controls.Add(this.snapshotButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // snapshotStatusLabel
            // 
            this.snapshotStatusLabel.AutoSize = true;
            this.snapshotStatusLabel.Location = new System.Drawing.Point(179, 40);
            this.snapshotStatusLabel.Name = "snapshotStatusLabel";
            this.snapshotStatusLabel.Size = new System.Drawing.Size(91, 13);
            this.snapshotStatusLabel.TabIndex = 17;
            this.snapshotStatusLabel.Text = "Snapshot Status: ";
            this.snapshotStatusLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.snapshotStatusLabel_Paint);
            // 
            // tracingStatusLabel
            // 
            this.tracingStatusLabel.AutoSize = true;
            this.tracingStatusLabel.Location = new System.Drawing.Point(179, 11);
            this.tracingStatusLabel.Name = "tracingStatusLabel";
            this.tracingStatusLabel.Size = new System.Drawing.Size(82, 13);
            this.tracingStatusLabel.TabIndex = 16;
            this.tracingStatusLabel.Text = "Tracing Status: ";
            this.tracingStatusLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.tracingStatusLabel_Paint);
            // 
            // startManualTracingButton
            // 
            this.startManualTracingButton.Location = new System.Drawing.Point(3, 6);
            this.startManualTracingButton.Name = "startManualTracingButton";
            this.startManualTracingButton.Size = new System.Drawing.Size(170, 23);
            this.startManualTracingButton.TabIndex = 15;
            this.startManualTracingButton.Text = "Enable Tracing";
            this.startManualTracingButton.UseVisualStyleBackColor = true;
            this.startManualTracingButton.Click += new System.EventHandler(this.startManualTracingButton_Click);
            // 
            // snapshotButton
            // 
            this.snapshotButton.Location = new System.Drawing.Point(3, 35);
            this.snapshotButton.Name = "snapshotButton";
            this.snapshotButton.Size = new System.Drawing.Size(170, 23);
            this.snapshotButton.TabIndex = 14;
            this.snapshotButton.Text = "Signal Snapshot";
            this.snapshotButton.UseVisualStyleBackColor = true;
            this.snapshotButton.Click += new System.EventHandler(this.snapshotButton_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1254, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Results Page";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.resultsPageActive);
            this.tabPage3.Leave += new System.EventHandler(this.resultsPageInactive);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.11538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.00641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.92628F));
            this.tableLayoutPanel1.Controls.Add(this.loadedLibraryList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.processInstructionFileButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultsGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.loadedThreadList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lowDepthTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.highDepthTextBox, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 360);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // loadedLibraryList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.loadedLibraryList, 2);
            this.loadedLibraryList.ContextMenuStrip = contextMenuStrip1;
            this.loadedLibraryList.DataSource = this.librariesBindingSource;
            this.loadedLibraryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadedLibraryList.FormattingEnabled = true;
            this.loadedLibraryList.Location = new System.Drawing.Point(528, 36);
            this.loadedLibraryList.Name = "loadedLibraryList";
            this.loadedLibraryList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.loadedLibraryList.Size = new System.Drawing.Size(717, 157);
            this.loadedLibraryList.TabIndex = 2;
            this.loadedLibraryList.SelectedValueChanged += new System.EventHandler(this.loadedLibraryList_SelectedValueChanged);
            // 
            // librariesBindingSource
            // 
            this.librariesBindingSource.DataSource = typeof(MemoryPINGui.LibraryResultsProcessor);
            // 
            // processInstructionFileButton
            // 
            this.processInstructionFileButton.Location = new System.Drawing.Point(3, 3);
            this.processInstructionFileButton.Name = "processInstructionFileButton";
            this.processInstructionFileButton.Size = new System.Drawing.Size(170, 23);
            this.processInstructionFileButton.TabIndex = 2;
            this.processInstructionFileButton.Text = "Process Instruction File";
            this.processInstructionFileButton.UseVisualStyleBackColor = true;
            this.processInstructionFileButton.Click += new System.EventHandler(this.processInstructionFileButton_Click);
            // 
            // resultsGridView
            // 
            this.resultsGridView.AllowUserToAddRows = false;
            this.resultsGridView.AllowUserToDeleteRows = false;
            this.resultsGridView.AutoGenerateColumns = false;
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instructionnumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.SystemCallName,
            this.Depth,
            this.threadidDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.LibraryName});
            this.resultsGridView.DataSource = this.instructionBindingSource;
            this.resultsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.resultsGridView.Location = new System.Drawing.Point(3, 36);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.ReadOnly = true;
            this.resultsGridView.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.resultsGridView, 2);
            this.resultsGridView.Size = new System.Drawing.Size(519, 321);
            this.resultsGridView.TabIndex = 3;
            this.resultsGridView.DataSourceChanged += new System.EventHandler(this.resultsGridView_DataSourceChanged);
            // 
            // instructionnumberDataGridViewTextBoxColumn
            // 
            this.instructionnumberDataGridViewTextBoxColumn.DataPropertyName = "Instructionnumber";
            this.instructionnumberDataGridViewTextBoxColumn.HeaderText = "Instructionnumber";
            this.instructionnumberDataGridViewTextBoxColumn.Name = "instructionnumberDataGridViewTextBoxColumn";
            this.instructionnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            dataGridViewCellStyle1.Format = "X08";
            dataGridViewCellStyle1.NullValue = "0";
            this.addressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SystemCallName
            // 
            this.SystemCallName.DataPropertyName = "SystemCallName";
            this.SystemCallName.HeaderText = "SystemCallName";
            this.SystemCallName.Name = "SystemCallName";
            this.SystemCallName.ReadOnly = true;
            // 
            // Depth
            // 
            this.Depth.DataPropertyName = "Depth";
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            this.Depth.ReadOnly = true;
            // 
            // threadidDataGridViewTextBoxColumn
            // 
            this.threadidDataGridViewTextBoxColumn.DataPropertyName = "Threadid";
            this.threadidDataGridViewTextBoxColumn.HeaderText = "Threadid";
            this.threadidDataGridViewTextBoxColumn.Name = "threadidDataGridViewTextBoxColumn";
            this.threadidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LibraryName
            // 
            this.LibraryName.DataPropertyName = "LibraryName";
            this.LibraryName.HeaderText = "LibraryName";
            this.LibraryName.Name = "LibraryName";
            this.LibraryName.ReadOnly = true;
            // 
            // instructionBindingSource
            // 
            this.instructionBindingSource.DataSource = typeof(MemoryPINGui.Instruction);
            // 
            // loadedThreadList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.loadedThreadList, 2);
            this.loadedThreadList.DataSource = this.threadBindingSource;
            this.loadedThreadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadedThreadList.FormattingEnabled = true;
            this.loadedThreadList.Location = new System.Drawing.Point(528, 199);
            this.loadedThreadList.Name = "loadedThreadList";
            this.loadedThreadList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.loadedThreadList.Size = new System.Drawing.Size(717, 158);
            this.loadedThreadList.TabIndex = 4;
            this.loadedThreadList.SelectedValueChanged += new System.EventHandler(this.loadedThreadList_SelectedValueChanged);
            // 
            // lowDepthTextBox
            // 
            this.lowDepthTextBox.Location = new System.Drawing.Point(528, 3);
            this.lowDepthTextBox.Name = "lowDepthTextBox";
            this.lowDepthTextBox.Size = new System.Drawing.Size(355, 20);
            this.lowDepthTextBox.TabIndex = 5;
            this.lowDepthTextBox.Text = "Lower Instruction Depth";
            this.lowDepthTextBox.TextChanged += new System.EventHandler(this.depthFilterChanged);
            // 
            // highDepthTextBox
            // 
            this.highDepthTextBox.Location = new System.Drawing.Point(889, 3);
            this.highDepthTextBox.Name = "highDepthTextBox";
            this.highDepthTextBox.Size = new System.Drawing.Size(354, 20);
            this.highDepthTextBox.TabIndex = 6;
            this.highDepthTextBox.Text = "High Instruction Depth";
            this.highDepthTextBox.TextChanged += new System.EventHandler(this.depthFilterChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.histogramDataView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1254, 366);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Histogram";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.histogramData_Enter);
            // 
            // histogramDataView
            // 
            this.histogramDataView.AllowUserToAddRows = false;
            this.histogramDataView.AllowUserToDeleteRows = false;
            this.histogramDataView.AllowUserToOrderColumns = true;
            this.histogramDataView.AutoGenerateColumns = false;
            this.histogramDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.histogramDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn});
            this.histogramDataView.DataSource = this.histogramEntryBindingSource1;
            this.histogramDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogramDataView.Location = new System.Drawing.Point(3, 3);
            this.histogramDataView.Name = "histogramDataView";
            this.histogramDataView.ReadOnly = true;
            this.histogramDataView.Size = new System.Drawing.Size(1248, 360);
            this.histogramDataView.TabIndex = 0;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 392);
            this.Controls.Add(this.tabContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramEntryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramEntryBindingSource)).EndInit();
            this.tabContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox regionMonitorCheckBox;
        private System.Windows.Forms.CheckBox alternateResultsCheckbox;
        private System.Windows.Forms.CheckBox instructionTracingCheckbox;
        private System.Windows.Forms.CheckBox libraryLoadMonitoringCheckbox;
        private System.Windows.Forms.TextBox regionStartBox;
        private System.Windows.Forms.TextBox regionEndBox;
        private System.Windows.Forms.TextBox resultsFileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memoryPINDllPath;
        private System.Windows.Forms.TextBox pinPathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button startManualTracingButton;
        private System.Windows.Forms.Button snapshotButton;
        private System.Windows.Forms.CheckBox traceOnStartCheckbox;
        private System.Windows.Forms.Label snapshotStatusLabel;
        private System.Windows.Forms.Label tracingStatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button processInstructionFileButton;
        private System.Windows.Forms.BindingSource librariesBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox loadedLibraryList;
        private System.Windows.Forms.BindingSource instructionBindingSource;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.ListBox loadedThreadList;
        private System.Windows.Forms.BindingSource threadBindingSource;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource histogramBindingSource;
        private System.Windows.Forms.BindingSource histogramEntryBindingSource;
        private System.Windows.Forms.BindingSource histogramEntryBindingSource1;
        private System.Windows.Forms.DataGridView histogramDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox lowDepthTextBox;
        private System.Windows.Forms.TextBox highDepthTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemCallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn threadidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibraryName;
        private System.Windows.Forms.ToolStripMenuItem libraryRebaseMenuItem;
    }
}

