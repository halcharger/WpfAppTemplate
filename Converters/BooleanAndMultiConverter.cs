using System;

using System.Globalization;
using System.Windows.Data;

namespace WpfAppTemplate.Converters
{
    /// <summary>
    /// Ensure all components are True
    /// </summary>
    public class BooleanAndMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var result = true;

            foreach (var value in values)
            {
                if (value is bool)
                    result = result && (bool) value;
                else
                {
                    return false;
                }
            }

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
