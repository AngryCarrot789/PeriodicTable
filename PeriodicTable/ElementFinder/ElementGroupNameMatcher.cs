using PeriodicTable.Elements;
using PeriodicTable.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.ElementFinder
{
    public static class ElementGroupNameMatcher
    {
        public static ElementGroup FindElementGroupFromString(string group)
        {
            switch (group)
            {
                case "AlkaliMetal": return StaticElementGroupHolder.AlkaliMetal;
            }
            if (!LoggerWindow.WindowVisible)
            {
                LoggerWindow.ShowWindow();
            }
            LoggerWindow.AddError("Couldn't find group", group);
            return null;
        }
    }
}
