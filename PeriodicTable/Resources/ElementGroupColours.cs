using System.Windows.Media;

namespace PeriodicTable.Resources
{
    public static class ElementGroupColours
    {
        public static SolidColorBrush AlkaliMetal         => new SolidColorBrush(Color.FromRgb(241, 185, 10));
        public static SolidColorBrush AlkaliEarthMetal    => new SolidColorBrush(Color.FromRgb(220, 220, 14));
        public static SolidColorBrush Lanthanide          => new SolidColorBrush(Color.FromRgb(230, 72, 151)); //Just above the bottom one - Lanthanum
        public static SolidColorBrush Actinide            => new SolidColorBrush(Color.FromRgb(114, 85, 191)); //Very bottom - Uranium
        public static SolidColorBrush TransitionMetal     => new SolidColorBrush(Color.FromRgb(124, 192, 224));
        public static SolidColorBrush UnknownProperties   => new SolidColorBrush(Color.FromRgb(210, 210, 210));
        public static SolidColorBrush PostTransitionMetal => new SolidColorBrush(Color.FromRgb(31, 197, 144));
        public static SolidColorBrush Metalloid           => new SolidColorBrush(Color.FromRgb(45, 184, 68));
        public static SolidColorBrush OtherNonMetal       => new SolidColorBrush(Color.FromRgb(80, 218, 1));
        public static SolidColorBrush Halogen             => new SolidColorBrush(Color.FromRgb(136, 255, 37));
        public static SolidColorBrush NobleGas            => new SolidColorBrush(Color.FromRgb(41, 153, 222));
    }
}
