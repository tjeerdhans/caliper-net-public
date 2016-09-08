using ImsGlobal.Caliper.Entities;
using ImsGlobal.Caliper.Entities.Agent;
using ImsGlobal.Caliper.Events;
using ImsGlobal.Caliper.Protocol;
using ImsGlobal.Caliper.Tests.SimpleHelpers;
using Xunit;

namespace ImsGlobal.Caliper.Tests
{
    public class MinimalEventTest
    {
        [Fact]
        public void MinimalEvent_MatchesReferenceJson()
        {
            var @object = new BaseEntity("https://example.com/viewer/book/34843#epubcfi(/4/3)")
            {
                Type = new EntityType("http://www.idpf.org/epub/vocab/structure/#volume")
            };

            var actor = new Agent("https://example.edu/user/554433")
            {
                Type = new EntityType("http://purl.imsglobal.org/caliper/v1/lis/Person")
            };

            var @event = new BaseEvent
            {
                Actor = actor,
                Action = Action.Viewed,
                Object = @object,
                EventTime = TestEntities.DefaultStartedAtTime
            };

            var caliperMessage = new CaliperMessage<BaseEvent>
            {
                SensorId = "https://example.edu/sensor/001",
                SendTime = TestEntities.DefaultSendTime,
                Data = new[] { @event }
            };

            JsonAssertions.AssertSameObjectJson(caliperMessage, "caliperEnvelopeEventViewViewedMinimal");
        }
    }
}