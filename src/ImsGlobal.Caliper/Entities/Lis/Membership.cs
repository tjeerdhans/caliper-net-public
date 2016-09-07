﻿using System.Collections.Generic;
using ImsGlobal.Caliper.Entities.Agent;
using ImsGlobal.Caliper.Entities.W3c;
using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Lis
{
    /// <summary>
    /// A Caliper Membership is used to define the relationship between
    /// objects that can have members and objects that can be members.
    /// Objects recognized as having members are CourseOffering,
    /// CourseSection and Group, all of which implement the IOrganization
    /// marker interface. Any Agent entity can be a member.
    /// </summary>
    public class Membership : Entity, IMembership<Person>
    {
        public Membership(string id)
            : base(id)
        {
            Type = EntityType.Membership;
            Roles = new List<IRole>();
        }

        [JsonProperty("member", Order = 21)]
        [JsonConverter(typeof(JsonIdConverter<Person>))]
        public Person Member { get; set; }

        [JsonProperty("organization", Order = 22)]
        [JsonConverter(typeof(JsonIdConverter<IOrganization>))]
        public IOrganization Organization { get; set; }

        [JsonProperty("roles", Order = 23)]
        public IList<IRole> Roles { get; set; }

        [JsonProperty("status", Order = 24)]
        public IStatus Status { get; set; }
    }
}