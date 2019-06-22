using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBot {
	static class ReferenceElementsHelper {

		public static Form1 form1;
		public static Settings settings;

		public static void GetRef(ref Form1 y) {
			form1 = y;
		}

		public static void GetRef(ref Settings y) {
			settings = y;
		}

	}
}