using BasCal_SilverlightClient.ServiceReference1;
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
                string paluu = "";
                foreach (var e in this.Days[0].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }
        public string Tuesday 
        {
            get
            {
                string paluu = "";
                foreach (var e in this.Days[1].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }
        public string Wednesday
        {
            get
            {
                string paluu = "";
                foreach (var e in this.Days[2].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }
        public string Thursday
        {
            get
            {
                string paluu = "";
                foreach (var e in this.Days[3].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }
        public string Friday
        {
            get
            {
                string paluu = "";
                foreach (var e in this.Days[4].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }
        public string Saturday
        {
            get
            {
                string paluu = "";
                foreach (var e in this.Days[5].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }
        public string Sunday
        {
            get
            {
                string paluu = "";
                foreach (var e in this.Days[6].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }

        public Week()
        {
            FillDayList();
        }

        public Week(ObservableCollection<Day> days)
        {
            FillDayList();
            AddDays(days);
        }
        public Week(ObservableCollection<UpcomingEventShortDTO> upcomingEvents)
        {
            FillDayList();
            foreach (UpcomingEventShortDTO ev in upcomingEvents)
            {
                PopulateWeekDayLists(ev);
            }
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

        public void AddDays(ObservableCollection<Day> days)
        {
            foreach (Day d in days)
            {
                AddDay(d);
            }
        }

        public void AddDay2(Day day)
        {
            //this.Days.Where(d => d.Date.DayOfWeek)
        }
        public void AddDay(Day day)
        {
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

        //public void FixPreludingDates()
        //{
        //    this.Days = new ObservableCollection<Day>(this.Days.OrderByDescending(o => o.Date));
        //    int increment = GetDayIncrement(this.Days.Where(d => d.Date == new DateTime()).FirstOrDefault().Date.DayOfWeek.ToString());
        //    if(increment != 0)
        //    {
        //        do
        //        {
        //            this.Days
        //        } while (increment > 0);
        //    }

        //}

        private int GetDayIncrement(string dayofweek)
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
