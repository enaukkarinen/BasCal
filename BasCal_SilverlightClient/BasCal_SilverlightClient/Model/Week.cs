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

namespace BasCal_SilverlightClient.Model
{
    public class Week
    {
        public ObservableCollection<Day> Days { get; set; }

        public string Sunday
        {
            get 
            {
                string paluu = "";
                paluu += this.Days[0].Date + "\r\n";

                foreach (var e in this.Days[0].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }
        public string Monday 
        {
            get
            {
                string paluu = "";
                paluu += this.Days[1].Date + "\r\n";
                foreach (var e in this.Days[1].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }
        public string Tueday
        {
            get
            {
                string paluu = "";
                paluu += this.Days[2].Date + "\r\n";
                foreach (var e in this.Days[2].DaysEvents)
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
                paluu += this.Days[3].Date + "\r\n";
                foreach (var e in this.Days[3].DaysEvents)
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
                paluu += this.Days[4].Date + "\r\n";
                foreach (var e in this.Days[4].DaysEvents)
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
                paluu += this.Days[5].Date + "\r\n";
                foreach (var e in this.Days[5].DaysEvents)
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
                paluu += this.Days[6].Date + "\r\n";
                foreach (var e in this.Days[6].DaysEvents)
                {
                    paluu += e.Name + "\r\n";
                }
                return paluu;
            }
        }

        public Week()
        {
            this.Days = new ObservableCollection<Day>();
        }

        public Week(ObservableCollection<UpcomingEventShortDTO> upcomingEvents)
        {
            this.Days = new ObservableCollection<Day>();

            foreach (UpcomingEventShortDTO ev in upcomingEvents)
            {
                PopulateWeekDayLists(ev);
            }
        }

        public void PopulateWeekDayLists(UpcomingEventShortDTO eve)
        {
            switch (eve.StartTime.DayOfWeek.ToString())
            {
                case "Sunday":
                    Days[0].DaysEvents.Add(eve);
                    break;
                case "Monday":
                    Days[1].DaysEvents.Add(eve);
                    break;
                case "Tuesday":
                    Days[2].DaysEvents.Add(eve);
                    break;
                case "Wednesday":
                    Days[3].DaysEvents.Add(eve);
                    break;
                case "Thursday":
                    Days[4].DaysEvents.Add(eve);
                    break;
                case "Friday":
                    Days[5].DaysEvents.Add(eve);
                    break;
                case "Saturday":
                    Days[6].DaysEvents.Add(eve);
                    break;
                default:
                    Days[0].DaysEvents.Add(eve);
                    break;
            }
        }
    }


}
