namespace Namer
{
    partial class NamerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NamerForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.directoryGroupBox = new System.Windows.Forms.GroupBox();
            this.dirTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.filesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.filesButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.getPatternButton = new System.Windows.Forms.Button();
            this.patternGroupBox = new System.Windows.Forms.GroupBox();
            this.replacementTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.patternComboBox = new System.Windows.Forms.ComboBox();
            this.regExCheckBox = new System.Windows.Forms.CheckBox();
            this.replacementComboBox = new System.Windows.Forms.ComboBox();
            this.replacementLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.applyToAllCheckBox = new System.Windows.Forms.CheckBox();
            this.fileOperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.manualRenameButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTableLayoutPanel.SuspendLayout();
            this.directoryGroupBox.SuspendLayout();
            this.dirTableLayoutPanel.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.filesTableLayoutPanel.SuspendLayout();
            this.filesButtonsFlowLayoutPanel.SuspendLayout();
            this.patternGroupBox.SuspendLayout();
            this.replacementTableLayoutPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.fileOperationsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.15942F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.84058F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.mainTableLayoutPanel.Controls.Add(this.directoryGroupBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.filesGroupBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.patternGroupBox, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.startButton, 2, 3);
            this.mainTableLayoutPanel.Controls.Add(this.statusStrip, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.applyToAllCheckBox, 2, 2);
            this.mainTableLayoutPanel.Controls.Add(this.fileOperationsGroupBox, 2, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54482F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.45518F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(839, 681);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // directoryGroupBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.directoryGroupBox, 3);
            this.directoryGroupBox.Controls.Add(this.dirTableLayoutPanel);
            this.directoryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryGroupBox.Location = new System.Drawing.Point(3, 3);
            this.directoryGroupBox.Name = "directoryGroupBox";
            this.directoryGroupBox.Size = new System.Drawing.Size(833, 54);
            this.directoryGroupBox.TabIndex = 11;
            this.directoryGroupBox.TabStop = false;
            this.directoryGroupBox.Text = "Directory options";
            // 
            // dirTableLayoutPanel
            // 
            this.dirTableLayoutPanel.ColumnCount = 3;
            this.dirTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.dirTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dirTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.dirTableLayoutPanel.Controls.Add(this.directoryTextBox, 1, 0);
            this.dirTableLayoutPanel.Controls.Add(this.directoryLabel, 0, 0);
            this.dirTableLayoutPanel.Controls.Add(this.browseButton, 2, 0);
            this.dirTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.dirTableLayoutPanel.Name = "dirTableLayoutPanel";
            this.dirTableLayoutPanel.RowCount = 1;
            this.dirTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dirTableLayoutPanel.Size = new System.Drawing.Size(827, 35);
            this.dirTableLayoutPanel.TabIndex = 0;
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directoryTextBox.Location = new System.Drawing.Point(103, 7);
            this.directoryTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(541, 22);
            this.directoryTextBox.TabIndex = 0;
            this.directoryTextBox.Leave += new System.EventHandler(this.DirectoryTextBoxLeave);
            // 
            // directoryLabel
            // 
            this.directoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(3, 11);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(76, 13);
            this.directoryLabel.TabIndex = 4;
            this.directoryLabel.Text = "Directory path:";
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(650, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(174, 29);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // filesGroupBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.filesGroupBox, 2);
            this.filesGroupBox.Controls.Add(this.filesTableLayoutPanel);
            this.filesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesGroupBox.Location = new System.Drawing.Point(3, 63);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(641, 510);
            this.filesGroupBox.TabIndex = 12;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Files";
            // 
            // filesTableLayoutPanel
            // 
            this.filesTableLayoutPanel.ColumnCount = 5;
            this.filesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.filesTableLayoutPanel.Controls.Add(this.fileListBox, 0, 0);
            this.filesTableLayoutPanel.Controls.Add(this.filesButtonsFlowLayoutPanel, 0, 1);
            this.filesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.filesTableLayoutPanel.Name = "filesTableLayoutPanel";
            this.filesTableLayoutPanel.RowCount = 2;
            this.filesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0862F));
            this.filesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.913794F));
            this.filesTableLayoutPanel.Size = new System.Drawing.Size(635, 491);
            this.filesTableLayoutPanel.TabIndex = 0;
            // 
            // fileListBox
            // 
            this.filesTableLayoutPanel.SetColumnSpan(this.fileListBox, 5);
            this.fileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.HorizontalScrollbar = true;
            this.fileListBox.ItemHeight = 16;
            this.fileListBox.Location = new System.Drawing.Point(3, 3);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fileListBox.Size = new System.Drawing.Size(629, 436);
            this.fileListBox.TabIndex = 7;
            // 
            // filesButtonsFlowLayoutPanel
            // 
            this.filesTableLayoutPanel.SetColumnSpan(this.filesButtonsFlowLayoutPanel, 5);
            this.filesButtonsFlowLayoutPanel.Controls.Add(this.getPatternButton);
            this.filesButtonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesButtonsFlowLayoutPanel.Location = new System.Drawing.Point(3, 445);
            this.filesButtonsFlowLayoutPanel.Name = "filesButtonsFlowLayoutPanel";
            this.filesButtonsFlowLayoutPanel.Size = new System.Drawing.Size(629, 43);
            this.filesButtonsFlowLayoutPanel.TabIndex = 8;
            // 
            // getPatternButton
            // 
            this.getPatternButton.Location = new System.Drawing.Point(3, 3);
            this.getPatternButton.Name = "getPatternButton";
            this.getPatternButton.Size = new System.Drawing.Size(95, 34);
            this.getPatternButton.TabIndex = 0;
            this.getPatternButton.Text = "Get pattern";
            this.getPatternButton.UseVisualStyleBackColor = true;
            this.getPatternButton.Click += new System.EventHandler(this.GetPatternButtonClick);
            // 
            // patternGroupBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.patternGroupBox, 2);
            this.patternGroupBox.Controls.Add(this.replacementTableLayoutPanel);
            this.patternGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.patternGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patternGroupBox.Location = new System.Drawing.Point(3, 579);
            this.patternGroupBox.Name = "patternGroupBox";
            this.mainTableLayoutPanel.SetRowSpan(this.patternGroupBox, 2);
            this.patternGroupBox.Size = new System.Drawing.Size(641, 72);
            this.patternGroupBox.TabIndex = 13;
            this.patternGroupBox.TabStop = false;
            this.patternGroupBox.Text = "Renaming";
            // 
            // replacementTableLayoutPanel
            // 
            this.replacementTableLayoutPanel.ColumnCount = 3;
            this.replacementTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.replacementTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.replacementTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.replacementTableLayoutPanel.Controls.Add(this.patternComboBox, 1, 1);
            this.replacementTableLayoutPanel.Controls.Add(this.regExCheckBox, 0, 1);
            this.replacementTableLayoutPanel.Controls.Add(this.replacementComboBox, 2, 1);
            this.replacementTableLayoutPanel.Controls.Add(this.replacementLabel, 2, 0);
            this.replacementTableLayoutPanel.Controls.Add(this.patternLabel, 1, 0);
            this.replacementTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replacementTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.replacementTableLayoutPanel.Name = "replacementTableLayoutPanel";
            this.replacementTableLayoutPanel.RowCount = 2;
            this.replacementTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.replacementTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.replacementTableLayoutPanel.Size = new System.Drawing.Size(635, 53);
            this.replacementTableLayoutPanel.TabIndex = 0;
            // 
            // patternComboBox
            // 
            this.patternComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternComboBox.FormattingEnabled = true;
            this.patternComboBox.Location = new System.Drawing.Point(102, 29);
            this.patternComboBox.Name = "patternComboBox";
            this.patternComboBox.Size = new System.Drawing.Size(262, 21);
            this.patternComboBox.TabIndex = 1;
            // 
            // regExCheckBox
            // 
            this.regExCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.regExCheckBox.AutoSize = true;
            this.regExCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regExCheckBox.Location = new System.Drawing.Point(3, 29);
            this.regExCheckBox.Name = "regExCheckBox";
            this.regExCheckBox.Size = new System.Drawing.Size(89, 21);
            this.regExCheckBox.TabIndex = 6;
            this.regExCheckBox.Text = "Use regex";
            this.regExCheckBox.UseVisualStyleBackColor = true;
            // 
            // replacementComboBox
            // 
            this.replacementComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replacementComboBox.FormattingEnabled = true;
            this.replacementComboBox.Location = new System.Drawing.Point(370, 29);
            this.replacementComboBox.Name = "replacementComboBox";
            this.replacementComboBox.Size = new System.Drawing.Size(262, 21);
            this.replacementComboBox.TabIndex = 2;
            // 
            // replacementLabel
            // 
            this.replacementLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.replacementLabel.AutoSize = true;
            this.replacementLabel.Location = new System.Drawing.Point(370, 13);
            this.replacementLabel.Name = "replacementLabel";
            this.replacementLabel.Size = new System.Drawing.Size(72, 13);
            this.replacementLabel.TabIndex = 10;
            this.replacementLabel.Text = "Replace with:";
            // 
            // patternLabel
            // 
            this.patternLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(102, 13);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(44, 13);
            this.patternLabel.TabIndex = 9;
            this.patternLabel.Text = "Pattern:";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(650, 618);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(186, 33);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // statusStrip
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.statusStrip, 3);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 659);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(839, 22);
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Ready.";
            // 
            // applyToAllCheckBox
            // 
            this.applyToAllCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.applyToAllCheckBox.AutoSize = true;
            this.applyToAllCheckBox.Checked = true;
            this.applyToAllCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyToAllCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyToAllCheckBox.Location = new System.Drawing.Point(650, 579);
            this.applyToAllCheckBox.Name = "applyToAllCheckBox";
            this.applyToAllCheckBox.Size = new System.Drawing.Size(123, 33);
            this.applyToAllCheckBox.TabIndex = 15;
            this.applyToAllCheckBox.Text = "Rename all files";
            this.applyToAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileOperationsGroupBox
            // 
            this.fileOperationsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.fileOperationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileOperationsGroupBox.Location = new System.Drawing.Point(650, 63);
            this.fileOperationsGroupBox.Name = "fileOperationsGroupBox";
            this.fileOperationsGroupBox.Size = new System.Drawing.Size(186, 510);
            this.fileOperationsGroupBox.TabIndex = 16;
            this.fileOperationsGroupBox.TabStop = false;
            this.fileOperationsGroupBox.Text = "File operations";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.manualRenameButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // manualRenameButton
            // 
            this.manualRenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manualRenameButton.Location = new System.Drawing.Point(3, 3);
            this.manualRenameButton.Name = "manualRenameButton";
            this.manualRenameButton.Size = new System.Drawing.Size(174, 43);
            this.manualRenameButton.TabIndex = 0;
            this.manualRenameButton.Text = "Rename";
            this.manualRenameButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(3, 52);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(174, 43);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // NamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 681);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(855, 720);
            this.Name = "NamerForm";
            this.Text = "Namer, v0.1";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.directoryGroupBox.ResumeLayout(false);
            this.dirTableLayoutPanel.ResumeLayout(false);
            this.dirTableLayoutPanel.PerformLayout();
            this.filesGroupBox.ResumeLayout(false);
            this.filesTableLayoutPanel.ResumeLayout(false);
            this.filesButtonsFlowLayoutPanel.ResumeLayout(false);
            this.patternGroupBox.ResumeLayout(false);
            this.replacementTableLayoutPanel.ResumeLayout(false);
            this.replacementTableLayoutPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.fileOperationsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.ComboBox patternComboBox;
        private System.Windows.Forms.ComboBox replacementComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox regExCheckBox;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button getPatternButton;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Label replacementLabel;
        private System.Windows.Forms.GroupBox directoryGroupBox;
        private System.Windows.Forms.TableLayoutPanel dirTableLayoutPanel;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.TableLayoutPanel filesTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel filesButtonsFlowLayoutPanel;
        private System.Windows.Forms.GroupBox patternGroupBox;
        private System.Windows.Forms.TableLayoutPanel replacementTableLayoutPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.CheckBox applyToAllCheckBox;
        private System.Windows.Forms.GroupBox fileOperationsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button manualRenameButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button browseButton;
    }
}

