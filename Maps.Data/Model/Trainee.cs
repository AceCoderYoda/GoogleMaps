#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.Trainee.cs
// Created On    ::    05/07/2018 09:37
// Altered On    ::    05/07/2018 09:38
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Maps.Data.Interfaces;

#endregion

namespace Maps.Data.Model
{
    public class Trainee : ITrainee
    {
        public Trainee(int id, string name, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Selected = false;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Selected { get; set; }
    }
}