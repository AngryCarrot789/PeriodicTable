using PeriodicTable.ElementUtilities;
using PeriodicTable.Units.Units;

namespace PeriodicTable.Elements
{
    public static class StaticElementHolder
    {
        public static Element Lithium = new Element
        {
            ElementName = "Lithium",
            ElementSymbol = "Li",
            AtomicNumber = 3,
            AtomicMass = 6.941,
            Group = ElementGroups.AlkaliMetal,
            Density = new Density(0.53, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(180.55, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(1341.85, TempratureUnits.Celsius),
            ShellCount = 2,
            Shell1Electrons = 2,
            Shell2Electrons = 1,
            ShellStructure = "2, 1",
            Protons = 3,
            Neutrons = 4,
            Electrons = 3
        };
        public static Element Potassium = new Element
        {
            ElementName = "Potassium",
            ElementSymbol = "K",
            AtomicNumber = 19,
            AtomicMass = 39.0983,
            Group = ElementGroups.AlkaliMetal,
            Density = new Density(0.86, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(63.65, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(759.85, TempratureUnits.Celsius),
            ShellCount = 2,
            Shell1Electrons = 2,
            Shell2Electrons = 8,
            Shell3Electrons = 8,
            Shell4Electrons = 1,
            ShellStructure = "2, 8, 8, 1",
            Protons = 3,
            Neutrons = 4,
            Electrons = 3
        };
        public static Element Sodium = new Element
        {
            ElementName = "Sodium",
            ElementSymbol = "Na",
            AtomicNumber = 3,
            AtomicMass = 6.941,
            Group = ElementGroups.AlkaliMetal,
            Density = new Density(0.53, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(180.55, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(1341.85, TempratureUnits.Celsius),
            ShellCount = 2,
            Shell1Electrons = 2,
            Shell2Electrons = 1,
            ShellStructure = "2, 1",
            Protons = 3,
            Neutrons = 4,
            Electrons = 3
        };

        public static Element Boron = new Element
        {
            ElementName = "Boron",
            ElementSymbol = "B",
            AtomicNumber = 5,
            AtomicMass = 10.81,
            Group = ElementGroups.Metalloid,
            Density = new Density(1, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(700, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(1000, TempratureUnits.Celsius),
            ShellCount = 2,
            Shell1Electrons = 2,
            Shell2Electrons = 3,
            ShellStructure = "2, 3",
            Protons =5,
            Neutrons = 6,
            Electrons = 5
        };

        public static Element Argon = new Element
        {
            ElementName = "Argon",
            ElementSymbol = "Ar",
            AtomicNumber = 3,
            AtomicMass = 6.941,
            Group = ElementGroups.NobleGas,
            Density = new Density(0.53, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(180.55, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(1341.85, TempratureUnits.Celsius),
            ShellCount = 2,
            Shell1Electrons = 2,
            Shell2Electrons = 1,
            ShellStructure = "2, 1",
            Protons = 3,
            Neutrons = 4,
            Electrons = 3
        };
        public static Element Helium = new Element
        {
            ElementName = "Helium",
            ElementSymbol = "He",
            AtomicNumber = 2,
            AtomicMass = 4.0026,
            Group = ElementGroups.NobleGas,
            Density = new Density(0.18, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(-272.2, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(-268.93, TempratureUnits.Celsius),
            ShellCount = 1,
            Shell1Electrons = 2,
            ShellStructure = "2",
            Protons = 2,
            Neutrons = 2,
            Electrons = 2
        };
        public static Element Neon = new Element
        {
            ElementName = "Neon",
            ElementSymbol = "Ne",
            AtomicNumber = 10,
            AtomicMass = 20.1797,
            Group = ElementGroups.NobleGas,
            Density = new Density(0.90, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(-248.595, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(-246.046, TempratureUnits.Celsius),
            ShellCount = 2,
            Shell1Electrons = 2,
            Shell2Electrons = 8,
            ShellStructure = "2, 8",
            Protons = 10,
            Neutrons = 10,
            Electrons = 10
        };

        public static Element Carbon = new Element
        {
            ElementName = "Carbon",
            ElementSymbol = "C",
            AtomicNumber = 6,
            AtomicMass = 12.011,
            Group = ElementGroups.OtherNonMetal,
            Density = new Density(1, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(1000, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(5000, TempratureUnits.Celsius),
            ShellCount = 2,
            Shell1Electrons = 2,
            Shell2Electrons = 4,
            ShellStructure = "2, 4",
            Protons = 6,
            Neutrons = 6,
            Electrons = 6
        };
        public static Element Hydrogen = new Element
        {
            ElementName = "Hydrogen",
            ElementSymbol = "H",
            AtomicNumber = 3,
            AtomicMass = 6.941,
            Group = ElementGroups.OtherNonMetal,
            Density = new Density(0.53, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(180.55, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(1341.85, TempratureUnits.Celsius),
            ShellCount = 2,
            Shell1Electrons = 2,
            Shell2Electrons = 1,
            ShellStructure = "2, 1",
            Protons = 3,
            Neutrons = 4,
            Electrons = 3
        };

        public static Element Aluminium = new Element
        {
            ElementName = "Aluminium",
            ElementSymbol = "Al",
            AtomicNumber = 13,
            AtomicMass = 26.9815,
            Group = ElementGroups.PostTransitionMetal,
            Density = new Density(2.7, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(660.35, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(2466.85, TempratureUnits.Celsius),
            ShellCount = 3,
            Shell1Electrons = 2,
            Shell2Electrons = 8,
            Shell3Electrons = 3,
            ShellStructure = "2, 8, 3",
            Protons = 13,
            Neutrons = 14,
            Electrons = 13
        };
        public static Element Iron = new Element
        {
            ElementName = "Iron",
            ElementSymbol = "Fe",
            AtomicNumber = 26,
            AtomicMass = 55.845,
            Group = ElementGroups.TransitionMetal,
            Density = new Density(7.874d, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(1537.85d, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(2860.85d, TempratureUnits.Celsius),
            ShellCount = 4,
            Shell1Electrons = 2,
            Shell2Electrons = 8,
            Shell3Electrons = 14,
            Shell4Electrons = 2,
            ShellStructure = "2, 8, 14, 2",
            Protons = 26,
            Neutrons = 30,
            Electrons = 26
        };

        public static Element Uranium = new Element
        {
            ElementName = "Uranium",
            ElementSymbol = "U",
            AtomicNumber = 92,
            AtomicMass = 238,
            Group = ElementGroups.Actinide,
            Density = new Density(19.1d, DensityUnits.GramPerCM3),
            MeltingPoint = new Temprature(1132d, TempratureUnits.Celsius),
            BoilingPoint = new Temprature(4131d, TempratureUnits.Celsius),
            ShellCount = 7,
            Shell1Electrons = 2,
            Shell2Electrons = 8,
            Shell3Electrons = 18,
            Shell4Electrons = 32,
            Shell5Electrons = 21,
            Shell6Electrons = 9,
            Shell7Electrons = 2,
            ShellStructure = "2, 8, 18, 32,\n 21, 9, 2",
            Protons = 92,
            Neutrons = 146,
            Electrons = 92,
            Radioactive = true
        };
    }
}