using SpaceApp.Core;
using SpaceApp.MVVM.Model;
using SpaceApp.MVVM.View;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace SpaceApp.MVVM.ViewModel
{
    public class SessionsViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<SessionModel> Sessions { get; set; } = new ObservableCollection<SessionModel>();

        public ICommand OpenPopupCommand { get; }

        public SessionsViewModel()
        {
            OpenPopupCommand = new RelayCommand(OpenPopup);

            Sessions.Add(new SessionModel
            {
                Name = "SkyWatching Session 1",
                Date = DateOnly.FromDateTime(DateTime.Now),
                Location = "Canvey Island",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Jupiter" },
                ImageSource = "../../Images/Amateur Space Image.jpeg"
            }) ;
            Sessions.Add(new SessionModel
            {
                Name = "SkyWatching Session 2",
                Date = DateOnly.FromDateTime(DateTime.Now),
                Length = 3,
                Location = "Basildon",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Moon, Venus" },
                ImageSource = "../../Images/SpaceBackground1.jpeg"
            });
            Sessions.Add(new SessionModel
            {
                Name = "SkyWatching Session 3",
                Date = DateOnly.FromDateTime(DateTime.Now),
                Length = 5,
                Location = "Scotland",
                WeatherCondition = "Clear",
                SkyCondition = "Great",
                Observables = new string[] { "Mars, Moon, Milkyway" },
                ImageSource = "../../Images/StarryNightSkyBG.png"
            });
            Sessions.Add(new SessionModel
            {
                Name = "SkyWatching Session 4",
                Date = DateOnly.FromDateTime(DateTime.Now),
                Length = 1,
                Location = "France",
                WeatherCondition = "Cloudy",
                SkyCondition = "Great",
                ImageSource = ""
            });
            Sessions.Add(new SessionModel
            {
                Name = "SkyWatching Session 5",
                Date = DateOnly.FromDateTime(DateTime.Now),
                Length = 7,
                Location = "Belgium",
                WeatherCondition = "Foggy",
                SkyCondition = "Great",
                ImageSource = "",
                Observables = new string[] { "Jupiter", "Mars", "Moon" }
            });
        }

        private void OnSessionCreated(SessionModel session)
        {
            Sessions.Add(session);
            Console.WriteLine("Added session!!!");
        }

        private void OpenPopup(object parameter)
        {
            var sessionDataEntryViewModel = new SessionDataEntryViewModel();

            sessionDataEntryViewModel.SessionCreated += OnSessionCreated;

            SessionDataEntryView window = new SessionDataEntryView(sessionDataEntryViewModel);
            if (parameter is Window ownerWindow)
            {
                window.Owner = ownerWindow;
            }

            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
