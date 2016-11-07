using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace KeepFit.Models
{
    public class TrainingPlanModel
    {
        public List<int> Levels { get; set; }
        public List<int> Days { get; set; }
        public List<int> Series { get; set; }

        public TrainingPlanModel(string dataPath)
        {
            Levels = new List<int>();
            Days = new List<int>();
            Series = new List<int>();

            var assembly = typeof(TrainingPlanModel).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(dataPath);
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
                string[] data = text.Split(';');
                //Debug.WriteLine("Pierwsza część tekstu: " + data[0]);
                //Debug.WriteLine("Druga część tekstu: " + data[1]);
                //Debug.WriteLine("Trzeecia część tekstu: " + data[2]);
                putIntegersFromStringToList(data[0], Levels);
                putIntegersFromStringToList(data[1], Days);
                putIntegersFromStringToList(data[2], Series);
            }

            Debug.WriteLine(Levels.Count);
            Debug.WriteLine(Days.Count);
            Debug.WriteLine(Series.Count);
        }

        private void putIntegersFromStringToList(string text, List<int> list)
        {
            string variable = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i] != '\t' && text[i] != '\n' && text[i] != '\r')
                {
                    variable += text[i];
                }
                else
                {
                    if (variable != "")
                    {
                        int number = int.Parse(variable);
                        variable = "";
                        //Debug.WriteLine(number);
                        list.Add(number);
                    }
                }
            }
            if (variable != "")
            {
                int number = int.Parse(variable);
                variable = "";
                //Debug.WriteLine(number);
                list.Add(number);
            }
        }
    }
}
