using PeriodicTable.Elements;
using PeriodicTable.Units.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.ElementUtilities
{
    public interface IElement : IAtom
    {
        string ElementName { get; }
        string ElementSymbol { get; }
        double AtomicNumber { get; }
        double AtomicMass { get; }
        ElementGroups Group { get; }
        Density Density { get; }
        Temprature MeltingPoint { get; }
        Temprature BoilingPoint { get; }
        int ShellCount { get; }
        int Shell1Electrons  { get; }
        int Shell2Electrons  { get; }
        int Shell3Electrons  { get; }
        int Shell4Electrons  { get; }
        int Shell5Electrons  { get; }
        int Shell6Electrons  { get; }
        int Shell7Electrons  { get; }
        int Shell8Electrons { get; }
        string ShellStructure { get; }
    }
}
