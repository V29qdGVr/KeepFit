using KeepFit.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Views.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowMessage(string message)
        {
            await App.Current.MainPage.DisplayAlert("Keep Fit", message, "OK");
        }
    }
}
