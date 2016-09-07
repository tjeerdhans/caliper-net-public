using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ImsGlobal.Caliper.Entities;
using ImsGlobal.Caliper.Events;
using Newtonsoft.Json;
using NodaTime;
using NodaTime.Serialization.JsonNet;

namespace ImsGlobal.Caliper.Protocol
{
    internal class CaliperClient
    {
        private readonly CaliperEndpointOptions _options;
        private readonly string _sensorId;
        private readonly JsonSerializerSettings _serializerSettings;

        public CaliperClient(CaliperEndpointOptions options, string sensorId)
        {
            _options = options;
            _sensorId = sensorId;
            _serializerSettings = new JsonSerializerSettings();
            _serializerSettings.ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);
        }

        public async Task<bool> Send(IEnumerable<Event> events)
        {
            return await SendData(events);
        }

        public async Task<bool> Describe(IEnumerable<Entity> entities)
        {
            return await SendData(entities);
        }

        public async Task<bool> SendData<T>(IEnumerable<T> data)
        {
            var message = new CaliperMessage<T>
            {
                SensorId = _sensorId,
                SendTime = SystemClock.Instance.Now,
                Data = data
            };
            string json = JsonConvert.SerializeObject(message, _serializerSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = _options.Host;
                try
                {
                    HttpResponseMessage response = await client.PostAsync("", content);
                    response.EnsureSuccessStatusCode();
                }
                catch (HttpRequestException ex)
                {
                    var msg = String.Format("Failed to send data: {0}", ex.Message);
                    Trace.WriteLine(msg);
                    return false;
                }
            }

            return true;
        }
    }
}