﻿using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Media
{
    [JsonConverter(typeof(JsonValueConverter<MediaObjectType>))]
    public sealed class MediaObjectType : IType, IJsonValue
    {
        public static readonly MediaObjectType AudioObject = new MediaObjectType("http://purl.imsglobal.org/caliper/v1/AudioObject");
        public static readonly MediaObjectType ImageObject = new MediaObjectType("http://purl.imsglobal.org/caliper/v1/ImageObject");
        public static readonly MediaObjectType VideoObject = new MediaObjectType("http://purl.imsglobal.org/caliper/v1/VideoObject");

        public MediaObjectType()
        {
        }

        public MediaObjectType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}