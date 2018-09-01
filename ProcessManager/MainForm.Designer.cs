namespace ProcessManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectProcessButton = new System.Windows.Forms.Button();
            this.ProcessRefreshButton = new System.Windows.Forms.Button();
            this.ProcessModuleListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveModuleButton = new System.Windows.Forms.Button();
            this.SaveAllButton = new System.Windows.Forms.Button();
            this.ViewInfoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemoryStatusLabel = new System.Windows.Forms.Label();
            this.CreateProcessHandle = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.WriteMemoryBox = new System.Windows.Forms.TextBox();
            this.WriteMemDataTypeBox = new System.Windows.Forms.ComboBox();
            this.WriteMemoryButton = new System.Windows.Forms.Button();
            this.ReadMemoryButton = new System.Windows.Forms.Button();
            this.ReadMemoryBox = new System.Windows.Forms.TextBox();
            this.ReadMemDataTypeBox = new System.Windows.Forms.ComboBox();
            this.ProcessInfoBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SaveAllInfoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RescanModuleButton = new System.Windows.Forms.Button();
            this.ProcessListBox = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.SearchProcessBox = new System.Windows.Forms.TextBox();
            this.SearchProcessButton = new System.Windows.Forms.Button();
            this.MainInformationTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshinfobox = new System.Windows.Forms.CheckBox();
            this.RefreshModuleInfo = new System.Windows.Forms.CheckBox();
            this.SelectedProcessLabel = new System.Windows.Forms.Label();
            this.MemoryManagerTimer = new System.Windows.Forms.Timer(this.components);
            this.StringLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.WriteValueBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StringLengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process List";
            // 
            // SelectProcessButton
            // 
            this.SelectProcessButton.Location = new System.Drawing.Point(82, 221);
            this.SelectProcessButton.Name = "SelectProcessButton";
            this.SelectProcessButton.Size = new System.Drawing.Size(86, 23);
            this.SelectProcessButton.TabIndex = 2;
            this.SelectProcessButton.Text = "Select Process";
            this.SelectProcessButton.UseVisualStyleBackColor = true;
            this.SelectProcessButton.Click += new System.EventHandler(this.SelectProcessButton_Click);
            // 
            // ProcessRefreshButton
            // 
            this.ProcessRefreshButton.Location = new System.Drawing.Point(12, 221);
            this.ProcessRefreshButton.Name = "ProcessRefreshButton";
            this.ProcessRefreshButton.Size = new System.Drawing.Size(64, 23);
            this.ProcessRefreshButton.TabIndex = 3;
            this.ProcessRefreshButton.Text = "Refresh";
            this.ProcessRefreshButton.UseVisualStyleBackColor = true;
            this.ProcessRefreshButton.Click += new System.EventHandler(this.ProcessRefreshButton_Click);
            // 
            // ProcessModuleListBox
            // 
            this.ProcessModuleListBox.FormattingEnabled = true;
            this.ProcessModuleListBox.Location = new System.Drawing.Point(573, 32);
            this.ProcessModuleListBox.Name = "ProcessModuleListBox";
            this.ProcessModuleListBox.Size = new System.Drawing.Size(215, 290);
            this.ProcessModuleListBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Process Modules";
            // 
            // SaveModuleButton
            // 
            this.SaveModuleButton.Location = new System.Drawing.Point(574, 377);
            this.SaveModuleButton.Name = "SaveModuleButton";
            this.SaveModuleButton.Size = new System.Drawing.Size(93, 23);
            this.SaveModuleButton.TabIndex = 7;
            this.SaveModuleButton.Text = "Save Module";
            this.SaveModuleButton.UseVisualStyleBackColor = true;
            this.SaveModuleButton.Click += new System.EventHandler(this.SaveModuleButton_Click);
            // 
            // SaveAllButton
            // 
            this.SaveAllButton.Location = new System.Drawing.Point(573, 415);
            this.SaveAllButton.Name = "SaveAllButton";
            this.SaveAllButton.Size = new System.Drawing.Size(94, 23);
            this.SaveAllButton.TabIndex = 8;
            this.SaveAllButton.Text = "Save All";
            this.SaveAllButton.UseVisualStyleBackColor = true;
            this.SaveAllButton.Click += new System.EventHandler(this.SaveAllButton_Click);
            // 
            // ViewInfoButton
            // 
            this.ViewInfoButton.Location = new System.Drawing.Point(695, 377);
            this.ViewInfoButton.Name = "ViewInfoButton";
            this.ViewInfoButton.Size = new System.Drawing.Size(93, 23);
            this.ViewInfoButton.TabIndex = 9;
            this.ViewInfoButton.Text = "View  Info";
            this.ViewInfoButton.UseVisualStyleBackColor = true;
            this.ViewInfoButton.Click += new System.EventHandler(this.ViewInfoButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.WriteValueBox);
            this.panel1.Controls.Add(this.StringLengthUpDown);
            this.panel1.Controls.Add(this.MemoryStatusLabel);
            this.panel1.Controls.Add(this.CreateProcessHandle);
            this.panel1.Controls.Add(this.ValueLabel);
            this.panel1.Controls.Add(this.WriteMemoryBox);
            this.panel1.Controls.Add(this.WriteMemDataTypeBox);
            this.panel1.Controls.Add(this.WriteMemoryButton);
            this.panel1.Controls.Add(this.ReadMemoryButton);
            this.panel1.Controls.Add(this.ReadMemoryBox);
            this.panel1.Controls.Add(this.ReadMemDataTypeBox);
            this.panel1.Location = new System.Drawing.Point(33, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 187);
            this.panel1.TabIndex = 10;
            // 
            // MemoryStatusLabel
            // 
            this.MemoryStatusLabel.AutoSize = true;
            this.MemoryStatusLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryStatusLabel.Location = new System.Drawing.Point(4, 58);
            this.MemoryStatusLabel.Name = "MemoryStatusLabel";
            this.MemoryStatusLabel.Size = new System.Drawing.Size(64, 18);
            this.MemoryStatusLabel.TabIndex = 28;
            this.MemoryStatusLabel.Text = "Status:";
            this.MemoryStatusLabel.Click += new System.EventHandler(this.MemoryStatusLabel_Click);
            // 
            // CreateProcessHandle
            // 
            this.CreateProcessHandle.Location = new System.Drawing.Point(20, 8);
            this.CreateProcessHandle.Name = "CreateProcessHandle";
            this.CreateProcessHandle.Size = new System.Drawing.Size(200, 33);
            this.CreateProcessHandle.TabIndex = 27;
            this.CreateProcessHandle.Text = "Attach to Process";
            this.CreateProcessHandle.UseVisualStyleBackColor = true;
            this.CreateProcessHandle.Click += new System.EventHandler(this.CreateProcessHandle_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(3, 165);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(120, 22);
            this.ValueLabel.TabIndex = 26;
            this.ValueLabel.Text = "Value: None";
            // 
            // WriteMemoryBox
            // 
            this.WriteMemoryBox.Location = new System.Drawing.Point(143, 58);
            this.WriteMemoryBox.Name = "WriteMemoryBox";
            this.WriteMemoryBox.Size = new System.Drawing.Size(100, 20);
            this.WriteMemoryBox.TabIndex = 5;
            this.WriteMemoryBox.Enter += new System.EventHandler(this.WriteAddressBoxFocus);
            this.WriteMemoryBox.Leave += new System.EventHandler(this.WriteAddressBoxNotFocus);
            // 
            // WriteMemDataTypeBox
            // 
            this.WriteMemDataTypeBox.FormattingEnabled = true;
            this.WriteMemDataTypeBox.Items.AddRange(new object[] {
            "byte",
            "int",
            "float",
            "double",
            "string"});
            this.WriteMemDataTypeBox.Location = new System.Drawing.Point(143, 109);
            this.WriteMemDataTypeBox.Name = "WriteMemDataTypeBox";
            this.WriteMemDataTypeBox.Size = new System.Drawing.Size(100, 21);
            this.WriteMemDataTypeBox.TabIndex = 4;
            this.WriteMemDataTypeBox.Text = "int";
            this.WriteMemDataTypeBox.SelectedIndexChanged += new System.EventHandler(this.WriteMemDataTypeBox_SelectedIndexChanged);
            // 
            // WriteMemoryButton
            // 
            this.WriteMemoryButton.Location = new System.Drawing.Point(143, 136);
            this.WriteMemoryButton.Name = "WriteMemoryButton";
            this.WriteMemoryButton.Size = new System.Drawing.Size(100, 23);
            this.WriteMemoryButton.TabIndex = 3;
            this.WriteMemoryButton.Text = "Write";
            this.WriteMemoryButton.UseVisualStyleBackColor = true;
            this.WriteMemoryButton.Click += new System.EventHandler(this.WriteMemoryButton_Click);
            // 
            // ReadMemoryButton
            // 
            this.ReadMemoryButton.Location = new System.Drawing.Point(6, 136);
            this.ReadMemoryButton.Name = "ReadMemoryButton";
            this.ReadMemoryButton.Size = new System.Drawing.Size(100, 23);
            this.ReadMemoryButton.TabIndex = 2;
            this.ReadMemoryButton.Text = "Read";
            this.ReadMemoryButton.UseVisualStyleBackColor = true;
            this.ReadMemoryButton.Click += new System.EventHandler(this.ReadMemoryButton_Click);
            // 
            // ReadMemoryBox
            // 
            this.ReadMemoryBox.Location = new System.Drawing.Point(6, 84);
            this.ReadMemoryBox.Name = "ReadMemoryBox";
            this.ReadMemoryBox.Size = new System.Drawing.Size(100, 20);
            this.ReadMemoryBox.TabIndex = 1;
            this.ReadMemoryBox.Enter += new System.EventHandler(this.ReadAddressBoxFocus);
            this.ReadMemoryBox.Leave += new System.EventHandler(this.ReadAddressBoxNotFocus);
            // 
            // ReadMemDataTypeBox
            // 
            this.ReadMemDataTypeBox.FormattingEnabled = true;
            this.ReadMemDataTypeBox.Items.AddRange(new object[] {
            "byte",
            "int",
            "float",
            "double",
            "string"});
            this.ReadMemDataTypeBox.Location = new System.Drawing.Point(7, 110);
            this.ReadMemDataTypeBox.Name = "ReadMemDataTypeBox";
            this.ReadMemDataTypeBox.Size = new System.Drawing.Size(46, 21);
            this.ReadMemDataTypeBox.TabIndex = 0;
            this.ReadMemDataTypeBox.Text = "int";
            this.ReadMemDataTypeBox.SelectedIndexChanged += new System.EventHandler(this.ReadMemDataTypeBox_SelectedIndexChanged);
            // 
            // ProcessInfoBox
            // 
            this.ProcessInfoBox.Location = new System.Drawing.Point(330, 34);
            this.ProcessInfoBox.Name = "ProcessInfoBox";
            this.ProcessInfoBox.Size = new System.Drawing.Size(219, 181);
            this.ProcessInfoBox.TabIndex = 11;
            this.ProcessInfoBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Process Information";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(330, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Save informaton";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SaveAllInfoButton
            // 
            this.SaveAllInfoButton.Location = new System.Drawing.Point(694, 415);
            this.SaveAllInfoButton.Name = "SaveAllInfoButton";
            this.SaveAllInfoButton.Size = new System.Drawing.Size(94, 23);
            this.SaveAllInfoButton.TabIndex = 14;
            this.SaveAllInfoButton.Text = "Save All info";
            this.SaveAllInfoButton.UseVisualStyleBackColor = true;
            this.SaveAllInfoButton.Click += new System.EventHandler(this.SaveAllInfoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Simple Memory Manager";
            // 
            // RescanModuleButton
            // 
            this.RescanModuleButton.Location = new System.Drawing.Point(574, 348);
            this.RescanModuleButton.Name = "RescanModuleButton";
            this.RescanModuleButton.Size = new System.Drawing.Size(214, 23);
            this.RescanModuleButton.TabIndex = 16;
            this.RescanModuleButton.Text = "Rescan Modules";
            this.RescanModuleButton.UseVisualStyleBackColor = true;
            this.RescanModuleButton.Click += new System.EventHandler(this.RescanModuleButton_Click);
            // 
            // ProcessListBox
            // 
            this.ProcessListBox.FormattingEnabled = true;
            this.ProcessListBox.Location = new System.Drawing.Point(12, 58);
            this.ProcessListBox.Name = "ProcessListBox";
            this.ProcessListBox.Size = new System.Drawing.Size(280, 160);
            this.ProcessListBox.TabIndex = 17;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Manual ID Select";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // SearchProcessBox
            // 
            this.SearchProcessBox.Location = new System.Drawing.Point(12, 34);
            this.SearchProcessBox.Name = "SearchProcessBox";
            this.SearchProcessBox.Size = new System.Drawing.Size(156, 20);
            this.SearchProcessBox.TabIndex = 19;
            // 
            // SearchProcessButton
            // 
            this.SearchProcessButton.Location = new System.Drawing.Point(174, 32);
            this.SearchProcessButton.Name = "SearchProcessButton";
            this.SearchProcessButton.Size = new System.Drawing.Size(123, 23);
            this.SearchProcessButton.TabIndex = 20;
            this.SearchProcessButton.Text = "Search For Process";
            this.SearchProcessButton.UseVisualStyleBackColor = true;
            this.SearchProcessButton.Click += new System.EventHandler(this.SearchProcessButton_Click);
            // 
            // MainInformationTimer
            // 
            this.MainInformationTimer.Enabled = true;
            this.MainInformationTimer.Interval = 400;
            this.MainInformationTimer.Tick += new System.EventHandler(this.MainInformationTimer_Tick);
            // 
            // refreshinfobox
            // 
            this.refreshinfobox.AutoSize = true;
            this.refreshinfobox.Checked = true;
            this.refreshinfobox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refreshinfobox.Location = new System.Drawing.Point(448, 225);
            this.refreshinfobox.Name = "refreshinfobox";
            this.refreshinfobox.Size = new System.Drawing.Size(108, 17);
            this.refreshinfobox.TabIndex = 21;
            this.refreshinfobox.Text = "Auto Refresh info";
            this.refreshinfobox.UseVisualStyleBackColor = true;
            this.refreshinfobox.CheckedChanged += new System.EventHandler(this.refreshinfobox_CheckedChanged);
            // 
            // RefreshModuleInfo
            // 
            this.RefreshModuleInfo.AutoSize = true;
            this.RefreshModuleInfo.Location = new System.Drawing.Point(574, 325);
            this.RefreshModuleInfo.Name = "RefreshModuleInfo";
            this.RefreshModuleInfo.Size = new System.Drawing.Size(141, 17);
            this.RefreshModuleInfo.TabIndex = 22;
            this.RefreshModuleInfo.Text = "Auto Refresh Module list";
            this.RefreshModuleInfo.UseVisualStyleBackColor = true;
            this.RefreshModuleInfo.CheckedChanged += new System.EventHandler(this.RefreshModuleInfo_CheckedChanged);
            // 
            // SelectedProcessLabel
            // 
            this.SelectedProcessLabel.AutoSize = true;
            this.SelectedProcessLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedProcessLabel.Location = new System.Drawing.Point(319, 247);
            this.SelectedProcessLabel.Name = "SelectedProcessLabel";
            this.SelectedProcessLabel.Size = new System.Drawing.Size(230, 22);
            this.SelectedProcessLabel.TabIndex = 23;
            this.SelectedProcessLabel.Text = "Selected Process: None";
            // 
            // MemoryManagerTimer
            // 
            this.MemoryManagerTimer.Enabled = true;
            this.MemoryManagerTimer.Tick += new System.EventHandler(this.MemoryManagerTimer_Tick);
            // 
            // StringLengthUpDown
            // 
            this.StringLengthUpDown.Enabled = false;
            this.StringLengthUpDown.Location = new System.Drawing.Point(59, 110);
            this.StringLengthUpDown.Name = "StringLengthUpDown";
            this.StringLengthUpDown.Size = new System.Drawing.Size(47, 20);
            this.StringLengthUpDown.TabIndex = 29;
            this.StringLengthUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // WriteValueBox
            // 
            this.WriteValueBox.Location = new System.Drawing.Point(143, 84);
            this.WriteValueBox.Name = "WriteValueBox";
            this.WriteValueBox.Size = new System.Drawing.Size(100, 20);
            this.WriteValueBox.TabIndex = 30;
            this.WriteValueBox.TextChanged += new System.EventHandler(this.WriteValueBox_TextChanged);
            this.WriteValueBox.Enter += new System.EventHandler(this.WriteValueBoxFocused);
            this.WriteValueBox.Leave += new System.EventHandler(this.WriteValueBoxNotFocused);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.Controls.Add(this.SelectedProcessLabel);
            this.Controls.Add(this.RefreshModuleInfo);
            this.Controls.Add(this.refreshinfobox);
            this.Controls.Add(this.SearchProcessButton);
            this.Controls.Add(this.SearchProcessBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.ProcessListBox);
            this.Controls.Add(this.RescanModuleButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveAllInfoButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcessInfoBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewInfoButton);
            this.Controls.Add(this.SaveAllButton);
            this.Controls.Add(this.SaveModuleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProcessModuleListBox);
            this.Controls.Add(this.ProcessRefreshButton);
            this.Controls.Add(this.SelectProcessButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Process Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StringLengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectProcessButton;
        private System.Windows.Forms.Button ProcessRefreshButton;
        private System.Windows.Forms.ListBox ProcessModuleListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveModuleButton;
        private System.Windows.Forms.Button SaveAllButton;
        private System.Windows.Forms.Button ViewInfoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox ProcessInfoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SaveAllInfoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RescanModuleButton;
        private System.Windows.Forms.ListBox ProcessListBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox SearchProcessBox;
        private System.Windows.Forms.Button SearchProcessButton;
        private System.Windows.Forms.Timer MainInformationTimer;
        private System.Windows.Forms.CheckBox refreshinfobox;
        private System.Windows.Forms.CheckBox RefreshModuleInfo;
        private System.Windows.Forms.Label SelectedProcessLabel;
        private System.Windows.Forms.Button ReadMemoryButton;
        private System.Windows.Forms.TextBox ReadMemoryBox;
        private System.Windows.Forms.ComboBox ReadMemDataTypeBox;
        private System.Windows.Forms.TextBox WriteMemoryBox;
        private System.Windows.Forms.ComboBox WriteMemDataTypeBox;
        private System.Windows.Forms.Button WriteMemoryButton;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label MemoryStatusLabel;
        private System.Windows.Forms.Button CreateProcessHandle;
        private System.Windows.Forms.Timer MemoryManagerTimer;
        private System.Windows.Forms.NumericUpDown StringLengthUpDown;
        private System.Windows.Forms.TextBox WriteValueBox;
    }
}

