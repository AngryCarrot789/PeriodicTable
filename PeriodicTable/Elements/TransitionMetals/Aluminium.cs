using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Elements.TransitionMetals
{
    public class Aluminium : IElement
    {
        public string ElementName => "Aluminium";
        public string ElementSymbol => "Al";
        public double AtomicNumber => 13;
        public double AtomicMass => 26.9815;
        public ElementGroups Group => ElementGroups.PostTransitionMetal;
        public Density Density => new Density(2.7, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(660.35, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(2466.85, TempratureUnits.Celsius);
        public int ShellCount => 3;
        public int Shell1Electrons => 2;
        public int Shell2Electrons => 8;
        public int Shell3Electrons => 3;
        public int Shell4Electrons => 0;
        public int Shell5Electrons => 0;
        public int Shell6Electrons => 0;
        public int Shell7Electrons => 0;
        public int Shell8Electrons => 0;
        public string ShellStructure => "2, 8, 3";
        public int Protons => 13;
        public int Neutrons => 14;
        public int Electrons => 13;
    }
}
