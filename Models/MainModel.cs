using System.Collections.Generic;

namespace KeepFit.Models
{
    public class MainModel
    {
        public UserModel User { get; set; }
        //public TrainingPlanModel CrunchesPlan { get; set; }
        //public TrainingPlanModel PullUpsPlan { get; set; }
        //public TrainingPlanModel PushUpsPlan { get; set; }
        //public TrainingPlanModel SquatsPlan { get; set; }
        public List<TrainingPlanModel> TrainingPlanModels { get; set; }

        public MainModel()
        {
            User = new UserModel();
            //CrunchesPlan = new TrainingPlanModel("KeepFit.Resources.CrunchesData.txt");
            //PullUpsPlan = new TrainingPlanModel("KeepFit.Resources.PullUpsData.txt");
            //PushUpsPlan = new TrainingPlanModel("KeepFit.Resources.PushUpsData.txt");
            //SquatsPlan = new TrainingPlanModel("KeepFit.Resources.SquatsData.txt");
            TrainingPlanModels = new List<TrainingPlanModel>();
            TrainingPlanModels.Add(new TrainingPlanModel("KeepFit.Resources.CrunchesData.txt"));
            TrainingPlanModels.Add(new TrainingPlanModel("KeepFit.Resources.PullUpsData.txt"));
            TrainingPlanModels.Add(new TrainingPlanModel("KeepFit.Resources.PushUpsData.txt"));
            TrainingPlanModels.Add(new TrainingPlanModel("KeepFit.Resources.SquatsData.txt"));
        }
    }
}
