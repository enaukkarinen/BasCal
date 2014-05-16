using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasCal_WCF_Host.DTO_Models
{
    public class UpcomingEventDTO
    {
        public Guid EventId { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
