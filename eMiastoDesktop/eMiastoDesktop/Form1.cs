using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace eMiastoDesktop {
	public partial class Form1 : Form {
		[DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
		private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
		const int URLMON_OPTION_USERAGENT = 0x10000001;

		public void ChangeUserAgent(string Agent) {
			UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, Agent, Agent.Length, 0);
		}

		private BindingList<DanePunktu> lista = new BindingList<DanePunktu>();

		public Form1() {
			InitializeComponent();
			gridLista.DataSource = lista;
		}

		private void btnSzukaj_Click(object sender, EventArgs e) {


			StringBuilder add = new StringBuilder("http://maps.google.com?q=");

			add.Append(txtMiasto.Text);
			webBrowser.Navigate(add.ToString());
		}

		private void btnDodaj_Click(object sender, EventArgs e) {

			var match = Regex.Match(webBrowser.Url.ToString(), @"http.*/@(?<lat>-?\d*\.\d*),(?<lon>-?\d*\.\d*),(?<zzz>\d*z).*");
			var lat2 = match.Groups["lat"].Value;
			var lon2 = match.Groups["lon"].Value;
			var zzz2 = match.Groups["zzz"].Value;
			var id = lista.Count + 1;
			lista.Add(new DanePunktu() { 
				id = id,
				 Altitude = zzz2,
				 Latitude = lat2,
				 Longitude = lon2
			});
			
		}

	}
}
