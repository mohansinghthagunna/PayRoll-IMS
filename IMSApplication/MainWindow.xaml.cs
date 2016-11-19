using IMSApplication.Master_Setting;
using IMSApplication.Report;
using IMSApplication.Report.Hours_Worked_Daywise_;
using IMSApplication.Report.Leave_Report;
using IMSApplication.Report.Time_Logs;
using IMSApplication.Transaction;
using IMSApplication.Transaction.Leave_Management;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        //Start HyperLink Generator
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
        //End HyperLink Generator

        //Start File Menu Item Click
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
        //End File Menu Item Click


        //Start Transaction Mentu Item Click
        private void transactionMenuItemSelect(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":
                    break;

                case "1":
                    Force_Attendance forceAttendance = new Force_Attendance(this);
                    forceAttendance.Owner = this;
                    forceAttendance.Show();
                    break;
                case "3":
                    Travel_Entry_Slip travelEntrySlip = new Travel_Entry_Slip(this);
                    travelEntrySlip.Owner = this;
                    travelEntrySlip.Show();
                    break;
                case "4":
                    Travel_Attendance travelAttendance = new Travel_Attendance(this);
                    travelAttendance.Owner = this;
                    travelAttendance.Show();
                    break;

                case"7":
                    Forced_Weekend_Holidays forcedWeekendHoliday = new Forced_Weekend_Holidays(this);
                    forcedWeekendHoliday.Owner = this;
                    forcedWeekendHoliday.Show();
                    break;
                case"8":
                    Attendance_Absent_Remarks attendanceAbsentRemark = new Attendance_Absent_Remarks(this);
                    attendanceAbsentRemark.Owner = this;
                    attendanceAbsentRemark.Show();
                    break;
                case"9":
                    Office_Out_In_Remark officeOutInRemark = new Office_Out_In_Remark(this);
                    officeOutInRemark.Owner = this;
                    officeOutInRemark.Show();
                    break;
                case"10":
                    Personal_Out_In_Remark personalOutInRemark = new Personal_Out_In_Remark(this);
                    personalOutInRemark.Owner = this;
                    personalOutInRemark.Show();
                    break;
                case"11":
                    Official_Training officialTraining = new Official_Training(this);
                    officialTraining.Owner = this;
                    officialTraining.Show();
                    break;

            }
        }

        private void leaveManagementSubMenuItemSelect(object sender, RoutedEventArgs e)
        {
            switch((sender as MenuItem).Tag.ToString())
            {
                case"0":
                    Leave_Application leaveApplication = new Leave_Application(this);
                    leaveApplication.Owner = this;
                    leaveApplication.Show();
                    break;

                case"1":
                    Leave_Cancellation leaveCancellation = new Leave_Cancellation(this);
                    leaveCancellation.Owner = this;
                    leaveCancellation.Show();
                    break;
                case"2":
                    Negative_Leave_Form negativeLeaveForm = new Negative_Leave_Form(this);
                    negativeLeaveForm.Owner = this;
                    negativeLeaveForm.Show();
                    break;
                case"3":
                    break;
                case "4":
                    Add_Leave addLeave = new Add_Leave(this);
                    addLeave.Owner = this;
                    addLeave.Show();
                    break;
                case "5":
                    Leave_Adjust leaveAdjust = new Leave_Adjust(this);
                    leaveAdjust.Owner = this;
                    leaveAdjust.Show();
                    break;
            }
        }
        //End Transaction Mentu Item Click


        //Start MasteSetting Menu Item Click 
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
        //End MasteSetting Menu Item Click


        //Start Report Menu Item Click
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
                case "12":
                    Monthly_Late_Report monthlylatereport = new Monthly_Late_Report(this);
                    monthlylatereport.Owner = this;
                    monthlylatereport.Show();
                    break;
                case "13":
                    Monthly_Office_Out_In monthlyofficeoutin = new Monthly_Office_Out_In(this);
                    monthlyofficeoutin.Owner = this;
                    monthlyofficeoutin.Show();
                    break;
                case "14":
                    break;
                
                case "15":
                    Monthly_Band_Report monthlyBandReport = new Monthly_Band_Report(this);
                    monthlyBandReport.Owner = this;
                    monthlyBandReport.Show();
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

        private void timelogSubMenuSelect(object sender, RoutedEventArgs e)
        {
            switch ((sender as MenuItem).Tag.ToString())
            {
                case "0":
                    TimeLog_Monthly timeLogMonthly = new TimeLog_Monthly(this);
                    timeLogMonthly.Owner = this;
                    timeLogMonthly.Show();
                    break;
                case "1":
                    TimeLog_Daily timeLogDaily = new TimeLog_Daily(this);
                    timeLogDaily.Owner = this;
                    timeLogDaily.Show();
                    break;
            }
        }
        //End Report Menu Item Click
    }
}
