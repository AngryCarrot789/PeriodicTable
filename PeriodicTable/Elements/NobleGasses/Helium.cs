using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Elements.NobleGasses
{
    public class Helium : IElement
    {
        public string ElementName => GetType().Name;
        public string ElementSymbol => "He";
        public double AtomicNumber => 2;
        public double AtomicMass => 4.0026;
        public ElementGroups Group => ElementGroups.NobleGas;
        public Density Density => new Density(0.18, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(-272.2, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(-268.93, TempratureUnits.Celsius);
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
        public int Protons => 2;
        public int Neutrons => 2;
        public int Electrons => 2;
    }
}
