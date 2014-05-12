﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB_Solution
{
    public partial class Attendees
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
        public int AttendeeStatusId { get; set; }

        public virtual User User { get; set; }
        public virtual Event Event { get; set; }
        public virtual AttendeeStatus AttendeeStatus { get; set; }

    }
}
