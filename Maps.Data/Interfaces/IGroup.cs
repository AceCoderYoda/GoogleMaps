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
    public interface IGroup: IIdentifiable, IGeo
    {
        ICollection<ITrainee> Trainees { get; }

        void AddTrainee(XElement traineeXElement);
        void AddTrainee(ITrainee trainee);

    }
}