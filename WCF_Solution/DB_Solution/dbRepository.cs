using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Solution
{
    public class dbRepository
    {
        private dbContext db = new dbContext();

        #region Testitaulu

        public List<string> FetchDataAsString()
        {
            return db.Testit.Select(t => t.Nimi).ToList();
        }

        public IQueryable<Testitaulu> FetchDataAsTableModel()
        {
            return db.Testit;
        }

        #endregion

        #region Events

        public IQueryable<Event> FetchEvents()
        {
            return db.Events;
        }
        public Event FetchEventByGuid(Guid id)
        {
            return db.Events.Where(e => e.EventId == id).FirstOrDefault();
        }
        public IQueryable<Event> FetchEventsBeEventType(string name)
        {
            int typeid = db.EventTypes.Where(et => et.Name == name).Select(et => et.TypeId).FirstOrDefault();
            return db.Events.Where(e => e.TypeId == typeid);
        }
        public IQueryable<Event> FetchEventsByEventName(string name)
        {
            return db.Events.Where(e => e.Name.Contains(name));
        }
        public IQueryable<Event> FetchEventsByStartDate(DateTime date)
        {
            return db.Events.Where(e => e.StartTime.Date == date.Date);
        }
        public IQueryable<Event> FetchEventsByEndDate(DateTime date)
        {
            return db.Events.Where(e => e.EndTime.Date == date.Date);
        }
        public IQueryable<Event> FetchEventsByLocation(string location)
        {
            return db.Events.Where(e => e.Location == location);
        }

        #endregion

        #region EventTypes

        public IQueryable<EventType> FetchEventTypes()
        {
            return db.EventTypes;
        }

        #endregion
    }
}
