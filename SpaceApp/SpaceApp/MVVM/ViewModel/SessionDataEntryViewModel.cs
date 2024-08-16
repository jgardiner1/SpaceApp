using SpaceApp.Core;
using SpaceApp.MVVM.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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
        private DateTime? _sessionDateTime;
        private DateOnly _sessionDateOnly;
        private int? _sessionDay;
        private int? _sessionMonth;
        private int? _sessionYear;

        private string _currentWord;

        public string CurrentWord
        {
            get { return _currentWord; }
            set { 
                _currentWord = value;
                OnPropertyChanged();
                }
        }

        public ObservableCollection<WordItem> Words { get; set; } = new ObservableCollection<WordItem>();

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
        
        public DateOnly SessionDateOnly
        {
            get { return _sessionDateOnly; }
            set
            {
                if (_sessionDateOnly != value)
                {
                    _sessionDateOnly = value;

                    _sessionDay = value.Day;
                    _sessionMonth = value.Month;
                    _sessionYear = value.Year;
                    OnPropertyChanged();

                }
            }
        }

        public DateTime? SessionDateTime
        {
            get { return _sessionDateTime; }

            set
            {
                if (_sessionDateTime != value)
                {
                    _sessionDateTime = value;

                    _sessionDateOnly = _sessionDateTime.HasValue
                        ? DateOnly.FromDateTime(_sessionDateTime.Value)
                        : DateOnly.FromDateTime(DateTime.Today);

                    _sessionDay = _sessionDateOnly.Day;
                    _sessionMonth = _sessionDateOnly.Month;
                    _sessionYear = _sessionDateOnly.Year;

                    OnPropertyChanged();
                    OnPropertyChanged(nameof(SessionDateOnly));
                    OnPropertyChanged(nameof(SessionDay));
                    OnPropertyChanged(nameof(SessionMonth));
                    OnPropertyChanged(nameof(SessionYear));
                }
            }
        }
        public ICommand AddSessionCommand { get; }
        public ICommand AddDateOnlyCommand { get; }
        public ICommand AddWordCommand { get; }
        public ICommand RemoveWordCommand { get; }

        public SessionDataEntryViewModel()
        {
            AddSessionCommand = new RelayCommand(AddSession);
            AddDateOnlyCommand = new RelayCommand(AddDateOnly);
            AddWordCommand = new RelayCommand(AddWord);
            RemoveWordCommand = new RelayCommand(RemoveWord);
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

        private void AddWord(object parameter)
        {
            if (!string.IsNullOrWhiteSpace(CurrentWord) && !Words.Any(w => w.Text == CurrentWord))
            {
                var wordItem = new WordItem
                {
                    Text = CurrentWord,
                    DeleteCommand = new RelayCommand(RemoveWord)
                };
                Words.Add(wordItem);
                CurrentWord = string.Empty;
            }
        }

        private void RemoveWord(object parameter)
        {
            if (parameter is WordItem wordItem)
            {
                Words.Remove(wordItem);
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
    }
}
