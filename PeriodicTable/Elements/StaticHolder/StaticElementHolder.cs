using PeriodicTable.Elements.AlkaliMetals;
using PeriodicTable.Elements.Metalloids;
using PeriodicTable.Elements.NobleGasses;
using PeriodicTable.Elements.OtherNonMetals;
using PeriodicTable.Elements.TransitionMetals;
using PeriodicTable.ElementUtilities;
using System.Collections.Generic;

namespace PeriodicTable.Elements
{
    public static class StaticElementHolder
    {
        public static Lithium Lithium = new Lithium();
        public static Potassium Potassium = new Potassium();
        public static Sodium Sodium = new Sodium();

        public static Boron Boron = new Boron();

        public static Argon Argon = new Argon();
        public static Helium Helium = new Helium();
        public static Neon Neon = new Neon();

        public static Carbon Carbon = new Carbon();
        public static Hydrogen Hydrogen = new Hydrogen();

        public static Aluminium Aluminium = new Aluminium();
        public static Iron Iron = new Iron();

        public static List<IElement> Elements = new List<IElement>
        {
            Lithium,
            Potassium,
            Sodium,
            Boron,
            Argon,
            Helium,
            Neon,
            Carbon,
            Hydrogen,
            Aluminium,
            Iron
        };
    }
}