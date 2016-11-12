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
    }
}
