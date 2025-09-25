namespace Example
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
            this.SerialPorts = new System.Windows.Forms.ComboBox();
            this.SerialGroupBox = new System.Windows.Forms.GroupBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.BaudrateLable = new System.Windows.Forms.Label();
            this.SerialConnect = new System.Windows.Forms.Button();
            this.BaudrateTextbox = new System.Windows.Forms.TextBox();
            this.SerialRefresh = new System.Windows.Forms.Button();
            this.SerialStatus = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ReadRegisterTab = new System.Windows.Forms.TabPage();
            this.ReadRegisterList = new System.Windows.Forms.ListBox();
            this.mod3configs = new System.Windows.Forms.GroupBox();
            this.count3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startaddress3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Slaveid3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadRegisterButt = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WriteRegisterButt = new System.Windows.Forms.Button();
            this.WriteRegisterPanel = new System.Windows.Forms.Panel();
            this.mod16configs = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.count16 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startaddress16 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Slaveid16 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.status_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SerialGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ReadRegisterTab.SuspendLayout();
            this.mod3configs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mod16configs.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPorts
            // 
            this.SerialPorts.FormattingEnabled = true;
            this.SerialPorts.Location = new System.Drawing.Point(88, 23);
            this.SerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.SerialPorts.Name = "SerialPorts";
            this.SerialPorts.Size = new System.Drawing.Size(80, 27);
            this.SerialPorts.TabIndex = 0;
            // 
            // SerialGroupBox
            // 
            this.SerialGroupBox.Controls.Add(this.label7);
            this.SerialGroupBox.Controls.Add(this.status_panel);
            this.SerialGroupBox.Controls.Add(this.PortLabel);
            this.SerialGroupBox.Controls.Add(this.BaudrateLable);
            this.SerialGroupBox.Controls.Add(this.SerialConnect);
            this.SerialGroupBox.Controls.Add(this.BaudrateTextbox);
            this.SerialGroupBox.Controls.Add(this.SerialRefresh);
            this.SerialGroupBox.Controls.Add(this.SerialPorts);
            this.SerialGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SerialGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SerialGroupBox.Name = "SerialGroupBox";
            this.SerialGroupBox.Size = new System.Drawing.Size(175, 383);
            this.SerialGroupBox.TabIndex = 1;
            this.SerialGroupBox.TabStop = false;
            this.SerialGroupBox.Text = "Serial";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(6, 26);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(45, 19);
            this.PortLabel.TabIndex = 6;
            this.PortLabel.Text = "Port :";
            // 
            // BaudrateLable
            // 
            this.BaudrateLable.AutoSize = true;
            this.BaudrateLable.Location = new System.Drawing.Point(6, 58);
            this.BaudrateLable.Name = "BaudrateLable";
            this.BaudrateLable.Size = new System.Drawing.Size(79, 19);
            this.BaudrateLable.TabIndex = 5;
            this.BaudrateLable.Text = "Baudrate :";
            // 
            // SerialConnect
            // 
            this.SerialConnect.Location = new System.Drawing.Point(20, 128);
            this.SerialConnect.Name = "SerialConnect";
            this.SerialConnect.Size = new System.Drawing.Size(135, 30);
            this.SerialConnect.TabIndex = 4;
            this.SerialConnect.Text = "Connect";
            this.SerialConnect.UseVisualStyleBackColor = true;
            this.SerialConnect.Click += new System.EventHandler(this.SerialConnect_Click);
            // 
            // BaudrateTextbox
            // 
            this.BaudrateTextbox.Location = new System.Drawing.Point(88, 55);
            this.BaudrateTextbox.MaxLength = 6;
            this.BaudrateTextbox.Name = "BaudrateTextbox";
            this.BaudrateTextbox.Size = new System.Drawing.Size(80, 27);
            this.BaudrateTextbox.TabIndex = 2;
            this.BaudrateTextbox.Text = "115200";
            this.BaudrateTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // SerialRefresh
            // 
            this.SerialRefresh.Location = new System.Drawing.Point(20, 92);
            this.SerialRefresh.Name = "SerialRefresh";
            this.SerialRefresh.Size = new System.Drawing.Size(135, 30);
            this.SerialRefresh.TabIndex = 3;
            this.SerialRefresh.Text = "Refresh";
            this.SerialRefresh.UseVisualStyleBackColor = true;
            this.SerialRefresh.Click += new System.EventHandler(this.SerialRefresh_Click);
            // 
            // SerialStatus
            // 
            this.SerialStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SerialStatus.Location = new System.Drawing.Point(0, 383);
            this.SerialStatus.Name = "SerialStatus";
            this.SerialStatus.Size = new System.Drawing.Size(796, 20);
            this.SerialStatus.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ReadRegisterTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(175, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 383);
            this.tabControl1.TabIndex = 2;
            // 
            // ReadRegisterTab
            // 
            this.ReadRegisterTab.AutoScroll = true;
            this.ReadRegisterTab.Controls.Add(this.ReadRegisterList);
            this.ReadRegisterTab.Controls.Add(this.mod3configs);
            this.ReadRegisterTab.Location = new System.Drawing.Point(4, 28);
            this.ReadRegisterTab.Name = "ReadRegisterTab";
            this.ReadRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReadRegisterTab.Size = new System.Drawing.Size(613, 351);
            this.ReadRegisterTab.TabIndex = 0;
            this.ReadRegisterTab.Text = "Read Register";
            this.ReadRegisterTab.UseVisualStyleBackColor = true;
            // 
            // ReadRegisterList
            // 
            this.ReadRegisterList.BackColor = System.Drawing.SystemColors.Window;
            this.ReadRegisterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReadRegisterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadRegisterList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadRegisterList.FormattingEnabled = true;
            this.ReadRegisterList.ItemHeight = 20;
            this.ReadRegisterList.Location = new System.Drawing.Point(3, 75);
            this.ReadRegisterList.Name = "ReadRegisterList";
            this.ReadRegisterList.Size = new System.Drawing.Size(607, 273);
            this.ReadRegisterList.TabIndex = 1;
            // 
            // mod3configs
            // 
            this.mod3configs.Controls.Add(this.count3);
            this.mod3configs.Controls.Add(this.label3);
            this.mod3configs.Controls.Add(this.startaddress3);
            this.mod3configs.Controls.Add(this.label2);
            this.mod3configs.Controls.Add(this.Slaveid3);
            this.mod3configs.Controls.Add(this.label1);
            this.mod3configs.Controls.Add(this.ReadRegisterButt);
            this.mod3configs.Dock = System.Windows.Forms.DockStyle.Top;
            this.mod3configs.Location = new System.Drawing.Point(3, 3);
            this.mod3configs.Name = "mod3configs";
            this.mod3configs.Size = new System.Drawing.Size(607, 72);
            this.mod3configs.TabIndex = 0;
            this.mod3configs.TabStop = false;
            this.mod3configs.Text = "Config";
            // 
            // count3
            // 
            this.count3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count3.Location = new System.Drawing.Point(447, 28);
            this.count3.MaxLength = 3;
            this.count3.Name = "count3";
            this.count3.Size = new System.Drawing.Size(50, 27);
            this.count3.TabIndex = 2;
            this.count3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Count :";
            // 
            // startaddress3
            // 
            this.startaddress3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startaddress3.Location = new System.Drawing.Point(290, 28);
            this.startaddress3.MaxLength = 2;
            this.startaddress3.Name = "startaddress3";
            this.startaddress3.Size = new System.Drawing.Size(50, 27);
            this.startaddress3.TabIndex = 1;
            this.startaddress3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Address :";
            // 
            // Slaveid3
            // 
            this.Slaveid3.Location = new System.Drawing.Point(75, 28);
            this.Slaveid3.MaxLength = 3;
            this.Slaveid3.Name = "Slaveid3";
            this.Slaveid3.Size = new System.Drawing.Size(50, 27);
            this.Slaveid3.TabIndex = 0;
            this.Slaveid3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SlaveID :";
            // 
            // ReadRegisterButt
            // 
            this.ReadRegisterButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadRegisterButt.Location = new System.Drawing.Point(524, 24);
            this.ReadRegisterButt.Name = "ReadRegisterButt";
            this.ReadRegisterButt.Size = new System.Drawing.Size(75, 32);
            this.ReadRegisterButt.TabIndex = 3;
            this.ReadRegisterButt.Text = "Read";
            this.ReadRegisterButt.UseVisualStyleBackColor = true;
            this.ReadRegisterButt.Click += new System.EventHandler(this.ReadRegister_ButtonClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WriteRegisterButt);
            this.tabPage2.Controls.Add(this.WriteRegisterPanel);
            this.tabPage2.Controls.Add(this.mod16configs);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Write Register";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WriteRegisterButt
            // 
            this.WriteRegisterButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WriteRegisterButt.Location = new System.Drawing.Point(421, 281);
            this.WriteRegisterButt.Name = "WriteRegisterButt";
            this.WriteRegisterButt.Size = new System.Drawing.Size(75, 25);
            this.WriteRegisterButt.TabIndex = 7;
            this.WriteRegisterButt.Text = "Write";
            this.WriteRegisterButt.UseVisualStyleBackColor = true;
            this.WriteRegisterButt.Visible = false;
            this.WriteRegisterButt.Click += new System.EventHandler(this.WriteRegisterButt_Click);
            // 
            // WriteRegisterPanel
            // 
            this.WriteRegisterPanel.AutoScroll = true;
            this.WriteRegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriteRegisterPanel.Location = new System.Drawing.Point(3, 75);
            this.WriteRegisterPanel.Name = "WriteRegisterPanel";
            this.WriteRegisterPanel.Size = new System.Drawing.Size(607, 273);
            this.WriteRegisterPanel.TabIndex = 1;
            // 
            // mod16configs
            // 
            this.mod16configs.Controls.Add(this.button1);
            this.mod16configs.Controls.Add(this.count16);
            this.mod16configs.Controls.Add(this.label4);
            this.mod16configs.Controls.Add(this.startaddress16);
            this.mod16configs.Controls.Add(this.label5);
            this.mod16configs.Controls.Add(this.Slaveid16);
            this.mod16configs.Controls.Add(this.label6);
            this.mod16configs.Dock = System.Windows.Forms.DockStyle.Top;
            this.mod16configs.Location = new System.Drawing.Point(3, 3);
            this.mod16configs.Name = "mod16configs";
            this.mod16configs.Size = new System.Drawing.Size(607, 72);
            this.mod16configs.TabIndex = 0;
            this.mod16configs.TabStop = false;
            this.mod16configs.Text = "Config";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(524, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.WriteRegisterSet_CLK);
            // 
            // count16
            // 
            this.count16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count16.Location = new System.Drawing.Point(448, 28);
            this.count16.MaxLength = 3;
            this.count16.Name = "count16";
            this.count16.Size = new System.Drawing.Size(50, 27);
            this.count16.TabIndex = 2;
            this.count16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Count :";
            // 
            // startaddress16
            // 
            this.startaddress16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startaddress16.Location = new System.Drawing.Point(291, 28);
            this.startaddress16.MaxLength = 2;
            this.startaddress16.Name = "startaddress16";
            this.startaddress16.Size = new System.Drawing.Size(50, 27);
            this.startaddress16.TabIndex = 1;
            this.startaddress16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Start Address :";
            // 
            // Slaveid16
            // 
            this.Slaveid16.Location = new System.Drawing.Point(75, 28);
            this.Slaveid16.MaxLength = 3;
            this.Slaveid16.Name = "Slaveid16";
            this.Slaveid16.Size = new System.Drawing.Size(50, 27);
            this.Slaveid16.TabIndex = 0;
            this.Slaveid16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "SlaveID :";
            // 
            // status_panel
            // 
            this.status_panel.BackColor = System.Drawing.Color.Transparent;
            this.status_panel.Location = new System.Drawing.Point(135, 342);
            this.status_panel.Name = "status_panel";
            this.status_panel.Size = new System.Drawing.Size(20, 20);
            this.status_panel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(796, 403);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SerialGroupBox);
            this.Controls.Add(this.SerialStatus);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(814, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SerialGroupBox.ResumeLayout(false);
            this.SerialGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ReadRegisterTab.ResumeLayout(false);
            this.mod3configs.ResumeLayout(false);
            this.mod3configs.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.mod16configs.ResumeLayout(false);
            this.mod16configs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SerialPorts;
        private System.Windows.Forms.GroupBox SerialGroupBox;
        private System.Windows.Forms.Button SerialRefresh;
        private System.Windows.Forms.Button SerialConnect;
        private System.Windows.Forms.TextBox BaudrateTextbox;
        private System.Windows.Forms.Label BaudrateLable;
        private System.Windows.Forms.Panel SerialStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ReadRegisterTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.GroupBox mod3configs;
        private System.Windows.Forms.Button ReadRegisterButt;
        private System.Windows.Forms.ListBox ReadRegisterList;
        private System.Windows.Forms.TextBox count3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startaddress3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Slaveid3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mod16configs;
        private System.Windows.Forms.TextBox count16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startaddress16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Slaveid16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel WriteRegisterPanel;
        private System.Windows.Forms.Button WriteRegisterButt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel status_panel;
    }
}

