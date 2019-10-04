using PeriodicTable.ElementUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Elements
{
    public static class StaticElementGroupHolder
    {
        public static ElementGroup AlkaliMetal = new ElementGroup
        {
            Group = ElementGroups.AlkaliMetal,
            MainInformationTitle = "Alkali Metals",
            MainInformation = "They're some very reactive metals. They're found on the very left " +
            "of the periodic table",
            AtomInfoTitle = "Stats about them",
            AtomInfo = "Alkali metals are very reactive. So they have to be stored in oil so they " +
            "dont react with the oxygen in the air. as you go down the periodic table, the alkai " +
            "metals become increasingly more reactive; lithium is least reactive, potassium is quite " +
            "reactive, caesium... dont put it in water :/",
        };
    }
}
