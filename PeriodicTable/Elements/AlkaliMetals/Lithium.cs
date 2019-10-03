using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;

namespace PeriodicTable.Elements.AlkaliMetals
{
    public class Lithium : IElement
    { 
        public string ElementName => GetType().Name;
        public string ElementSymbol => "Li";
        public double AtomicNumber => 3;
        public double AtomicMass => 6.941;
        public ElementGroups Group => ElementGroups.AlkaliMetal;
        public Density Density => new Density(0.53, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(180.55, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(1341.85, TempratureUnits.Celsius);
        public int ShellCount => 2;
        public int Shell1Electrons => 2;
        public int Shell2Electrons => 1;
        public int Shell3Electrons => 0;
        public int Shell4Electrons => 0;
        public int Shell5Electrons => 0;
        public int Shell6Electrons => 0;
        public int Shell7Electrons => 0;
        public int Shell8Electrons => 0;
        public string ShellStructure => "2, 1";
        public int Protons => 3;
        public int Neutrons => 4;
        public int Electrons => 3;
    }
}
