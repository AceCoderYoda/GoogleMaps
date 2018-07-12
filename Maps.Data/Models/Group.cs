#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.Group.cs
// Created On    ::    12/07/2018 07:24
// Altered On    ::    12/07/2018 08:22
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Maps.Data.Interfaces;
using Newtonsoft.Json;

#endregion

namespace Maps.Data.Models
{
    public class Group : IGroup
    {
        public Group(string id, string name, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Trainees = new List<ITrainee>();
        }

        public IList<ITrainee> Trainees { get; }


        public string Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }



        public void AddTrainee(XElement traineeXElement)
        {
            var trainee = new Trainee(traineeXElement.Attribute("Id").Value, traineeXElement.Attribute("Name").Value,
                Convert.ToDouble(traineeXElement.Element("Geo").Element("Lat").Value),
                Convert.ToDouble(traineeXElement.Element("Geo").Element("Lng").Value));

            AddTrainee(trainee);
        }

        public void AddTrainee(ITrainee trainee)
        {
            if (!Trainees.Contains(trainee))
                Trainees.Add(trainee);
        }
    }
}