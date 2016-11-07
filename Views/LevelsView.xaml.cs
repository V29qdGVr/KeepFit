using KeepFit.Models;
using KeepFit.ViewModels;
using Xamarin.Forms;

namespace KeepFit.Views
{
    public partial class LevelsView : ContentPage
    {
        public LevelsView(MainModel mainModel, int whichTrainingPlanModel)
        {
            InitializeComponent();

            BindingContext = new LevelsViewModel(mainModel, whichTrainingPlanModel);
        }
    }
}
