using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Solution
{
    public class EventDataRepository
    {

        private EventDataContext edb = new EventDataContext();
        

        #region Testitaulu

        public List<string> FetchDataAsString()
        {
            return edb.Testit.Select(t => t.Nimi).ToList();
        }

        public IQueryable<Testitaulu> FetchDataAsTableModel()
        {
            return edb.Testit;
        }

        #endregion

        #region Events

        public IQueryable<Event> FetchEvents()
        {
            var paluu = edb.Events;
            return paluu;
        }
        public Event FetchEventByGuid(Guid id)
        {
            return edb.Events.Where(e => e.EventId == id).FirstOrDefault();
        }

        public void AddEvent(Event ev)
        {
            edb.Events.Add(ev);
            edb.SaveChanges();
        }

        public void DeleteEventByGuid(Guid id)
        {
            Event ev = FetchEventByGuid(id);
            edb.Events.Remove(ev);
            edb.SaveChanges();
        }

        public void UpdateEvent(Event ev)
        {
            try
            {
                Event tobechanged = edb.Events.Where(e => e.EventId == ev.EventId).SingleOrDefault();
                if (tobechanged != null)
                {
                    tobechanged.TypeId = ev.TypeId;
                    tobechanged.Name = ev.Name;
                    tobechanged.Summary = ev.Summary;
                    tobechanged.StartTime = ev.StartTime;
                    tobechanged.EndTime = ev.EndTime;
                    edb.SaveChanges();
                }
                else
                {
                    ev.EventType = edb.EventTypes.Where(type => type.TypeId == ev.TypeId).SingleOrDefault();
                    AddEvent(ev);
                }
            }
            catch (Exception e)
            {

            }

        }
        public IQueryable<Event> FetchEventsBeEventType(string name)
        {
            int typeid = edb.EventTypes.Where(et => et.Name == name).Select(et => et.TypeId).FirstOrDefault();
            return edb.Events.Where(e => e.TypeId == typeid);
        }

        public IQueryable<Event> FetchEventsByMonth(int month)
        {
            return edb.Events.Where(e => e.StartTime.Month == month);
        }

        public IQueryable<Event> FetchEventsByEventName(string name)
        {
            return edb.Events.Where(e => e.Name.Contains(name));
        }
        public IQueryable<Event> FetchEventsByStartDate(DateTime date)
        {
            return edb.Events.Where(e => e.StartTime.Date == date.Date);
        }
        public IQueryable<Event> FetchEventsByEndDate(DateTime date)
        {
            return edb.Events.Where(e => e.EndTime.Date == date.Date);
        }
        public IQueryable<Event> FetchEventsByLocation(string location)
        {
            return edb.Events.Where(e => e.Location == location);
        }

        #endregion

        #region EventTypes

        public IQueryable<EventType> FetchEventTypes()
        {
            return edb.EventTypes;
        }

        #endregion
    }
}
