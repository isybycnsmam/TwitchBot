namespace TwitchBot {
	partial class Settings {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.IContainer components = null;

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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.saveBTN = new System.Windows.Forms.Button();
			this.reloadBTN = new System.Windows.Forms.Button();
			this.closeBTN = new System.Windows.Forms.Button();
			this.proxyTXT = new System.Windows.Forms.TextBox();
			this.proxyCHK = new System.Windows.Forms.CheckBox();
			this.onStartSteamLoginCHK = new System.Windows.Forms.CheckBox();
			this.autoLinkingDisableCHK = new System.Windows.Forms.CheckBox();
			this.autoDetectingDisableCHK = new System.Windows.Forms.CheckBox();
			this.reactionDealyToTXT = new System.Windows.Forms.TextBox();
			this.reactionDealyFromTXT = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.messageDelayFromTXT = new System.Windows.Forms.TextBox();
			this.messageDelayToTXT = new System.Windows.Forms.TextBox();
			this.saveDefalautsBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(12, 46);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(297, 246);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBox1.Size = new System.Drawing.Size(297, 28);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// saveBTN
			// 
			this.saveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.saveBTN.FlatAppearance.BorderSize = 0;
			this.saveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.saveBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.saveBTN.Location = new System.Drawing.Point(12, 296);
			this.saveBTN.Name = "saveBTN";
			this.saveBTN.Size = new System.Drawing.Size(142, 31);
			this.saveBTN.TabIndex = 2;
			this.saveBTN.Text = "save";
			this.saveBTN.UseVisualStyleBackColor = false;
			this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
			// 
			// reloadBTN
			// 
			this.reloadBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.reloadBTN.FlatAppearance.BorderSize = 0;
			this.reloadBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reloadBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.reloadBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.reloadBTN.Location = new System.Drawing.Point(160, 296);
			this.reloadBTN.Name = "reloadBTN";
			this.reloadBTN.Size = new System.Drawing.Size(149, 31);
			this.reloadBTN.TabIndex = 3;
			this.reloadBTN.Text = "reload";
			this.reloadBTN.UseVisualStyleBackColor = false;
			this.reloadBTN.Click += new System.EventHandler(this.reloadBTN_Click);
			// 
			// closeBTN
			// 
			this.closeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.closeBTN.FlatAppearance.BorderSize = 0;
			this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.closeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.closeBTN.Location = new System.Drawing.Point(315, 267);
			this.closeBTN.Name = "closeBTN";
			this.closeBTN.Size = new System.Drawing.Size(431, 61);
			this.closeBTN.TabIndex = 14;
			this.closeBTN.Text = "close";
			this.closeBTN.UseVisualStyleBackColor = false;
			this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
			// 
			// proxyTXT
			// 
			this.proxyTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.proxyTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.proxyTXT.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.proxyTXT.ForeColor = System.Drawing.Color.White;
			this.proxyTXT.Location = new System.Drawing.Point(416, 14);
			this.proxyTXT.Name = "proxyTXT";
			this.proxyTXT.Size = new System.Drawing.Size(322, 20);
			this.proxyTXT.TabIndex = 5;
			this.proxyTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// proxyCHK
			// 
			this.proxyCHK.AutoSize = true;
			this.proxyCHK.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.proxyCHK.Location = new System.Drawing.Point(337, 12);
			this.proxyCHK.Name = "proxyCHK";
			this.proxyCHK.Size = new System.Drawing.Size(73, 25);
			this.proxyCHK.TabIndex = 4;
			this.proxyCHK.Text = "Proxy:";
			this.proxyCHK.UseVisualStyleBackColor = true;
			// 
			// onStartSteamLoginCHK
			// 
			this.onStartSteamLoginCHK.AutoSize = true;
			this.onStartSteamLoginCHK.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.onStartSteamLoginCHK.Location = new System.Drawing.Point(337, 46);
			this.onStartSteamLoginCHK.Name = "onStartSteamLoginCHK";
			this.onStartSteamLoginCHK.Size = new System.Drawing.Size(208, 25);
			this.onStartSteamLoginCHK.TabIndex = 6;
			this.onStartSteamLoginCHK.Text = "On start login to steam";
			this.onStartSteamLoginCHK.UseVisualStyleBackColor = true;
			// 
			// autoLinkingDisableCHK
			// 
			this.autoLinkingDisableCHK.AutoSize = true;
			this.autoLinkingDisableCHK.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.autoLinkingDisableCHK.Location = new System.Drawing.Point(337, 77);
			this.autoLinkingDisableCHK.Name = "autoLinkingDisableCHK";
			this.autoLinkingDisableCHK.Size = new System.Drawing.Size(177, 25);
			this.autoLinkingDisableCHK.TabIndex = 7;
			this.autoLinkingDisableCHK.Text = "Auto linking disabe";
			this.autoLinkingDisableCHK.UseVisualStyleBackColor = true;
			// 
			// autoDetectingDisableCHK
			// 
			this.autoDetectingDisableCHK.AutoSize = true;
			this.autoDetectingDisableCHK.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.autoDetectingDisableCHK.Location = new System.Drawing.Point(337, 108);
			this.autoDetectingDisableCHK.Name = "autoDetectingDisableCHK";
			this.autoDetectingDisableCHK.Size = new System.Drawing.Size(208, 25);
			this.autoDetectingDisableCHK.TabIndex = 8;
			this.autoDetectingDisableCHK.Text = "Auto detecting disabe";
			this.autoDetectingDisableCHK.UseVisualStyleBackColor = true;
			// 
			// reactionDealyToTXT
			// 
			this.reactionDealyToTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.reactionDealyToTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.reactionDealyToTXT.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.reactionDealyToTXT.ForeColor = System.Drawing.Color.White;
			this.reactionDealyToTXT.Location = new System.Drawing.Point(606, 146);
			this.reactionDealyToTXT.Name = "reactionDealyToTXT";
			this.reactionDealyToTXT.Size = new System.Drawing.Size(133, 20);
			this.reactionDealyToTXT.TabIndex = 10;
			this.reactionDealyToTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// reactionDealyFromTXT
			// 
			this.reactionDealyFromTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.reactionDealyFromTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.reactionDealyFromTXT.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.reactionDealyFromTXT.ForeColor = System.Drawing.Color.White;
			this.reactionDealyFromTXT.Location = new System.Drawing.Point(466, 146);
			this.reactionDealyFromTXT.Name = "reactionDealyFromTXT";
			this.reactionDealyFromTXT.Size = new System.Drawing.Size(139, 20);
			this.reactionDealyFromTXT.TabIndex = 9;
			this.reactionDealyFromTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label1.Location = new System.Drawing.Point(333, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "Reaction delay";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label2.Location = new System.Drawing.Point(333, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 21);
			this.label2.TabIndex = 16;
			this.label2.Text = "Messages delay";
			// 
			// messageDelayFromTXT
			// 
			this.messageDelayFromTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.messageDelayFromTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.messageDelayFromTXT.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.messageDelayFromTXT.ForeColor = System.Drawing.Color.White;
			this.messageDelayFromTXT.Location = new System.Drawing.Point(466, 179);
			this.messageDelayFromTXT.Name = "messageDelayFromTXT";
			this.messageDelayFromTXT.Size = new System.Drawing.Size(139, 20);
			this.messageDelayFromTXT.TabIndex = 11;
			this.messageDelayFromTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// messageDelayToTXT
			// 
			this.messageDelayToTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.messageDelayToTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.messageDelayToTXT.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.messageDelayToTXT.ForeColor = System.Drawing.Color.White;
			this.messageDelayToTXT.Location = new System.Drawing.Point(606, 179);
			this.messageDelayToTXT.Name = "messageDelayToTXT";
			this.messageDelayToTXT.Size = new System.Drawing.Size(133, 20);
			this.messageDelayToTXT.TabIndex = 12;
			this.messageDelayToTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// saveDefalautsBTN
			// 
			this.saveDefalautsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.saveDefalautsBTN.FlatAppearance.BorderSize = 0;
			this.saveDefalautsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveDefalautsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.saveDefalautsBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.saveDefalautsBTN.Location = new System.Drawing.Point(315, 218);
			this.saveDefalautsBTN.Name = "saveDefalautsBTN";
			this.saveDefalautsBTN.Size = new System.Drawing.Size(431, 43);
			this.saveDefalautsBTN.TabIndex = 13;
			this.saveDefalautsBTN.Text = "save defalauts";
			this.saveDefalautsBTN.UseVisualStyleBackColor = false;
			this.saveDefalautsBTN.Click += new System.EventHandler(this.saveDefalautsBTN_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(750, 332);
			this.ControlBox = false;
			this.Controls.Add(this.saveDefalautsBTN);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.messageDelayFromTXT);
			this.Controls.Add(this.messageDelayToTXT);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reactionDealyFromTXT);
			this.Controls.Add(this.reactionDealyToTXT);
			this.Controls.Add(this.autoDetectingDisableCHK);
			this.Controls.Add(this.autoLinkingDisableCHK);
			this.Controls.Add(this.onStartSteamLoginCHK);
			this.Controls.Add(this.proxyTXT);
			this.Controls.Add(this.proxyCHK);
			this.Controls.Add(this.closeBTN);
			this.Controls.Add(this.reloadBTN);
			this.Controls.Add(this.saveBTN);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.ForeColor = System.Drawing.Color.White;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Settings";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.ComboBox comboBox1;
		public System.Windows.Forms.Button saveBTN;
		public System.Windows.Forms.Button reloadBTN;
		public System.Windows.Forms.Button closeBTN;
		public System.Windows.Forms.TextBox proxyTXT;
		public System.Windows.Forms.CheckBox proxyCHK;
		public System.Windows.Forms.CheckBox onStartSteamLoginCHK;
		public System.Windows.Forms.CheckBox autoLinkingDisableCHK;
		public System.Windows.Forms.CheckBox autoDetectingDisableCHK;
		public System.Windows.Forms.TextBox reactionDealyToTXT;
		public System.Windows.Forms.TextBox reactionDealyFromTXT;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox messageDelayFromTXT;
		public System.Windows.Forms.TextBox messageDelayToTXT;
		public System.Windows.Forms.Button saveDefalautsBTN;
	}
}