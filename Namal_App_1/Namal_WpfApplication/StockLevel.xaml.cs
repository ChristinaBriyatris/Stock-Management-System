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

namespace Namal_WpfApplication
{
    /// <summary>
    /// Interaction logic for StockLevel.xaml
    /// </summary>
    public partial class StockLevel : Window
    {
        N_SServiceReference1.Service1Client ServiceClientObject = new N_SServiceReference1.Service1Client();
        public StockLevel()
        {
            InitializeComponent();
        }

        private void b_add_Click(object sender, RoutedEventArgs e) // changed Item_Id in to stock_Id & Item_Name in to Item_Id
        {
            {
                String mesg;
                Stock_tbl sld = new Stock_tbl();
                sld.Stock_Id = Convert.ToInt32(txtslS_id.Text);
                sld.Item_Id =int.Parse( txtsl_Id.Text);
                sld.Reorder_Limit = int.Parse(txtsl_d.Text);
                sld.Current_Stock_Level = Convert.ToInt32(txtcsl.Text);               
                sld.Current_Stock_Level = int.Parse(txtcsl.Text);
                mesg = ServiceClientObject.InsertStockDetails(sld);
                MessageBox.Show(mesg);
            }
        }

        private void txtsl_Id_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtsl_Id.Text = ServiceClientObject.ItemDetailsByItmID(txtsl_Id.Text).ToString();
        }


        private void b_asl_Click(object sender, RoutedEventArgs e)
        {
            search.Visibility = Visibility.Collapsed;
            txtsearch.Visibility = Visibility.Collapsed;
            txtslS_id.Text = ServiceClientObject.nextSupplierID().ToString();
            txtslS_id.IsEnabled = false;
        }

        public class iD 
        {
            public int itemI { get; set; }
            public string itemN { get; set; }
        }
        List<iD> IDD = new List<iD>();

        private void txtslS_id_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void b_home_Click(object sender, RoutedEventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Close();
        }

        private void b_cancle_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        private void b_updatesl_Click(object sender, RoutedEventArgs e)
        {
            txtsearch.Visibility = Visibility.Visible;
            search.Visibility = Visibility.Visible;
        }

        private void b_deletesl_Click(object sender, RoutedEventArgs e)
        {
            txtsearch.Visibility = Visibility.Visible;
            search.Visibility = Visibility.Visible;
        }

        
    }
}
