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

namespace IMSApplication.Transaction
{
    /// <summary>
    /// Interaction logic for Forced_Weekend_Holidays.xaml
    /// </summary>
    public partial class Forced_Weekend_Holidays : Window
    {
        private MainWindow _parentwindow;
        public Forced_Weekend_Holidays(MainWindow mainwindow)
        {
            InitializeComponent();
            _parentwindow = mainwindow;
        }
    }
}
