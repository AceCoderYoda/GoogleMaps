#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.IIdentifiable.cs
// Created On    ::    12/07/2018 12:00
// Altered On    ::    12/07/2018 12:00
// By            ::    Arjan Crielaard

#endregion

namespace Maps.Data.Interfaces
{
    public interface IIdentifiable
    {
        string Id { get; set; }
        string Name { get; set; }
    }
}