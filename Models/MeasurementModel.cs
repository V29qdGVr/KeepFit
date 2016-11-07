using System;

namespace KeepFit.Models
{
    public class MeasurementModel
    {
        public DateTime Date { get; set; }
        public int WeightMeasurement { get; set; }
        public int LeftCalfMeasurement { get; set; }
        public int RightCalfMeasurement { get; set; }
        public int LeftThighMeasurement { get; set; }
        public int RightThighMeasurement { get; set; }
        public int StomachMeasurement { get; set; }
        public int ChestMeasurement { get; set; }
        public int LeftBicepsMeasurement { get; set; }
        public int RightBicepsMeasurement { get; set; }

        public MeasurementModel()
        {
            Date = new DateTime();
        }
    }
}
