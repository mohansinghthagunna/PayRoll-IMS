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
using IMS;
namespace IMSApplication.Report.Leave_Report
{
    /// <summary>
    /// Interaction logic for Annula_Leave_Register.xaml
    /// </summary>
    public partial class Annual_Leave_Register : Window
    {
        private MainWindow _parentwindow;
        public Annual_Leave_Register(MainWindow mainwindow)
        {
            InitializeComponent();
            _parentwindow = mainwindow;
        }
    }
}
