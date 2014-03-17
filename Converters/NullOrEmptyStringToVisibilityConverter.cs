using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfAppTemplate.Converters
{
    public class NullOrEmptyStringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var flag = value == null;
            var s = value as string;
            if (s != null)
            {
                flag = string.IsNullOrEmpty(s);
            }
            var inverse = (parameter as string) == "inverse";

            if (inverse)
            {
                return (flag ? Visibility.Visible : Visibility.Collapsed);
            }

            return (flag ? Visibility.Collapsed : Visibility.Visible);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
