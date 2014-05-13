using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Solution
{
    public partial class Event
    {
        public Guid EventId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual EventType EventType { get; set; }
        public virtual ICollection<Attendees> Attendees { get; set; }

        public Event()
        {
            this.Attendees = new List<Attendees>();
        }
    }
}
