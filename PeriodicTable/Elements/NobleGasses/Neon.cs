using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;

namespace PeriodicTable.Elements.NobleGasses
{
    public class Neon : IElement
    {
        public string ElementName => GetType().Name;
        public string ElementSymbol => "Ne";
        public double AtomicNumber => 10;
        public double AtomicMass => 20.1797;
        public ElementGroups Group => ElementGroups.NobleGas;
        public Density Density => new Density(0.9, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(-248.59, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(-246.046, TempratureUnits.Celsius);
        public int ShellCount => 2;
        public int Shell1Electrons => 2;
        public int Shell2Electrons => 8;
        public int Shell3Electrons => 0;
        public int Shell4Electrons => 0;
        public int Shell5Electrons => 0;
        public int Shell6Electrons => 0;
        public int Shell7Electrons => 0;
        public int Shell8Electrons => 0;
        public string ShellStructure => "2, 8";
        public int Protons => 10;
        public int Neutrons => 10;
        public int Electrons => 10;
    }
}
