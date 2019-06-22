using Starksoft.Aspen.Proxy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Security.AccessControl;
using TwitchLib;
using SteamLibrary;
using System.Diagnostics;

namespace TwitchBot {
	public class TwitchAccount {

		#region classes

		public class ChatClient {

			#region var

			public TcpClient tcpClient;
			private StreamReader inoputStream;
			private StreamWriter outputStream;

			AccountData accountData;

			#endregion

			public ChatClient(ref AccountData accountData) {
				this.accountData = accountData;
				tcpClient = new TcpClient();
			}


			public void TwitchChatLogin(string proxy = "") {
				if (proxy == "") {
					tcpClient = new TcpClient("irc.twitch.tv", 80);
				}
				else {
					Socks5ProxyClient proxyClient = new Socks5ProxyClient(proxy.Split(':')[0], Convert.ToInt32(proxy.Split(':')[1]));
					tcpClient = proxyClient.CreateConnection("irc.twitch.tv", 80);
				}

				inoputStream = new StreamReader(tcpClient.GetStream());
				outputStream = new StreamWriter(tcpClient.GetStream());

				outputStream.WriteLine("CAP REQ :twitch.tv/tags twitch.tv/commands");
				outputStream.WriteLine("PASS " + "oauth:" + accountData.token);
				outputStream.WriteLine("NICK " + accountData.username);
				outputStream.WriteLine("USER " + accountData.username + " 8 * :" + accountData.username);
				outputStream.Flush();

			}

			public void JoinRoom(string chanel) {
				accountData.channel = chanel;

				outputStream.WriteLine("JOIN #" + accountData.channel);
				outputStream.Flush();
			}

			public void SendIrcMessage(string message) {
				outputStream.WriteLine(message);
				outputStream.Flush();
			}

			public void SendChatMessage(string message) {
				SendIrcMessage(":" + accountData.username + "!" + accountData.username + "@" + accountData.username + ".tmi.twitch.tx PRIVMSG #" + accountData.channel + " :" + message);
			}

			public string ReadMessage() {
				return inoputStream.ReadLine();
			}
		}

		public class AccountData {
			public int id;
			public string username;
			public string password;
			public string token;
			public string priority;
			public string devicecookie;
			public string persistent;
			public string channel;

			public AccountData() {
				id = 0;
				username = "";
				password = "";
				token = "";
				priority = "";
				devicecookie = "";
				persistent = "";
				channel = "";
			}
		}

		public class Threads {
			public Thread loadingChatAPI;
			public Thread loadingFollowsAPI;
			public Thread senging;
			public Thread following;
			public Thread unFollowing;
			public Thread checking;
			public Thread joining;
			public Thread linking;
			public Thread chatAlive;

			public Threads (){
				loadingChatAPI = new Thread(() => { });
				loadingFollowsAPI = new Thread(() => { });
				senging = new Thread(() => { });
				following = new Thread(() => { });
				unFollowing = new Thread(() => { });
				checking = new Thread(() => { });
				joining = new Thread(() => { });
				linking = new Thread(() => { });
				chatAlive = new Thread(() => { });
			}
		}

		#endregion
		
		#region var

		public ChatClient chatClient;
		public TwitchAPI api;
		public AccountData accountData;
		public Threads threads;
		public DataGridViewRow row;

		#endregion

		#region init

		public TwitchAccount(int id, string username, string password, string token, string priority, string devicecookie, string persistent) {
			accountData = new AccountData();
			accountData.id = id;
			accountData.username = username;
			accountData.password = password;
			accountData.token = token;
			accountData.priority = priority;
			accountData.devicecookie = devicecookie;
			accountData.persistent = persistent;

			threads = new Threads();

			chatClient = new ChatClient(ref accountData);
		}

		#endregion

		public void KeepChatAlive() {
			threads.chatAlive = new Thread(() => {

				try {
					for (; ; ) {
						Thread.Sleep(270000);
						chatClient.SendIrcMessage("PONG");
						Thread.Sleep(2000);
						chatClient.SendIrcMessage("PING");
					}
				}
				catch {

				}
			});

			threads.chatAlive.Start();
		}

		public void KeepChatAliveAbort() {
			try {
				threads.chatAlive.Abort();
			}
			catch {

			}
		}


