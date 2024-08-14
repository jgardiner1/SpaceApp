using SpaceApp.Core;
using SpaceApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace SpaceApp.MVVM.ViewModel
{
    public class SessionDataEntryViewModel : INotifyPropertyChanged
    {
        private string _sessionName;
        private string _sessionLocation;
        private string _sessionSkyCondition;
        private string _sessionWeatherCondition;

        public string SessionName
        {
            get { return _sessionName; }
            set
            {
                _sessionName = value;
                OnPropertyChanged();
            }
        }

        public string SessionLocation
        {
            get { return _sessionLocation; }
            set
            {
                _sessionLocation = value;
                OnPropertyChanged();
            }
        }

        public string SessionSkyCondition
        {
            get { return _sessionSkyCondition; }
            set
            {
                _sessionSkyCondition = value;
                OnPropertyChanged();
            }
        }

        public string SessionWeatherCondition
        {
            get { return _sessionWeatherCondition; }
            set
            {
                _sessionWeatherCondition = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddSessionCommand { get; }

        public SessionDataEntryViewModel()
        {
            AddSessionCommand = new RelayCommand(AddSession);
        }

        private void AddSession(object paramter)
        {
            System.Diagnostics.Debug.WriteLine("Adding new session");
            System.Diagnostics.Debug.WriteLine($"Name: {SessionName}\n" +
                $"Location: {SessionLocation}\n" +
                $"Sky Condition: {SessionSkyCondition}\n" +
                $"Weather Condition: {SessionWeatherCondition}");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
    }
}
