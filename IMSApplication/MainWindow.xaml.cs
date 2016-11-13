﻿using IMSApplication.Data_Utility;
using IMSApplication.Device_Settings;
using IMSApplication.Report;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object PersonamMap { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void companyinformation_Click(object sender, RoutedEventArgs e)
        {
            CompanyInformation ci = new CompanyInformation();
            ci.Show();
        }

        private void brand_click(object sender, RoutedEventArgs e)
        {
            Brands brand = new Brands(this);
            brand.Owner = this;
          //  this.IsEnabled = false;
            brand.Show();
            //this.IsEnabled = true;
        }

        private void branch_click(object sender, RoutedEventArgs e)
        {
            Branch branch = new Branch(this);
            branch.Owner = this;

            branch.Show();
        }

        
        private void monthlyAttendanceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MonthlyAttendance monthlyAttendace = new MonthlyAttendance(this);
            monthlyAttendace.Owner = this;
            monthlyAttendace.ShowDialog();
        }

        private void addressSettingsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddressSettings addressSettings = new AddressSettings();
            addressSettings.ShowDialog();
        }

        private void cardIdEmployeeMenuList_Click(object sender, RoutedEventArgs e)
        {
            CardIdEmployee cardIdEmployee = new CardIdEmployee();
            cardIdEmployee.ShowDialog();
        }

        private void backUpDatabaseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            BackUpDatabase backUpDatabase = new BackUpDatabase();
            backUpDatabase.ShowDialog();
        }

        private void personalMapMenuItem_Click(object sender, RoutedEventArgs e)
        {
            PersonalMap personalMap = new PersonalMap();
            personalMap.ShowDialog();
        }

        private void downloadDataMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DownloadData downloadData = new DownloadData();
            downloadData.ShowDialog();
        }

        private void restoreDatabaseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            RestoreDatabase restoreDatabase = new RestoreDatabase();
            restoreDatabase.ShowDialog();
        }
    }
}
