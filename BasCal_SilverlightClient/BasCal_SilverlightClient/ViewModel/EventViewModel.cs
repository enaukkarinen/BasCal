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
        private MonthViewModel month;


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

        public MonthViewModel Month
        {
            get { return month; }
            set 
            {
                month = value;
                RaisePropertyChanged("Month");
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
            MonthViewModel m = new MonthViewModel();
            m.MonthNumber = returnedList[0].StartTime.Month;
            m.MonthName = returnedList[0].StartTime.ToString("MMMM");
            m.Year = returnedList[0].StartTime.Year;

            m.Days = new ObservableCollection<Day>();

            for (int i = 1; i <= DateTime.DaysInMonth(m.Year, m.MonthNumber); i++)
            {
                Day day = new Day();
                day.DaysEvents = new ObservableCollection<UpcomingEventShortDTO>();
                foreach (UpcomingEventShortDTO ev in returnedList)
                {
                    if (ev.StartTime.Day == i)
                    {
                        day.DaysEvents.Add(ev);
                    }
                }
                day.Date = new DateTime(m.Year, m.MonthNumber, i);
                m.Days.Add(day);
            }

            int firstWeekIncrement = GetDayIncrement(m.Days[0].Date.DayOfWeek.ToString());


            for (int i = firstWeekIncrement; i > 0; i--)
            {
                m.Weeks[0].Days.Add(new Day(){Date = m.Days[0].Date.AddDays(i * -1)});
            }

            for (int i = 0; i < m.Days.Count; i++)
            {
                if (m.Weeks[0].Days.Count <= 7)
                {
                    m.Weeks[0].Days.Add(m.Days[i]);
                }
                else if (m.Weeks[1].Days.Count <= 7)
                {
                    m.Weeks[1].Days.Add(m.Days[i]);
                }
                else if (m.Weeks[2].Days.Count <= 7)
                {
                    m.Weeks[2].Days.Add(m.Days[i]);
                }
                else if (m.Weeks[3].Days.Count <= 7)
                {
                    m.Weeks[3].Days.Add(m.Days[i]);
                }
                else if (m.Weeks[4].Days.Count <= 7)
                {
                    m.Weeks[4].Days.Add(m.Days[i]);
                }
            }

            this.Month = m;
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
    }



}
