using KeepFit.Models;
using KeepFit.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace KeepFit.ViewModels
{
    public class LevelsViewModel
    {
        public ICommand NavigateToDaysViewCommand { get; set; }
        public MainModel MainModel { get; set; }
        public int WhichTrainingPlanModel { get; set; }
        public List<int> LevelsNumbers { get; set; }


        private readonly INavigationService _navigationService;
        public LevelsViewModel(MainModel mainModel, int whichTrainingPlanModel)
        {
            _navigationService = DependencyService.Get<INavigationService>();
            NavigateToDaysViewCommand = new Command((parameter) =>
            {
                int whichLevel = Int32.Parse(parameter.ToString());
                _navigationService.NavigateToDaysView(mainModel, whichTrainingPlanModel, whichLevel);
            });

            MainModel = mainModel;
            WhichTrainingPlanModel = whichTrainingPlanModel;

            LevelsNumbers = new List<int>();
            for (int i = 1; i <= MainModel.TrainingPlanModels[WhichTrainingPlanModel-1].Levels.Count; i++)
            {
                LevelsNumbers.Add(i);
            }
        }
    }
}
