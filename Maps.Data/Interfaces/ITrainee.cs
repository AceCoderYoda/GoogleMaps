#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.ITrainee.cs
// Created On    ::    05/07/2018 09:34
// Altered On    ::    05/07/2018 09:38
// By            ::    Arjan Crielaard

#endregion

namespace Maps.Data.Interfaces
{
    public interface ITrainee
    {
        int Id { get; set; }
        string Name { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        bool Selected { get; set; }
    }
}