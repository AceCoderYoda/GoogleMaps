#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.IGeo.cs
// Created On    ::    12/07/2018 12:01
// Altered On    ::    12/07/2018 12:01
// By            ::    Arjan Crielaard

#endregion

namespace Maps.Data.Interfaces
{
    public interface IGeo
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}