		public void LoadApiChat(string proxy = "", bool snd = false) {

			threads.loadingChatAPI = new Thread((object argProxy) => {
				KeepChatAliveAbort();

				try {
					row.Cells[2].Value = "Loading...";

					chatClient.TwitchChatLogin((string)argProxy);
					row.Cells[2].Value = "Loaded";

					if (snd)
						row.Cells[3].Value = "null";

					KeepChatAlive();
				}
				catch (ThreadAbortException) {
					row.Cells[2].Value = "false";
				}
				catch {
					row.Cells[2].Value = "Error";
				}
			});
			threads.loadingChatAPI.Start(proxy);

		}
		
		public void LoadApiChatAbort() {
			try {
				threads.loadingChatAPI.Abort();
			}
			catch {

			}
		}

		
		public void LoadApiFollows() {

			threads.loadingFollowsAPI = new Thread(() => {
				try {
					row.Cells[4].Value = "Loading...";
					api = new TwitchAPI("swlgbk4x104iafphqwstzxl3yrtjqt", accountData.token);
					row.Cells[4].Value = "Ready";
				}
				catch (ThreadAbortException) {
					row.Cells[4].Value = "null";
				}
				catch {
					row.Cells[4].Value = "Error";
				}
			});
			threads.loadingFollowsAPI.Start();

		}

		public void LoadApiFollowsAbort() {
			try {
				threads.loadingFollowsAPI.Abort();
			}
			catch {

			}
		}


		public void Follow(string channel, int deley) {

			threads.following = new Thread((object chnArg) => {

				try {
					//Loading api
					bool loaded = true;
					if (api == null) {
						row.Cells[4].Value = "Loading...";
						LoadApiFollows();
						loaded = false;
					}

					//Delay
					int del = Convert.ToInt32(((string)chnArg).Split(new string[] { "#@#" }, StringSplitOptions.None)[1]);

					for (; ; ) {
						if (del <= 1000) { 
							if (del != 0)
								Thread.Sleep(del);
							break;
						}

						if (row.Cells[4].Value.ToString() == "Ready")
							loaded = true;
						else if (row.Cells[4].Value.ToString() == "Error")
							throw new Exception();
						else if (row.Cells[4].Value.ToString() == "null")
							FollowAbort();
							

						row.Cells[4].Value = (del / 1000).ToString();
						Thread.Sleep(1000);
						del -= 1000;
					}

					//Loading api
					if (!loaded)
						for (; ; ) {
							if (row.Cells[4].Value.ToString() == "Ready")
								break;
							else if (row.Cells[4].Value.ToString() == "Error")
								throw new Exception();
							else if (row.Cells[4].Value.ToString() == "null")
								FollowAbort();
							else
								Thread.Sleep(250);
						}

					//Following
					row.Cells[4].Value = "Following...";
					api.Follows.v3.CreateFollowAsync(accountData.username, ((string)chnArg).Split(new string[] { "#@#" }, StringSplitOptions.None)[0]);
					row.Cells[4].Value = ((string)chnArg).Split(new string[] { "#@#" }, StringSplitOptions.None)[0];

				}
				catch (ThreadAbortException) {
					if (api != null)
						row.Cells[4].Value = "Ready";
					else
						row.Cells[4].Value = "null";
				}
				catch {
					try {
						row.Cells[4].Value = "Error";
					}
					catch {

					}
				}

			});
			threads.following.Start(channel + "#@#" + deley.ToString());
		}

		public void FollowAbort() {
			try {
				threads.following.Abort();
			}
			catch {

			}
		}


		public void UnFollow(string channel) {
			threads.unFollowing = new Thread((object chnArg) => {
				try {
					//Loading api
					bool loaded = true;
					if (api == null) {
						row.Cells[4].Value = "Loading...";
						LoadApiFollows();
						loaded = false;
					}

					//Loading api
					if (!loaded)
						for (; ; ) 
							if (row.Cells[4].Value.ToString() == "Ready")
								break;
							else if (row.Cells[4].Value.ToString() == "Error")
								throw new Exception();
							else if (row.Cells[4].Value.ToString() == "null")
								UnFollowAbort();
							else
								Thread.Sleep(250);
								

					//Following
					row.Cells[4].Value = "UnFollowing...";
					api.Follows.v3.RemoveFollowAsync(accountData.username, (string)chnArg);
					row.Cells[4].Value = "UnFollowed";

				}
				catch (ThreadAbortException) {
					if (api != null)
						row.Cells[4].Value = "Ready";
					else
						row.Cells[4].Value = "null";
				}
				catch {
					try {
						row.Cells[4].Value = "Error";
					}
					catch {

					}
				}
			});

			threads.unFollowing.Start(channel);
		}

