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
    
    public partial class EventType
    {
        public EventType()
        {
            this.Event = new HashSet<Event>();
        }
    
        public int TypeId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Event> Event { get; set; }
    }
}
