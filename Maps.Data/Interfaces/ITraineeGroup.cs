using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps.Data.Interfaces
{
    public interface ITraineeGroup
    {
        int Id { get; set; }
        string Name { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        bool Selected { get; set; }
    }
}