		public void UnFollowAbort() {
			try {
				threads.unFollowing.Abort();
			}
			catch {

			}
		}

		
		public void Check(string channel) {
			threads.checking = new Thread((object argChnl) => {
				try {

					//Loading api
					bool loaded = true;
					if (api == null) {
						row.Cells[4].Value = "Loading...";
						LoadApiFollows();
						loaded = false;
					}

					//Loading api
					if (!loaded)
						for (; ; )
							if (row.Cells[4].Value.ToString() == "Ready")
								break;
							else if (row.Cells[4].Value.ToString() == "Error")
								throw new Exception();
							else if (row.Cells[4].Value.ToString() == "null")
								CheckAbort();
							else
								Thread.Sleep(250);


					api.Follows.v3.GetFollowsStatusAsync(accountData.username, (string)argChnl).Result.CreatedAt.ToString();
					row.Cells[4].Value = (string)argChnl;
				}
				catch (ThreadAbortException) {
					if (api != null)
						row.Cells[4].Value = "Ready";
					else
						row.Cells[4].Value = "null";
				}
				catch {
					row.Cells[4].Value = "No";
				}
			});

			threads.checking.Start(channel);
		}

		public void CheckAbort() {
			try {
				threads.checking.Abort();
			}
			catch {

			}
		}

		public bool allowJoin;
		public void JoinChannel(string channel, bool instant = false) {
			allowJoin = instant;

			threads.joining = new Thread((object chanArg) => {

				try {
					if (row.Cells[2].Value.ToString() == "false" || !chatClient.tcpClient.Connected) {
						row.Cells[2].Value = "Loading...";
						row.Cells[3].Value = "Waiting...";
						LoadApiChat(ReferenceElementsHelper.settings.proxyCHK.Checked ? ReferenceElementsHelper.settings.proxyTXT.Text : "");
					}

					for (; ; )
						if (row.Cells[2].Value.ToString() == "Loaded")
							break;
						else if (row.Cells[2].Value.ToString() == "Error")
							throw new Exception();
						else if (row.Cells[2].Value.ToString() == "false")
							JoinChannelAbort();
						else
							Thread.Sleep(50);



					row.Cells[3].Value = "In queue";

					if (!allowJoin)
						ReferenceElementsHelper.form1.joiningList.Add(accountData.id);

					for (; ; ) {
						if (allowJoin) {
						
							row.Cells[3].Value = "Loading...";
							chatClient.JoinRoom((string)chanArg);
							row.Cells[3].Value = (string)chanArg;

							allowJoin = false;
							break;
						}
						else
							Thread.Sleep(50);
					}
				}
				catch (ThreadAbortException) {
					row.Cells[3].Value = "null";
				}
				catch {
					row.Cells[3].Value = "Error";
				}
			});

			threads.joining.Start(channel);
		}

		public void JoinChannelAbort() {
			try {
				threads.joining.Abort();
			}
			catch {

			}
		}


		public void SendChatMessage(string message, int delay, bool messageDynamic = false) {

			threads.senging = new Thread((object data) => {

				try {
					string msg = ((string)data).Split(new string[] { "#@#" }, StringSplitOptions.None)[0];
					int del = Convert.ToInt32(((string)data).Split(new string[] { "#@#" }, StringSplitOptions.None)[1]);
					bool instSend = ((string)data).Split(new string[] { "#@#" }, StringSplitOptions.None)[2] == "1" ? true : false;
					bool loaded = false;

					if (row.Cells[2].Value.ToString() == "false" || !chatClient.tcpClient.Connected || row.Cells[3].Value.ToString() == "null" || row.Cells[3].Value.ToString() == "Error") {
						JoinChannel(ReferenceElementsHelper.form1.channelNameTXT.Text);
						row.Cells[3].Value = "Waiting...";
					}
					else
						loaded = true;


					//delay
					for (; ; ) {
						if (del <= 1000) {
							if (del != 0)
								Thread.Sleep(del);
							break;
						}

						if (row.Cells[3].Value.ToString() == ReferenceElementsHelper.form1.channelNameTXT.Text)
							loaded = true;
						else if (row.Cells[3].Value.ToString() == "null")
							SendChatMessageAbort();
						else if (row.Cells[3].Value.ToString() == "Error")
							throw new Exception();
							
						row.Cells[5].Value = (del / 1000).ToString();
						Thread.Sleep(1000);
						del -= 1000;
					}


					if (!loaded)
						for (; ; )
							if (row.Cells[3].Value.ToString() == ReferenceElementsHelper.form1.channelNameTXT.Text)
								break;
							else if (row.Cells[3].Value.ToString() == "null")
								SendChatMessageAbort();
							else if (row.Cells[3].Value.ToString() == "Error")
								throw new Exception();
							else
								Thread.Sleep(50);
								
					chatClient.SendChatMessage(messageDynamic ? ReferenceElementsHelper.form1.chatMessageTXT.Text : message);
					row.Cells[5].Value = "Yes";

				}
				catch (ThreadAbortException) {
					row.Cells[5].Value = "No";
				}
				catch (Exception ex) {
					Console.WriteLine(ex.Message);
					row.Cells[5].Value = "X";
				}

			});

			threads.senging.Start(message + "#@#" + delay + "#@#" + (messageDynamic ? "1" : "0"));
			
		}

