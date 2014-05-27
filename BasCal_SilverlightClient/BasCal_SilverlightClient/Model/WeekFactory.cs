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
            DateTime firstDayOfMonth = new DateTime(events.First().StartTime.Year, events.First().StartTime.Month, 1);

            // Populates a month with days and events.
            ObservableCollection<Day> month = PopulateMonth(firstDayOfMonth, events);

            // Splits a month into weeks.
            ObservableCollection<Week> weeks = SplitDaysCollectionToWeeks(month);

            // Adds days visible from the adjacent months.
            weeks = AddAdjacentDays(weeks);

            return weeks;  
        }

        /// <summary>
        /// Populates a month with days and events.
        /// </summary>
        /// <param name="firstDayOfMonth"></param>
        /// <param name="events"></param>
        /// <returns>ObservableCollection<Day></returns>
        private static ObservableCollection<Day> PopulateMonth(DateTime firstDayOfMonth, ObservableCollection<UpcomingEventShortDTO> events)
        {
            int numberOfDaysInWholeMonth = DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month);
            ObservableCollection<Day> month = new ObservableCollection<Day>();

            for (int i = 1; i <= numberOfDaysInWholeMonth; i++)
            {
                Day newDay = new Day() { Date = new DateTime(firstDayOfMonth.Year, firstDayOfMonth.Month, i) };
                newDay.DaysEvents = new ObservableCollection<UpcomingEventShortDTO>
                    (events.Where(x => x.StartTime.Day <= newDay.Date.Day && x.EndTime.Day >= newDay.Date.Day));
                month.Add(newDay);
            }
            return month;
        }

        /// <summary>
        /// Categorizes days by week number.
        /// </summary>
        /// <param name="days"></param>
        /// <returns>ObservableCollection<Week></returns>
        private static ObservableCollection<Week> SplitDaysCollectionToWeeks(ObservableCollection<Day> days)
        {
            return (from eventDay in days
                    group eventDay by GetIso8601WeekOfYear(eventDay.Date) into w
                    select new Week(new ObservableCollection<Day>(w))).ToObservableCollection();
        }

        /// <summary>
        /// Adds "fillerdays" to the outermost weeks from adjacent months. 
        /// </summary>
        /// <param name="weeks"></param>
        /// <returns>ObservableCollection<Week></returns>
        private static ObservableCollection<Week> AddAdjacentDays(ObservableCollection<Week> weeks)
        {
            // Adds days visible from the previous month
            ObservableCollection<Day> DaysOfFirstWeek = (from day in weeks.First().Days
                                                         select day).Concat
                                                        (from day in GetDaysFromPreviousMonth(weeks.First().Days.First().Date)
                                                         select day).ToObservableCollection();
            weeks[0] = new Week(DaysOfFirstWeek.OrderBy(d => d.Date).ToObservableCollection());

            // Adds days visible from the following month
            ObservableCollection<Day> DaysOfLastWeek = (from day in weeks.Last().Days
                                                        select day).Concat
                                                       (from day in GetDaysFromFollowingMonth(weeks.Last().Days.Last().Date)
                                                        select day).ToObservableCollection();
            weeks[4] = new Week(DaysOfLastWeek.OrderBy(d => d.Date).ToObservableCollection());

            return weeks; 
        }

        /// <summary>
        /// Adds days visible from the previous month.
        /// </summary>
        /// <param name="firstDayofMonth"></param>
        /// <returns>ObservableCollection<Day></returns>
        private static ObservableCollection<Day> GetDaysFromPreviousMonth(DateTime firstDayofMonth)
        {
            ObservableCollection<Day> daysOfLastMonth = new ObservableCollection<Day>();
            int dayIncrementForBeginningOfMonth = ((int)firstDayofMonth.DayOfWeek == 0) ? 7 : (int)firstDayofMonth.DayOfWeek;
            dayIncrementForBeginningOfMonth--;          
            do
            {
                DateTime newDate = firstDayofMonth;
                newDate = newDate.AddDays(-1 * dayIncrementForBeginningOfMonth);
                daysOfLastMonth.Add(new Day() { Date = newDate });
                dayIncrementForBeginningOfMonth--;
            } while (dayIncrementForBeginningOfMonth > 0);
            return daysOfLastMonth;
        }

        /// <summary>
        /// Adds days visible from the following month.
        /// </summary>
        /// <param name="lastDayofMonth"></param>
        /// <returns>ObservableCollection<Day></returns>
        private static ObservableCollection<Day> GetDaysFromFollowingMonth(DateTime lastDayofMonth)
        {
            ObservableCollection<Day> daysOfFollowingMonth = new ObservableCollection<Day>();
            int dayIncrementForEndOfMonth = 7 - (((int)lastDayofMonth.DayOfWeek == 0) ? 7 : (int)lastDayofMonth.DayOfWeek);
            do
            {
                daysOfFollowingMonth.Add(new Day() { Date = lastDayofMonth.AddDays(dayIncrementForEndOfMonth) });
                dayIncrementForEndOfMonth--;
            } while (dayIncrementForEndOfMonth > 0);
            return daysOfFollowingMonth;
        }

        /// <summary>
        /// Return the week number of given date.
        /// Presumes that weeks start with Monday.
        /// Week 1 is the 1st week of the year with a Thursday in it.
        /// </summary>
        /// <param name="time"></param>
        /// <returns>int</returns>
        private static int GetIso8601WeekOfYear(DateTime time)
        {
            // If its Monday, Tuesday or Wednesday, then it'll 
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
