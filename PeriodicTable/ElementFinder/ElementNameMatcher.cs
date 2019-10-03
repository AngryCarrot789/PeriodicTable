using PeriodicTable.Elements;
using PeriodicTable.ViewModels;

namespace PeriodicTable.ElementFinder
{
    public static class ElementNameMatcher
    {
        public static Element FindElementFromString(string elementName)
        {
            switch(elementName)
            {
                case "Li": return StaticElementHolder.Lithium;
                case "K":  return StaticElementHolder.Potassium;
                case "Na": return StaticElementHolder.Sodium;

                case "B":  return StaticElementHolder.Boron;

                case "Ar": return StaticElementHolder.Argon;
                case "He": return StaticElementHolder.Helium;
                case "Ne": return StaticElementHolder.Neon;

                case "C":  return StaticElementHolder.Carbon;
                case "H":  return StaticElementHolder.Hydrogen;

                case "Al": return StaticElementHolder.Aluminium;
                case "Fe": return StaticElementHolder.Iron;

                case "U": return StaticElementHolder.Uranium;
            }
            if (!LoggerWindow.WindowVisible) {
                LoggerWindow.ShowWindow();
            }
            LoggerWindow.AddError("Couldn't find element", elementName);
            return null;
        }
    }
}
