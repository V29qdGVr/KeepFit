using KeepFit.Models;
using KeepFit.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace KeepFit.ViewModels
{
    public class DaysViewModel
    {
        public ICommand NavigateToSeriesViewCommand { get; set; }
        public MainModel MainModel { get; set; }
        public int WhichTrainingPlanModel { get; set; }
        public int WhichLevel { get; set; }
        public List<int> DaysNumbers { get; set; }


        private readonly IMessageService _messageService;
        private readonly INavigationService _navigationService;
        public DaysViewModel(MainModel mainModel, int whichTrainingPlanModel, int whichLevel)
        {
            _messageService = DependencyService.Get<IMessageService>();
            _messageService.ShowMessage("Remember to make at least 1 day break between every training." + 
                "\n\nHowever, you can join different kinds of trainings at one day.");

            _navigationService = DependencyService.Get<INavigationService>();
            NavigateToSeriesViewCommand = new Command((parameter) =>
            {
                int whichDay = Int32.Parse(parameter.ToString());
                _navigationService.NavigateToSeriesView(mainModel, whichTrainingPlanModel, whichLevel, whichDay);
            });

            MainModel = mainModel;
            WhichTrainingPlanModel = whichTrainingPlanModel;
            WhichLevel = whichLevel;

            DaysNumbers = new List<int>();
            for (int i = 1; i <= MainModel.TrainingPlanModels[WhichTrainingPlanModel-1].Levels[whichLevel-1]; i++)
            {
                DaysNumbers.Add(i);
            }
        }
    }
}
