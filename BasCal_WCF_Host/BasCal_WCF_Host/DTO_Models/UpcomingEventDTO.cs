﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace BasCal_WCF_Host.DTO_Models
{
    public class UpcomingEventDTO
    {
        private string name;
        public Guid EventId { get; set; }
        public int TypeId { get; set; }

        //[DisplayName("Type")]
        public string Type { get; set; }

        //[Required(ErrorMessage = "Name is required.")]
        public string Name
        { 
            get { return name; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name is required");
                }
                name = value;
            } 
        }
        public string Summary { get; set; }
        public string Location { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d}")]
        //[Required(ErrorMessage = "Please specify the starting time for the event.")]
        public DateTime StartTime { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d}")]
        //[Required(ErrorMessage = "Please specify the ending time for the event.")]
        public DateTime EndTime { get; set; }
    }
}
