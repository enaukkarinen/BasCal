using BasCal_SilverlightClient.EventDataService;
using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BasCal_SilverlightClient.View.Converters
{
    public class DaysEventsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var events = ((ObservableCollection<UpcomingEventShortDTO>)value);
            string CatenatedEventNames = "";
            foreach(var eve in events)
            {
                CatenatedEventNames += eve.Name + "\r\n";
            }
            return CatenatedEventNames;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((ObservableCollection<UpcomingEventShortDTO>)value);
        }
    }
}
