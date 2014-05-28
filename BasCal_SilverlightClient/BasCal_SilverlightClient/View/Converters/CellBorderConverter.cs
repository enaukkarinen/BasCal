using BasCal_SilverlightClient.EventDataService;
using System;
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
    public class CellBorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            SolidColorBrush color;
            DateTime date = ((DateTime)value).Date;
            if (date == DateTime.Now.Date)
            {
                color = HexaToArgbConverter.GetColorFromHexa("#FFC6C6C6");
            }
            else
            {
                color = new SolidColorBrush(Colors.Transparent);
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((DateTime)value);
        }


    }
   
}
