﻿using Newtonsoft.Json;

namespace weather.Model
{
    class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }
        [JsonProperty("lat")]
        public double Lat { get; set; }
    }
}