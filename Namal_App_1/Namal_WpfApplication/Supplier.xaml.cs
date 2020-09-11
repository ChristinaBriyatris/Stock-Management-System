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
    /// Interaction logic for Supplier.xaml
    /// </summary>
    public partial class Supplier : Window
    {
        N_SServiceReference1.Service1Client ServiceClientObject = new N_SServiceReference1.Service1Client();
        public Supplier()
        {
            InitializeComponent();
        }

        private void as_b_Click(object sender, RoutedEventArgs e)
        {
            txtsearch.Visibility = Visibility.Collapsed;
            search.Visibility = Visibility.Collapsed;
            add_b.Visibility = Visibility.Visible;
            updt_b.Visibility = Visibility.Collapsed;
            delt_b.Visibility = Visibility.Collapsed;
            cleartxt();
            suplIDtxt.Text = ServiceClientObject.nextSupplierID().ToString();
            suplIDtxt.IsEnabled = false;
            suplNametxt.IsEnabled = suplTeletxt.IsEnabled = true;
            as_b.IsEnabled = false;
            us_b.IsEnabled = ds_b.IsEnabled = true;
        }

        private void us_b_Click(object sender, RoutedEventArgs e)
        {
            txtsearch.Visibility = Visibility.Visible;
            search.Visibility = Visibility.Visible;
            add_b.Visibility = Visibility.Collapsed;
            updt_b.Visibility = Visibility.Visible;
            delt_b.Visibility = Visibility.Collapsed;
            cleartxt();
            us_b.IsEnabled = false;
            as_b.IsEnabled = ds_b.IsEnabled = true;
            suplNametxt.IsEnabled = suplTeletxt.IsEnabled = suplIDtxt.IsEnabled = true;
        }

        private void ds_b_Click(object sender, RoutedEventArgs e)
        {
            txtsearch.Visibility = Visibility.Visible;
            search.Visibility = Visibility.Visible;
            add_b.Visibility = Visibility.Collapsed;
            updt_b.Visibility = Visibility.Collapsed;
            delt_b.Visibility = Visibility.Visible;
            cleartxt();
            ds_b.IsEnabled = false;
            as_b.IsEnabled = us_b.IsEnabled = true;
            suplNametxt.IsEnabled = suplTeletxt.IsEnabled = false;
            suplIDtxt.IsEnabled = true;
        }

        private void clear_b_Click(object sender, RoutedEventArgs e)
        {
            cleartxt();
        }

        public void cleartxt()
        {
            suplIDtxt.Clear();
            suplNametxt.Clear();
            suplTeletxt.Clear();
        }

        private void add_b_Click(object sender, RoutedEventArgs e)
        {
            String mesg;
            Suppliers_tbl SupplierInfo = new Suppliers_tbl();
            SupplierInfo.Supplier_Id = Convert.ToInt32(suplIDtxt.Text);
            SupplierInfo.Supplier_Name = suplNametxt.Text;
            SupplierInfo.Phone_No = Convert.ToInt32(suplTeletxt.Text);
            mesg = ServiceClientObject.InsertSupplierDetails(SupplierInfo);
            MessageBox.Show(mesg);
        }

        private void updt_b_Click(object sender, RoutedEventArgs e)
        {
            String mesg, mesg2;
            mesg2 = ServiceClientObject.SupplierDetails(Convert.ToInt32(suplIDtxt.Text));
            MessageBoxResult re= MessageBox.Show(mesg2, "You are going to Update Supplier", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if (re.Equals(MessageBoxResult.OK))
            {
                Suppliers_tbl SupplierInfo = new Suppliers_tbl();
                SupplierInfo.Supplier_Id = Convert.ToInt32(suplIDtxt.Text);
                SupplierInfo.Supplier_Name = suplNametxt.Text;
                SupplierInfo.Phone_No = Convert.ToInt32(suplTeletxt.Text);
                mesg = ServiceClientObject.UpdateSupplierDetails(SupplierInfo);
                MessageBox.Show(mesg);
            }
            else
                cleartxt();
        }

        private void delt_b_Click(object sender, RoutedEventArgs e)
        {
            String mesg;
            mesg = ServiceClientObject.DeleteSupplierDetails(Convert.ToInt32(suplIDtxt.Text));
            MessageBox.Show(mesg);
        }

        private void home_b_Click(object sender, RoutedEventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Close();
        }

        private void suplTeletxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            int tele;
            if (String.IsNullOrWhiteSpace(suplTeletxt.Text).Equals(false) && !int.TryParse(suplTeletxt.Text, out tele))
                checkW.Visibility = Visibility.Visible;
            else
                checkW.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
