using BasCal_SilverlightClient.EventDataService;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Collections.Generic;
using BasCal_SilverlightClient.CollectionExtensions;

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

            var weeks = (from eventDay in dayCollection
                         group eventDay by GetIso8601WeekOfYear(eventDay.Date) into w
                         select new Week(new ObservableCollection<Day>(w))).ToObservableCollection();

            
             //Adds the days visible from previous month
            Week firstWeek = weeks.First();
            int dayIncrementForBeginningOfMonth = ((int)firstWeek.Days.First().Date.DayOfWeek == 0) ? 7 : (int)firstWeek.Days.First().Date.DayOfWeek;
            dayIncrementForBeginningOfMonth--;
            do
            {
                DateTime newDate = startOftheMonth;
                newDate = newDate.AddDays(-1 * dayIncrementForBeginningOfMonth);
                firstWeek.Days.Insert(0, new Day() { Date = newDate });
                dayIncrementForBeginningOfMonth--;
            } while (dayIncrementForBeginningOfMonth > 0);
            weeks[0] = new Week(firstWeek.Days);


            //Adds the days visible from next month
            Week lastWeek = weeks.Last();
            int dayIncrementForEndOfMonth = ((int)lastWeek.Days.Last().Date.DayOfWeek == 0) ? 7 : (int)lastWeek.Days.Last().Date.DayOfWeek;
            dayIncrementForEndOfMonth = 7 - dayIncrementForEndOfMonth;
            do
            {
                lastWeek.Days.Add(new Day() { Date = lastWeek.Days.Last().Date.AddDays(dayIncrementForEndOfMonth) });
                dayIncrementForEndOfMonth--;
            } while (dayIncrementForEndOfMonth > 0);
            weeks[4] = new Week(lastWeek.Days);

            return weeks;  
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
