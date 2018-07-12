#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.Marker.cs
// Created On    ::    12/07/2018 09:22
// Altered On    ::    12/07/2018 09:24
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Newtonsoft.Json;

#endregion

namespace Maps.Data.Tools
{
    internal class Marker
    {
        [JsonProperty("position")] public LatLng Position { get; set; }

        [JsonProperty("label")] public string Label { get; set; }

        [JsonProperty("draggable")] public bool Draggable { get; set; }

        [JsonProperty("map")] public object Map { get; set; }
    }
}