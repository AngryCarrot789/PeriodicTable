using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;

namespace PeriodicTable.Elements.OtherNonMetals
{
    public class Hydrogen : IElement
    {
        public string ElementName => GetType().Name;
        public string ElementSymbol => "H";
        public double AtomicNumber => 1;
        public double AtomicMass => 1.008;
        public ElementGroups Group => ElementGroups.OtherNonMetal;
        public Density Density => new Density(0.09, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(-259.34, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(-252.87, TempratureUnits.Celsius);
        public int ShellCount => 1;
        public int Shell1Electrons => 1;
        public int Shell2Electrons => 0;
        public int Shell3Electrons => 0;
        public int Shell4Electrons => 0;
        public int Shell5Electrons => 0;
        public int Shell6Electrons => 0;
        public int Shell7Electrons => 0;
        public int Shell8Electrons => 0;
        public string ShellStructure => "1";
        public int Protons =>  1;
        public int Neutrons => 0;
        public int Electrons => 1;
    }
}
