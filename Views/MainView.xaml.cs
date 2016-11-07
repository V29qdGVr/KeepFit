using KeepFit.ViewModels;

using Xamarin.Forms;

namespace KeepFit.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}
