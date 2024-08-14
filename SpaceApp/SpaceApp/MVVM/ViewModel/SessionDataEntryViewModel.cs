using SpaceApp.Core;
using SpaceApp.MVVM.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SpaceApp.MVVM.ViewModel
{
    public class SessionDataEntryViewModel : INotifyPropertyChanged
    {
        public event Action<SessionModel> SessionCreated;

        private string _sessionName;
        private string _sessionLocation;
        private string _sessionSkyCondition;
        private string _sessionWeatherCondition;
        private DateOnly _sessionDate;
        private int? _sessionDay;
        private int? _sessionMonth;
        private int? _sessionYear;

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

        public int? SessionDay
        {
            get { return _sessionDay; }
            set
            {
                _sessionDay = value;
                OnPropertyChanged();
            }
        }

        public int? SessionMonth
        {
            get { return _sessionMonth; }
            set
            {
                _sessionMonth = value;
                OnPropertyChanged();
            }
        }

        public int? SessionYear
        {
            get { return _sessionYear; }
            set
            {
                _sessionYear = value;
                OnPropertyChanged();
            }
        }
        
        public DateOnly SessionDate
        {
            get { return _sessionDate; }
            set
            {
                _sessionDate = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddSessionCommand { get; }
        public ICommand AddDateOnlyCommand { get; }

        public SessionDataEntryViewModel()
        {
            AddSessionCommand = new RelayCommand(AddSession);
            AddDateOnlyCommand = new RelayCommand(AddDateOnly);
        }

        private void AddSession(object parameter)
        {
            int year = SessionYear ?? DateTime.Today.Year;
            int month = SessionMonth ?? DateTime.Today.Month;
            int day = SessionDay ?? DateTime.Today.Day;
            try
            {
                DateOnly date = new DateOnly(year, month, day);

                SessionModel session = (new SessionModel
                {
                    Name = SessionName,
                    Date = date,
                    Location = SessionLocation,
                    WeatherCondition = SessionWeatherCondition,
                    SkyCondition = SessionSkyCondition,
                    Observables = new string[] { "Jupiter" },
                    ImageSource = ""
                });

                SessionCreated?.Invoke(session);
            }
            catch(ArgumentOutOfRangeException ex) 
            { 
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void AddDateOnly(object parameter)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            SessionDay = today.Day;
            SessionMonth = today.Month;
            SessionYear = today.Year;
        }
        


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
    }
}
