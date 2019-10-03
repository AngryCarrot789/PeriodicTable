using PeriodicTable.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PeriodicTable.ViewModels
{
    public class CommandsViewModel : BaseViewModel
    {
        public ICommand ShowIonicSolverCommand { get; set; }

        public CommandsViewModel()
        {
            ShowIonicSolverCommand = new Command(ShowIonicWindow);
        }

        #region Methods

        private void ShowIonicWindow(object eeoeo)
        {
            //foreach(IElement v1 in StaticElementHolder.Elements)
            //{
            //    foreach (var v2 in StaticElementHolder.Elements)
            //    {
            //        if (v2.Shell3Electrons == 6)
            //        {
            //            MessageBox.Show($"Match: {v1.ElementName}, {v2.ElementName}");
            //        }
            //    }
            //}
        }

        #endregion
    }
}