		public void SendChatMessageAbort() {
			try {
				threads.senging.Abort();
			}
			catch {

			}
		}


		public void FadeLinkedSteam() {
			Thread disapear = new Thread(() => {
				int[] cl = { row.DefaultCellStyle.ForeColor.R, row.DefaultCellStyle.ForeColor.G, row.DefaultCellStyle.ForeColor.B };
				int x;

				for (; ; ) {
					x = 0;
					for (int k = 0; k < 3; k++) {
						cl[k] += 10;
						if (cl[k] >= 255) {
							cl[k] = 255;
							x++;
						}

						row.DefaultCellStyle.ForeColor = Color.FromArgb(cl[0], cl[1], cl[2]);
						row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(cl[0], cl[1], cl[2]);
						if (x == 3)
							return;
					}

					Thread.Sleep(1000);
				}
			});

			disapear.Start();
		}


		public void LinkToSteam(int id) {
			threads.linking = new Thread((object st_id) => {
				var watch = Stopwatch.StartNew();
				row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 196, 112);
				row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 196, 112);

				try {
					if (ReferenceElementsHelper.form1.steamAccounts[id].needs_update || ReferenceElementsHelper.form1.steamAccounts[id].client.data.cookies.Count < 1) {
					
						ReferenceElementsHelper.form1.steamAccounts[id].GetCookies();
						ReferenceElementsHelper.form1.cookieStatusLAB.Text = "Geting...";

						for (; ; )
							if (ReferenceElementsHelper.form1.cookieStatusLAB.Text == "Ok")
								break;
							else if (ReferenceElementsHelper.form1.cookieStatusLAB.Text == "No")
								throw new Exception("Steam error");
							else
								Thread.Sleep(50);
					}

					SLibResponse.PageLoginResponse resp = ReferenceElementsHelper.form1.steamAccounts[id].client.LoginNotAscPage("https://steamcommunity.com/openid/login?openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.realm=https%3A%2F%2Fapi.twitch.tv&openid.return_to=https%3A%2F%2Fapi.twitch.tv%2Fv5%2Fsteam%2F" + accountData.persistent.Split('%')[0] + "%2Fcallback%3Fclient_id%3D" + "jzkbprff40iqj646a697cyrvl0zt2m6", new CookieCollection { new Cookie("device_cookie", accountData.devicecookie, "/", ".twitch.tv"), new Cookie("persistent", accountData.persistent, "/", ".twitch.tv") });
					watch.Stop();
					
					bool p = false;
					if (resp.responseUri != null)
						if (resp.responseUri.AbsoluteUri != "https://www.twitch.tv/steam_sharing/callback_success")
							p = true;


					if (!resp.status || p) 
						throw new Exception(p ? "Bad callback" : resp.message);
					else {
						row.DefaultCellStyle.ForeColor = Color.FromArgb(99, 235, 123);
						row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(99, 235, 123);
						FadeLinkedSteam();

						float el = watch.ElapsedMilliseconds;
						el /= 1000;

						ReferenceElementsHelper.form1.AppendLogBox("[APP] Succesfully linked " + accountData.username + " in " + el + " sec", Color.Green);
					}
				}
				catch (Exception ex){
					ReferenceElementsHelper.form1.AppendLogBox("[APP] Failed to link " + accountData.username + " -> " + ex.Message, Color.OrangeRed);
					row.DefaultCellStyle.ForeColor = Color.FromArgb(253, 111, 118);
					row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(253, 111, 118);
					FadeLinkedSteam();
				}
				
			});
			threads.linking.Start();

		}

		public void LinkToSteamAbort() {

		}

	}
}