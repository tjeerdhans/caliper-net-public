﻿using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation
{
    public class BookmarkAnnotation : Annotation
    {
        public BookmarkAnnotation(string id)
            : base(id)
        {
            Type = AnnotationType.Bookmark;
        }

        [JsonProperty("bookmarkNotes", Order = 31)]
        public string BookmarkNotes { get; set; }
    }
}