using KeepFit.ViewModels.Services;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace KeepFit.ViewModels
{
    public class RegisterViewModel //: ViewModelBase
    {
        private string _name;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                //Notify("Name");
            }
        }

        private DateTime _birthday;
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
                //Notify("Birthday");
            }
        }

        private bool _isMale;
        public bool IsMale
        {
            get
            {
                return _isMale;
            }
            set
            {
                _isMale = value;
                //Notify("IsMale");
            }
        }

        public ICommand RegisterCommand
        {
            get;
            set;
        }

        private readonly INavigationService _navigationService;
        public RegisterViewModel()
        {
            Name = "";
            Birthday = new DateTime(2000, 1, 1);
            RegisterCommand = new Command(Register);
            _navigationService = DependencyService.Get<INavigationService>();
        }

        private async void Register()
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new ChoiceView());
            await _navigationService.NavigateToChoice();
            Debug.WriteLine(Name + " " + Birthday.ToString() + " " + IsMale.ToString());
        }
    }
}
