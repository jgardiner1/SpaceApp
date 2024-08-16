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

        private Dictionary<int, string> _months = new Dictionary<int, string>()
        {
            {1, "Jan" },
            {2, "Feb" },
            {3, "Mar" },
            {4, "Apr" },
            {5, "May" },
            {6, "Jun" },
            {7, "Jul" },
            {8, "Aug" },
            {9, "Sep" },
            {10, "Oct" },
            {11, "Nov" },
            {12, "Dec" },
        };

        public string ObservablesJoined
        {
            get { return Observables == null ? "Observed: Nothing" : "Observed: " + string.Join(", ", Observables); }
        }

        public string LengthJoined
        {
            get { return Length == null ? null: Length.ToString() + " hours";  }
        }

        public string DateFormatted
        {
            get { return $"{Date.Day} {_months[Date.Month]}, {Date.Year}"; }
        }
    }
}
