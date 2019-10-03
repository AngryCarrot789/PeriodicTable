using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;

namespace PeriodicTable.Elements
{
    public class Element
    {
        //Element 
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

        //Atom
        public int Protons { get; set; }
        public int Neutrons { get; set; }
        public int Electrons { get; set; }
        public bool Radioactive { get; set; }

        //Ion stuff
        //Same metal can have 2 different ion things
        //Like how iron can have +2 or +3
        public int IonCharge1 { get; set; }
        public int IonCharge2 { get; set; }
        //idk just says if you've given something a charge or not. might remove later cus charge 1 or 2 will be 0 if not used :/
        public bool IonChargesSetup { get; set; }
    }
}
