using KeepFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.ViewModels.Services
{
    public interface INavigationService
    {
        //Task NavigateTo(string viewName, object param);

        Task NavigateToChoice();

        Task NavigateToLevelsView(MainModel mainModel, int whichTrainingPlanModel);

        Task NavigateToDaysView(MainModel mainModel, int whichTrainingPlanModel, int whichLevel);

        Task NavigateToSeriesView(MainModel mainModel, int whichTrainingPlanModel, int whichLevel, int whichDay);
    }
}
