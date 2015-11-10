using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
				if (lista.Count > 0) {
					nowa.defaulturl = "http://www.maps.google.com?q="+lista.Last().Latitude.ToString().Replace(',','.')+" "+lista.Last().Longitude.ToString().Replace(',','.');
				}
				nowa.ShowDialog();
				var wyciety = nowa.browser.Address.Substring(nowa.browser.Address.IndexOf("/@"), (nowa.browser.Address.IndexOf('z', nowa.browser.Address.IndexOf("/@")) - nowa.browser.Address.IndexOf("/@"))).Substring(2);
				var listawycietych = wyciety.Split(',');
				if (listawycietych.Count() == 3) {
					double latitude;
					double.TryParse(listawycietych[0].Replace('.', ','), out latitude);
					double longitude;
					double.TryParse(listawycietych[1].Replace('.', ','), out longitude);
					var request = (HttpWebRequest) WebRequest.Create(string.Format("https://maps.googleapis.com/maps/api/elevation/json?locations={0},{1}", latitude.ToString().Replace(",", "."), longitude.ToString().Replace(",", ".")));
					var response = (HttpWebResponse) request.GetResponse();
					var sr = new StreamReader(response.GetResponseStream() ?? new MemoryStream()).ReadToEnd();
					JObject json = JObject.Parse(sr);

					double altitude = Convert.ToDouble((from f in json["results"].Children()
														select
														(string) f["elevation"]
									  ).SingleOrDefault().Replace('.', ','));
					var id = lista.Count + 1;
					if (lista.Any(x => x.Longitude == longitude && x.Latitude == latitude)) {
						MessageBox.Show("Taki punkt już istnieje na liście. Proszę dodać inny", "Ostrzeżenie", MessageBoxButtons.OK);
					} else {
						lista.Add(new DanePunktu() {
							Id = id,
							Altitude = altitude,
							Latitude = latitude,
							Longitude = longitude
						});
					}
				}
			}
		}

		private void btnPrzelicz_Click(object sender, EventArgs e) {
			lista.ToList().ForEach(item => {
				if (item.Altitude == 0) {
					var request = (HttpWebRequest) WebRequest.Create(string.Format("https://maps.googleapis.com/maps/api/elevation/json?locations={0},{1}", item.Latitude.ToString().Replace(",", "."), item.Longitude.ToString().Replace(",", ".")));
					var response = (HttpWebResponse) request.GetResponse();
					var sr = new StreamReader(response.GetResponseStream() ?? new MemoryStream()).ReadToEnd();
					JObject json = JObject.Parse(sr);

					double altitude = Convert.ToDouble((from f in json["results"].Children()
														select
														(string) f["elevation"]
									  ).SingleOrDefault().Replace('.', ','));
					item.Altitude = altitude;
				}
			});
		}
	}
}
