using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Elements
{
    public class Element
    {
        public string ElementName { get; set; }
        public string ElementSymbol { get; set; }
        public double AtomicNumber { get; set; }

        public double AtomicMass { get; set; }
        public ElementGroups Group { get; set; }
        public Density Density { get; set; }
        public Temprature MeltingPoint { get; set; }
        public Temprature BoilingPoint { get; set; }
        public int ShellCount { get; set; }
        public int Shell1Electrons { get; set; }
        public int Shell2Electrons { get; set; }
        public int Shell3Electrons { get; set; }
        public int Shell4Electrons { get; set; }
        public int Shell5Electrons { get; set; }
        public int Shell6Electrons { get; set; }
        public int Shell7Electrons { get; set; }
        public int Shell8Electrons { get; set; }
        public string ShellStructure { get; set; }
        public int Protons { get; set; }
        public int Neutrons { get; set; }
        public int Electrons { get; set; }
    }
}
