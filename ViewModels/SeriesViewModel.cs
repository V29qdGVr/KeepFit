using KeepFit.Models;
using KeepFit.ViewModels.Services;
using System.Collections.Generic;
using Xamarin.Forms;

namespace KeepFit.ViewModels
{
    public class SeriesViewModel
    {
        public MainModel MainModel { get; set; }
        public int WhichTrainingPlanModel { get; set; }
        public int WhichLevel { get; set; }
        public int WhichDay { get; set; }
        public List<int> SeriesValues { get; set; }


        private readonly IMessageService _messageService;
        public SeriesViewModel(MainModel mainModel, int whichTrainingPlanModel, int whichLevel, int whichDay)
        {
            _messageService = DependencyService.Get<IMessageService>();
            _messageService.ShowMessage("Remember to make at least 2 minute break between every series." + 
                "\n\nThe last value is the minimum, try doing more repetitions.");

            MainModel = mainModel;
            WhichTrainingPlanModel = whichTrainingPlanModel;
            WhichLevel = whichLevel;
            WhichDay = whichDay;

            SeriesValues = new List<int>();
            fillSeriesValues();
        }

        private void fillSeriesValues()
        {
            // count how many days are in front of me
            int days = 0;            
            for (int i = 0; i < WhichLevel - 1; i++)
            {
                days += MainModel.TrainingPlanModels[WhichTrainingPlanModel-1].Levels[i];
            }
            days += WhichDay - 1;

            // count how many series are in front of me
            int series = 0;
            for (int i = 0; i < days; i++)
                series += MainModel.TrainingPlanModels[WhichTrainingPlanModel-1].Days[i];

            int startIndex = series; // start of the interval
            int currentDaySeries = MainModel.TrainingPlanModels[WhichTrainingPlanModel-1].Days[days]; // series quantity of the current day
            int endIndex = startIndex + currentDaySeries; // the index standing after the end of the interval

            for (int i = startIndex; i < endIndex; i++)
                SeriesValues.Add(MainModel.TrainingPlanModels[WhichTrainingPlanModel-1].Series[i]);
        }
    }
}
