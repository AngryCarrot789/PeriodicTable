using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace PeriodicTable.Resources
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class RadioactiveIconVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool IsRadioactive = (bool)value;

            if (IsRadioactive)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visible = (Visibility)value;

            if (visible == Visibility.Visible)
                return true;
            else
                return false;
        }
    }
}