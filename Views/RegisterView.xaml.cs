using KeepFit.ViewModels;

using Xamarin.Forms;

namespace KeepFit.Views
{
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
        }
    }
}
