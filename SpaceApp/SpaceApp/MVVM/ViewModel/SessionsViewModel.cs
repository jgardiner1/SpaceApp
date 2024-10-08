﻿using SpaceApp.MVVM.Model;
using SpaceApp.MVVM.Utilities;
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
                SessionName = "SkyWatching Session 1",
                DateTime = DateTime.Now,
                Location = "Canvey Island",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Jupiter" },
                ImageSource = "../../Images/Amateur Space Image.jpeg"
            }) ;
            Sessions.Add(new SessionModel
            {
                SessionName = "SkyWatching Session 2",
                DateTime = DateTime.Now,
                SessionLength = 3,
                Location = "Basildon",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Moon, Venus" },
                ImageSource = "../../Images/SpaceBackground1.jpeg"
            });
            Sessions.Add(new SessionModel
            {
                SessionName = "SkyWatching Session 3",
                DateTime = DateTime.Now,
                SessionLength = 5,
                Location = "Scotland",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Mars, Moon, Milkyway" },
                ImageSource = "../../Images/StarryNightSkyBG.png"
            });
            Sessions.Add(new SessionModel
            {
                SessionName = "SkyWatching Session 4",
                DateTime = DateTime.Now,
                SessionLength = 1,
                Location = "France",
                WeatherCondition = "Cloudy",
                SkyCondition = "Great",
            });
            Sessions.Add(new SessionModel
            {
                SessionName = "SkyWatching Session 5",
                DateTime = DateTime.Now,
                SessionLength = 7,
                Location = "Belgium",
                WeatherCondition = "Foggy",
                SkyCondition = "Great",
                Observables = new string[] { "Jupiter", "Mars", "Moon" }
            });
        }
    }
}
