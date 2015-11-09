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

namespace eMiastoDesktop {
	public partial class ListaPunktow : Form {
		private BindingList<DanePunktu> lista;
		public ListaPunktow() {
			InitializeComponent();
			lista = new BindingList<DanePunktu>();
			gridLista.DataSource = lista;
		}
		
		private void btnDodaj_Click(object sender, EventArgs e) {
			using (SimpleBrowserForm nowa = new SimpleBrowserForm()) {
				nowa.ShowDialog();
				var match = Regex.Match(nowa.browser.Address, @"http.*/@(?<lat>-?\d*\.\d*),(?<lon>-?\d*\.\d*),(?<zzz>\d*z).*");
				if (match.Success) {
					double lat2;
					double.TryParse(match.Groups["lat"].Value.Replace('.', ','), out lat2);
					double lon2;
					double.TryParse(match.Groups["lon"].Value.Replace('.', ','), out lon2);
					var zzz2 = match.Groups["zzz"].Value;
					var id = lista.Count + 1;
					lista.Add(new DanePunktu() {
						Id = id,
						Altitude = zzz2,
						Latitude = lat2,
						Longitude = lon2
					});
				}
			}
		}
	}
}
