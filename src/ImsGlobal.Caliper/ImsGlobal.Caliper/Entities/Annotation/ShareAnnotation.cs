using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation {

	public class ShareAnnotation : Annotation {

        public ShareAnnotation(string id)
			: base( id ) {
			this.Type = AnnotationType.Shared.Uri;
            this.WithAgents = new List<string>();
		}

		[JsonProperty( "withAgents", Order = 31 )]
        public IList<string> WithAgents { get; set; }

	}
}
