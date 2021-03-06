﻿#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.Factory.cs
// Created On    ::    12/07/2018 07:24
// Altered On    ::    12/07/2018 08:39
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using Maps.Data.Interfaces;
using Maps.Data.Models;
using Maps.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

#endregion

namespace Maps.Data
{
    public class Factory
    {
        public Factory()
        {
            TraineeGroups = new List<IGroup>();
        }

        public IList<IGroup> TraineeGroups { get; }

        public string Source => JsonConvert.SerializeObject(TraineeGroups, Formatting.Indented);

        public void Initialize()
        {
            var xml = Reader.GetResourceFile("datasource.xml");
            var xdoc = XDocument.Parse(xml);

            foreach (var groupXElement in xdoc.Root.Elements())
            {
                var group = CreateGroup(groupXElement);
                foreach (var traineeXElement in groupXElement.Element("Trainees").Elements())
                    group.AddTrainee(traineeXElement);
                TraineeGroups.Add(group);
            }
        }

        public IList<ITrainee> Sort(string sortOrder, string search)
        {
            var trainees = Trainees;
            if (!string.IsNullOrEmpty(search))
            {
                trainees = trainees.Where(s => s.Name.ToLower().Contains(search.ToLower())
                                               || s.Group.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            switch (sortOrder)
            {
                case "name_desc":
                    trainees = trainees.OrderByDescending(s => s.Name).ToList();
                    break;
                case "group":
                    trainees = trainees.OrderBy(s => s.Group.Name).ToList();
                    break;
                case "group_desc":
                    trainees = trainees.OrderByDescending(s => s.Group.Name).ToList();
                    break;
                default:
                    trainees = trainees.OrderBy(s => s.Name).ToList();
                    break;
            }

            return trainees;
        }


        public IList<ITrainee> Trainees
        {
            get
            {
                var result = new List<ITrainee>();
                foreach (var traineeGroup in TraineeGroups)
                {
                    result.AddRange(traineeGroup.Trainees);
                }

                return result;
            }
        }

        public string Markers()
        {
            var markers = new List<Marker>();
            foreach (var traineeGroup in TraineeGroups)
            {
                var list = traineeGroup.Trainees.Select(t => new Marker()
                {
                    Draggable = true,
                    Label = t.Name,
                    Position = new LatLng() { Lng = t.Longitude, Lat = t.Latitude },
                    Map = null
                });

                markers.AddRange(list);
            }

            return JsonConvert.SerializeObject(markers);

        }


        private IGroup CreateGroup(XElement group)
        {
            return new Group(group.Attribute("Id").Value, group.Attribute("Name").Value,
                Convert.ToDouble(group.Element("Geo").Element("Lat").Value),
                Convert.ToDouble(group.Element("Geo").Element("Lng").Value));
        }

        public IGroup FirstOrDefault()
        {
            return TraineeGroups.FirstOrDefault();
        }

        public void Update()
        {
            if (TraineeGroups.Count == 0)
            {
                Initialize();
            }
        }

        public ITrainee this[string id]
        {
            get { return Trainees.FirstOrDefault(t => t.Id == id); }
        }

        public void Save(ITrainee trainee)
        {
          
        }
    }
}