using IMS;
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

namespace IMSApplication.Master_Setting
{
    /// <summary>
    /// Interaction logic for Employee_Detail.xaml
    /// </summary>
    public partial class Employee_Detail : Window
    {
        private MainWindow _parentwindow;
        public Employee_Detail(MainWindow mainWindow)
        {
            _parentwindow = mainWindow;
            InitializeComponent();
        }
    }
}
