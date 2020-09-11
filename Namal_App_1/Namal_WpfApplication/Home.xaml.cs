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

namespace Namal_WpfApplication
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        N_SServiceReference1.Service1Client ServiceClientObject = new N_SServiceReference1.Service1Client();
        public Home()
        {
            InitializeComponent();
        }

        private void b_sd_Click(object sender, RoutedEventArgs e)
        {
            Supplier S = new Supplier();
            S.Show();
            S.suplIDtxt.Text = ServiceClientObject.nextSupplierID().ToString();
            S.suplIDtxt.IsEnabled = false;
            S.as_b.IsEnabled = false;
            this.Close();
        }

        private void b_id_Click(object sender, RoutedEventArgs e)
        {
            Item I = new Item();
            I.txtiid.Text = ServiceClientObject.nextItemID().ToString();
            I.search.Visibility = Visibility.Collapsed;
            I.Show();
            I.txtsearch.Visibility = Visibility.Collapsed;
            I.txtiid.IsEnabled = false;
            I.b_ai.IsEnabled = false;
            this.Close();
        }

        private void b_sl_Click(object sender, RoutedEventArgs e)
        {
            StockLevel SL = new StockLevel();
            SL.search.Visibility = Visibility.Collapsed;
            SL.txtsearch.Visibility = Visibility.Collapsed;
            SL.Show();
            this.Close();
        }

        private void b_p_Click(object sender, RoutedEventArgs e)
        {
            Payment P = new Payment();
            //P.txtiid.Text = ServiceClientObject.nextItemID().ToString();
            //P.search.Visibility = Visibility.Collapsed;
            P.Show();
            /*P.txtsearch.Visibility = Visibility.Collapsed;
            P.txtiid.IsEnabled = false;
            P.b_ai.IsEnabled = false;*/
            this.Close();
        }

        private void b_r_Click(object sender, RoutedEventArgs e)
        {
            MonthlyReport R = new MonthlyReport();
            
            R.Show();
            this.Close();
        }
    }
}
