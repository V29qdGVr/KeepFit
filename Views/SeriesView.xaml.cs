using KeepFit.Models;
using KeepFit.ViewModels;
using Xamarin.Forms;

namespace KeepFit.Views
{
    public partial class SeriesView : ContentPage
    {
        public SeriesView(MainModel mainModel, int whichTrainingPlanModel, int whichLevel, int whichDay)
        {
            InitializeComponent();

            BindingContext = new SeriesViewModel(mainModel, whichTrainingPlanModel, whichLevel, whichDay);
        }
    }
}
