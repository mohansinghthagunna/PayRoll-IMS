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

namespace IMS
{
    /// <summary>
    /// Interaction logic for Brands.xaml
    /// </summary>
    public partial class Brands : Window
    {
        private MainWindow _parentWindow;
        public Brands(MainWindow mainWindow)
        {
            InitializeComponent();
            _parentWindow = mainWindow;
        }
    }
}
