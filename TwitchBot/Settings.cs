using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBot {
	public partial class Settings : Form {
		public Settings() {
			InitializeComponent();
		}

		Thread saving;
		Thread loading;

		public void EditCombo(bool value) {
			if (InvokeRequired) {
				this.Invoke(new Action<bool>(EditCombo), new object[] { value });
				return;
			}

			try {
				comboBox1.Enabled = value;
			}
			catch {

			}
		}

		public void EditTextBox(string value) {
			if (InvokeRequired) {
				this.Invoke(new Action<string>(EditTextBox), new object[] { value });
				return;
			}

			try {
				textBox1.Text = value;
			}
			catch {

			}
		}

		public void savingTh(object acc) {
			try {
				saveBTN.ForeColor = Color.FromArgb(255, 150, 78);
				for (; ; )
					if (!AccountsLoader.inUse)
						break;

				AccountsLoader.inUse = true;

				string fileContent = File.ReadAllText("steam.json").Replace(Environment.NewLine, "").Replace(" ", "");
				dynamic stuff = JsonConvert.DeserializeObject(fileContent);

				stuff.steam_acounts[(int)acc].giveaway_win_text = textBox1.Text.Replace(Environment.NewLine, "$$##$$");
				ReferenceElementsHelper.form1.steamAccounts[(int)acc].giveaway_win_text = textBox1.Text.Replace(Environment.NewLine, "$$##$$");

				string output = Newtonsoft.Json.JsonConvert.SerializeObject(stuff, Formatting.Indented);
				File.WriteAllText("steam.json", output);

				AccountsLoader.inUse = false;
				saveBTN.ForeColor = Color.White;
				EditCombo(true);
			}
			catch (ThreadAbortException) {

				try {
					AccountsLoader.inUse = false;
				}
				catch {

				}

				try {
					saveBTN.ForeColor = Color.White;
				}
				catch {

				}

				try {
					EditCombo(true);
				}
				catch {

				}

			}
			catch (Exception ex) {

				try {
					AccountsLoader.inUse = false;
				}
				catch {

				}

				try {
					saveBTN.ForeColor = Color.White;
				}
				catch {

				}

				try {
					EditCombo(true);
				}
				catch {

				}

				try {
					MessageBox.Show("Error in saving giveaway_win_text!" + Environment.NewLine + ex.Message);
				}
				catch {

				}

			}
		}

		private void saveBTN_Click(object sender, EventArgs e) {
			if (comboBox1.SelectedIndex != -1) {
				if (saveBTN.ForeColor != Color.FromArgb(255, 150, 78)) {
					saving = new Thread(savingTh);
					saving.Start(comboBox1.SelectedIndex);
					EditCombo(false);
				}
			}
			else {
				Thread x = new Thread(() => {
					MessageBox.Show("Select account!");
				});
				x.Start();
			}
		}

		private void reloadBTN_Click(object sender, EventArgs e) {
			if (comboBox1.SelectedIndex != -1) {
				if (reloadBTN.ForeColor != Color.FromArgb(255, 150, 78)) {
					loading = new Thread((object acc) => {
						try {
							reloadBTN.ForeColor = Color.FromArgb(255, 150, 78);

							for (; ; )
								if (!AccountsLoader.inUse)
									break;

							AccountsLoader.inUse = true;

							string fileContent = File.ReadAllText("steam.json").Replace(Environment.NewLine, "").Replace(" ", "");
							dynamic stuff = JsonConvert.DeserializeObject(fileContent);

							for (int i = 0; i < ReferenceElementsHelper.form1.steamAccounts.Count; i++)
								ReferenceElementsHelper.form1.steamAccounts[i].giveaway_win_text = stuff.steam_acounts[i].giveaway_win_text.ToString();

							EditTextBox(ReferenceElementsHelper.form1.steamAccounts[(int)acc].giveaway_win_text.Replace("$$##$$", Environment.NewLine));

							AccountsLoader.inUse = false;
							reloadBTN.ForeColor = Color.White;
							EditCombo(true);
						}
						catch (ThreadAbortException) {

							try {
								AccountsLoader.inUse = false;
							}
							catch {

							}

							try {
								reloadBTN.ForeColor = Color.White;
							}
							catch {

							}

							EditCombo(true);

						}
						catch (Exception ex) {

							try {
								AccountsLoader.inUse = false;
							}
							catch {

							}

							try {
								reloadBTN.ForeColor = Color.White;
							}
							catch {

							}

							EditCombo(true);

							try {
								MessageBox.Show("Error in reloading giveaway_win_text!" + Environment.NewLine + ex.Message);
							}
							catch {

							}

						}
					});
					EditCombo(false);
					loading.Start(comboBox1.SelectedIndex);
				}
			}
			else {
				Thread x = new Thread(() => {
					MessageBox.Show("Select account!");
				});
				x.Start();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				EditTextBox(ReferenceElementsHelper.form1.steamAccounts[comboBox1.SelectedIndex].giveaway_win_text.Replace("$$##$$", Environment.NewLine));
			}
			catch {

			}
		}

		private void closeBTN_Click(object sender, EventArgs e) {
			ReferenceElementsHelper.form1.settingsBTN_Click(null, null);
		}

		private void saveDefalautsBTN_Click(object sender, EventArgs e) {
			ReferenceElementsHelper.form1.SaveDefalauts();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			ReferenceElementsHelper.form1.steamAccounts[comboBox1.SelectedIndex].giveaway_win_text = textBox1.Text.Replace(Environment.NewLine, "$$##$$");
		}

	}
}