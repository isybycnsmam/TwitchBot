using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBot {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Settings settings = new Settings();
			ReferenceElementsHelper.GetRef(ref settings);

			Form1 form1 = new Form1();
			ReferenceElementsHelper.GetRef(ref form1);

			Application.Run(form1);
		}
	}
}