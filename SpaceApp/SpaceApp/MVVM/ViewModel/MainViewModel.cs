using SpaceApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
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

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            SessionsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SessionsVM;
            });

            EventsViewCommand = new RelayCommand(o =>
            {
                CurrentView = EventsVM;
            });
        }
    }
}
