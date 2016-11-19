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

namespace IMSApplication.Report.Time_Logs
{
    /// <summary>
    /// Interaction logic for TimeLog_Daily.xaml
    /// </summary>
    public partial class TimeLog_Daily : Window
    {
        private MainWindow _parentwindow;
        public TimeLog_Daily(MainWindow mainwindow)
        {
            InitializeComponent();
            _parentwindow = mainwindow;
        }
    }
}
