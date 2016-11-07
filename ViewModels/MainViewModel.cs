using KeepFit.Models;
using KeepFit.ViewModels.Services;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace KeepFit.ViewModels
{
    public class MainViewModel //: ViewModelBase
    {
        public ICommand NavigateToLevelsViewCommand { get; set; }
        public MainModel MainModel { get; set; }

        private readonly INavigationService _navigationService;
        public MainViewModel()
        {
            _navigationService = DependencyService.Get<INavigationService>();
            NavigateToLevelsViewCommand = new Command((parameter) =>
            {
                int whichTrainingPlanModel = Int32.Parse(parameter.ToString());
                _navigationService.NavigateToLevelsView(MainModel, whichTrainingPlanModel);
            });

            MainModel = new MainModel();
        }
    }
}
