using System;

namespace ImsGlobal.Caliper
{
    /// <summary>
    /// Options for registering a Caliper endpoint with the Caliper sensor.
    /// </summary>
    public class CaliperEndpointOptions
    {
        private const int DefaultTimeout = 10000;

        public CaliperEndpointOptions(Uri host, string apiKey = null, int timeout = DefaultTimeout)
        {
            if (host == null)
            {
                throw new ArgumentNullException("host");
            }
            if (timeout < 1000)
            {
                throw new ArgumentOutOfRangeException("timeout", "timeout must be at least 1000 milliseconds.");
            }

            Host = host;
            ApiKey = apiKey;
            Timeout = timeout;
        }

        /// <summary>
        /// The Caliper web API endpoint.
        /// </summary>
        public Uri Host { get; set; }

        /// <summary>
        /// The Caliper web API key.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Connection timeout in milliseconds.
        /// </summary>
        public int Timeout { get; set; }
    }
}