﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfAppTemplate.Converters
{
    public class ObjectExistsToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}