using PeriodicTable.Elements;
using PeriodicTable.ElementUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PeriodicTable.ElementFinder
{
    public static class ElementNameMatcher
    {
        public static IElement FindElementFromString(string elementName)
        {
            switch(elementName)
            {
                case "Li": return StaticElementHolder.Lithium;
                case "K": return StaticElementHolder.Potassium;
                case "Na": return StaticElementHolder.Sodium;

                case "B": return StaticElementHolder.Boron;

                case "Ar": return StaticElementHolder.Argon;
                case "He": return StaticElementHolder.Helium;
                case "Ne": return StaticElementHolder.Neon;

                case "C": return StaticElementHolder.Carbon;
                case "H": return StaticElementHolder.Hydrogen;

                case "Al": return StaticElementHolder.Aluminium;
                case "Fe": return StaticElementHolder.Iron;
            }
            MessageBox.Show($"Couldn't find element: {elementName}");
            return null;
        }
    }
}
