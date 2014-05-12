﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB_Solution
{
    public partial class GroupMembers
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public string Role { get; set; }

        public virtual User User { get; set; }
        public virtual Group Group { get; set; }
    }
}
