using PeriodicTable.ElementUtilities;
using PeriodicTable.Resources;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace PeriodicTable
{
    [ValueConversion(typeof(ElementGroups), typeof(SolidColorBrush))]
    public class ElementToBackgroundColourConverter : IValueConverter
    {
        public static ElementToBackgroundColourConverter Instance = new ElementToBackgroundColourConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(10, 10, 10));
            switch((ElementGroups)value)
            {
                case ElementGroups.AlkaliMetal:         brush = ElementGroupColours.AlkaliMetal; break;
                case ElementGroups.AlkaliEarthMetal:    brush = ElementGroupColours.AlkaliEarthMetal; break;
                case ElementGroups.Lanthanide:          brush = ElementGroupColours.Lanthanide; break;
                case ElementGroups.Actinide:            brush = ElementGroupColours.Actinide; break;
                case ElementGroups.TransitionMetal:     brush = ElementGroupColours.TransitionMetal; break;
                case ElementGroups.UnknownProperties:   brush = ElementGroupColours.UnknownProperties; break;
                case ElementGroups.PostTransitionMetal: brush = ElementGroupColours.PostTransitionMetal; break;
                case ElementGroups.Metalloid:           brush = ElementGroupColours.Metalloid; break;
                case ElementGroups.OtherNonMetal:       brush = ElementGroupColours.OtherNonMetal; break;
                case ElementGroups.Halogen:             brush = ElementGroupColours.Halogen; break;
                case ElementGroups.NobleGas:            brush = ElementGroupColours.NobleGas; break;
            }
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
