﻿using System;
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
    /// Interaction logic for Monthly_Band_Report.xaml
    /// </summary>
    public partial class Monthly_Band_Report : Window
    {
        private MainWindow _parentwindow;
        public Monthly_Band_Report(MainWindow mainwindow)
        {
            InitializeComponent();
            _parentwindow = mainwindow;
        }
    }
}
