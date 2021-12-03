using Newtonsoft.Json.Linq;

namespace SwaggerEndpointsParser
{
    internal class Root
    {
        public string openapi;
        public JObject info;
        public JObject paths;
        public JObject components;
        public JArray security;
    }
}
