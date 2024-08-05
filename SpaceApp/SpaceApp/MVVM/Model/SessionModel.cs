using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SpaceApp.MVVM.Model
{
    internal class SessionModel
    {
        public string SessionName { get; set; }
        public DateTime DateTime { get; set; }
        public int ?SessionLength { get; set;}
        public string Location { get; set; }
        public string WeatherCondition { get; set; }
        public string SkyCondition { get; set; }
        public string[] Observables { get; set; }
        public string ImageSource { get; set; }

        public string ObservablesJoined
        {
            get { return Observables == null ? "Observed: Nothing" : "Observed: " + string.Join(", ", Observables); }
        }

        public string SessionLengthJoined
        {
            get { return SessionLength == null ? null: SessionLength.ToString() + " hours";  }
        }

    }
}
