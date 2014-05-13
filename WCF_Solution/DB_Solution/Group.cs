using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Solution
{
    public partial class Group
    {
        public Guid GroupId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GroupMembers> GroupMembers { get; set; }

        public Group()
        {
            this.GroupMembers = new List<GroupMembers>();
        }
    }
}
