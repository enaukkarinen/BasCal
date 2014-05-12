using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB_Solution
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Attendees> Attendees { get; set; }
        public virtual ICollection<GroupMembers> GroupMembers { get; set; }

        public User()
        {
            this.Attendees = new List<Attendees>();
            this.GroupMembers = new List<GroupMembers>();
        }
    }
}
