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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mod16configs = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SerialGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ReadRegisterTab.SuspendLayout();
            this.mod16configs.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPorts
            // 
            this.SerialPorts.FormattingEnabled = true;
            this.SerialPorts.Location = new System.Drawing.Point(88, 23);
            this.SerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.SerialPorts.Name = "SerialPorts";
            this.SerialPorts.Size = new System.Drawing.Size(80, 23);
            this.SerialPorts.TabIndex = 0;
            // 
            // SerialGroupBox
            // 
            this.SerialGroupBox.Controls.Add(this.PortLabel);
            this.SerialGroupBox.Controls.Add(this.BaudrateLable);
            this.SerialGroupBox.Controls.Add(this.SerialConnect);
            this.SerialGroupBox.Controls.Add(this.BaudrateTextbox);
            this.SerialGroupBox.Controls.Add(this.SerialRefresh);
            this.SerialGroupBox.Controls.Add(this.SerialPorts);
            this.SerialGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SerialGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SerialGroupBox.Name = "SerialGroupBox";
            this.SerialGroupBox.Size = new System.Drawing.Size(175, 341);
            this.SerialGroupBox.TabIndex = 1;
            this.SerialGroupBox.TabStop = false;
            this.SerialGroupBox.Text = "Serial";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(6, 26);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(36, 15);
            this.PortLabel.TabIndex = 6;
            this.PortLabel.Text = "Port :";
            // 
            // BaudrateLable
            // 
            this.BaudrateLable.AutoSize = true;
            this.BaudrateLable.Location = new System.Drawing.Point(6, 58);
            this.BaudrateLable.Name = "BaudrateLable";
            this.BaudrateLable.Size = new System.Drawing.Size(64, 15);
            this.BaudrateLable.TabIndex = 5;
            this.BaudrateLable.Text = "Baudrate :";
            // 
            // SerialConnect
            // 
            this.SerialConnect.Location = new System.Drawing.Point(20, 128);
            this.SerialConnect.Name = "SerialConnect";
            this.SerialConnect.Size = new System.Drawing.Size(135, 23);
            this.SerialConnect.TabIndex = 2;
            this.SerialConnect.Text = "Connect";
            this.SerialConnect.UseVisualStyleBackColor = true;
            this.SerialConnect.Click += new System.EventHandler(this.SerialConnect_Click);
            // 
            // BaudrateTextbox
            // 
            this.BaudrateTextbox.Location = new System.Drawing.Point(88, 55);
            this.BaudrateTextbox.MaxLength = 6;
            this.BaudrateTextbox.Name = "BaudrateTextbox";
            this.BaudrateTextbox.Size = new System.Drawing.Size(80, 23);
            this.BaudrateTextbox.TabIndex = 4;
            this.BaudrateTextbox.Text = "115200";
            this.BaudrateTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // SerialRefresh
            // 
            this.SerialRefresh.Location = new System.Drawing.Point(20, 92);
            this.SerialRefresh.Name = "SerialRefresh";
            this.SerialRefresh.Size = new System.Drawing.Size(135, 23);
            this.SerialRefresh.TabIndex = 3;
            this.SerialRefresh.Text = "Refresh";
            this.SerialRefresh.UseVisualStyleBackColor = true;
            this.SerialRefresh.Click += new System.EventHandler(this.SerialRefresh_Click);
            // 
            // SerialStatus
            // 
            this.SerialStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SerialStatus.Location = new System.Drawing.Point(0, 341);
            this.SerialStatus.Name = "SerialStatus";
            this.SerialStatus.Size = new System.Drawing.Size(684, 20);
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
            this.tabControl1.Size = new System.Drawing.Size(509, 341);
            this.tabControl1.TabIndex = 3;
            // 
            // ReadRegisterTab
            // 
            this.ReadRegisterTab.AutoScroll = true;
            this.ReadRegisterTab.Controls.Add(this.mod16configs);
            this.ReadRegisterTab.Location = new System.Drawing.Point(4, 24);
            this.ReadRegisterTab.Name = "ReadRegisterTab";
            this.ReadRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReadRegisterTab.Size = new System.Drawing.Size(501, 313);
            this.ReadRegisterTab.TabIndex = 0;
            this.ReadRegisterTab.Text = "Read Register";
            this.ReadRegisterTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mod16configs
            // 
            this.mod16configs.Controls.Add(this.button1);
            this.mod16configs.Dock = System.Windows.Forms.DockStyle.Top;
            this.mod16configs.Location = new System.Drawing.Point(3, 3);
            this.mod16configs.Name = "mod16configs";
            this.mod16configs.Size = new System.Drawing.Size(495, 72);
            this.mod16configs.TabIndex = 0;
            this.mod16configs.TabStop = false;
            this.mod16configs.Text = "Config";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReadRegister_ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SerialGroupBox);
            this.Controls.Add(this.SerialStatus);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SerialGroupBox.ResumeLayout(false);
            this.SerialGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ReadRegisterTab.ResumeLayout(false);
            this.mod16configs.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox mod16configs;
        private System.Windows.Forms.Button button1;
    }
}

