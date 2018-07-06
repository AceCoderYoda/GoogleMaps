using Maps.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps.Data
{
    public class TraineGroups
    {
        private readonly IList<ITraineeGroup> traineeGroup = new List<ITraineeGroup>();

        public TraineGroups()
        {
           var Rotterdam = new TraineeGroup(8,"MostDevRotterdam", 52.215276, 4.420897);
            Rotterdam.addTrainee(new Trainee(1, "Michiel", 51.58307, 4.7769505));
            Rotterdam.addTrainee(new Trainee(2, "Adjay", 53.033626, 4.790168));
            Rotterdam.addTrainee(new Trainee(3, "Tilly", 52.373800, 4.899672));
            Rotterdam.addTrainee(new Trainee(4, "Nick", 52.215276, 4.420897));
            Rotterdam.addTrainee(new Trainee(5, "Idris", 36.072566, -95.888664));
            Rotterdam.addTrainee(new Trainee(6, "Mark", 51.598880, 4.766995));
            traineeGroup.Add(Rotterdam);
        

            var Amsterdam = new TraineeGroup(7, "MostDevAmsterdam", 51, 51);
            Amsterdam.addTrainee(new Trainee(1, "Bart", 51.58307, 4.7769505));
            Amsterdam.addTrainee(new Trainee(2, "Karin", 53.033626, 4.790168));
            Amsterdam.addTrainee(new Trainee(3, "Emiel", 52.373800, 4.899672));
            Amsterdam.addTrainee(new Trainee(4, "Laurette", 52.215276, 4.420897));
            Amsterdam.addTrainee(new Trainee(5, "Wendy", 36.072566, -95.888664));
            Amsterdam.addTrainee(new Trainee(6, "Leendert", 51.598880, 4.766995));
            traineeGroup.Add(Amsterdam);
        }

        public IList<ITraineeGroup> Items => traineeGroup;

        public void SetSelected(int index)
        {
            foreach (var traineeGroup in Items) traineeGroup.Selected = traineeGroup.Id == index;
        }



        //private readonly IList<ITrainee> trainees = new List<ITrainee>();

        //public Trainees()
        //{
        //    trainees.Add(new Trainee(1, "Michiel", 51.58307, 4.7769505));
        //    trainees.Add(new Trainee(2, "Adjay", 53.033626, 4.790168));
        //    trainees.Add(new Trainee(3, "Tilly", 52.373800, 4.899672));
        //    trainees.Add(new Trainee(4, "Nick", 52.215276, 4.420897));
        //    trainees.Add(new Trainee(5, "Idris", 36.072566, -95.888664));
        //    trainees.Add(new Trainee(6, "Mark", 51.598880, 4.766995));
        //}

        //public List<ITrainee> Items => trainees.ToList();

        //public void SetSelected(int index)
        //{
        //    foreach (var trainee in Items) trainee.Selected = trainee.Id == index;
        //}
    }
}
