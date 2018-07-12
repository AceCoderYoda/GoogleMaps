﻿#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.Trainee.cs
// Created On    ::    12/07/2018 07:24
// Altered On    ::    12/07/2018 08:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Maps.Data.Interfaces;

#endregion

namespace Maps.Data.Models
{
    public class Trainee : ITrainee
    {
        public Trainee(string id, string name, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Selected = false;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Selected { get; set; }
    }
}