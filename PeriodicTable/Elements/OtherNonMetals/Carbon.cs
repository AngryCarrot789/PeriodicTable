using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Elements.OtherNonMetals
{
    public class Carbon : IElement
    {
        public string ElementName => GetType().Name;
        public string ElementSymbol => "C";
        public double AtomicNumber => 6;
        public double AtomicMass => 12.011;
        public ElementGroups Group => ElementGroups.OtherNonMetal;
        public Density Density => new Density(1, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(1, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(1, TempratureUnits.Celsius);
        public int ShellCount => 2;
        public int Shell1Electrons => 2;
        public int Shell2Electrons => 4;
        public int Shell3Electrons => 0;
        public int Shell4Electrons => 0;
        public int Shell5Electrons => 0;
        public int Shell6Electrons => 0;
        public int Shell7Electrons => 0;
        public int Shell8Electrons => 0;
        public string ShellStructure => "2, 4";
        public int Protons => 6;
        public int Neutrons => 6;
        public int Electrons => 6;
    }
}
