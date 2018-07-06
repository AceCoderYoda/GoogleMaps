using Maps.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps.Data
{
    public class TraineeGroup : ITraineeGroup
    {

        public TraineeGroup(int id, string name, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Selected = false;
            Group = new List<ITrainee>();
        }
       

        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Selected { get; set; }

        public void addTrainee(ITrainee trainee)
        {
            if(!Group.Contains(trainee))
            Group.Add(trainee);
        }

        public IList<ITrainee> Group { get;}
    }
}
