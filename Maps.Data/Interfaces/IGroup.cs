#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.IGroup.cs
// Created On    ::    12/07/2018 07:16
// Altered On    ::    12/07/2018 07:35
// By            ::    Arjan Crielaard

#endregion

using System.Collections.Generic;
using System.Xml.Linq;

namespace Maps.Data.Interfaces
{
    public interface IGroup
    {
        string Id { get; set; }
        string Name { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        bool Selected { get; set; }
        IList<ITrainee> Trainees { get; }

        void AddTrainee(XElement traineeXElement);
        void AddTrainee(ITrainee trainee);

    }
}