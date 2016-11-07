using System;
using System.Collections.Generic;

namespace KeepFit.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsMale { get; set; }
        //public int CrunchesPassedDaysQuantity { get; set; }
        //public int PullUpsPassedDaysQuantity { get; set; }
        //public int PushUpsPassedDaysQuantity { get; set; }
        //public int SquatsPassedDaysQuantity { get; set; }
        public List<int> ExercisesPassedDaysQuantities { get; set; }
        public List<MeasurementModel> Measurements { get; set; }

        public UserModel()
        {
            Birthday = new DateTime();
            ExercisesPassedDaysQuantities = new List<int>();
            Measurements = new List<MeasurementModel>();
            //CrunchesPassedDaysQuantity = 24;
            //PullUpsPassedDaysQuantity = 25;
            //PushUpsPassedDaysQuantity = 26;
            //SquatsPassedDaysQuantity = 27;
            //WCZYTAĆ DANE Z SQLITE
            ExercisesPassedDaysQuantities.Add(24);
            ExercisesPassedDaysQuantities.Add(25);
            ExercisesPassedDaysQuantities.Add(26);
            ExercisesPassedDaysQuantities.Add(27);
        }
    }
}
