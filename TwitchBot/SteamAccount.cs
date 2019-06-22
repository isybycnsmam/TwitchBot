using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteamLibrary;

namespace TwitchBot {
	public class SteamAccount {
		public SteamPcClient client;

		public int id;
		public string username;
		public string password;
		public string token;
		public string giveaway_win_text;
		public long last_update;
		public string[] cookies;
		public bool needs_update;
		public Thread getCookies;

		public SteamAccount(int id, string username, string password, string token, string giveaway_win_text, long last_update, CookieCollection cookies) {
			this.id = id;
			this.username = username;
			this.password = password;
			this.token = token;
			this.giveaway_win_text = giveaway_win_text;
			this.last_update = last_update;
			this.giveaway_win_text = giveaway_win_text;

			getCookies = new Thread(() => { });

			if (DateTimeOffset.Now.ToUnixTimeSeconds() - 72000 >= last_update || cookies.Count <= 0)
				needs_update = true;
			else {
				needs_update = false;
				client = new SteamPcClient(cookies);
			}
		}

		public void GetCookies() {
			getCookies = new Thread(() => {

				try {
					if (id == Convert.ToInt32(ReferenceElementsHelper.form1.switchSteamBTN.Text)) {
						ReferenceElementsHelper.form1.EditLabelCookieStatus("Geting...");
						ReferenceElementsHelper.form1.cookieStatusLAB.ForeColor = Color.Orange;
					}

					client = new SteamPcClient(username, password, token, true);

					if (client.data.status) {
						if (id == Convert.ToInt32(ReferenceElementsHelper.form1.switchSteamBTN.Text)) {
							ReferenceElementsHelper.form1.EditLabelCookieStatus("Ok");
							ReferenceElementsHelper.form1.cookieStatusLAB.ForeColor = Color.Green;
						}

						last_update = DateTimeOffset.Now.ToUnixTimeSeconds();
						needs_update = false;

						for (; ; )
							if (!AccountsLoader.inUse)
								break;
							else
								Thread.Sleep(250);
						
						AccountsLoader.inUse = true;
						string fileContent = File.ReadAllText("steam.json").Replace(Environment.NewLine, "").Replace(" ", "");
						dynamic stuff = JsonConvert.DeserializeObject(fileContent);

						stuff.steam_acounts[id].last_update = last_update;


						stuff.steam_acounts[id].cookies.Clear();
						foreach (Cookie cookie in client.data.cookies)
							stuff.steam_acounts[id].cookies.Add(cookie.Name + ":" + cookie.Value + ":" + cookie.Path + ":" + cookie.Domain);

						string output = Newtonsoft.Json.JsonConvert.SerializeObject(stuff, Newtonsoft.Json.Formatting.Indented);
						File.WriteAllText("steam.json", output);
						AccountsLoader.inUse = false;
					}
					else
						throw new Exception(client.data.message);
				}
				catch (Exception ex){
					if (ReferenceElementsHelper.form1.switchSteamBTN.Text == id.ToString()) {
						ReferenceElementsHelper.form1.EditLabelCookieStatus("No");
						ReferenceElementsHelper.form1.cookieStatusLAB.ForeColor = Color.Red;
					}

					ReferenceElementsHelper.form1.AppendLogBox("[APP] Error get steam cookies on " + username + Environment.NewLine + ex.Message, Color.Red);
					
					needs_update = true;
				}

			});
			getCookies.Start();
		}

		public void GetCookiesAbort() {
			try {
				getCookies.Abort();
			}
			catch {

			}
		}

	}
}