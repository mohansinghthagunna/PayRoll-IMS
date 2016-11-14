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

namespace IMSApplication.Report
{
    /// <summary>
    /// Interaction logic for Employee_List_Gradewise.xaml
    /// </summary>
    public partial class Employee_List_Gradewise : Window
    {
        private MainWindow _parentWindow;
        public Employee_List_Gradewise(MainWindow mainwindow)
        {
            InitializeComponent();
            _parentWindow = mainwindow;
        }
    }
}
