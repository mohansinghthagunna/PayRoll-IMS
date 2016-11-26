using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace IMSApplication.Device_Settings
{
    /// <summary>
    /// Interaction logic for AddressSettings.xaml
    /// </summary>
    public partial class AddressSettings : Window
    {
        public ObservableCollection<DeviceList> _DeviceList = new ObservableCollection<DeviceList>();
        public ObservableCollection<DeviceList> DeviceLists { get { return _DeviceList; } set { _DeviceList = value; } }

        public AddressSettings()
        {
            InitializeComponent();
            Loaded += AddressSettings_Loaded;
            this.DataContext = this;
        }

        private void AddressSettings_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateDeviceList();
        }

        private void PopulateDeviceList()
        {
            DeviceList item = new DeviceList
            {
                SN = "1",
                ChannelNo = "1280",
                DeviceNo = "E345",
                PortNo = "8989",
                IPAddress = "192.168.1.1",
                DeviceModel = "Moba Tech",
                DisplayName = "Supors Variety",
                BaudRate = "1.46 KHz"
            };

            DeviceLists.Add(item);
        }

        public class DeviceList
        {
            public string SN { get; set; }
            public string ChannelNo { get; set; }
            public string DeviceNo { get; set; }
            public string PortNo { get; set; }
            public string IPAddress { get; set; }
            public string DeviceModel { get; set; }
            public string DisplayName { get; set; }
            public string BaudRate { get; set; }
        }
    }
}
