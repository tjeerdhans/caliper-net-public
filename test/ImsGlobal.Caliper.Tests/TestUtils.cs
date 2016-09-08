using System;
using System.IO;
using System.Reflection;

namespace ImsGlobal.Caliper.Tests
{
    internal static class TestUtils
    {
        public static string LoadReferenceJsonFile(string refJsonName)
        {
            var assembly = typeof(TestUtils).GetTypeInfo().Assembly;
            var resourceName = "ImsGlobal.Caliper.Tests.ReferenceJson." + refJsonName + ".json";

            string content;

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new Exception($"Could not load reference json resource ({resourceName}).");
                }
                using (var reader = new StreamReader(stream))
                {
                    content = reader.ReadToEnd();
                }
            }
            return content;
        }
    }
}