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

namespace IMSApplication.Transaction.Leave_Management
{
    /// <summary>
    /// Interaction logic for Leave_Adjust.xaml
    /// </summary>
    public partial class Leave_Adjust : Window
    {
        private MainWindow _parentwindow;
        public Leave_Adjust(MainWindow mainwindow)
        {
            InitializeComponent();
            _parentwindow = mainwindow;
        }
    }
}
