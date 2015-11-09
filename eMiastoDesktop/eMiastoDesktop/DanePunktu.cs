using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMiastoDesktop {
	class DanePunktu {
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
		[JsonProperty("latitude")]
		public double Longitude {
			get { return this.longitude; }
			set { this.longitude = value; }
		}

		string altitude;
		[JsonProperty("altitude")]
		public string Altitude {
			get { return this.altitude; }
			set { this.altitude = value; }
		}

	}
}
