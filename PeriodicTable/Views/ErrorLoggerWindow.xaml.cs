using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PeriodicTable.Views
{
    /// <summary>
    /// Interaction logic for ErrorLoggerWindow.xaml
    /// </summary>
    public partial class ErrorLoggerWindow : MetroWindow
    {
        public Action WndClosing { get; set; }
        public ErrorLoggerWindow()
        {
            InitializeComponent();
        }

        public void AddError(string errName, string description)
        {
            list.Items.Add($"{errName}: {description}");
        }

        public void AddMessage(string message)
        {
            list.Items.Add(message);
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            WndClosing?.Invoke();
        }
    }
}
