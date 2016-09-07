﻿using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Media
{
    /// <summary>
    /// An audio object embedded in a web page.
    /// </summary>
    public class AudioObject : MediaObject, IAudioObject
    {
        public AudioObject(string id)
            : base(id, MediaObjectType.AudioObject)
        {
        }

        [JsonProperty("volumeMin", Order = 81)]
        public string VolumeMin { get; set; }

        [JsonProperty("volumeMax", Order = 82)]
        public string VolumeMax { get; set; }

        [JsonProperty("volumeLevel", Order = 83)]
        public string VolumeLevel { get; set; }

        [JsonProperty("muted", Order = 84)]
        public bool Muted { get; set; }
    }
}