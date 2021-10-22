using imIOmeter_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace imIOmeter
{
    /// <summary>
    /// Interaktionslogik für Tabs.xaml
    /// </summary>
    public partial class Tabs : Window
    {
        private static imIOmeter_Utility imIOmeter_utility;
        public BindingList<DriveData> DrivesToDisplay { get; set; }

        public Tabs()
        {
            InitializeComponent();
            // Setup utility helper class.
            imIOmeter_utility = new imIOmeter_Utility();
            // Display a list of connected drives to the user.
            DrivesToDisplay = new BindingList<DriveData>();
            imIOmeter_utility.PopulateDrivesToSelect(DrivesToDisplay, DriveDropDownMenu);
        }
         private void JEDECStandardComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            JEDECStandardComboBox.Items.Add("Enterprise");
            JEDECStandardComboBox.Items.Add("Client");

        }

        private void DriveDropDownMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
