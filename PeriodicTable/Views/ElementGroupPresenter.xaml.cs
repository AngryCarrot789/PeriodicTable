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
    /// Interaction logic for ElementGroupPresenter.xaml
    /// </summary>
    public partial class ElementGroupPresenter : Window
    {
        public bool IsOpen { get; set; }
        public ElementGroupPresenter()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            IsOpen = false;
        }
    }
}
