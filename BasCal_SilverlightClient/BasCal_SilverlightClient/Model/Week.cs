using BasCal_SilverlightClient.EventDataService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Linq;

namespace BasCal_SilverlightClient.Model
{
    public class Week
    {

        public ObservableCollection<Day> Days { get; set; }

        public string MondayDate 
        {
            get { return this.Days[0].Date.ToShortDateString(); } 
        }
        public string TuesdayDate
        {
            get { return this.Days[1].Date.ToShortDateString(); }
        }
        public string WednesdayDate
        {
            get { return this.Days[2].Date.ToShortDateString(); }
        }
        public string ThursdayDate
        {
            get { return this.Days[3].Date.ToShortDateString(); }
        }
        public string FridayDate
        {
            get { return this.Days[4].Date.ToShortDateString(); }
        }
        public string SaturdayDate
        {
            get { return this.Days[5].Date.ToShortDateString(); }
        }
        public string SundayDate
        {
            get { return this.Days[6].Date.ToShortDateString(); }
        }

        public string Monday
        {
            get 
            {
                return GetDaysEvents(0);
            }
        }
        public string Tuesday 
        {
            get
            {
                return GetDaysEvents(1);
            }
        }
        public string Wednesday
        {
            get
            {
                return GetDaysEvents(2);
            }
        }
        public string Thursday
        {
            get
            {
                return GetDaysEvents(3);
            }
        }
        public string Friday
        {
            get
            {
                return GetDaysEvents(4);
            }
        }
        public string Saturday
        {
            get
            {
                return GetDaysEvents(5);
            }
        }
        public string Sunday
        {
            get
            {
                return GetDaysEvents(6);
            }
        }

        public Week(ObservableCollection<Day> days)
        {
            FillDayList();
            AddDays(days);
        }
        public Week(IEnumerable<UpcomingEventShortDTO> upcomingEvents)
        {
            FillDayList();
            foreach (UpcomingEventShortDTO ev in upcomingEvents)
            {
                PopulateWeekDayLists(ev);
            }
        }

        private string GetDaysEvents(int d)
        {
            string catenatedEvents = "";
            foreach (var e in this.Days[d].DaysEvents)
            {
                catenatedEvents += e.Name + "\r\n";
            }
            return catenatedEvents;
        }

        public void FillDayList()
        {
            if (this.Days == null)
            {
                this.Days = new ObservableCollection<Day>();
            }
            while (this.Days.Count < 7)
            {
                this.Days.Add(new Day());
            }
        }

        public void AddDays(IEnumerable<Day> days)
        {
            foreach (Day d in days)
            {
                AddDay(d);
            }
        }

        public void AddDay(Day day)
        {
            //(from d in this.Days
            //         where d.Date.DayOfWeek == day.Date.DayOfWeek
            //         select d).First().Date = new DateTime();
   
            //Day y = this.Days.Where(dd => dd.Date.DayOfWeek == day.Date.DayOfWeek).Single();
            if (Days[0].Date == new DateTime())
            {
                Days[0] = day;
            }
            else
            {
                foreach (var d in day.DaysEvents)
                {
                    Days[0].DaysEvents.Add(d);
                }   
            }

            switch (day.Date.DayOfWeek.ToString())
            {
                case "Monday":
                    if (Days[0].Date == new DateTime())
                    {
                        Days[0] = day;
                    }
                    else
                    {
                        foreach(var d in day.DaysEvents)
                        {
                            Days[0].DaysEvents.Add(d);
                        }   
                    }
                    break;
                case "Tuesday":
                    if (Days[1].Date == new DateTime())
                    {
                        Days[1] = day;
                    }
                    else
                    {
                        foreach(var d in day.DaysEvents)
                        {
                            Days[1].DaysEvents.Add(d);
                        }   
                    }
                    break;
                case "Wednesday":
                    if (Days[2].Date == new DateTime())
                    {
                        Days[2] = day;
                    }
                    else
                    {
                        foreach(var d in day.DaysEvents)
                        {
                            Days[2].DaysEvents.Add(d);
                        }   
                    }
                    break;
                case "Thursday":
                    if (Days[3].Date == new DateTime())
                    {
                        Days[3] = day;
                    }
                    else
                    {
                        foreach(var d in day.DaysEvents)
                        {
                            Days[3].DaysEvents.Add(d);
                        }   
                    }
                    break;
                case "Friday":
                    if (Days[4].Date == new DateTime())
                    {
                        Days[4] = day;
                    }
                    else
                    {
                        foreach(var d in day.DaysEvents)
                        {
                            Days[4].DaysEvents.Add(d);
                        }   
                    }
                    break;
                case "Saturday":
                    if (Days[5].Date == new DateTime())
                    {
                        Days[5] = day;
                    }
                    else
                    {
                        foreach(var d in day.DaysEvents)
                        {
                            Days[5].DaysEvents.Add(d);
                        }   
                    }
                    break;
                case "Sunday":
                    if (Days[6].Date == new DateTime())
                    {
                        Days[6] = day;
                    }
                    else
                    {
                        foreach(var d in day.DaysEvents)
                        {
                            Days[6].DaysEvents.Add(d);
                        }   
                    }
                    break;
             
                default:
                    break;
            }
        }
        private static IEnumerable<T> ReplaceImpl<T>(IEnumerable<T> sequence, T find, T replaceWith, IEqualityComparer<T> comparer)
        {
            foreach (T item in sequence)
            {
                bool match = comparer.Equals(find, item);
                T x = match ? replaceWith : item;
                yield return x;
            }
        }
        public void PopulateWeekDayLists(UpcomingEventShortDTO eve)
        {
            switch (eve.StartTime.DayOfWeek.ToString())
            {
                case "Monday":
                    Days[0].Date = eve.StartTime;
                    Days[0].DaysEvents.Add(eve);
                    break;
                case "Tuesday":
                    Days[1].Date = eve.StartTime;
                    Days[1].DaysEvents.Add(eve);
                    break;
                case "Wednesday":
                    Days[2].Date = eve.StartTime;
                    Days[2].DaysEvents.Add(eve);
                    break;
                case "Thursday":
                    Days[3].Date = eve.StartTime;
                    Days[3].DaysEvents.Add(eve);
                    break;
                case "Friday":
                    Days[4].Date = eve.StartTime;
                    Days[4].DaysEvents.Add(eve);
                    break;
                case "Saturday":
                    Days[5].Date = eve.StartTime;
                    Days[5].DaysEvents.Add(eve);
                    break;
                case "Sunday":
                    Days[6].Date = eve.StartTime;
                    Days[6].DaysEvents.Add(eve);
                    break;
                default:
                    break;
            }
        }
    }


}
