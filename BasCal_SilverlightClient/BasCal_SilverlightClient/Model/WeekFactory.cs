using BasCal_SilverlightClient.EventDataService;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Collections.Generic;

namespace BasCal_SilverlightClient.Model
{
    public static class WeekFactory
    {
        public static ObservableCollection<Week> WeekBuilder(ObservableCollection<UpcomingEventShortDTO> events)
        {
            DateTime startOftheMonth = new DateTime(events[0].StartTime.Year, events[0].StartTime.Month, 1);
            int startOftheMonthWeekNumber = GetIso8601WeekOfYear(startOftheMonth);
            int numberOfDaysInWholeMonth = DateTime.DaysInMonth(startOftheMonth.Year, startOftheMonth.Month);
            ObservableCollection<Day> dayCollection = new ObservableCollection<Day>();

            for (int i = 1; i <= numberOfDaysInWholeMonth; i++)
            {
                Day newDay = new Day() { Date = new DateTime(startOftheMonth.Year, startOftheMonth.Month, i) };
                newDay.DaysEvents = new ObservableCollection<UpcomingEventShortDTO>
                    (events.Where(x => x.StartTime.Day <= newDay.Date.Day && x.EndTime.Day >= newDay.Date.Day));

                dayCollection.Add(newDay);
            }

            // Adds the days visible from the previous month
            int dayIncrement = (int)dayCollection[0].Date.DayOfWeek + 2;
            do
            {
                DateTime newDate = startOftheMonth;
                newDate = newDate.AddDays(-1 * dayIncrement);
                dayCollection.Insert(0, new Day() { Date = newDate });
                dayIncrement--;
            } while (dayIncrement > 0);
                    

            IEnumerable<Week> weeks = from eventDay in dayCollection
                                      group eventDay by GetIso8601WeekOfYear(eventDay.Date) into w
                                      select new Week(new ObservableCollection<Day>(w));

            return new ObservableCollection<Week>(weeks);  
        }


        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        private static int GetIso8601WeekOfYear(DateTime time)
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
