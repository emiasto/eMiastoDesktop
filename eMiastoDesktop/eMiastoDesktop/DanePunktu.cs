using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMiastoDesktop {
	class DanePunktu : INotifyPropertyChanged {
		int id;
		[JsonProperty("id")]
		public int Id {
			get { return this.id; }
			set { this.id = value; }
		}

		string name;
		[JsonProperty("name")]
		public string Name {
			get { return this.name; }
			set { this.name = value; }
		}

		string description;
		[Browsable(false)]
		[JsonProperty("description")]
		public string Description {
			get { return this.description; }
			set { this.description = value; }
		}

		double latitude;
		[JsonProperty("latitude")]
		public double Latitude {
			get { return this.latitude; }
			set { this.latitude = value; }
		}

		double longitude;
		[JsonProperty("longitude")]
		public double Longitude {
			get { return this.longitude; }
			set { this.longitude = value; }
		}

		double altitude;
		[JsonProperty("altitude")]
		public double Altitude {
			get { return this.altitude; }
			set { this.altitude = value; }
		}


		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string p) {
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(p));
		}

	}

	class KolekcjaPunktow {
		[JsonProperty("ListaPunktow")]
		public BindingList<DanePunktu> ListaPunktow { get; set; }

		public KolekcjaPunktow() {
			this.ListaPunktow = new BindingList<DanePunktu>();
		}
	}
}
