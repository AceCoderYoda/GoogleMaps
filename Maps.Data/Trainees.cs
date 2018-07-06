#region ...   [Header]   ...

// Solution      ::    GoogleMaps
// Filename      ::    Maps.Data.ListOfTrainees.cs
// Created On    ::    05/07/2018 09:37
// Altered On    ::    05/07/2018 09:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;
using System.Linq;
using Maps.Data.Interfaces;

#endregion

namespace Maps.Data
{
    public class Trainees
    {
        private readonly IList<ITrainee> trainees = new List<ITrainee>();

        public Trainees()
        {
            trainees.Add(new Trainee(1, "Michiel", 51.58307, 4.7769505));
            trainees.Add(new Trainee(2, "Adjay", 53.033626, 4.790168));
            trainees.Add(new Trainee(3, "Tilly", 52.373800, 4.899672));
            trainees.Add(new Trainee(4, "Nick", 52.215276, 4.420897));
            trainees.Add(new Trainee(5, "Idris", 36.072566, -95.888664));
            trainees.Add(new Trainee(6, "Mark", 51.598880, 4.766995));
        }

        public List<ITrainee> Items => trainees.ToList();

        public void SetSelected(int index)
        {
            foreach (var trainee in Items) trainee.Selected = trainee.Id == index;
        }
    }
}