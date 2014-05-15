using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB_Solution
{
    public partial class AttendeeStatus
    {
        public int StatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Attendees> Attendees { get; set; }

        public AttendeeStatus()
        {
            Attendees = new List<Attendees>();
        }
    }
}
