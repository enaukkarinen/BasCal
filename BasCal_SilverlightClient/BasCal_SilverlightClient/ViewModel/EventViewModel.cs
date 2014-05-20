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
    public class EventViewModel : INotifyPropertyChanged
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
        
        // Constructor
        public EventViewModel()
        {
            client = new DBserviceClient();
            client.FetchUpcomingEventsShortCompleted += client_FetchUpcomingEventsShortCompleted;
            client.FetchEventByGuidCompleted += client_FetchEventByGuidCompleted;
        }

        private void FillCalendarDataGrid(ObservableCollection<UpcomingEventShortDTO> returnedList)
        {
            DateTime startOftheMonth = new DateTime(returnedList[0].StartTime.Year, returnedList[0].StartTime.Month, 1);
            int startOftheMonthWeekNumber = GetIso8601WeekOfYear(startOftheMonth);
            ObservableCollection<UpcomingEventShortDTO> week1Items = new ObservableCollection<UpcomingEventShortDTO>(returnedList.Where(ev => GetIso8601WeekOfYear(ev.StartTime) == startOftheMonthWeekNumber));
            ObservableCollection<UpcomingEventShortDTO> week2Items = new ObservableCollection<UpcomingEventShortDTO>(returnedList.Where(ev => GetIso8601WeekOfYear(ev.StartTime) == startOftheMonthWeekNumber + 1));
            ObservableCollection<UpcomingEventShortDTO> week3Items = new ObservableCollection<UpcomingEventShortDTO>(returnedList.Where(ev => GetIso8601WeekOfYear(ev.StartTime) == startOftheMonthWeekNumber + 2));
            ObservableCollection<UpcomingEventShortDTO> week4Items = new ObservableCollection<UpcomingEventShortDTO>(returnedList.Where(ev => GetIso8601WeekOfYear(ev.StartTime) == startOftheMonthWeekNumber + 3));
            ObservableCollection<UpcomingEventShortDTO> week5Items = new ObservableCollection<UpcomingEventShortDTO>(returnedList.Where(ev => GetIso8601WeekOfYear(ev.StartTime) == startOftheMonthWeekNumber + 4));
            
            this.Weeks = new ObservableCollection<Week>();
            this.Weeks.Add(new Week(week1Items));
            this.Weeks.Add(new Week(week2Items));
            this.Weeks.Add(new Week(week3Items));
            this.Weeks.Add(new Week(week4Items));
            this.Weeks.Add(new Week(week5Items));

            returnedList = new ObservableCollection<UpcomingEventShortDTO>(returnedList.OrderBy(x => x.StartTime));
            
            int daysInMonth = DateTime.DaysInMonth(startOftheMonth.Year, startOftheMonth.Month);

            // Find out where to put the first day of the month on the datagrid
            int firstWeekIncrement = GetDayIncrement(startOftheMonth.Date.DayOfWeek.ToString());
            int addedEmpties = firstWeekIncrement;
            this.Weeks.Add(new Week());

        }


        public void FetchUpcomingEventShortInShortFormat()
        {
            client.FetchUpcomingEventsShortAsync();
        }
        void client_FetchUpcomingEventsShortCompleted(object sender, FetchUpcomingEventsShortCompletedEventArgs e)
        {
            UpcomingEventsInShortFormatList = e.Result;
            FillCalendarDataGrid(e.Result);
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
    }



}
