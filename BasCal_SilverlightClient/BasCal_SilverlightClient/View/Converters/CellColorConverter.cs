
using BasCal_SilverlightClient.EventDataService;
using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BasCal_SilverlightClient.View.Converters
{
    public class CellColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int count = ((ObservableCollection<UpcomingEventShortDTO>)value).Count;
            if (count > 0)
            {
                return HexaToArgbConverter.GetColorFromHexa("#FF6F93BB");
            }
            else
            {
                return HexaToArgbConverter.GetColorFromHexa("#FF5C6875");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return HexaToArgbConverter.GetColorFromHexa("#FF5C6875");
        }

    }

}
