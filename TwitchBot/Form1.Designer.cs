namespace TwitchBot {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.scrollEnabled = new System.Windows.Forms.CheckBox();
			this.editLabelCHK = new System.Windows.Forms.CheckBox();
			this.selectetRowsCountLBL = new System.Windows.Forms.Label();
			this.label100 = new System.Windows.Forms.Label();
			this.selectAllBTN = new System.Windows.Forms.Button();
			this.loadApiFollowsBTN = new System.Windows.Forms.Button();
			this.sortBTN = new System.Windows.Forms.Button();
			this.minimizeBTN = new System.Windows.Forms.Button();
			this.closeBTN = new System.Windows.Forms.Button();
			this.loadChatApiBTN = new System.Windows.Forms.Button();
			this.channelNameTXT = new System.Windows.Forms.TextBox();
			this.followDelayToTXT = new System.Windows.Forms.TextBox();
			this.followDelayFromTXT = new System.Windows.Forms.TextBox();
			this.followBTN = new System.Windows.Forms.Button();
			this.checkBTN = new System.Windows.Forms.Button();
			this.unFollowBTN = new System.Windows.Forms.Button();
			this.joinChannelBTN = new System.Windows.Forms.Button();
			this.chatDelayFromTXT = new System.Windows.Forms.TextBox();
			this.chatDelayToTXT = new System.Windows.Forms.TextBox();
			this.chatMessageTXT = new System.Windows.Forms.TextBox();
			this.sendMessageBTN = new System.Windows.Forms.Button();
			this.switchChatMessageBTN = new System.Windows.Forms.Button();
			this.searchBoxTXT = new System.Windows.Forms.TextBox();
			this.searchBoxBTN = new System.Windows.Forms.Button();
			this.linkToSteamBTN = new System.Windows.Forms.Button();
			this.autoDetectingWinnetCHK = new System.Windows.Forms.CheckBox();
			this.autoLinkingCHK = new System.Windows.Forms.CheckBox();
			this.spyChatCHK = new System.Windows.Forms.CheckBox();
			this.autoRespondingCHK = new System.Windows.Forms.CheckBox();
			this.getCookiesBTN = new System.Windows.Forms.Button();
			this.settingsBTN = new System.Windows.Forms.Button();
			this.clearSendBTN = new System.Windows.Forms.Button();
			this.clearLogBTN = new System.Windows.Forms.Button();
			this.clearFollowBTN = new System.Windows.Forms.Button();
			this.switchSteamBTN = new System.Windows.Forms.Button();
			this.cookieStatusLAB = new System.Windows.Forms.Label();
			this.resetBTN = new System.Windows.Forms.Button();
			this.logBoxTXT = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ColumnHeadersVisible = false;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.White;
			this.dataGridView1.Location = new System.Drawing.Point(0, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(537, 594);
			this.dataGridView1.TabIndex = 91;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// Column0
			// 
			this.Column0.HeaderText = "Id";
			this.Column0.Name = "Column0";
			this.Column0.ReadOnly = true;
			this.Column0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column0.Width = 50;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "User Name";
			this.Column1.Name = "Column1";
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 160;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "API";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.Width = 60;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "     Chanel";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "     Follow";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Send";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 50;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Match";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
			this.panel1.Controls.Add(this.scrollEnabled);
			this.panel1.Controls.Add(this.editLabelCHK);
			this.panel1.Controls.Add(this.selectetRowsCountLBL);
			this.panel1.Controls.Add(this.label100);
			this.panel1.Controls.Add(this.selectAllBTN);
			this.panel1.Controls.Add(this.loadApiFollowsBTN);
			this.panel1.Controls.Add(this.sortBTN);
			this.panel1.Controls.Add(this.minimizeBTN);
			this.panel1.Controls.Add(this.closeBTN);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1427, 22);
			this.panel1.TabIndex = 92;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// scrollEnabled
			// 
			this.scrollEnabled.AutoSize = true;
			this.scrollEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.scrollEnabled.ForeColor = System.Drawing.Color.Aqua;
			this.scrollEnabled.Location = new System.Drawing.Point(1323, 6);
			this.scrollEnabled.Name = "scrollEnabled";
			this.scrollEnabled.Size = new System.Drawing.Size(12, 11);
			this.scrollEnabled.TabIndex = 125;
			this.scrollEnabled.UseVisualStyleBackColor = true;
			this.scrollEnabled.CheckedChanged += new System.EventHandler(this.scrollEnabled_CheckedChanged);
			// 
			// editLabelCHK
			// 
			this.editLabelCHK.AutoSize = true;
			this.editLabelCHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editLabelCHK.ForeColor = System.Drawing.Color.Aqua;
			this.editLabelCHK.Location = new System.Drawing.Point(1341, 6);
			this.editLabelCHK.Name = "editLabelCHK";
			this.editLabelCHK.Size = new System.Drawing.Size(12, 11);
			this.editLabelCHK.TabIndex = 124;
			this.editLabelCHK.UseVisualStyleBackColor = true;
			// 
			// selectetRowsCountLBL
			// 
			this.selectetRowsCountLBL.AutoSize = true;
			this.selectetRowsCountLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.selectetRowsCountLBL.Location = new System.Drawing.Point(252, 5);
			this.selectetRowsCountLBL.Name = "selectetRowsCountLBL";
			this.selectetRowsCountLBL.Size = new System.Drawing.Size(13, 13);
			this.selectetRowsCountLBL.TabIndex = 99;
			this.selectetRowsCountLBL.Text = "0";
			// 
			// label100
			// 
			this.label100.AutoSize = true;
			this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label100.Location = new System.Drawing.Point(202, 5);
			this.label100.Name = "label100";
			this.label100.Size = new System.Drawing.Size(55, 13);
			this.label100.TabIndex = 98;
			this.label100.Text = "Selected: ";
			// 
			// selectAllBTN
			// 
			this.selectAllBTN.FlatAppearance.BorderSize = 0;
			this.selectAllBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.selectAllBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.selectAllBTN.Location = new System.Drawing.Point(55, 0);
			this.selectAllBTN.Name = "selectAllBTN";
			this.selectAllBTN.Size = new System.Drawing.Size(66, 22);
			this.selectAllBTN.TabIndex = 97;
			this.selectAllBTN.Text = "Select all";
			this.selectAllBTN.UseVisualStyleBackColor = true;
			this.selectAllBTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectAllBTN_MouseUp);
			// 
			// loadApiFollowsBTN
			// 
			this.loadApiFollowsBTN.FlatAppearance.BorderSize = 0;
			this.loadApiFollowsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadApiFollowsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loadApiFollowsBTN.Location = new System.Drawing.Point(375, 0);
			this.loadApiFollowsBTN.Name = "loadApiFollowsBTN";
			this.loadApiFollowsBTN.Size = new System.Drawing.Size(79, 22);
			this.loadApiFollowsBTN.TabIndex = 96;
			this.loadApiFollowsBTN.Text = "Load API";
			this.loadApiFollowsBTN.UseVisualStyleBackColor = true;
			this.loadApiFollowsBTN.Click += new System.EventHandler(this.loadApiFollowsBTN_Click);
			// 
			// sortBTN
			// 
			this.sortBTN.FlatAppearance.BorderSize = 0;
			this.sortBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sortBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sortBTN.Location = new System.Drawing.Point(0, 0);
			this.sortBTN.Name = "sortBTN";
			this.sortBTN.Size = new System.Drawing.Size(50, 22);
			this.sortBTN.TabIndex = 95;
			this.sortBTN.Text = "Sort";
			this.sortBTN.UseVisualStyleBackColor = true;
			this.sortBTN.Click += new System.EventHandler(this.sortBTN_Click);
			// 
			// minimizeBTN
			// 
			this.minimizeBTN.BackColor = System.Drawing.Color.Silver;
			this.minimizeBTN.FlatAppearance.BorderSize = 0;
			this.minimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.minimizeBTN.ForeColor = System.Drawing.Color.Black;
			this.minimizeBTN.Location = new System.Drawing.Point(1367, 0);
			this.minimizeBTN.Name = "minimizeBTN";
			this.minimizeBTN.Size = new System.Drawing.Size(30, 22);
			this.minimizeBTN.TabIndex = 94;
			this.minimizeBTN.Text = "_";
			this.minimizeBTN.UseVisualStyleBackColor = false;
			this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
			// 
			// closeBTN
			// 
			this.closeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.closeBTN.FlatAppearance.BorderSize = 0;
			this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.closeBTN.ForeColor = System.Drawing.Color.Black;
			this.closeBTN.Location = new System.Drawing.Point(1397, 0);
			this.closeBTN.Name = "closeBTN";
			this.closeBTN.Size = new System.Drawing.Size(30, 22);
			this.closeBTN.TabIndex = 93;
			this.closeBTN.UseVisualStyleBackColor = false;
			this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
			// 
			// loadChatApiBTN
			// 
			this.loadChatApiBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.loadChatApiBTN.FlatAppearance.BorderSize = 0;
			this.loadChatApiBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadChatApiBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.loadChatApiBTN.ForeColor = System.Drawing.Color.White;
			this.loadChatApiBTN.Location = new System.Drawing.Point(543, 31);
			this.loadChatApiBTN.Name = "loadChatApiBTN";
			this.loadChatApiBTN.Size = new System.Drawing.Size(167, 43);
			this.loadChatApiBTN.TabIndex = 94;
			this.loadChatApiBTN.Text = "Load Chat API";
			this.loadChatApiBTN.UseVisualStyleBackColor = false;
			this.loadChatApiBTN.Click += new System.EventHandler(this.loadChatApiBTN_Click);
			// 
			// channelNameTXT
			// 
			this.channelNameTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.channelNameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.channelNameTXT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.channelNameTXT.ForeColor = System.Drawing.Color.White;
			this.channelNameTXT.Location = new System.Drawing.Point(543, 78);
			this.channelNameTXT.Name = "channelNameTXT";
			this.channelNameTXT.Size = new System.Drawing.Size(231, 24);
			this.channelNameTXT.TabIndex = 96;
			this.channelNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// followDelayToTXT
			// 
			this.followDelayToTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.followDelayToTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.followDelayToTXT.Font = new System.Drawing.Font("Calibri", 14.25F);
			this.followDelayToTXT.ForeColor = System.Drawing.Color.White;
			this.followDelayToTXT.Location = new System.Drawing.Point(844, 78);
			this.followDelayToTXT.Name = "followDelayToTXT";
			this.followDelayToTXT.Size = new System.Drawing.Size(60, 24);
			this.followDelayToTXT.TabIndex = 98;
			this.followDelayToTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// followDelayFromTXT
			// 
			this.followDelayFromTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.followDelayFromTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.followDelayFromTXT.Font = new System.Drawing.Font("Calibri", 14.25F);
			this.followDelayFromTXT.ForeColor = System.Drawing.Color.White;
			this.followDelayFromTXT.Location = new System.Drawing.Point(775, 78);
			this.followDelayFromTXT.Name = "followDelayFromTXT";
			this.followDelayFromTXT.Size = new System.Drawing.Size(68, 24);
			this.followDelayFromTXT.TabIndex = 97;
			this.followDelayFromTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// followBTN
			// 
			this.followBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.followBTN.FlatAppearance.BorderSize = 0;
			this.followBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.followBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.followBTN.ForeColor = System.Drawing.Color.White;
			this.followBTN.Location = new System.Drawing.Point(543, 106);
			this.followBTN.Name = "followBTN";
			this.followBTN.Size = new System.Drawing.Size(117, 43);
			this.followBTN.TabIndex = 99;
			this.followBTN.Text = "Follow";
			this.followBTN.UseVisualStyleBackColor = false;
			this.followBTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.followBTN_MouseUp);
			// 
			// checkBTN
			// 
			this.checkBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.checkBTN.FlatAppearance.BorderSize = 0;
			this.checkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBTN.ForeColor = System.Drawing.Color.White;
			this.checkBTN.Location = new System.Drawing.Point(775, 106);
			this.checkBTN.Name = "checkBTN";
			this.checkBTN.Size = new System.Drawing.Size(129, 43);
			this.checkBTN.TabIndex = 101;
			this.checkBTN.Text = "Check";
			this.checkBTN.UseVisualStyleBackColor = false;
			this.checkBTN.Click += new System.EventHandler(this.checkBTN_Click);
			// 
			// unFollowBTN
			// 
			this.unFollowBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.unFollowBTN.FlatAppearance.BorderSize = 0;
			this.unFollowBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.unFollowBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.unFollowBTN.ForeColor = System.Drawing.Color.White;
			this.unFollowBTN.Location = new System.Drawing.Point(661, 106);
			this.unFollowBTN.Name = "unFollowBTN";
			this.unFollowBTN.Size = new System.Drawing.Size(113, 43);
			this.unFollowBTN.TabIndex = 100;
			this.unFollowBTN.Text = "UnFollow";
			this.unFollowBTN.UseVisualStyleBackColor = false;
			this.unFollowBTN.Click += new System.EventHandler(this.unFollowBTN_Click);
			// 
			// joinChannelBTN
			// 
			this.joinChannelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.joinChannelBTN.FlatAppearance.BorderSize = 0;
			this.joinChannelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.joinChannelBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.joinChannelBTN.ForeColor = System.Drawing.Color.White;
			this.joinChannelBTN.Location = new System.Drawing.Point(711, 31);
			this.joinChannelBTN.Name = "joinChannelBTN";
			this.joinChannelBTN.Size = new System.Drawing.Size(193, 43);
			this.joinChannelBTN.TabIndex = 95;
			this.joinChannelBTN.Text = "Join To Channel";
			this.joinChannelBTN.UseVisualStyleBackColor = false;
			this.joinChannelBTN.Click += new System.EventHandler(this.joinChannelBTN_Click);
			// 
			// chatDelayFromTXT
			// 
			this.chatDelayFromTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.chatDelayFromTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.chatDelayFromTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.chatDelayFromTXT.ForeColor = System.Drawing.Color.White;
			this.chatDelayFromTXT.Location = new System.Drawing.Point(775, 177);
			this.chatDelayFromTXT.Name = "chatDelayFromTXT";
			this.chatDelayFromTXT.Size = new System.Drawing.Size(68, 24);
			this.chatDelayFromTXT.TabIndex = 103;
			this.chatDelayFromTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// chatDelayToTXT
			// 
			this.chatDelayToTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.chatDelayToTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.chatDelayToTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.chatDelayToTXT.ForeColor = System.Drawing.Color.White;
			this.chatDelayToTXT.Location = new System.Drawing.Point(844, 177);
			this.chatDelayToTXT.Name = "chatDelayToTXT";
			this.chatDelayToTXT.Size = new System.Drawing.Size(60, 24);
			this.chatDelayToTXT.TabIndex = 104;
			this.chatDelayToTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// chatMessageTXT
			// 
			this.chatMessageTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.chatMessageTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.chatMessageTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chatMessageTXT.ForeColor = System.Drawing.Color.White;
			this.chatMessageTXT.Location = new System.Drawing.Point(543, 177);
			this.chatMessageTXT.Name = "chatMessageTXT";
			this.chatMessageTXT.Size = new System.Drawing.Size(231, 24);
			this.chatMessageTXT.TabIndex = 102;
			this.chatMessageTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chatMessageTXT.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chatMessageTXT_PreviewKeyDown);
			// 
			// sendMessageBTN
			// 
			this.sendMessageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.sendMessageBTN.FlatAppearance.BorderSize = 0;
			this.sendMessageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sendMessageBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sendMessageBTN.ForeColor = System.Drawing.Color.White;
			this.sendMessageBTN.Location = new System.Drawing.Point(543, 205);
			this.sendMessageBTN.Name = "sendMessageBTN";
			this.sendMessageBTN.Size = new System.Drawing.Size(300, 43);
			this.sendMessageBTN.TabIndex = 105;
			this.sendMessageBTN.Text = "Send Message";
			this.sendMessageBTN.UseVisualStyleBackColor = false;
			this.sendMessageBTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sendMessageBTN_MouseUp);
			// 
			// switchChatMessageBTN
			// 
			this.switchChatMessageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.switchChatMessageBTN.FlatAppearance.BorderSize = 0;
			this.switchChatMessageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.switchChatMessageBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.switchChatMessageBTN.ForeColor = System.Drawing.Color.White;
			this.switchChatMessageBTN.Location = new System.Drawing.Point(844, 205);
			this.switchChatMessageBTN.Name = "switchChatMessageBTN";
			this.switchChatMessageBTN.Size = new System.Drawing.Size(60, 43);
			this.switchChatMessageBTN.TabIndex = 106;
			this.switchChatMessageBTN.Text = "0";
			this.switchChatMessageBTN.UseVisualStyleBackColor = false;
			this.switchChatMessageBTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.switchChatMessageBTN_MouseUp);
			// 
			// searchBoxTXT
			// 
			this.searchBoxTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.searchBoxTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchBoxTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.searchBoxTXT.ForeColor = System.Drawing.Color.White;
			this.searchBoxTXT.Location = new System.Drawing.Point(543, 278);
			this.searchBoxTXT.Name = "searchBoxTXT";
			this.searchBoxTXT.Size = new System.Drawing.Size(361, 24);
			this.searchBoxTXT.TabIndex = 107;
			this.searchBoxTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// searchBoxBTN
			// 
			this.searchBoxBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.searchBoxBTN.FlatAppearance.BorderSize = 0;
			this.searchBoxBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchBoxBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.searchBoxBTN.ForeColor = System.Drawing.Color.White;
			this.searchBoxBTN.Location = new System.Drawing.Point(543, 306);
			this.searchBoxBTN.Name = "searchBoxBTN";
			this.searchBoxBTN.Size = new System.Drawing.Size(361, 43);
			this.searchBoxBTN.TabIndex = 108;
			this.searchBoxBTN.Text = "Search";
			this.searchBoxBTN.UseVisualStyleBackColor = false;
			this.searchBoxBTN.Click += new System.EventHandler(this.searchBoxBTN_Click);
			// 
			// linkToSteamBTN
			// 
			this.linkToSteamBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.linkToSteamBTN.FlatAppearance.BorderSize = 0;
			this.linkToSteamBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.linkToSteamBTN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.linkToSteamBTN.ForeColor = System.Drawing.Color.White;
			this.linkToSteamBTN.Location = new System.Drawing.Point(543, 379);
			this.linkToSteamBTN.Name = "linkToSteamBTN";
			this.linkToSteamBTN.Size = new System.Drawing.Size(300, 43);
			this.linkToSteamBTN.TabIndex = 109;
			this.linkToSteamBTN.Text = "Link to NULL";
			this.linkToSteamBTN.UseVisualStyleBackColor = false;
			this.linkToSteamBTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.linkToSteamBTN_MouseUp);
			// 
			// autoDetectingWinnetCHK
			// 
			this.autoDetectingWinnetCHK.AutoSize = true;
			this.autoDetectingWinnetCHK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.autoDetectingWinnetCHK.ForeColor = System.Drawing.Color.White;
			this.autoDetectingWinnetCHK.Location = new System.Drawing.Point(543, 449);
			this.autoDetectingWinnetCHK.Name = "autoDetectingWinnetCHK";
			this.autoDetectingWinnetCHK.Size = new System.Drawing.Size(208, 25);
			this.autoDetectingWinnetCHK.TabIndex = 111;
			this.autoDetectingWinnetCHK.Text = "Auto detecting winner";
			this.autoDetectingWinnetCHK.UseVisualStyleBackColor = true;
			// 
			// autoLinkingCHK
			// 
			this.autoLinkingCHK.AutoSize = true;
			this.autoLinkingCHK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.autoLinkingCHK.ForeColor = System.Drawing.Color.White;
			this.autoLinkingCHK.Location = new System.Drawing.Point(543, 480);
			this.autoLinkingCHK.Name = "autoLinkingCHK";
			this.autoLinkingCHK.Size = new System.Drawing.Size(121, 25);
			this.autoLinkingCHK.TabIndex = 113;
			this.autoLinkingCHK.Text = "Auto linking";
			this.autoLinkingCHK.UseVisualStyleBackColor = true;
			// 
			// spyChatCHK
			// 
			this.spyChatCHK.AutoSize = true;
			this.spyChatCHK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.spyChatCHK.ForeColor = System.Drawing.Color.White;
			this.spyChatCHK.Location = new System.Drawing.Point(806, 449);
			this.spyChatCHK.Name = "spyChatCHK";
			this.spyChatCHK.Size = new System.Drawing.Size(98, 25);
			this.spyChatCHK.TabIndex = 112;
			this.spyChatCHK.Text = "Spy chat";
			this.spyChatCHK.UseVisualStyleBackColor = true;
			this.spyChatCHK.CheckedChanged += new System.EventHandler(this.spyChatCHK_CheckedChanged);
			// 
			// autoRespondingCHK
			// 
			this.autoRespondingCHK.AutoSize = true;
			this.autoRespondingCHK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.autoRespondingCHK.ForeColor = System.Drawing.Color.White;
			this.autoRespondingCHK.Location = new System.Drawing.Point(744, 480);
			this.autoRespondingCHK.Name = "autoRespondingCHK";
			this.autoRespondingCHK.Size = new System.Drawing.Size(160, 25);
			this.autoRespondingCHK.TabIndex = 114;
			this.autoRespondingCHK.Text = "Auto responding";
			this.autoRespondingCHK.UseVisualStyleBackColor = true;
			this.autoRespondingCHK.CheckedChanged += new System.EventHandler(this.autoRespondingCHK_CheckedChanged);
			// 
			// getCookiesBTN
			// 
			this.getCookiesBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.getCookiesBTN.FlatAppearance.BorderSize = 0;
			this.getCookiesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getCookiesBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.getCookiesBTN.ForeColor = System.Drawing.Color.White;
			this.getCookiesBTN.Location = new System.Drawing.Point(543, 568);
			this.getCookiesBTN.Name = "getCookiesBTN";
			this.getCookiesBTN.Size = new System.Drawing.Size(180, 43);
			this.getCookiesBTN.TabIndex = 119;
			this.getCookiesBTN.Text = "Get Cookies";
			this.getCookiesBTN.UseVisualStyleBackColor = false;
			this.getCookiesBTN.Click += new System.EventHandler(this.getCookiesBTN_Click);
			// 
			// settingsBTN
			// 
			this.settingsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.settingsBTN.Enabled = false;
			this.settingsBTN.FlatAppearance.BorderSize = 0;
			this.settingsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingsBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.settingsBTN.ForeColor = System.Drawing.Color.White;
			this.settingsBTN.Location = new System.Drawing.Point(724, 568);
			this.settingsBTN.Name = "settingsBTN";
			this.settingsBTN.Size = new System.Drawing.Size(180, 43);
			this.settingsBTN.TabIndex = 120;
			this.settingsBTN.Text = "Settings";
			this.settingsBTN.UseVisualStyleBackColor = false;
			this.settingsBTN.Click += new System.EventHandler(this.settingsBTN_Click);
			// 
			// clearSendBTN
			// 
			this.clearSendBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.clearSendBTN.FlatAppearance.BorderSize = 0;
			this.clearSendBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearSendBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.clearSendBTN.ForeColor = System.Drawing.Color.White;
			this.clearSendBTN.Location = new System.Drawing.Point(543, 533);
			this.clearSendBTN.Name = "clearSendBTN";
			this.clearSendBTN.Size = new System.Drawing.Size(103, 31);
			this.clearSendBTN.TabIndex = 115;
			this.clearSendBTN.Text = "Clear Send";
			this.clearSendBTN.UseVisualStyleBackColor = false;
			this.clearSendBTN.Click += new System.EventHandler(this.clearSendBTN_Click);
			// 
			// clearLogBTN
			// 
			this.clearLogBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.clearLogBTN.FlatAppearance.BorderSize = 0;
			this.clearLogBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearLogBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.clearLogBTN.ForeColor = System.Drawing.Color.White;
			this.clearLogBTN.Location = new System.Drawing.Point(760, 533);
			this.clearLogBTN.Name = "clearLogBTN";
			this.clearLogBTN.Size = new System.Drawing.Size(103, 31);
			this.clearLogBTN.TabIndex = 117;
			this.clearLogBTN.Text = "Clear Log";
			this.clearLogBTN.UseVisualStyleBackColor = false;
			this.clearLogBTN.Click += new System.EventHandler(this.clearLogBTN_Click);
			// 
			// clearFollowBTN
			// 
			this.clearFollowBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.clearFollowBTN.FlatAppearance.BorderSize = 0;
			this.clearFollowBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearFollowBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.clearFollowBTN.ForeColor = System.Drawing.Color.White;
			this.clearFollowBTN.Location = new System.Drawing.Point(647, 533);
			this.clearFollowBTN.Name = "clearFollowBTN";
			this.clearFollowBTN.Size = new System.Drawing.Size(112, 31);
			this.clearFollowBTN.TabIndex = 116;
			this.clearFollowBTN.Text = "Clear Follow";
			this.clearFollowBTN.UseVisualStyleBackColor = false;
			this.clearFollowBTN.Click += new System.EventHandler(this.clearFollowBTN_Click);
			// 
			// switchSteamBTN
			// 
			this.switchSteamBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.switchSteamBTN.FlatAppearance.BorderSize = 0;
			this.switchSteamBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.switchSteamBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.switchSteamBTN.ForeColor = System.Drawing.Color.White;
			this.switchSteamBTN.Location = new System.Drawing.Point(844, 379);
			this.switchSteamBTN.Name = "switchSteamBTN";
			this.switchSteamBTN.Size = new System.Drawing.Size(60, 43);
			this.switchSteamBTN.TabIndex = 110;
			this.switchSteamBTN.Text = "0";
			this.switchSteamBTN.UseVisualStyleBackColor = false;
			this.switchSteamBTN.Click += new System.EventHandler(this.switchSteamBTN_Click);
			// 
			// cookieStatusLAB
			// 
			this.cookieStatusLAB.AutoSize = true;
			this.cookieStatusLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cookieStatusLAB.Location = new System.Drawing.Point(694, 514);
			this.cookieStatusLAB.Name = "cookieStatusLAB";
			this.cookieStatusLAB.Size = new System.Drawing.Size(42, 16);
			this.cookieStatusLAB.TabIndex = 121;
			this.cookieStatusLAB.Text = "NULL";
			// 
			// resetBTN
			// 
			this.resetBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.resetBTN.FlatAppearance.BorderSize = 0;
			this.resetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.resetBTN.ForeColor = System.Drawing.Color.White;
			this.resetBTN.Location = new System.Drawing.Point(864, 533);
			this.resetBTN.Name = "resetBTN";
			this.resetBTN.Size = new System.Drawing.Size(40, 31);
			this.resetBTN.TabIndex = 118;
			this.resetBTN.Text = "R";
			this.resetBTN.UseVisualStyleBackColor = false;
			this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
			// 
			// logBoxTXT
			// 
			this.logBoxTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.logBoxTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.logBoxTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.logBoxTXT.ForeColor = System.Drawing.Color.White;
			this.logBoxTXT.Location = new System.Drawing.Point(910, 30);
			this.logBoxTXT.Name = "logBoxTXT";
			this.logBoxTXT.ReadOnly = true;
			this.logBoxTXT.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.logBoxTXT.Size = new System.Drawing.Size(517, 571);
			this.logBoxTXT.TabIndex = 123;
			this.logBoxTXT.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1427, 614);
			this.Controls.Add(this.logBoxTXT);
			this.Controls.Add(this.resetBTN);
			this.Controls.Add(this.cookieStatusLAB);
			this.Controls.Add(this.switchSteamBTN);
			this.Controls.Add(this.clearFollowBTN);
			this.Controls.Add(this.clearLogBTN);
			this.Controls.Add(this.clearSendBTN);
			this.Controls.Add(this.settingsBTN);
			this.Controls.Add(this.getCookiesBTN);
			this.Controls.Add(this.autoRespondingCHK);
			this.Controls.Add(this.spyChatCHK);
			this.Controls.Add(this.autoLinkingCHK);
			this.Controls.Add(this.autoDetectingWinnetCHK);
			this.Controls.Add(this.linkToSteamBTN);
			this.Controls.Add(this.searchBoxBTN);
			this.Controls.Add(this.searchBoxTXT);
			this.Controls.Add(this.switchChatMessageBTN);
			this.Controls.Add(this.sendMessageBTN);
			this.Controls.Add(this.chatDelayFromTXT);
			this.Controls.Add(this.chatDelayToTXT);
			this.Controls.Add(this.chatMessageTXT);
			this.Controls.Add(this.joinChannelBTN);
			this.Controls.Add(this.unFollowBTN);
			this.Controls.Add(this.checkBTN);
			this.Controls.Add(this.followBTN);
			this.Controls.Add(this.followDelayFromTXT);
			this.Controls.Add(this.followDelayToTXT);
			this.Controls.Add(this.channelNameTXT);
			this.Controls.Add(this.loadChatApiBTN);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(0, 10);
			this.Name = "Form1";
			this.Text = "TwitchBot by isybycnsmam";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Button closeBTN;
		public System.Windows.Forms.Button minimizeBTN;
		public System.Windows.Forms.Button loadChatApiBTN;
		public System.Windows.Forms.TextBox channelNameTXT;
		public System.Windows.Forms.TextBox followDelayToTXT;
		public System.Windows.Forms.TextBox followDelayFromTXT;
		public System.Windows.Forms.Button followBTN;
		public System.Windows.Forms.Button checkBTN;
		public System.Windows.Forms.Button unFollowBTN;
		public System.Windows.Forms.Button joinChannelBTN;
		public System.Windows.Forms.TextBox chatDelayFromTXT;
		public System.Windows.Forms.TextBox chatDelayToTXT;
		public System.Windows.Forms.TextBox chatMessageTXT;
		public System.Windows.Forms.Button sendMessageBTN;
		public System.Windows.Forms.Button switchChatMessageBTN;
		public System.Windows.Forms.TextBox searchBoxTXT;
		public System.Windows.Forms.Button searchBoxBTN;
		public System.Windows.Forms.Button linkToSteamBTN;
		public System.Windows.Forms.CheckBox autoDetectingWinnetCHK;
		public System.Windows.Forms.CheckBox autoLinkingCHK;
		public System.Windows.Forms.CheckBox spyChatCHK;
		public System.Windows.Forms.CheckBox autoRespondingCHK;
		public System.Windows.Forms.Button getCookiesBTN;
		public System.Windows.Forms.Button settingsBTN;
		public System.Windows.Forms.Button clearSendBTN;
		public System.Windows.Forms.Button clearLogBTN;
		public System.Windows.Forms.Button clearFollowBTN;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column0;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		public System.Windows.Forms.Button sortBTN;
		public System.Windows.Forms.Button loadApiFollowsBTN;
		public System.Windows.Forms.Button switchSteamBTN;
		public System.Windows.Forms.Label cookieStatusLAB;
		public System.Windows.Forms.Button resetBTN;
		private System.Windows.Forms.RichTextBox logBoxTXT;
		public System.Windows.Forms.Button selectAllBTN;
		private System.Windows.Forms.Label label100;
		private System.Windows.Forms.Label selectetRowsCountLBL;
		private System.Windows.Forms.CheckBox editLabelCHK;
		private System.Windows.Forms.CheckBox scrollEnabled;
	}
}

