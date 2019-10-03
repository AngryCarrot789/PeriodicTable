using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeriodicTable.ElementUtilities;
using PeriodicTable.Units;
using PeriodicTable.Units.Units;

namespace PeriodicTable.Elements
{
    public class Iron : IElement
    {
        #region Element
        public string ElementName => "Iron";
        public string ElementSymbol => "Fe";
        public double AtomicNumber => 26;
        public double AtomicMass => 55.845;
        public ElementGroups Group => ElementGroups.TransitionMetal;
        public Density Density => new Density(7.874, DensityUnits.GramPerCM3);
        public Temprature MeltingPoint => new Temprature(1537.85, TempratureUnits.Celsius);
        public Temprature BoilingPoint => new Temprature(2860.85, TempratureUnits.Celsius);
        #endregion

        #region Atom
        public int Protons => 26;
        public int Neutrons => 30;
        public int Electrons => 26;
        #endregion

        #region shells
        public int ShellCount => 4;
        public int Shell1Electrons => 2;
        public int Shell2Electrons => 8;
        public int Shell3Electrons => 14;
        public int Shell4Electrons => 2;
        public int Shell5Electrons => 0;
        public int Shell6Electrons => 0;
        public int Shell7Electrons => 0;
        public int Shell8Electrons => 0;
        public string ShellStructure => "2, 8, 14, 2";
        //{
        //    get
        //    {
        //        string struc = "0";
        //
        //        switch (ShellCount)
        //        {
        //            case 1: struc = $"{Shell1Electrons}"; break;
        //            case 2: struc = $"{Shell1Electrons}, {Shell2Electrons} "; break;
        //            case 3: struc = $"{Shell1Electrons}, {Shell2Electrons}, {Shell3Electrons}"; break;
        //            case 4: struc = $"{Shell1Electrons}, {Shell2Electrons}, {Shell3Electrons}, {Shell4Electrons}"; break;
        //            case 5: struc = $"{Shell1Electrons}, {Shell2Electrons}, {Shell3Electrons}, {Shell4Electrons}, {Shell5Electrons}"; break;
        //            case 6: struc = $"{Shell1Electrons}, {Shell2Electrons}, {Shell3Electrons}, {Shell4Electrons}, {Shell5Electrons}, {Shell6Electrons}"; break;
        //            case 7: struc = $"{Shell1Electrons}, {Shell2Electrons}, {Shell3Electrons}, {Shell4Electrons}, {Shell5Electrons}, {Shell6Electrons}, {Shell7Electrons}"; break;
        //            case 8: struc = $"{Shell1Electrons}, {Shell2Electrons}, {Shell3Electrons}, {Shell4Electrons}, {Shell5Electrons}, {Shell6Electrons}, {Shell7Electrons}, {Shell8Electrons}"; break;
        //        }
        //
        //        return struc;
        //    }
        //}
        #endregion
    }
}
