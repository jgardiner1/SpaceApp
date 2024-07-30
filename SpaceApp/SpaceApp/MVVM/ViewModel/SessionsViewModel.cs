using SpaceApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceApp.MVVM.ViewModel
{
    internal class SessionsViewModel
    {

        public ObservableCollection<SessionModel> Sessions { get; set; }

        public SessionsViewModel()
        {
            Sessions = new ObservableCollection<SessionModel>();

            Sessions.Add(new SessionModel
            {
                SessionName = "My SkyWatching Session",
                DateTime = DateTime.Now,
                Location = "Canvey Island",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Jupiter", "Mars", "Moon" },
                ImageSource = "../../Images/Amateur Space Image.jpeg"
            }) ;
            Sessions.Add(new SessionModel
            {
                SessionName = "My SkyWatching Session",
                DateTime = DateTime.Now,
                Location = "Canvey Island",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Jupiter", "Mars", "Moon" }
            });
            Sessions.Add(new SessionModel
            {
                SessionName = "My SkyWatching Session",
                DateTime = DateTime.Now,
                Location = "Canvey Island",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Jupiter", "Mars", "Moon" }
            });
            Sessions.Add(new SessionModel
            {
                SessionName = "My SkyWatching Session",
                DateTime = DateTime.Now,
                Location = "Canvey Island",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Jupiter", "Mars", "Moon" }
            });
            Sessions.Add(new SessionModel
            {
                SessionName = "My SkyWatching Session",
                DateTime = DateTime.Now,
                Location = "Canvey Island",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Jupiter", "Mars", "Moon" }
            });
        }
    }
}
