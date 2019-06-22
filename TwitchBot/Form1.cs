using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;
using Newtonsoft.Json;

namespace TwitchBot {
	public partial class Form1 : Form {

		#region var

		public List<TwitchAccount> twitchAccounts;
		public List<SteamAccount> steamAccounts;
		public Thread joiningThread;
		public Thread spyChat;
		public Thread autoResponding;
		public TwitchAccount spyBotAccount;
		int joiningPublicTime = 14400;
		public List<int> joiningList = new List<int>();
		Random rnd = new Random();
		List<string> clipboard;

		#endregion

		#region init

		public Form1() {

			InitializeComponent();

			LoadDefalauts(0);

			Thread loadAcc = new Thread(() => {

				//SpyAndSecurity.CheckTokens();

				try {

					joiningThread = new Thread(() => { });
					spyChat = new Thread(() => { });
					autoResponding = new Thread(() => { });


					twitchAccounts = AccountsLoader.LoadTwitchAccounts();
					steamAccounts = AccountsLoader.LoadSteamAccounts();


					if (steamAccounts.Count < 1) {
						ChangeLinkingAval(false);
						AppendLogBox("[APP_ERROR] Linking to steam is disabled no accounts specified!", Color.Red);
					}
					else {
						foreach (SteamAccount st in steamAccounts)
							ReferenceElementsHelper.settings.comboBox1.Items.Add(st.username);

						ReferenceElementsHelper.settings.comboBox1.SelectedIndex = 0;

						EditLinkBox("Link to " + steamAccounts[0].username);

						List<int> k = new List<int>();

						for (int i = 0; i < steamAccounts.Count; i++) {
							if (steamAccounts[i].needs_update && Convert.ToInt32(switchSteamBTN.Text) == i) {
								ReferenceElementsHelper.form1.EditLabelCookieStatus("No");
								ReferenceElementsHelper.form1.cookieStatusLAB.ForeColor = Color.Red;
							}
							else {
								ReferenceElementsHelper.form1.EditLabelCookieStatus("Ok");
								ReferenceElementsHelper.form1.cookieStatusLAB.ForeColor = Color.Green;
							}

							if (steamAccounts[i].needs_update && ReferenceElementsHelper.settings.onStartSteamLoginCHK.Checked)
								steamAccounts[i].GetCookies();

						}

						LoadDefalauts(1);
					}
					for (int i = 0; i < twitchAccounts.Count; i++) {
						AddDataGridVievRow(twitchAccounts[i].accountData.id, twitchAccounts[i].accountData.username);
						twitchAccounts[i].row = dataGridView1.Rows[i];
					}

					EditSettingsBtn(true);

				}
				catch (Exception ex) {
					Thread x = new Thread(() => {
						MessageBox.Show("Eroor in init thread!" + Environment.NewLine + ex.Message);
					});
					x.Start();
				}
			});
			loadAcc.Start();

			joiningThread = new Thread(JOINING_FUNC);
			joiningThread.Start();

			Thread syncProcess = new Thread(MAIN_SYNC_FUNC);
			syncProcess.Start();
		}

		public void MAIN_SYNC_FUNC() {
			int k = 0;
			for (; ; ) {

				#region Loading Chat API

				k = 0;
				try {
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].threads.loadingChatAPI.IsAlive)
							k++;

					if (k == 0)
						loadChatApiBTN.ForeColor = Color.White;
					else
						loadChatApiBTN.ForeColor = Color.FromArgb(255, 150, 78);
				}
				catch {

				}

				#endregion

				#region joining

				k = 0;
				try {
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].threads.joining.IsAlive)
							k++;

