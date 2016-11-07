using KeepFit.Models;
using KeepFit.ViewModels.Services;
using System.Threading.Tasks;

namespace KeepFit.Views.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateToChoice()
        {
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new MainView());
        }

        public async Task NavigateToLevelsView(MainModel mainModel, int whichTrainingPlanModel)
        {
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new LevelsView(mainModel, whichTrainingPlanModel));
        }

        public async Task NavigateToDaysView(MainModel mainModel, int whichTrainingPlanModel, int whichLevel)
        {
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new DaysView(mainModel, whichTrainingPlanModel, whichLevel));
        }

        public async Task NavigateToSeriesView(MainModel mainModel, int whichTrainingPlanModel, int whichLevel, int whichDay)
        {
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new SeriesView(mainModel, whichTrainingPlanModel, whichLevel, whichDay));
        }
    }
}
