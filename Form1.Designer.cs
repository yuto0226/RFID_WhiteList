namespace RFID_WhiteList
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.textCommand = new System.Windows.Forms.TextBox();
            this.serialPortRFID = new System.IO.Ports.SerialPort(this.components);
            this.textResponse = new System.Windows.Forms.TextBox();
            this.comboCOM = new System.Windows.Forms.ComboBox();
            this.groupConsole = new System.Windows.Forms.GroupBox();
            this.groupSetting = new System.Windows.Forms.GroupBox();
            this.labelWhiteList = new System.Windows.Forms.Label();
            this.comboCardId = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.labelCardAccess = new System.Windows.Forms.Label();
            this.labelCardStatusHint = new System.Windows.Forms.Label();
            this.btnRemoveCardId = new System.Windows.Forms.Button();
            this.btnAddCardId = new System.Windows.Forms.Button();
            this.labelIdStatus = new System.Windows.Forms.Label();
            this.textCardID = new System.Windows.Forms.TextBox();
            this.labelCardID = new System.Windows.Forms.Label();
            this.labelStatusCode = new System.Windows.Forms.Label();
            this.statusBit0 = new System.Windows.Forms.TextBox();
            this.statusBit1 = new System.Windows.Forms.TextBox();
            this.statusBit2 = new System.Windows.Forms.TextBox();
            this.statusBit3 = new System.Windows.Forms.TextBox();
            this.statusBit4 = new System.Windows.Forms.TextBox();
            this.statusBit5 = new System.Windows.Forms.TextBox();
            this.statusBit6 = new System.Windows.Forms.TextBox();
            this.statusBit7 = new System.Windows.Forms.TextBox();
            this.labelStatusIcon = new System.Windows.Forms.Label();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白名單ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupConsole.SuspendLayout();
            this.groupSetting.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCommand.Location = new System.Drawing.Point(518, 514);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(85, 34);
            this.btnSendCommand.TabIndex = 3;
            this.btnSendCommand.Text = "送出";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // textCommand
            // 
            this.textCommand.AcceptsReturn = true;
            this.textCommand.Font = new System.Drawing.Font("JetBrainsMono NF Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCommand.Location = new System.Drawing.Point(6, 514);
            this.textCommand.Name = "textCommand";
            this.textCommand.Size = new System.Drawing.Size(506, 34);
            this.textCommand.TabIndex = 2;
            this.textCommand.Text = "530000";
            this.textCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCommand_KeyDown);
            // 
            // serialPortRFID
            // 
            this.serialPortRFID.Handshake = System.IO.Ports.Handshake.RequestToSend;
            this.serialPortRFID.StopBits = System.IO.Ports.StopBits.Two;
            // 
            // textResponse
            // 
            this.textResponse.Font = new System.Drawing.Font("JetBrainsMono NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResponse.Location = new System.Drawing.Point(6, 24);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.ReadOnly = true;
            this.textResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResponse.Size = new System.Drawing.Size(597, 484);
            this.textResponse.TabIndex = 99;
            this.textResponse.TabStop = false;
            // 
            // comboCOM
            // 
            this.comboCOM.Font = new System.Drawing.Font("JetBrainsMono NF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCOM.FormattingEnabled = true;
            this.comboCOM.Items.AddRange(new object[] {
            "懶得找 COM",
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.comboCOM.Location = new System.Drawing.Point(76, 26);
            this.comboCOM.Name = "comboCOM";
            this.comboCOM.Size = new System.Drawing.Size(216, 30);
            this.comboCOM.TabIndex = 0;
            this.comboCOM.TabStop = false;
            // 
            // groupConsole
            // 
            this.groupConsole.Controls.Add(this.textCommand);
            this.groupConsole.Controls.Add(this.textResponse);
            this.groupConsole.Controls.Add(this.btnSendCommand);
            this.groupConsole.Font = new System.Drawing.Font("JetBrainsMono NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupConsole.Location = new System.Drawing.Point(12, 30);
            this.groupConsole.Name = "groupConsole";
            this.groupConsole.Size = new System.Drawing.Size(609, 554);
            this.groupConsole.TabIndex = 4;
            this.groupConsole.TabStop = false;
            this.groupConsole.Text = "Console";
            // 
            // groupSetting
            // 
            this.groupSetting.Controls.Add(this.labelWhiteList);
            this.groupSetting.Controls.Add(this.comboCardId);
            this.groupSetting.Controls.Add(this.labelPort);
            this.groupSetting.Controls.Add(this.comboCOM);
            this.groupSetting.Font = new System.Drawing.Font("JetBrainsMono NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSetting.Location = new System.Drawing.Point(627, 402);
            this.groupSetting.Name = "groupSetting";
            this.groupSetting.Size = new System.Drawing.Size(298, 102);
            this.groupSetting.TabIndex = 5;
            this.groupSetting.TabStop = false;
            this.groupSetting.Text = "Setting";
            // 
            // labelWhiteList
            // 
            this.labelWhiteList.AutoSize = true;
            this.labelWhiteList.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhiteList.Location = new System.Drawing.Point(6, 65);
            this.labelWhiteList.Name = "labelWhiteList";
            this.labelWhiteList.Size = new System.Drawing.Size(63, 25);
            this.labelWhiteList.TabIndex = 7;
            this.labelWhiteList.Text = "白名單";
            this.labelWhiteList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboCardId
            // 
            this.comboCardId.Font = new System.Drawing.Font("JetBrainsMono NF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCardId.FormattingEnabled = true;
            this.comboCardId.Location = new System.Drawing.Point(76, 62);
            this.comboCardId.Name = "comboCardId";
            this.comboCardId.Size = new System.Drawing.Size(216, 30);
            this.comboCardId.TabIndex = 6;
            this.comboCardId.TabStop = false;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(6, 29);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(63, 25);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "通訊埠";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConnect.Location = new System.Drawing.Point(627, 510);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(298, 74);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.TabStop = false;
            this.btnConnect.Text = "連線";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.labelCardAccess);
            this.groupStatus.Controls.Add(this.labelCardStatusHint);
            this.groupStatus.Controls.Add(this.btnRemoveCardId);
            this.groupStatus.Controls.Add(this.btnAddCardId);
            this.groupStatus.Controls.Add(this.labelIdStatus);
            this.groupStatus.Controls.Add(this.textCardID);
            this.groupStatus.Controls.Add(this.labelCardID);
            this.groupStatus.Controls.Add(this.labelStatusCode);
            this.groupStatus.Controls.Add(this.statusBit0);
            this.groupStatus.Controls.Add(this.statusBit1);
            this.groupStatus.Controls.Add(this.statusBit2);
            this.groupStatus.Controls.Add(this.statusBit3);
            this.groupStatus.Controls.Add(this.statusBit4);
            this.groupStatus.Controls.Add(this.statusBit5);
            this.groupStatus.Controls.Add(this.statusBit6);
            this.groupStatus.Controls.Add(this.statusBit7);
            this.groupStatus.Controls.Add(this.labelStatusIcon);
            this.groupStatus.Controls.Add(this.labelStatusText);
            this.groupStatus.Font = new System.Drawing.Font("JetBrainsMono NF Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStatus.Location = new System.Drawing.Point(627, 30);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(298, 366);
            this.groupStatus.TabIndex = 6;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Status";
            // 
            // labelCardAccess
            // 
            this.labelCardAccess.Font = new System.Drawing.Font("Noto Sans TC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCardAccess.Location = new System.Drawing.Point(6, 288);
            this.labelCardAccess.Name = "labelCardAccess";
            this.labelCardAccess.Size = new System.Drawing.Size(286, 75);
            this.labelCardAccess.TabIndex = 19;
            this.labelCardAccess.Text = "----";
            this.labelCardAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCardStatusHint
            // 
            this.labelCardStatusHint.AutoSize = true;
            this.labelCardStatusHint.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardStatusHint.Location = new System.Drawing.Point(6, 140);
            this.labelCardStatusHint.Margin = new System.Windows.Forms.Padding(3, 14, 3, 4);
            this.labelCardStatusHint.Name = "labelCardStatusHint";
            this.labelCardStatusHint.Size = new System.Drawing.Size(100, 22);
            this.labelCardStatusHint.TabIndex = 18;
            this.labelCardStatusHint.Text = "卡片讀取失敗";
            // 
            // btnRemoveCardId
            // 
            this.btnRemoveCardId.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemoveCardId.Location = new System.Drawing.Point(155, 169);
            this.btnRemoveCardId.Name = "btnRemoveCardId";
            this.btnRemoveCardId.Size = new System.Drawing.Size(137, 38);
            this.btnRemoveCardId.TabIndex = 17;
            this.btnRemoveCardId.Text = "刪除";
            this.btnRemoveCardId.UseVisualStyleBackColor = true;
            this.btnRemoveCardId.Click += new System.EventHandler(this.btnRemoveCardId_Click);
            // 
            // btnAddCardId
            // 
            this.btnAddCardId.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddCardId.Location = new System.Drawing.Point(6, 169);
            this.btnAddCardId.Name = "btnAddCardId";
            this.btnAddCardId.Size = new System.Drawing.Size(143, 38);
            this.btnAddCardId.TabIndex = 16;
            this.btnAddCardId.Text = "新增";
            this.btnAddCardId.UseVisualStyleBackColor = true;
            this.btnAddCardId.Click += new System.EventHandler(this.btnAddCardId_Click);
            // 
            // labelIdStatus
            // 
            this.labelIdStatus.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelIdStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelIdStatus.Location = new System.Drawing.Point(241, 100);
            this.labelIdStatus.Name = "labelIdStatus";
            this.labelIdStatus.Size = new System.Drawing.Size(48, 38);
            this.labelIdStatus.TabIndex = 15;
            this.labelIdStatus.Text = "-";
            this.labelIdStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCardID
            // 
            this.textCardID.Font = new System.Drawing.Font("JetBrainsMono NF", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardID.Location = new System.Drawing.Point(6, 100);
            this.textCardID.MaxLength = 20;
            this.textCardID.Name = "textCardID";
            this.textCardID.ReadOnly = true;
            this.textCardID.Size = new System.Drawing.Size(229, 38);
            this.textCardID.TabIndex = 14;
            this.textCardID.TabStop = false;
            this.textCardID.Text = "None";
            // 
            // labelCardID
            // 
            this.labelCardID.AutoSize = true;
            this.labelCardID.Location = new System.Drawing.Point(6, 74);
            this.labelCardID.Margin = new System.Windows.Forms.Padding(3, 14, 3, 4);
            this.labelCardID.Name = "labelCardID";
            this.labelCardID.Size = new System.Drawing.Size(72, 19);
            this.labelCardID.TabIndex = 13;
            this.labelCardID.Text = "Card ID";
            // 
            // labelStatusCode
            // 
            this.labelStatusCode.AutoSize = true;
            this.labelStatusCode.Location = new System.Drawing.Point(6, 224);
            this.labelStatusCode.Margin = new System.Windows.Forms.Padding(3, 14, 3, 4);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(108, 19);
            this.labelStatusCode.TabIndex = 12;
            this.labelStatusCode.Text = "Status Code";
            // 
            // statusBit0
            // 
            this.statusBit0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit0.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit0.Location = new System.Drawing.Point(229, 250);
            this.statusBit0.MaxLength = 1;
            this.statusBit0.Name = "statusBit0";
            this.statusBit0.ReadOnly = true;
            this.statusBit0.Size = new System.Drawing.Size(25, 25);
            this.statusBit0.TabIndex = 10;
            this.statusBit0.TabStop = false;
            this.statusBit0.Text = "0";
            this.statusBit0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit1
            // 
            this.statusBit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit1.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit1.Location = new System.Drawing.Point(198, 250);
            this.statusBit1.MaxLength = 1;
            this.statusBit1.Name = "statusBit1";
            this.statusBit1.ReadOnly = true;
            this.statusBit1.Size = new System.Drawing.Size(25, 25);
            this.statusBit1.TabIndex = 9;
            this.statusBit1.TabStop = false;
            this.statusBit1.Text = "0";
            this.statusBit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit2
            // 
            this.statusBit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit2.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit2.Location = new System.Drawing.Point(167, 250);
            this.statusBit2.MaxLength = 1;
            this.statusBit2.Name = "statusBit2";
            this.statusBit2.ReadOnly = true;
            this.statusBit2.Size = new System.Drawing.Size(25, 25);
            this.statusBit2.TabIndex = 8;
            this.statusBit2.TabStop = false;
            this.statusBit2.Text = "0";
            this.statusBit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit3
            // 
            this.statusBit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit3.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit3.Location = new System.Drawing.Point(136, 250);
            this.statusBit3.MaxLength = 1;
            this.statusBit3.Name = "statusBit3";
            this.statusBit3.ReadOnly = true;
            this.statusBit3.Size = new System.Drawing.Size(25, 25);
            this.statusBit3.TabIndex = 7;
            this.statusBit3.TabStop = false;
            this.statusBit3.Text = "0";
            this.statusBit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit4
            // 
            this.statusBit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit4.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit4.Location = new System.Drawing.Point(105, 250);
            this.statusBit4.MaxLength = 1;
            this.statusBit4.Name = "statusBit4";
            this.statusBit4.ReadOnly = true;
            this.statusBit4.Size = new System.Drawing.Size(25, 25);
            this.statusBit4.TabIndex = 6;
            this.statusBit4.TabStop = false;
            this.statusBit4.Text = "0";
            this.statusBit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit5
            // 
            this.statusBit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit5.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit5.Location = new System.Drawing.Point(74, 250);
            this.statusBit5.MaxLength = 1;
            this.statusBit5.Name = "statusBit5";
            this.statusBit5.ReadOnly = true;
            this.statusBit5.Size = new System.Drawing.Size(25, 25);
            this.statusBit5.TabIndex = 5;
            this.statusBit5.TabStop = false;
            this.statusBit5.Text = "0";
            this.statusBit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit6
            // 
            this.statusBit6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit6.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit6.Location = new System.Drawing.Point(43, 250);
            this.statusBit6.MaxLength = 1;
            this.statusBit6.Name = "statusBit6";
            this.statusBit6.ReadOnly = true;
            this.statusBit6.Size = new System.Drawing.Size(25, 25);
            this.statusBit6.TabIndex = 4;
            this.statusBit6.TabStop = false;
            this.statusBit6.Text = "0";
            this.statusBit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit7
            // 
            this.statusBit7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit7.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit7.Location = new System.Drawing.Point(12, 250);
            this.statusBit7.MaxLength = 1;
            this.statusBit7.Name = "statusBit7";
            this.statusBit7.ReadOnly = true;
            this.statusBit7.Size = new System.Drawing.Size(25, 25);
            this.statusBit7.TabIndex = 3;
            this.statusBit7.TabStop = false;
            this.statusBit7.Text = "0";
            this.statusBit7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStatusIcon
            // 
            this.labelStatusIcon.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelStatusIcon.Location = new System.Drawing.Point(241, 24);
            this.labelStatusIcon.Margin = new System.Windows.Forms.Padding(3, 4, 12, 0);
            this.labelStatusIcon.Name = "labelStatusIcon";
            this.labelStatusIcon.Size = new System.Drawing.Size(48, 38);
            this.labelStatusIcon.TabIndex = 1;
            this.labelStatusIcon.Text = "●";
            this.labelStatusIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStatusText.Location = new System.Drawing.Point(6, 27);
            this.labelStatusText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(107, 33);
            this.labelStatusText.TabIndex = 0;
            this.labelStatusText.Text = "連線失敗";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.白名單ToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(937, 27);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menu";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 白名單ToolStripMenuItem1
            // 
            this.白名單ToolStripMenuItem1.Name = "白名單ToolStripMenuItem1";
            this.白名單ToolStripMenuItem1.Size = new System.Drawing.Size(68, 23);
            this.白名單ToolStripMenuItem1.Text = "白名單";
            this.白名單ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem白名單_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 592);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupConsole);
            this.Controls.Add(this.groupSetting);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Myfare 卡驗證系統";
            this.groupConsole.ResumeLayout(false);
            this.groupConsole.PerformLayout();
            this.groupSetting.ResumeLayout(false);
            this.groupSetting.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox textCommand;
        private System.IO.Ports.SerialPort serialPortRFID;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.ComboBox comboCOM;
        private System.Windows.Forms.GroupBox groupConsole;
        private System.Windows.Forms.GroupBox groupSetting;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Label labelStatusIcon;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox statusBit7;
        private System.Windows.Forms.TextBox statusBit6;
        private System.Windows.Forms.TextBox statusBit1;
        private System.Windows.Forms.TextBox statusBit2;
        private System.Windows.Forms.TextBox statusBit3;
        private System.Windows.Forms.TextBox statusBit4;
        private System.Windows.Forms.TextBox statusBit5;
        private System.Windows.Forms.TextBox statusBit0;
        private System.Windows.Forms.Label labelCardID;
        private System.Windows.Forms.Label labelStatusCode;
        private System.Windows.Forms.TextBox textCardID;
        private System.Windows.Forms.Label labelIdStatus;
        private System.Windows.Forms.Button btnRemoveCardId;
        private System.Windows.Forms.Button btnAddCardId;
        private System.Windows.Forms.Label labelWhiteList;
        private System.Windows.Forms.ComboBox comboCardId;
        private System.Windows.Forms.Label labelCardStatusHint;
        private System.Windows.Forms.Label labelCardAccess;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白名單ToolStripMenuItem1;
    }
}

