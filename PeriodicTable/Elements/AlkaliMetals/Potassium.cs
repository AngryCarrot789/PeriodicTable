using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Elements.AlkaliMetals
{
    public class Potassium : IElement
    {
        public string ElementName => GetType().Name;
        public string ElementSymbol => "K";
        public double AtomicNumber => 0;
        public double AtomicMass => 0;
        public ElementGroups Group => ElementGroups.AlkaliMetal;
        public Density Density => new Density(1, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(1, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(1, TempratureUnits.Celsius);
        public int ShellCount => 1;
        public int Shell1Electrons => 2;
        public int Shell2Electrons => 0;
        public int Shell3Electrons => 0;
        public int Shell4Electrons => 0;
        public int Shell5Electrons => 0;
        public int Shell6Electrons => 0;
        public int Shell7Electrons => 0;
        public int Shell8Electrons => 0;
        public string ShellStructure => "2";
        public int Protons => 1;
        public int Neutrons => 1;
        public int Electrons => 1;
    }
}
