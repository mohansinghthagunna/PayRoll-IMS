using IMSApplication.Master_Setting;
using IMSApplication.Report;
using IMSApplication.Report.Hours_Worked_Daywise_;
using IMSApplication.Report.Leave_Report;
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

        private void reportMenuselect(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":
                    break;
                case "1":
                    Monthly_Travel_Report monthlytravelreport = new Monthly_Travel_Report(this);
                    monthlytravelreport.Owner = this;
                    monthlytravelreport.Show();
                    break;
                case "2":
                    Monthly_Attendance_Summary monthlyattendancesummary = new Monthly_Attendance_Summary(this);
                    monthlyattendancesummary.Owner = this;
                    monthlyattendancesummary.Show();
                    break;
                case "3":
                    break;
                case "4":
                    Employee_Daily_Attendance_Report employeedailyattendancereport = new Employee_Daily_Attendance_Report(this);
                    employeedailyattendancereport.Owner = this;
                    employeedailyattendancereport.Show();
                    break;
                case "5":
                    Employee_Daily_Absent_Report employeedailyabsentreport = new Employee_Daily_Absent_Report(this);
                    employeedailyabsentreport.Owner = this;
                    employeedailyabsentreport.Show();
                    break;
                case "6":

                    break;
                case "7":
                    Employee_List employeelist = new Employee_List(this);
                    employeelist.Owner=this;
                    employeelist.Show();
                    break;
                case "8":
                    break;
                
                case "9":
                    Employee_List_Gradewise employeelistgradewise=new Employee_List_Gradewise(this);
                    employeelistgradewise.Owner=this;
                    employeelistgradewise.Show();
                    break;
                case "10":

                    break;
                case "11":
                    Attendance_Summary__Daywise_ attendancesummarydaywise = new Attendance_Summary__Daywise_(this);
                    attendancesummarydaywise.Owner = this;
                    attendancesummarydaywise.Show();
                    break;
            }
        }

        private void LeaveReportSubMenuSelect(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":
                    Leave_Register leavereport = new Leave_Register(this);
                    leavereport.Owner = this;
                    leavereport.Show();
                    break;
                case "1":
                    Monthly_Leave_Detail monthlyleavedetail = new Monthly_Leave_Detail(this);
                    monthlyleavedetail.Owner = this;
                    monthlyleavedetail.Show();
                    break;
                case "2":
                    Annual_Leave_Register annualleaveregister = new Annual_Leave_Register(this);
                    annualleaveregister.Owner = this;
                    annualleaveregister.Show();
                    break;
            }
        }

        private void hoursworkedSubMenuSelect(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":
                    Hours_Worked_Summary_Daywise_ hoursworkedsummarydaywise = new Hours_Worked_Summary_Daywise_(this);
                    hoursworkedsummarydaywise.Owner = this;
                    hoursworkedsummarydaywise.Show();
                    break;
                case "1":
                    Hours_Worked_Detail_Daywise_ hoursworkeddetaidaywise = new Hours_Worked_Detail_Daywise_(this);
                    hoursworkeddetaidaywise.Owner=this;
                    hoursworkeddetaidaywise.Show();
                    break;
            }
        }

        

    }
}
