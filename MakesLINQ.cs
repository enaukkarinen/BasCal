//CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DayOfWeek.Monday);
//CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);

var daysInMonth = CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(year, month);

var events = new[] { new Event { Start = DateTime.Now.AddDays(-1), End = DateTime.Now.AddDays(1) } };

var days = new List<DateTime>();
for (var dayNum = 1; dayNum <= daysInMonth; dayNum++)
	days.Add(new DateTime(year, month, dayNum));

var eventDays = from day in days
				select new Day
				{
					Date = day,
					Events = from e in events where day <= e.End && day >= e.Start select e
				};

var grouping = from eventDay in eventDays
			   let weekNum = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(eventDay.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
			   group eventDay by weekNum into g
			   select g;

var weeks = from daysOfWeek in grouping
			select new ObservableCollection<Day>(daysOfWeek);

// Could use constructor of Week
// public Week(IEnumerable<Day> days)
// var weeks = from daysOfWeek in grouping
//             select new Week(daysOfWeek);