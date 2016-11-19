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
    /// Interaction logic for Personal_Out_In_Remark.xaml
    /// </summary>
    public partial class Personal_Out_In_Remark : Window
    {
        private MainWindow _parentwindow;
        public Personal_Out_In_Remark(MainWindow  mainwindow)
        {
            InitializeComponent();
            _parentwindow = mainwindow;
        }
    }
}
