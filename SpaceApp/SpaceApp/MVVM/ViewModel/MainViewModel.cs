using SpaceApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SpaceApp.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand SessionsViewCommand { get; set; }
        public RelayCommand EventsViewCommand { get; set; }

        public HomeViewModel HomeVM {  get; set; }
        public SessionsViewModel SessionsVM { get; set; }
        public EventsViewModel EventsVM { get; set; }

        private object _currentView;

        private string _backgroundImageSource;

        public string BackgroundImageSource
        {
            get { return _backgroundImageSource; }
            set
            {
                _backgroundImageSource = value;
                OnPropertyChanged();
            }
        }

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() { 
            
            HomeVM = new HomeViewModel();
            SessionsVM = new SessionsViewModel();
            EventsVM = new EventsViewModel();
            CurrentView = HomeVM;
            BackgroundImageSource = "pack://application:,,,/Images/10893418.png";

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
                BackgroundImageSource = "pack://application:,,,/Images/10893418.png";
            });

            SessionsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SessionsVM;
                BackgroundImageSource = "pack://application:,,,/Images/10893418.png";
            });

            EventsViewCommand = new RelayCommand(async o =>
            {
                CurrentView = EventsVM;
                BackgroundImageSource = "pack://application:,,,/Images/10893418.png";
                await EventsVM.InitialiseAsync();
            });
        }
    }
}
