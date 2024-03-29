﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasCal_WCF_Host.DTO_Models
{
    public class UpcomingEventDTO : INotifyPropertyChanged 
    {
        private System.DateTime EndTimeField;

        private System.Guid EventIdField;

        private string LocationField;

        private string NameField;

        private System.DateTime StartTimeField;

        private string SummaryField;

        private string TypeField;

        private int TypeIdField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndTime
        {
            get
            {
                return this.EndTimeField;
            }
            set
            {
                if ((this.EndTimeField.Equals(value) != true))
                {
                    this.EndTimeField = value;
                    this.RaisePropertyChanged("EndTime");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid EventId
        {
            get
            {
                return this.EventIdField;
            }
            set
            {
                if ((this.EventIdField.Equals(value) != true))
                {
                    this.EventIdField = value;
                    this.RaisePropertyChanged("EventId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                if ((object.ReferenceEquals(this.LocationField, value) != true))
                {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }

        [Required]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NameField, value) != true))
                {
                    Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Name" }); 
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime
        {
            get
            {
                return this.StartTimeField;
            }
            set
            {
                if ((this.StartTimeField.Equals(value) != true))
                {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary
        {
            get
            {
                return this.SummaryField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SummaryField, value) != true))
                {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.TypeField, value) != true))
                {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypeId
        {
            get
            {
                return this.TypeIdField;
            }
            set
            {
                if ((this.TypeIdField.Equals(value) != true))
                {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    
    }
}
