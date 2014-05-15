using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasCal_WCF_Host.DTO_Models
{
    public class UpcomingEventShortDTO
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public string StartDate { get; set; }
        public string EndTime { get; set; }
        public string EndDate { get; set; }
    }
}
