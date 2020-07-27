using Stimulsoft.Report;
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

namespace Show_Dashboard_in_the_WPF_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();
        }

        private StiReport GetTemplate()
        {
            var report = StiReport.CreateNewDashboard();
            report.Load("Dashboards\\DashboardChristmas.mrt");

            return report;
        }

        private void Button_Click_Dialog(object sender, RoutedEventArgs e)
        {
            var report = GetTemplate();
            report.ShowWithWpf();
        }

        private void Button_Click_Panel(object sender, RoutedEventArgs e)
        {
            ViewerControl.Report = GetTemplate();
        }
    }
}
