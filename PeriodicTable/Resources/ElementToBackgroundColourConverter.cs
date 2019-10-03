using PeriodicTable.ElementUtilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                case ElementGroups.AlkaliMetal:         brush = new SolidColorBrush(Color.FromRgb(224, 175, 25)); break;
                case ElementGroups.AlkaliEarthMetal:    brush = new SolidColorBrush(Color.FromRgb(207, 207, 27)); break;
                case ElementGroups.Lanthanide:          brush = new SolidColorBrush(Color.FromRgb(255, 117, 47)); break;
                case ElementGroups.Actinide:            brush = new SolidColorBrush(Color.FromRgb(253, 145, 218)); break;
                case ElementGroups.TransitionMetal:     brush = new SolidColorBrush(Color.FromRgb(247, 94, 94)); break;
                case ElementGroups.UnknownProperties:   brush = new SolidColorBrush(Color.FromRgb(210, 210, 210)); break;
                case ElementGroups.PostTransitionMetal: brush = new SolidColorBrush(Color.FromRgb(62, 187, 142)); break;
                case ElementGroups.Metalloid:           brush = new SolidColorBrush(Color.FromRgb(45, 184, 68)); break;
                case ElementGroups.OtherNonMetal:       brush = new SolidColorBrush(Color.FromRgb(19, 220, 19)); break;
                case ElementGroups.Halogen:             brush = new SolidColorBrush(Color.FromRgb(131, 255, 45)); break;
                case ElementGroups.NobleGas:            brush = new SolidColorBrush(Color.FromRgb(41, 153, 222)); break;
            }
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
