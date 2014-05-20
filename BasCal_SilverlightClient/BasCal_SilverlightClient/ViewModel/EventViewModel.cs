using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using BasCal_SilverlightClient.ServiceReference1;
using System.Collections.ObjectModel;
using System.ComponentModel;
using BasCal_SilverlightClient.Model;
using System.Diagnostics;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace BasCal_SilverlightClient.ViewModel
{
    public class EventViewModel : INotifyPropertyChanged, ICommand
    {
        private DBserviceClient client;
        private UpcomingEventDTO upcomingEventInFull;
        private ObservableCollection<UpcomingEventShortDTO> upcomingEventsInShortFormatList;
        private ObservableCollection<Week> weeks;


        public ObservableCollection<UpcomingEventShortDTO> UpcomingEventsInShortFormatList
        {
            get { return upcomingEventsInShortFormatList; }
            set
            {
                upcomingEventsInShortFormatList = value;
                RaisePropertyChanged("UpcomingEventsInShortFormatList");

            }
        }

        public UpcomingEventDTO UpcomingEventInFull
        {
            get { return upcomingEventInFull; }
            set 
            {
                upcomingEventInFull = value;
                RaisePropertyChanged("UpcomingEventInFull");
            }
        }

        public ObservableCollection<Week> Weeks
        {
            get { return weeks; }
            set 
            {
                weeks = value;
                RaisePropertyChanged("Weeks");
            }
        }

        public ICommand DoTheDew
        {
            get
            {
                return new Microsoft.Expression.Interactivity.Core.ActionCommand(() => MessageBox.Show("Hello from command!"));
            }
        }

        // Constructor
        public EventViewModel()
        {
            client = new DBserviceClient();
            client.FetchUpcomingEventsShortCompleted += client_FetchUpcomingEventsShortCompleted;
            client.FetchEventByGuidCompleted += client_FetchEventByGuidCompleted;
            client.FetchEventsByMonthCompleted += client_FetchEventsByMonthCompleted;
        }

        void client_FetchEventsByMonthCompleted(object sender, FetchEventsByMonthCompletedEventArgs e)
        {
            FillCalendarDataGrid(e.Result);
        }

        public void FetchEventsByMonth(int m)
        {
            client.FetchEventsByMonthAsync(m);
        }

        private void FillCalendarDataGrid(ObservableCollection<UpcomingEventShortDTO> returnedList)
        {
            DateTime startOftheMonth = new DateTime(returnedList[0].StartTime.Year, returnedList[0].StartTime.Month, 1);
            int startOftheMonthWeekNumber = GetIso8601WeekOfYear(startOftheMonth);
            int numberOfDaysInWholeMonth = DateTime.DaysInMonth(startOftheMonth.Year, startOftheMonth.Month);
            ObservableCollection<Day> secondCollection = new ObservableCollection<Day>();

            for(int i = 1 ; i <= numberOfDaysInWholeMonth; i++)
            {
                Day newDay = new Day(){Date = new DateTime(startOftheMonth.Year, startOftheMonth.Month, i)};
                newDay.DaysEvents = new ObservableCollection<UpcomingEventShortDTO>(returnedList.Where(x => x.StartTime.Day <= newDay.Date.Day && x.EndTime.Day >= newDay.Date.Day));

                secondCollection.Add(newDay);
            }


            int dayIncrement = GetDayIncrement(secondCollection[0].Date.DayOfWeek.ToString());
            do
            {
                DateTime newDate = startOftheMonth;
                newDate = newDate.AddDays(-1 * dayIncrement);
                secondCollection.Insert(0, new Day(){Date = newDate});
                dayIncrement--;
            } while (dayIncrement > 0);

            this.Weeks = new ObservableCollection<Week>();
            this.Weeks.Add(new Week(new ObservableCollection<Day>(secondCollection.Where(x => GetIso8601WeekOfYear(x.Date) <= startOftheMonthWeekNumber ))));
            this.Weeks.Add(new Week(new ObservableCollection<Day>(secondCollection.Where(x => GetIso8601WeekOfYear(x.Date) == startOftheMonthWeekNumber + 1))));
            this.Weeks.Add(new Week(new ObservableCollection<Day>(secondCollection.Where(x => GetIso8601WeekOfYear(x.Date) == startOftheMonthWeekNumber + 2))));
            this.Weeks.Add(new Week(new ObservableCollection<Day>(secondCollection.Where(x => GetIso8601WeekOfYear(x.Date) == startOftheMonthWeekNumber + 3))));
            this.Weeks.Add(new Week(new ObservableCollection<Day>(secondCollection.Where(x => GetIso8601WeekOfYear(x.Date) == startOftheMonthWeekNumber + 4))));

        }


        public void FetchUpcomingEventShortInShortFormat()
        {
            client.FetchUpcomingEventsShortAsync();
        }
        void client_FetchUpcomingEventsShortCompleted(object sender, FetchUpcomingEventsShortCompletedEventArgs e)
        {
            UpcomingEventsInShortFormatList = new ObservableCollection<UpcomingEventShortDTO>(e.Result.OrderByDescending(ev => ev.StartTime));
        }

        public void FetchUpcomingEventByGuid(Guid guid)
        {
            client.FetchEventByGuidAsync(guid);
        }
        void client_FetchEventByGuidCompleted(object sender, FetchEventByGuidCompletedEventArgs e)
        {
            UpcomingEventInFull = e.Result;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) 
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) 
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private static int GetDayIncrement(string dayofweek)
        {
            switch (dayofweek)
            {
                case "Monday":
                    return 0;
                case "Tuesday":
                    return 1;
                case "Wednesday":
                    return 2;
                case "Thursday":
                    return 3;
                case "Friday":
                    return 4;
                case "Saturday":
                    return 5;
                case "Sunday":
                    return 6;
                default:
                    return 0;
            }
        }

        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }



}
