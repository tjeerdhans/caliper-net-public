﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Response
{
    public class FillInBlankResponse : Response
    {
        public FillInBlankResponse(string id)
            : base(id)
        {
            Type = ResponseType.FillInBlank;
        }

        [JsonProperty("values", Order = 31)]
        public IList<string> Values { get; set; }
    }
}