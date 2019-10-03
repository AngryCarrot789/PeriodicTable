using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Elements.Metalloids
{
    public class Boron : IElement
    {
        public string ElementName => GetType().Name;
        public string ElementSymbol => "B";
        public double AtomicNumber => 5;
        public double AtomicMass => 10.81;
        public ElementGroups Group => ElementGroups.Metalloid;
        public Density Density => new Density(1, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(1, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(1, TempratureUnits.Celsius);
        public int ShellCount => 2;
        public int Shell1Electrons => 2;
        public int Shell2Electrons => 3;
        public int Shell3Electrons => 0;
        public int Shell4Electrons => 0;
        public int Shell5Electrons => 0;
        public int Shell6Electrons => 0;
        public int Shell7Electrons => 0;
        public int Shell8Electrons => 0;
        public string ShellStructure => "2, 3";
        public int Protons => 5;
        public int Neutrons => 6;
        public int Electrons => 5;
    }
}
