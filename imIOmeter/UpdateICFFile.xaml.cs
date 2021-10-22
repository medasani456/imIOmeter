using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaktionslogik für UpdateICFFile.xaml
    /// </summary>
    public partial class UpdateICFFile : Window
    {

        public string meaniops;
        public string stdeviops;
        public string miniops;
        public string maxiops;
        public string meanmbps;
        public string stdevmbps;
        public string minmbps;
        public string maxmbps;
        public string _latency;

        String current_path = "";
        // Set the current working directory path.

        public UpdateICFFile()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            current_path = Environment.CurrentDirectory;
            string text = File.ReadAllText(current_path + "\\RefereneceICF.txt");


            text = text.Replace("REFER1", meaniops);
            text = text.Replace("REFER2", stdeviops);
            text = text.Replace("REFER3", miniops);
            text = text.Replace("REFER4", maxiops);
            text = text.Replace("REFER5", meanmbps);
            text = text.Replace("REFER6", stdevmbps);
            text = text.Replace("REFER7", minmbps);
            text = text.Replace("REFER8", maxmbps);
            text = text.Replace("REFER9", _latency);

            File.WriteAllText(current_path + "\\IOmeterConfigFiles\\Random Writes Queue Depth 32.icf", text);



            if (MessageBox.Show("Would you like to close Window?", "Parameters updated", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                // no
            }
            else
            {
                this.Close();
            }


        }

        private void TextBox_meanIOps(object sender, TextChangedEventArgs e)
        {
            meaniops = meanIOps.Text;
        }

        private void TextBox_StdevIOps(object sender, TextChangedEventArgs e)
        {

            stdeviops = StdevIOps.Text;

        }

        private void TextBox_minIOps(object sender, TextChangedEventArgs e)
        {
            miniops = minIOps.Text;

        }

        private void TextBox_maxIOps(object sender, TextChangedEventArgs e)
        {
            maxiops = maxIOps.Text;
        }

        private void TextBox_meanMBps(object sender, TextChangedEventArgs e)
        {
            meanmbps = meanMBps.Text;


        }

        private void TextBox_StdevMBps(object sender, TextChangedEventArgs e)
        {
            stdeviops = StdevIOps.Text;

        }

        private void TextBox_minMBps(object sender, TextChangedEventArgs e)
        {
            minmbps = minMBps.Text;

        }

        private void TextBox_maxMBps(object sender, TextChangedEventArgs e)
        {
            maxmbps = maxMBps.Text;

        }

        private void TextBox_mlatency(object sender, TextChangedEventArgs e)
        {
            _latency = mlatency.Text;
        }

        private void DriveDropDownMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    
}
