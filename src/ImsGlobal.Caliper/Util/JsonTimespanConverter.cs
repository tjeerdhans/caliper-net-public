using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ImsGlobal.Caliper.Util {

	internal sealed class JsonDurationConverter : JsonConverter {

		public override bool CanRead {
			get { return false; }
		}

		public override bool CanWrite {
			get { return true; }
		}

		public override bool CanConvert( Type objectType ) {
			return objectType == typeof( TimeSpan ) || objectType == typeof( TimeSpan? );
		}

		public override object ReadJson(
			JsonReader reader,
			Type objectType,
			object existingValue,
			JsonSerializer serializer ) {

			throw new NotImplementedException();
		}

		public override void WriteJson(
			JsonWriter writer,
			object value,
			JsonSerializer serializer ) {

			var period = (NodaTime.Period)value;
			var tsString = period.ToXsdDuration();
			serializer.Serialize( writer, tsString );
		}

	}

}
