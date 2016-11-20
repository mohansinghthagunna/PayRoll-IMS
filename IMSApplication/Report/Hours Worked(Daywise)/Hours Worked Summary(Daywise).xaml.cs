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

namespace IMSApplication.Report.Hours_Worked_Daywise_
{
    /// <summary>
    /// Interaction logic for Hours_Worked_Summary_Daywise_.xaml
    /// </summary>
    public partial class Hours_Worked_Summary_Daywise_ : Window
    {
        private MainWindow _parentwindow;
        public Hours_Worked_Summary_Daywise_(MainWindow mainwindow)
        {
            InitializeComponent();
            _parentwindow = mainwindow;
        }
    }
}
