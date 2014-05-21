using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasCal_WCF_Host.DTO_Models;
using DB_Solution;

namespace BasCal_WCF_Host.Extension
{
    public static class DTOExtensions
    {
        public static Event ToEvent(this UpcomingEventDTO uev)
        {
            return new Event()
            {
                EventId = uev.EventId,
                TypeId = uev.TypeId,
                Name = uev.Name,
                Summary = uev.Summary,
                Location = uev.Location,
                StartTime = uev.StartTime,
                EndTime = uev.EndTime
            };
        }
        public static UpcomingEventDTO ToUpcomingEventDTO(this Event ev)
        {
            return new UpcomingEventDTO()
            {
                EventId = ev.EventId,
                Type = ev.EventType.Name,
                Name = ev.Name,
                Summary = ev.Summary,
                Location = ev.Location,
                StartTime = ev.StartTime,
                EndTime = ev.EndTime
            };
        }

        public static UpcomingEventShortDTO ToUpcomingEventShortDTO(this Event ev)
        {
            return new UpcomingEventShortDTO()
            {
                EventId = ev.EventId,
                Name = ev.Name,
                StartTime = ev.StartTime,
                EndTime = ev.EndTime
            };
        }
    }
}
