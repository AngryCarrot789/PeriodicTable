using MahApps.Metro.Controls;
using System;

namespace PeriodicTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Closed(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
