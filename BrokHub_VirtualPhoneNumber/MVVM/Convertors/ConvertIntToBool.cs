using System;
using System.Globalization;
using System.Windows.Data;

namespace BrokHub_VirtualPhoneNumber.MVVM.Convertors
{
    public class ConvertIntToBool : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != "1" ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != "1" ? true : false;

        }
    }
}
