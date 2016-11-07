using KeepFit.Models;
using KeepFit.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace KeepFit.Views.Services
{
    public class DayTemplateSelector : DataTemplateSelector
    {
        public List<int> DaysNumbers { get; set; }

        public DataTemplate PassedTemplate { get; set; }
        public DataTemplate NotPassedTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            int whichTrainingPlanModel = ((DaysViewModel)container.BindingContext).WhichTrainingPlanModel;
            int whichLevel = ((DaysViewModel)container.BindingContext).WhichLevel;
            int whichDay = (int)item;

            TrainingPlanModel trainingPlanModel = ((DaysViewModel)container.BindingContext).MainModel.TrainingPlanModels[whichTrainingPlanModel-1];
            // count the absolute number of the day in the whole training plan //
            int whichDayAbsolute = 0;
            for (int i = 0; i < whichLevel - 1; i++)
            {
                whichDayAbsolute += trainingPlanModel.Levels[i];
            }
            whichDayAbsolute += whichDay;
            // ------------------------------------------------------ //

            int userPassedDays = ((DaysViewModel)container.BindingContext).MainModel.User.ExercisesPassedDaysQuantities[whichTrainingPlanModel-1];

            //Debug.WriteLine("whichTrainingPlan = " + whichTrainingPlanModel
            //    + " whichLevel = " + whichLevel
            //    + " whichDay = " + whichDay
            //    + " userPassedDays = " + userPassedDays
            //    + " daysInFrontOfMe = " + whichDayAbsolute);


            if (whichDayAbsolute <= userPassedDays)
                return PassedTemplate;
            else
                return NotPassedTemplate;
        }
    }
}
