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
    /// Interaction logic for TimeLog_Monthly.xaml
    /// </summary>
    public partial class TimeLog_Monthly : Window
    {
        private MainWindow _parentwindow;
        public TimeLog_Monthly(MainWindow mainwindow)
        {
            InitializeComponent();
            _parentwindow = mainwindow;
        }

    }
}
