﻿using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities
{
    [JsonConverter(typeof(JsonValueConverter<DigitalResourceType>))]
    public sealed class DigitalResourceType : IType, IJsonValue
    {
        public static readonly DigitalResourceType AssignableDigitalResource = new DigitalResourceType("http://purl.imsglobal.org/caliper/v1/AssignableDigitalResource");
        public static readonly DigitalResourceType EpubChapter = new DigitalResourceType("http://www.idpf.org/epub/vocab/structure/#chapter");
        public static readonly DigitalResourceType EpubPart = new DigitalResourceType("http://www.idpf.org/epub/vocab/structure/#part");
        public static readonly DigitalResourceType EpubSubChapter = new DigitalResourceType("http://www.idpf.org/epub/vocab/structure/#subchapter");
        public static readonly DigitalResourceType EpubVolume = new DigitalResourceType("http://www.idpf.org/epub/vocab/structure/#volume");
        public static readonly DigitalResourceType Frame = new DigitalResourceType("http://purl.imsglobal.org/caliper/v1/Frame");
        public static readonly DigitalResourceType MediaLocation = new DigitalResourceType("http://purl.imsglobal.org/caliper/v1/MediaLocation");
        public static readonly DigitalResourceType MediaObject = new DigitalResourceType("http://purl.imsglobal.org/caliper/v1/MediaObject");
        public static readonly DigitalResourceType Reading = new DigitalResourceType("http://purl.imsglobal.org/caliper/v1/Reading");
        public static readonly DigitalResourceType WebPage = new DigitalResourceType("http://purl.imsglobal.org/caliper/v1/WebPage");

        public DigitalResourceType()
        {
        }

        public DigitalResourceType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}