					if (k == 0)
						joinChannelBTN.ForeColor = Color.White;
					else
						joinChannelBTN.ForeColor = Color.FromArgb(255, 150, 78);
				}
				catch {

				}

				#endregion

				#region following

				k = 0;
				try {
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].threads.following.IsAlive)
							k++;

					if (k == 0)
						followBTN.ForeColor = Color.White;
					else
						followBTN.ForeColor = Color.FromArgb(255, 150, 78);
				}
				catch {

				}

				#endregion

				#region unFollowing

				k = 0;
				try {
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].threads.unFollowing.IsAlive)
							k++;

					if (k == 0)
						unFollowBTN.ForeColor = Color.White;
					else
						unFollowBTN.ForeColor = Color.FromArgb(255, 150, 78);
				}
				catch {

				}

				#endregion

				#region checking

				k = 0;
				try {
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].threads.checking.IsAlive)
							k++;

					if (k == 0)
						checkBTN.ForeColor = Color.White;
					else
						checkBTN.ForeColor = Color.FromArgb(255, 150, 78);
				}
				catch {

				}

				#endregion

				#region Loading Follow API

				k = 0;
				try {
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].threads.loadingFollowsAPI.IsAlive)
							k++;

					if (k == 0)
						loadApiFollowsBTN.ForeColor = Color.White;
					else
						loadApiFollowsBTN.ForeColor = Color.FromArgb(255, 150, 78);
				}
				catch {

				}

				#endregion

				#region sending

				k = 0;
				try {
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].threads.senging.IsAlive)
							k++;

					if (k == 0)
						sendMessageBTN.ForeColor = Color.White;
					else
						sendMessageBTN.ForeColor = Color.FromArgb(255, 150, 78);
				}
				catch {

				}

				#endregion

				#region Steam Cookies

				k = 0;
				try {
					if (steamAccounts[Convert.ToInt32(switchSteamBTN.Text)].getCookies.IsAlive)
						getCookiesBTN.ForeColor = Color.FromArgb(255, 150, 78);
					else
						getCookiesBTN.ForeColor = Color.White;
				}
				catch {

				}

				#endregion

				#region Linking

				k = 0;
				try {
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].threads.linking.IsAlive)
							k++;

					if (k != 0)
						linkToSteamBTN.ForeColor = Color.FromArgb(255, 150, 78);
					else
						linkToSteamBTN.ForeColor = Color.White;

				}
				catch {

				}


				#endregion

				Thread.Sleep(50);
				if (!(joiningPublicTime >= 14400))
					joiningPublicTime += 50;
			}
		}

		public void JOINING_FUNC() {
			for (; ; ) {

				if (joiningList.Count > 0 && joiningPublicTime >= 300) {

					twitchAccounts[joiningList[0]].allowJoin = true;

					joiningPublicTime -= 300;
					joiningList.RemoveAt(0);
				}

				Thread.Sleep(50);
			}
		}

		private static string ExtractString(string content, string startString, string endString) {
			int Start = 0, End = 0;
			if (content.Contains(startString) && content.Contains(endString)) {
				Start = content.IndexOf(startString, 0) + startString.Length;
				End = content.IndexOf(endString, Start);

				string Hresult = content.Substring(Start, End - Start);

				return Hresult;
			}
			else
				return string.Empty;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			SaveDefalauts();
			Environment.Exit(0);
		}

		public void SaveDefalauts() {
			Properties.Settings.Default.SettingsProxyTXT = ReferenceElementsHelper.settings.proxyTXT.Text;

			Properties.Settings.Default.SettingsProxyCHK = ReferenceElementsHelper.settings.proxyCHK.Checked;
			Properties.Settings.Default.SettingsOnStartSteamCHK = ReferenceElementsHelper.settings.onStartSteamLoginCHK.Checked;
			Properties.Settings.Default.SettingsAutoLinkingDisableCHK = ReferenceElementsHelper.settings.autoLinkingDisableCHK.Checked;
			Properties.Settings.Default.SettingsAutoDetectingDisableCHK = ReferenceElementsHelper.settings.autoDetectingDisableCHK.Checked;

			Properties.Settings.Default.FormMessageClipboardTXT = "";

			clipboard[Convert.ToInt32(switchChatMessageBTN.Text)] = chatMessageTXT.Text;

			for (int i = 0; i < clipboard.Count; i++) {
				if (i != 0)
					Properties.Settings.Default.FormMessageClipboardTXT += "@#@";

				Properties.Settings.Default.FormMessageClipboardTXT += clipboard[i];

			}

			Properties.Settings.Default.FormChannelNameTXT = channelNameTXT.Text;
			Properties.Settings.Default.FormSearchBoxTXT = searchBoxTXT.Text;

			try {
				Properties.Settings.Default.SettingsReactionDelayFromTXT = Convert.ToInt32(ReferenceElementsHelper.settings.reactionDealyFromTXT.Text);
			}
			catch {
				Properties.Settings.Default.SettingsReactionDelayFromTXT = 4000;
			}

			try {
				Properties.Settings.Default.SettingsReactionDelayToTXT = Convert.ToInt32(ReferenceElementsHelper.settings.reactionDealyToTXT.Text);
			}
			catch {
				Properties.Settings.Default.SettingsReactionDelayToTXT = 5000;
			}


			try {
				Properties.Settings.Default.SettingsMessagesDelayFromTXT = Convert.ToInt32(ReferenceElementsHelper.settings.messageDelayFromTXT.Text);
			}
			catch {
				Properties.Settings.Default.SettingsMessagesDelayFromTXT = 4000;
			}

			try {
				Properties.Settings.Default.SettingsMessagesDelayToTXT = Convert.ToInt32(ReferenceElementsHelper.settings.messageDelayToTXT.Text);
			}
			catch {
				Properties.Settings.Default.SettingsMessagesDelayToTXT = 5000;
			}



			try {
				Properties.Settings.Default.FormFollowDelayFromTXT = Convert.ToInt32(followDelayFromTXT.Text);
			}
			catch {
				Properties.Settings.Default.FormFollowDelayFromTXT = 6000;
			}

			try {
				Properties.Settings.Default.FormFollowDelayToTXT = Convert.ToInt32(followDelayToTXT.Text);
			}
			catch {
				Properties.Settings.Default.FormFollowDelayToTXT = 8000;
			}


			try {
				Properties.Settings.Default.FormMessageDelayFromTXT = Convert.ToInt32(chatDelayFromTXT.Text);
			}
			catch {
				Properties.Settings.Default.FormMessageDelayFromTXT = 3000;
			}

			try {
				Properties.Settings.Default.FormMessageDelayToTXT = Convert.ToInt32(chatDelayToTXT.Text);
			}
			catch {
				Properties.Settings.Default.FormMessageDelayToTXT = 5000;
			}


			try {
				Properties.Settings.Default.FormLastSteamAccSelected = Convert.ToInt32(switchSteamBTN.Text);
			}
			catch {
				Properties.Settings.Default.FormLastSteamAccSelected = 0;
			}


			for (; ; )
				if (!AccountsLoader.inUse)
					break;

			AccountsLoader.inUse = true;

			string fileContent = File.ReadAllText("steam.json").Replace(Environment.NewLine, "").Replace(" ", "");
			dynamic stuff = JsonConvert.DeserializeObject(fileContent);

			for (int i = 0; i < steamAccounts.Count; i++)
				stuff.steam_acounts[i].giveaway_win_text = ReferenceElementsHelper.settings.comboBox1.SelectedIndex == i ? ReferenceElementsHelper.settings.textBox1.Text : steamAccounts[i].giveaway_win_text;


			string output = Newtonsoft.Json.JsonConvert.SerializeObject(stuff, Formatting.Indented);
			File.WriteAllText("steam.json", output);

			AccountsLoader.inUse = false;

			Properties.Settings.Default.Save();
		}

		public void LoadDefalauts(int x) {
			if (InvokeRequired) {
				this.Invoke(new Action<int>(LoadDefalauts), new object[] { x });
				return;
			}


			if (x == 0) {
				ReferenceElementsHelper.settings.proxyTXT.Text = Properties.Settings.Default.SettingsProxyTXT;

				ReferenceElementsHelper.settings.proxyCHK.Checked = Properties.Settings.Default.SettingsProxyCHK;
				ReferenceElementsHelper.settings.onStartSteamLoginCHK.Checked = Properties.Settings.Default.SettingsOnStartSteamCHK;
				ReferenceElementsHelper.settings.autoLinkingDisableCHK.Checked = Properties.Settings.Default.SettingsAutoLinkingDisableCHK;
				ReferenceElementsHelper.settings.autoDetectingDisableCHK.Checked = Properties.Settings.Default.SettingsAutoDetectingDisableCHK;

				clipboard = new List<string>();
				foreach (string ste in Properties.Settings.Default.FormMessageClipboardTXT.Split(new string[] { "@#@" }, StringSplitOptions.None))
					clipboard.Add(ste);

				chatMessageTXT.Text = clipboard[0];
				switchChatMessageBTN.Text = 0.ToString();

				channelNameTXT.Text = Properties.Settings.Default.FormChannelNameTXT;
				searchBoxTXT.Text = Properties.Settings.Default.FormSearchBoxTXT;

				ReferenceElementsHelper.settings.reactionDealyFromTXT.Text = Properties.Settings.Default.SettingsReactionDelayFromTXT.ToString();
				ReferenceElementsHelper.settings.reactionDealyToTXT.Text = Properties.Settings.Default.SettingsReactionDelayToTXT.ToString();

				ReferenceElementsHelper.settings.messageDelayFromTXT.Text = Properties.Settings.Default.SettingsMessagesDelayFromTXT.ToString();
				ReferenceElementsHelper.settings.messageDelayToTXT.Text = Properties.Settings.Default.SettingsMessagesDelayToTXT.ToString();

				followDelayFromTXT.Text = Properties.Settings.Default.FormFollowDelayFromTXT.ToString();
				followDelayToTXT.Text = Properties.Settings.Default.FormFollowDelayToTXT.ToString();

				chatDelayFromTXT.Text = Properties.Settings.Default.FormMessageDelayFromTXT.ToString();
				chatDelayToTXT.Text = Properties.Settings.Default.FormMessageDelayToTXT.ToString();
			}
			else {
				switchSteamBTN.Text = Properties.Settings.Default.FormLastSteamAccSelected.ToString();
				switchSteamBTN_Click(4, null);
			}
		}

		#endregion

		#region baypass

		public void AppendLogBox(string text, Color color) {
			if (InvokeRequired) {
				this.Invoke(new Action<string, Color>(AppendLogBox), new object[] { text, color });
				return;
			}

			if (editLabelCHK.Checked) {


			}
			else {

				try {
					logBoxTXT.SelectionStart = logBoxTXT.TextLength;
					logBoxTXT.SelectionLength = 0;

					logBoxTXT.SelectionColor = color;
					logBoxTXT.AppendText(text + Environment.NewLine);
					logBoxTXT.SelectionColor = logBoxTXT.ForeColor;
				}
				catch {

				}

				logBoxTXT.SelectionStart = logBoxTXT.Text.Length;
				logBoxTXT.ScrollToCaret();
			}

		}

		public void AddDataGridVievRow(int id, string username) {
			if (InvokeRequired) {
				this.Invoke(new Action<int, string>(AddDataGridVievRow), new object[] { id, username });
				return;
			}

			try {
				dataGridView1.Rows.Add(id, username, "false", "null", "null", "No");
			}
			catch {

			}
		}

		public void ChangeLinkingAval(bool value) {
			if (InvokeRequired) {
				this.Invoke(new Action<bool>(ChangeLinkingAval), new object[] { value });
				return;
			}

			try {
				linkToSteamBTN.ForeColor = Color.Red;
				autoLinkingCHK.ForeColor = Color.Red;
			}
			catch {

			}
		}

		public void EditLinkBox(string value) {
			if (InvokeRequired) {
				this.Invoke(new Action<string>(EditLinkBox), new object[] { value });
				return;
			}

			try {
				linkToSteamBTN.Text = value;
			}
			catch {

			}
		}

		public void EditAutoDetectingWinnerCHK(bool value) {
			if (InvokeRequired) {
				this.Invoke(new Action<bool>(EditAutoDetectingWinnerCHK), new object[] { value });
				return;
			}

			try {
				autoDetectingWinnetCHK.Checked = value;
			}
			catch {

			}
		}

		public void EditLinkToSteamCHK(bool value) {
			if (InvokeRequired) {
				this.Invoke(new Action<bool>(EditLinkToSteamCHK), new object[] { value });
				return;
			}

			try {
				autoLinkingCHK.Checked = value;
			}
			catch {

			}
		}

		public void AutoRespondingDisable(bool value) {
			if (InvokeRequired) {
				this.Invoke(new Action<bool>(AutoRespondingDisable), new object[] { value });
				return;
			}

			try {
				autoRespondingCHK.Checked = value;
			}
			catch {

			}
		}

		public void EditLabelCookieStatus(string value) {
			if (InvokeRequired) {
				this.Invoke(new Action<string>(EditLabelCookieStatus), new object[] { value });
				return;
			}

			try {
				cookieStatusLAB.Text = value;
			}
			catch {

			}
		}

		public void EditSpy(bool value) {
			if (InvokeRequired) {
				this.Invoke(new Action<bool>(EditSpy), new object[] { value });
				return;
			}

			try {
				spyChatCHK.Checked = value;
			}
			catch {

			}
		}

		public void EditSettingsBtn(bool value) {
			if (InvokeRequired) {
				this.Invoke(new Action<bool>(EditSettingsBtn), new object[] { value });
				return;
			}

			try {
				settingsBTN.Enabled = value;
			}
			catch {

			}
		}

		#endregion

		#region base func

		private void loadChatApiBTN_Click(object sender, EventArgs e) {
			if (loadChatApiBTN.ForeColor == Color.FromArgb(255, 150, 78))
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value.ToString())].LoadApiChatAbort();
			else
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value.ToString())].LoadApiChat(snd: true, proxy: ReferenceElementsHelper.settings.proxyCHK.Checked ? ReferenceElementsHelper.settings.proxyTXT.Text : "");
		}

		private void joinChannelBTN_Click(object sender, EventArgs e) {

			if (joinChannelBTN.ForeColor == Color.FromArgb(255, 150, 78))
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].JoinChannelAbort();
			else {

				DataGridViewSelectedRowCollection selectedrows = dataGridView1.SelectedRows;

				for (int i = selectedrows.Count - 1; i >= 0; i--)
					twitchAccounts[Convert.ToInt32(selectedrows[i].Cells[0].Value)].JoinChannel(channelNameTXT.Text);
			}

		}

		private void sendMessageBTN_MouseUp(object sender, MouseEventArgs e) {

			int state = 0;

			try {
				if (e.Location.X <= -1 || e.Location.Y <= -1 || e.Location.X >= ((Button)sender).Width || e.Location.Y >= ((Button)sender).Height)
					return;

				state = (e.Button == MouseButtons.Left ? 0 : (e.Button == MouseButtons.Right ? 1 : 2));
			}
			catch { }


			if (sendMessageBTN.ForeColor == Color.FromArgb(255, 150, 78))
				if (state == 2)
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						try {
							twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].chatClient.SendChatMessage(chatMessageTXT.Text);
						}
						catch { }
				else
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].SendChatMessageAbort();
			else {

				int timeLine = 0;

				DataGridViewSelectedRowCollection selectedrows = dataGridView1.SelectedRows;

				for (int i = selectedrows.Count - 1; i >= 0; i--) {
					twitchAccounts[Convert.ToInt32(selectedrows[i].Cells[0].Value)].SendChatMessage(chatMessageTXT.Text, timeLine, state == 1);
					if (state != 2) {
						try {
							timeLine += rnd.Next(Convert.ToInt32(chatDelayFromTXT.Text), Convert.ToInt32(chatDelayToTXT.Text));
						}
						catch {
							AppendLogBox("[APP] Bad chat delay", Color.OrangeRed);
							return;
						}
					}
				}
			}
		}

		private void switchChatMessageBTN_MouseUp(object sender, MouseEventArgs e) {

			if (e.Location.X <= -1 || e.Location.Y <= -1 || e.Location.X >= ((Button)sender).Width || e.Location.Y >= ((Button)sender).Height)
				return;

			int state = (e.Button == MouseButtons.Left ? 0 : (e.Button == MouseButtons.Right ? 1 : 2));


			int k = Convert.ToInt32(switchChatMessageBTN.Text);


			if (state == 0) {
				clipboard[k] = chatMessageTXT.Text;
				k++;

				if (k >= clipboard.Count)
					k = 0;

				switchChatMessageBTN.Text = k.ToString();

				chatMessageTXT.Text = clipboard[k];
			}
			else if (state == 1) {
				clipboard[k] = chatMessageTXT.Text;

				clipboard.Add("");
				switchChatMessageBTN.Text = (clipboard.Count - 1).ToString();
				chatMessageTXT.Text = clipboard[clipboard.Count - 1];
			}
			else {
				if (clipboard.Count != 1) {
					clipboard.RemoveAt(k);

					for (; ; )
						if (k >= clipboard.Count)
							k--;
						else
							break;

					switchChatMessageBTN.Text = k.ToString();

					chatMessageTXT.Text = clipboard[k];
				}
			}
		}

		private void chatMessageTXT_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
			if (e.KeyCode == Keys.Enter)
				sendMessageBTN_MouseUp(null, null);
		}

		#endregion

		#region controls

		#region window

		bool mouseDown = false;
		int mouseX = 0;
		int mouseY = 0;

		private void panel1_MouseMove(object sender, MouseEventArgs e) {
			if (mouseDown)
				this.SetDesktopLocation(DesktopLocation.X + e.X - mouseX, DesktopLocation.Y + e.Y - mouseY);
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e) {
			mouseDown = false;
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e) {
			mouseDown = true;
			mouseX = e.X;
			mouseY = e.Y;
		}

		private void closeBTN_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void minimizeBTN_Click(object sender, EventArgs e) {
			this.WindowState = FormWindowState.Minimized;
		}

		#endregion

		#region datagrid and rest

		private void clearSendBTN_Click(object sender, EventArgs e) {
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				row.Cells[5].Value = "No";
		}

		private void clearFollowBTN_Click(object sender, EventArgs e) {
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				if (twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].api != null)
					row.Cells[4].Value = "Ready";
				else
					row.Cells[4].Value = "null";
		}

		private void clearLogBTN_Click(object sender, EventArgs e) {
			logBoxTXT.Text = "";
		}

		public void settingsBTN_Click(object sender, EventArgs e) {
			if (settingsBTN.ForeColor == Color.FromArgb(255, 150, 78)) {
				settingsBTN.ForeColor = Color.White;
				ReferenceElementsHelper.settings.Hide();



			}
			else {
				settingsBTN.ForeColor = Color.FromArgb(255, 150, 78);
				ReferenceElementsHelper.settings.Show();
			}
		}

		private void sortBTN_Click(object sender, EventArgs e) {
			dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
		}

		private void selectAllBTN_MouseUp(object sender, MouseEventArgs e) {

			int state = 0;

			if (e.Location.X <= -1 || e.Location.Y <= -1 || e.Location.X >= ((Button)sender).Width || e.Location.Y >= ((Button)sender).Height)
				return;

			state = (e.Button == MouseButtons.Left ? 0 : (e.Button == MouseButtons.Right ? 1 : 2));

			if (state == 0)
				dataGridView1.SelectAll();
			else
				dataGridView1.ClearSelection();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
			selectetRowsCountLBL.Text = dataGridView1.SelectedRows.Count.ToString();
		}

		private void resetBTN_Click(object sender, EventArgs e) {
			try {
				for (int i = 0; i < dataGridView1.Rows.Count; i++) {
					dataGridView1.Rows[i].Selected = false;
					dataGridView1.Rows[i].Cells[2].Value = "false";
					dataGridView1.Rows[i].Cells[3].Value = "null";
					dataGridView1.Rows[i].Cells[4].Value = (twitchAccounts[Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)].api == null ? "null" : "Ready");
					dataGridView1.Rows[i].Cells[5].Value = "No";
					logBoxTXT.Text = "";
				}
			}
			catch {

			}
		}

		private void scrollEnabled_CheckedChanged(object sender, EventArgs e) {
			if (scrollEnabled.Checked)
				logBoxTXT.ScrollBars = RichTextBoxScrollBars.Vertical;
			else
				logBoxTXT.ScrollBars = RichTextBoxScrollBars.None;
		}

		#endregion

		#endregion

		#region follows

		private void followBTN_MouseUp(object sender, MouseEventArgs e) {

			if (e.Location.X <= -1 || e.Location.Y <= -1 || e.Location.X >= ((Button)sender).Width || e.Location.Y >= ((Button)sender).Height)
				return;

			int state = (e.Button == MouseButtons.Left ? 0 : (e.Button == MouseButtons.Right ? 1 : 2));

			if (state == 1)
				return;

			if (followBTN.ForeColor == Color.FromArgb(255, 150, 78))
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value.ToString())].FollowAbort();
			else {
				int timeLine = 0;

				DataGridViewSelectedRowCollection selectedrows = dataGridView1.SelectedRows;
				for (int i = selectedrows.Count - 1; i >= 0; i--) {
					twitchAccounts[Convert.ToInt32(selectedrows[i].Cells[0].Value.ToString())].Follow(channelNameTXT.Text, timeLine);
					if (state != 2) {
						try {
							timeLine += rnd.Next(Convert.ToInt32(followDelayFromTXT.Text), Convert.ToInt32(followDelayToTXT.Text));
						}
						catch {
							AppendLogBox("[APP] Bad follow delay", Color.OrangeRed);
							return;
						}
					}
				}
			}
		}

		private void unFollowBTN_Click(object sender, EventArgs e) {
			if (unFollowBTN.ForeColor == Color.FromArgb(255, 150, 78))
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value.ToString())].UnFollowAbort();
			else
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value.ToString())].UnFollow(channelNameTXT.Text);
		}

		private void checkBTN_Click(object sender, EventArgs e) {
			if (checkBTN.ForeColor == Color.FromArgb(255, 150, 78))
				for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
					twitchAccounts[Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString())].CheckAbort();
			else {
				DataGridViewSelectedRowCollection selectedrows = dataGridView1.SelectedRows;

				for (int i = selectedrows.Count - 1; i >= 0; i--)
					twitchAccounts[Convert.ToInt32(selectedrows[i].Cells[0].Value.ToString())].Check(channelNameTXT.Text);
			}
		}

		private void loadApiFollowsBTN_Click(object sender, EventArgs e) {

			if (loadApiFollowsBTN.ForeColor == Color.FromArgb(255, 150, 78))
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].LoadApiFollowsAbort();
			else {
				DataGridViewSelectedRowCollection selectedrows = dataGridView1.SelectedRows;

				for (int i = selectedrows.Count - 1; i >= 0; i--)
					twitchAccounts[Convert.ToInt32(selectedrows[i].Cells[0].Value)].LoadApiFollows();
			}
		}

		#endregion

		#region search

		private void searchBoxBTN_Click(object sender, EventArgs e) {
			try {
				foreach (DataGridViewRow row in dataGridView1.Rows) {

					int match = 0;

					string x_1 = row.Cells[1].Value.ToString().Length >= searchBoxTXT.Text.Length ? row.Cells[1].Value.ToString() : searchBoxTXT.Text;
					string x_2 = row.Cells[1].Value.ToString().Length < searchBoxTXT.Text.Length ? row.Cells[1].Value.ToString() : searchBoxTXT.Text;

					if (x_1 == x_2) {
						dataGridView1.ClearSelection();
						dataGridView1.Rows[row.Index].Selected = true;
						return;
					}

					x_1 = x_1.ToLower();
					x_2 = x_2.ToLower();

					StringBuilder y_1 = new StringBuilder(x_1);
					StringBuilder y_2 = new StringBuilder(x_2);


					List<bool> charUsed = new List<bool>();

					for (int y = 0; y < y_1.Length; y++) {
						for (int x = 0; x < y_2.Length; x++) {
							if (y_1[y] == y_2[x]) {
								match++;
								y_2[x] = '@';
							}
						}
					}

					match *= 100;
					match /= row.Cells[1].Value.ToString().Length;

					dataGridView1.Rows[row.Index].Cells[6].Value = match;
				}

				dataGridView1.Sort(dataGridView1.Columns[6], ListSortDirection.Descending);

				dataGridView1.ClearSelection();

				dataGridView1.Rows[0].Selected = true;
			}
			catch {

			}
		}

		#endregion

		#region steam linking

		private void linkToSteamBTN_MouseUp(object sender, MouseEventArgs e) {

			if (e.Location.X <= -1 || e.Location.Y <= -1 || e.Location.X >= ((Button)sender).Width || e.Location.Y >= ((Button)sender).Height)
				return;

			int state = (e.Button == MouseButtons.Left ? 0 : (e.Button == MouseButtons.Right ? 1 : 2));

			if (state != 2) {
				if (dataGridView1.SelectedRows.Count != 1) {
					AppendLogBox("[APP] Select one twitch account to link!", Color.OrangeRed);
					return;
				}

				if (linkToSteamBTN.ForeColor == Color.FromArgb(255, 150, 78))
					foreach (DataGridViewRow row in dataGridView1.SelectedRows)
						twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].LinkToSteamAbort();

				else {
					DataGridViewRow row = dataGridView1.SelectedRows[0];
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].LinkToSteam(Convert.ToInt32(switchSteamBTN.Text));
				}
			}
			else
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
					twitchAccounts[Convert.ToInt32(row.Cells[0].Value)].LinkToSteam(0);


		}

		private void switchSteamBTN_Click(object sender, EventArgs e) {

			bool c = true;

			try {
				int u = (int)sender;
				if (u == 4)
					c = false;
			}
			catch {

			}

			int k = Convert.ToInt32(switchSteamBTN.Text);

			if (c)
				k++;

			if (k == steamAccounts.Count)
				k = 0;

			if (steamAccounts.Count < 1)
				return;

			switchSteamBTN.Text = k.ToString();
			EditLinkBox("Link to " + steamAccounts[k].username);

			if (steamAccounts[k].getCookies.IsAlive) {
				ReferenceElementsHelper.form1.EditLabelCookieStatus("Geting...");
				ReferenceElementsHelper.form1.cookieStatusLAB.ForeColor = Color.Orange;
			}
			else if (steamAccounts[k].needs_update) {
				ReferenceElementsHelper.form1.EditLabelCookieStatus("No");
				ReferenceElementsHelper.form1.cookieStatusLAB.ForeColor = Color.Red;
			}
			else {
				ReferenceElementsHelper.form1.EditLabelCookieStatus("Ok");
				ReferenceElementsHelper.form1.cookieStatusLAB.ForeColor = Color.Green;
			}
		}

		private void getCookiesBTN_Click(object sender, EventArgs e) {
			int k = Convert.ToInt32(switchSteamBTN.Text);

			if (loadChatApiBTN.ForeColor == Color.FromArgb(255, 150, 78))
				steamAccounts[k].GetCookiesAbort();
			else
				steamAccounts[k].GetCookies();
		}

		#endregion

		#region check box

		private void spyChatCHK_CheckedChanged(object sender, EventArgs e) {
			if (spyChatCHK.Checked) {
				spyChat = new Thread(() => {
					try {
						spyChatCHK.ForeColor = Color.Purple;
						spyBotAccount = new TwitchAccount(-1, "chatspy", "piesek1234", "28nuqukxqk5u6yc7jwf6zcb7aw9e3h", "", "", "");

						spyBotAccount.chatClient.TwitchChatLogin();
						spyBotAccount.KeepChatAlive();
						spyBotAccount.chatClient.JoinRoom(ReferenceElementsHelper.form1.channelNameTXT.Text);

						string msgBUF = "";
						string messageData = "";
						string messageDataPost = "";

						string[] pat = new string[] { "win", "won", "congr" };
						string[] noPat = new string[] { "thanks ", "Thank ", "for following", "for follow", "to win" };
						string[] userStatus = new string[] { "moderator", "broadcaster" };

						spyChatCHK.ForeColor = Color.Green;

						while (true) {

							try {
								msgBUF = "";
								messageData = "";
								messageDataPost = "";

								msgBUF = spyBotAccount.chatClient.ReadMessage();
								messageData = msgBUF.Split(new string[] { "user-type=" }, StringSplitOptions.None)[1];
								messageDataPost = msgBUF.Split(new string[] { "user-type=" }, StringSplitOptions.None)[0];


								if (messageData.Contains("PRIVMSG")) {

									string user = messageData.Split(new string[] { ":", "!" }, StringSplitOptions.None)[1].ToLower();
									string msg = messageData.Split(new string[] { "#" + spyBotAccount.accountData.channel + " :" }, StringSplitOptions.None)[1];
									string tags = ExtractString(messageDataPost, "badges=", ";").ToLower();

									Color cl = Color.White;
									if (tags.Contains("broadcaster"))
										cl = Color.FromArgb(255, 82, 82);
									else if (tags.Contains("moderator"))
										cl = Color.FromArgb(70, 218, 130);

									ReferenceElementsHelper.form1.AppendLogBox("[CHAT] " + user + ": " + msg, cl);
									msg = msg.ToLower();

									if (autoDetectingWinnetCHK.Checked) {

										if (ReferenceElementsHelper.settings.autoDetectingDisableCHK.Checked)
											EditAutoDetectingWinnerCHK(false);


										bool ok = false;

										for (int i = 0; i < userStatus.Length; i++) {
											if (tags.Contains(userStatus[i])) {
												ok = true;
												break;
											}
										}

										if (!ok)
											continue;

										ok = false;

										for (int i = 0; i < pat.Length; i++) {
											if (msg.Contains(pat[i])) {
												ok = true;
												break;
											}
										}

										if (!ok)
											continue;

										for (int i = 0; i < noPat.Length; i++) {
											if (msg.Contains(noPat[i])) {
												ok = false;
												break;
											}
										}

										if (ok) {

											bool isMe = false;
											int winnerID = -1;

											foreach (DataGridViewRow row in dataGridView1.Rows)
												row.Selected = false;

											foreach (DataGridViewRow row in dataGridView1.Rows)
												if (msg.Contains(row.Cells[1].Value.ToString().ToLower())) {
													isMe = true;
													row.Selected = true;
													winnerID = Convert.ToInt32(row.Cells[0].Value);
													break;
												}

											if (isMe) {
												AppendLogBox("[GIVEAWAY_EVENT] Winner found id: " + winnerID + "  " + twitchAccounts[winnerID].accountData.username, Color.Green);

												Thread xd = new Thread(() => {

													try {
														SpeechSynthesizer synth = new SpeechSynthesizer();

														synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

														synth.Speak("You won the giveaway on " + twitchAccounts[winnerID].accountData.username);
													}
													catch {

													}

												});
												xd.Start();


												if (autoLinkingCHK.Checked) {
													twitchAccounts[winnerID].LinkToSteam(Convert.ToInt32(switchSteamBTN.Text));
													if (ReferenceElementsHelper.settings.autoLinkingDisableCHK.Checked)
														EditLinkToSteamCHK(false);
												}

												if (autoRespondingCHK.Checked) {
													if (!autoResponding.IsAlive) {
														autoResponding = new Thread((object winId) => {
															autoRespondingCHK.ForeColor = Color.Purple;

															try {

																int x, y;
																try {
																	x = Convert.ToInt32(ReferenceElementsHelper.settings.reactionDealyFromTXT.Text);
																	y = Convert.ToInt32(ReferenceElementsHelper.settings.reactionDealyToTXT.Text);
																}
																catch {
																	x = 4000;
																	y = 5000;
																}

																twitchAccounts[(int)winnerID].JoinChannel(channelNameTXT.Text, true);

																autoRespondingCHK.ForeColor = Color.Orange;

																Thread.Sleep(rnd.Next(x, y));

																autoRespondingCHK.ForeColor = Color.Green;

																int k = steamAccounts[Convert.ToInt32(switchSteamBTN.Text)].giveaway_win_text.Split(new string[] { "[]" }, StringSplitOptions.None).Length;
																

																foreach (string keyMsg in steamAccounts[Convert.ToInt32(switchSteamBTN.Text)].giveaway_win_text.Split(new string[] { "[]" }, StringSplitOptions.None)) {
																	string xy = keyMsg.Replace("$$##$$", "");
																	twitchAccounts[(int)winnerID].SendChatMessage(xy, 0);

																	int z, u;
																	try {
																		z = Convert.ToInt32(ReferenceElementsHelper.settings.reactionDealyFromTXT.Text);
																		u = Convert.ToInt32(ReferenceElementsHelper.settings.reactionDealyToTXT.Text);
																	}
																	catch {
																		z = 5000;
																		u = 6000;
																	}

																	if ((--k) > 0)
																		Thread.Sleep(rnd.Next(z, u));

																}

																autoRespondingCHK.ForeColor = Color.White;
																AutoRespondingDisable(false);

															}
															catch (ThreadAbortException) {
																AppendLogBox("[AUTO_RESPONDING__ERROR] Responding thread failed to complete!", Color.OrangeRed);
																autoRespondingCHK.ForeColor = Color.White;
																AutoRespondingDisable(false);
															}
															catch (Exception ex) {
																AppendLogBox("[AUTO_RESPONDING__ERROR] Responding thread failed to complete!" + Environment.NewLine + ex.Message, Color.OrangeRed);
																autoRespondingCHK.ForeColor = Color.White;
																AutoRespondingDisable(false);
															}
														});
														autoResponding.Start(winnerID);
													}
													else
														AppendLogBox("[SYSTEM_MESSAGE] Responding thread is already bussy!", Color.OrangeRed);
												}
											}
											else {
												AppendLogBox("[GIVEAWAY_EVENT] Winner not found", Color.Red);

												Thread xd = new Thread(() => {

													try {
														SpeechSynthesizer synth = new SpeechSynthesizer();

														synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);

														synth.Speak("You lost the giveaway");
													}
													catch {

													}

												});
												xd.Start();

											}
										}
									}

								}
							}
							catch (ThreadAbortException) {

							}
							catch {

							}
						}
					}
					catch {
						EditSpy(false);
						spyChatCHK.ForeColor = Color.White;
					}
				});

				spyChat.Start();
			}
			else {
				try {
					EditSpy(false);
					spyChatCHK.ForeColor = Color.White;
					spyChat.Abort();
				}
				catch {

				}
			}
		}

		private void autoRespondingCHK_CheckedChanged(object sender, EventArgs e) {
			if (autoRespondingCHK.ForeColor == Color.Green) {
				try {
					autoResponding.Abort();
				}
				catch {

				}
			}
		}
		
		#endregion

	}
}