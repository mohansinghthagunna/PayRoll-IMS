using IMSApplication.Master_Setting;
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
        public MainWindow()
        {
            InitializeComponent();
        }       

        //File Menu Item Click
        private void fileMenuSelect(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":
                    CompanyInformation ci = new CompanyInformation(this);
                    ci.Owner = this;
                    ci.Show();
                    break;
            }
        }


        //MasteSetting Menu Item Click
        private void masterSettingMenuSelect(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":
                    Employee_Detail employee_detail = new Employee_Detail(this);
                    employee_detail.Owner = this;
                    employee_detail.Show();
                    break;
                case "1":
                  
                    Bands brand = new Bands(this);
                    brand.Owner = this;
                    //  this.IsEnabled = false;
                    brand.Show();
                    //this.IsEnabled = true;
                    break;
                case "2":
                    Branch branch = new Branch(this);
                    branch.Owner = this;
                    branch.Show();
                    break;
                case "3":
                    
                    break;
                case "4":
                    break;
                case "5":
                    Grade grade = new Grade(this);
                    grade.Owner = this;
                    grade.Show();
                    break;
                case "6":
                    Holiday holiday = new Holiday(this);
                    holiday.Owner = this;
                    holiday.Show();
                    break;
                case "7":
                    Leave leave = new Leave(this);
                    leave.Owner = this;
                    leave.Show();
                    break;
            }
        }

        

    }
}
