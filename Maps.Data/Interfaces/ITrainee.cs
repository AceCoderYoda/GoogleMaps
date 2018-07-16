#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.ITrainee.cs
// Created On    ::    05/07/2018 09:34
// Altered On    ::    12/07/2018 12:01
// By            ::    Arjan Crielaard

#endregion

namespace Maps.Data.Interfaces
{
    public interface ITrainee : IIdentifiable, IGeo
    {
        string Group { get; set; }
    }
}