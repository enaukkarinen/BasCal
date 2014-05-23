using BasCal_SilverlightClient.EventDataService;
using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BasCal_SilverlightClient.Model
{
    public class Day
    {
        public DateTime Date { get; set; }
        public ObservableCollection<UpcomingEventShortDTO> DaysEvents { get; set; }
        public SolidColorBrush CellColor 
        {
            get
            {
                if (this.DaysEvents.Count > 0)
                {
                    return GetColorFromHexa("#FF6F93BB");                 
                }
                else
                {
                    return GetColorFromHexa("#FF5C6875");
                }
            }
        }

        public Day()
        {
            this.DaysEvents = new ObservableCollection<UpcomingEventShortDTO>();
        }

        private SolidColorBrush GetColorFromHexa(string hexaColor)
        {
            return new SolidColorBrush(
                Color.FromArgb(
                    Convert.ToByte(hexaColor.Substring(1, 2), 16),
                    Convert.ToByte(hexaColor.Substring(3, 2), 16),
                    Convert.ToByte(hexaColor.Substring(5, 2), 16),
                    Convert.ToByte(hexaColor.Substring(7, 2), 16)
                )
            );
        }
    }
}
