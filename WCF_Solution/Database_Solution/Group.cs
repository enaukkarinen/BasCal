//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database_Solution
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        public Group()
        {
            this.GroupMembers = new HashSet<GroupMembers>();
        }
    
        public System.Guid GroupId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<GroupMembers> GroupMembers { get; set; }
    }
}
