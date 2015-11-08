using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMiastoDesktop {
	class DanePunktu {
		[JsonProperty("id")]
		public int id {
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

		string latitude;
		[JsonProperty("latitude")]
		public string Latitude {
			get { return this.latitude; }
			set { this.latitude = value; }
		}

		string longitude;
		[JsonProperty("latitude")]
		public string Longitude {
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
