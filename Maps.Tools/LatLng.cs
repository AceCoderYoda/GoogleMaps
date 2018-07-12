#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.LatLng.cs
// Created On    ::    12/07/2018 08:32
// Altered On    ::    12/07/2018 08:33
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Newtonsoft.Json;

#endregion

namespace Maps.Tools
{
    public class LatLng
    {
        [JsonProperty("lat")] public double Lat { get; set; }

        [JsonProperty("lng")] public double Lng { get; set; }
    }
}