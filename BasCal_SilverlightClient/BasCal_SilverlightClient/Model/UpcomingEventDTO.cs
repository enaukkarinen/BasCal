using System;
using System.ComponentModel;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using BasCal_SilverlightClient.EventDataService;
using System.ComponentModel.DataAnnotations;

namespace BasCal_SilverlightClient.Model
{
    public class UpcomingEventDTO : INotifyPropertyChanged, IDataErrorInfo
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
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        [Required]
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

        [Required]
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

        public UpcomingEventDTO()
        {
        }

        public UpcomingEventDTO(BasCal_SilverlightClient.EventDataService.UpcomingEventDTO ued)
        {
            this.EventId = ued.EventId;
            this.Name = ued.Name;
            this.Summary = ued.Summary;
            this.Location = ued.Location;
            this.TypeId = ued.TypeId;
            this.Type = ued.Type;
            this.StartTime = ued.StartTime;
            this.EndTime = ued.EndTime;
        }

        public BasCal_SilverlightClient.EventDataService.UpcomingEventDTO ToWCFUpcomingEventDTO()
        {
            return new EventDataService.UpcomingEventDTO()
            {
                EventId = this.EventId,
                Name = this.Name,
                Summary = this.Summary,
                Location = this.Location,
                TypeId = this.TypeId,
                Type = this.Type,
                StartTime = this.StartTime,
                EndTime = this.EndTime
            };
        }


        #region Error handling

        private string Errors;
        private const string ErrorsText = "Error in event data.";
        public string Error
        {
            get { return Errors; }
        }

        public string this[string columnName]
        {
            get 
            {
                Errors = null;

                switch (columnName)
                {
                    case "Name":
                        if (string.IsNullOrEmpty(Name))
                        {
                            Errors = ErrorsText;
                            return "Name cannot by empty.";
                        }
                        break;
                    case "StartTime":
                        if (StartTime > EndTime)
                        {
                            Errors = ErrorsText;
                            return "Start time has to be sooner than end time.";
                        }
                        break;
                }
                return null; 
            }
        }

        #endregion
    }
}