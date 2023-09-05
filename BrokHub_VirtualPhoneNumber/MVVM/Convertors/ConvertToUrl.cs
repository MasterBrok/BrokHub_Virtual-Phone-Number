
using System;
using System.Globalization;
using System.Windows.Data;

namespace BrokHub_VirtualPhoneNumber.MVVM.Convertors
{
    public class ConvertToUrl : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "https://numberland.ir" + value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "https://numberland.ir" + value;
        }
    }
}
