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
using Namal_WpfApplication.N_SServiceReference1;
using System.Windows.Controls.Primitives;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports.Design;
using CrystalDecisions.ReportSource;

namespace Namal_WpfApplication
{
    /// <summary>
    /// Interaction logic for MonthlyReport.xaml
    /// </summary>
    public partial class MonthlyReport : Window
    {
        Service1Client Namal_client = new Service1Client();
        public MonthlyReport()
        {
            InitializeComponent();

            var sidepanel = crystalReportsViewer.FindName("btnToggleSidePanel") as ToggleButton;

            if (sidepanel != null)
            {
                crystalReportsViewer.ViewChange += (x, y) => sidepanel.IsChecked = false;
            }

        }

        public void setReportSource(CrystalDecisions.CrystalReports.Engine.ReportDocument aReport)
        {
            this.crystalReportsViewer.ViewerCore.ReportSource = aReport;
        }

        public void Display_report(ReportClass rc, object objDataSource, Window parentWindow)
        {
            try
            {
                rc.SetDataSource(objDataSource);
                this.setReportSource(rc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Close();
        }

        private void btn_View_Click(object sender, RoutedEventArgs e)
        {
            


        }
    }
}
