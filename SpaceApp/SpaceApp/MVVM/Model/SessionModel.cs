using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SpaceApp.MVVM.Model
{
    public class SessionModel
    {
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public int ?Length { get; set;}
        public string Location { get; set; }
        public string WeatherCondition { get; set; }
        public string SkyCondition { get; set; }
        public string[] Observables { get; set; }
        public string ImageSource { get; set; }

        public string ObservablesJoined
        {
            get { return Observables == null ? "Observed: Nothing" : "Observed: " + string.Join(", ", Observables); }
        }

        public string LengthJoined
        {
            get { return Length == null ? null: Length.ToString() + " hours";  }
        }

    }
}
