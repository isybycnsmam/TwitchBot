using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitchBot {
	public static class AccountsLoader {

		public static bool inUse = false;

		public static List<TwitchAccount> LoadTwitchAccounts() {
			List<TwitchAccount> response = new List<TwitchAccount>();

			try {
			
				string fileContent = File.ReadAllText("twitch.json").Replace(Environment.NewLine, "").Replace(" ", "");
				dynamic stuff = JsonConvert.DeserializeObject(fileContent);
				
				for (int i = 0; i < stuff.twitch_acounts.Count; i++) {
					int id = Convert.ToInt32(stuff.twitch_acounts[i].id.ToString());
					string username = stuff.twitch_acounts[i].username;
					string password = stuff.twitch_acounts[i].password;
					string token = stuff.twitch_acounts[i].token;
					string priority = stuff.twitch_acounts[i].priority;
					string devicecookie = stuff.twitch_acounts[i].devicecookie;
					string persistent = stuff.twitch_acounts[i].persistent;

					response.Add(new TwitchAccount(id, username, password, token, priority, devicecookie, persistent));
				}
			}
			catch (Exception ex) {
				ReferenceElementsHelper.form1.AppendLogBox("[APP_CRITICAL_ERROR] Error in loading twitch accounts function message: " + ex.Message, Color.Red);
			}
			return response;
		}

		public static List<SteamAccount> LoadSteamAccounts() {
			List<SteamAccount> response = new List<SteamAccount>();

			try {

				string fileContent = File.ReadAllText("steam.json").Replace(Environment.NewLine, "").Replace(" ", "");
				dynamic stuff = JsonConvert.DeserializeObject(fileContent);

				for (int i = 0; i < stuff.steam_acounts.Count; i++) {
					int id = Convert.ToInt32(stuff.steam_acounts[i].id.ToString());
					string username = stuff.steam_acounts[i].username;
					string password = stuff.steam_acounts[i].password;
					string token = stuff.steam_acounts[i].token;
					string giveaway_win_text = stuff.steam_acounts[i].giveaway_win_text;
					long last_update = stuff.steam_acounts[i].last_update;
					CookieCollection cookies = new CookieCollection();

					for (int k = 0; k < stuff.steam_acounts[i].cookies.Count; k++) {
						string s = stuff.steam_acounts[i].cookies[k].ToString();
						cookies.Add(new Cookie(s.Split(':')[0], s.Split(':')[1], s.Split(':')[2], s.Split(':')[3]));
					}

					response.Add(new SteamAccount(id, username, password, token, giveaway_win_text, last_update, cookies));
				}
			}
			catch (Exception ex) {
				ReferenceElementsHelper.form1.AppendLogBox("[APP_CRITICAL_ERROR] Error in loading steam accounts function message: " + ex.Message, Color.Red);
			}

			return response;
		}

	}
}