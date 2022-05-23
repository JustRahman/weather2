using Newtonsoft.Json;

namespace weather.Model
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}