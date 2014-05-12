using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Solution
{
    public partial class EventType
    {
        public int TypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Event> Events { get; set; }

        public EventType()
        {
            this.Events = new List<Event>();
        }
    }
}
