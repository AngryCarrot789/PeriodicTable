using System.Windows.Media;

namespace PeriodicTable.Resources
{
    public static class ElementGroupColours
    {
        public static SolidColorBrush AlkaliMetal         => new SolidColorBrush(Color.FromRgb(224, 175, 25));
        public static SolidColorBrush AlkaliEarthMetal    => new SolidColorBrush(Color.FromRgb(207, 207, 27));
        public static SolidColorBrush Lanthanide          => new SolidColorBrush(Color.FromRgb(255, 117, 47));
        public static SolidColorBrush Actinide            => new SolidColorBrush(Color.FromRgb(253, 145, 218));
        public static SolidColorBrush TransitionMetal     => new SolidColorBrush(Color.FromRgb(247, 94, 94));
        public static SolidColorBrush UnknownProperties   => new SolidColorBrush(Color.FromRgb(210, 210, 210));
        public static SolidColorBrush PostTransitionMetal => new SolidColorBrush(Color.FromRgb(62, 187, 142));
        public static SolidColorBrush Metalloid           => new SolidColorBrush(Color.FromRgb(45, 184, 68));
        public static SolidColorBrush OtherNonMetal       => new SolidColorBrush(Color.FromRgb(19, 220, 19));
        public static SolidColorBrush Halogen             => new SolidColorBrush(Color.FromRgb(131, 255, 45));
        public static SolidColorBrush NobleGas            => new SolidColorBrush(Color.FromRgb(41, 153, 222));
    }
}
