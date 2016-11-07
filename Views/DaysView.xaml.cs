using KeepFit.Models;
using KeepFit.ViewModels;
using Xamarin.Forms;

namespace KeepFit.Views
{
    public partial class DaysView : ContentPage
    {
        public DaysView(MainModel mainModel, int whichTrainingPlanModel, int whichLevel)
        {
            InitializeComponent();

            BindingContext = new DaysViewModel(mainModel, whichTrainingPlanModel, whichLevel);
        }
    }
}
