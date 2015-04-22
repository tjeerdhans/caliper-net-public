using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImsGlobal.Caliper.Entities.Lis {

	public sealed class Status {

		public static readonly Status Active = new Status( "http://purl.imsglobal.org/vocab/lis/v2/status#Active" );
		public static readonly Status Deleted = new Status( "http://purl.imsglobal.org/vocab/lis/v2/status#Deleted" );
		public static readonly Status Inactive = new Status( "http://purl.imsglobal.org/vocab/lis/v2/status#Inactive" );

		private Status( string value ) {
			this.Value = value;
		}

		public string Value { get; private set; }
	}

}
