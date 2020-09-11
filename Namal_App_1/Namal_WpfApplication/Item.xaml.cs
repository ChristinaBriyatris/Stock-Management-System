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
    /// Interaction logic for Item.xaml
    /// </summary>
    public partial class Item : Window
    {
        N_SServiceReference1.Service1Client ServiceClientObject = new N_SServiceReference1.Service1Client();
        public Item()
        {
            InitializeComponent();
        }

        private void b_ai_Click(object sender, RoutedEventArgs e)
        {
            search.Visibility = Visibility.Collapsed;
            txtsearch.Visibility = Visibility.Collapsed;
            iadd_b.Visibility = Visibility.Visible;
            iupdt_b.Visibility = Visibility.Collapsed;
            idelt_b.Visibility = Visibility.Collapsed;
            cleartxt();
            txtiid.Text = ServiceClientObject.nextItemID().ToString();
            txtiid.IsEnabled = false;
            txtiname.IsEnabled = txt_d.IsEnabled = txt_s.IsEnabled = true;
            b_ai.IsEnabled = false;
            b_ui.IsEnabled = b_di.IsEnabled = true;
        }

        private void b_ui_Click(object sender, RoutedEventArgs e)
        {
            txtsearch.Visibility = Visibility.Visible;
            search.Visibility = Visibility.Visible;
            iadd_b.Visibility = Visibility.Collapsed;
            iupdt_b.Visibility = Visibility.Visible;
            idelt_b.Visibility = Visibility.Collapsed;
            txtiid.IsEnabled = txtiname.IsEnabled = txt_d.IsEnabled = txt_s.IsEnabled = true;
            cleartxt();
            b_ui.IsEnabled = false;
            b_ai.IsEnabled = b_di.IsEnabled = true;

        }

        private void b_di_Click(object sender, RoutedEventArgs e)
        {
            txtsearch.Visibility = Visibility.Visible;
            search.Visibility = Visibility.Visible;
            iadd_b.Visibility = Visibility.Collapsed;
            iupdt_b.Visibility = Visibility.Collapsed;
            idelt_b.Visibility = Visibility.Visible;
            cleartxt();
            b_di.IsEnabled = false;
            b_ai.IsEnabled = b_ui.IsEnabled = true;
            txtiid.IsEnabled = true;
            txtiname.IsEnabled = txt_d.IsEnabled  = txt_s.IsEnabled = false;
        }

     

        private void iadd_b_Click(object sender, RoutedEventArgs e)
        {
            String mesg;
            Item_tbl ItemInfo = new Item_tbl();
            ItemInfo.Item_Id = Convert.ToInt32(txtiid.Text);
            ItemInfo.Item_Name = txtiname.Text;
            ItemInfo.Item_Description = txt_d.Text;
            ItemInfo.Supplier_Id= int .Parse(txt_s.Text);
            ItemInfo.Price = Convert.ToInt32(txtre_o.Text);
            mesg = ServiceClientObject.InsertItemDetails(ItemInfo);
            MessageBox.Show(mesg);
        }

        private void iupdt_b_Click(object sender, RoutedEventArgs e)
        {
            String mesg, mesg2;
            mesg2 = ServiceClientObject.ItemDetails(Convert.ToInt32(txtiid.Text));
            MessageBoxResult re = MessageBox.Show(mesg2, "You are going to Update Item", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if (re.Equals(MessageBoxResult.OK))
            {
                Item_tbl ItemInfo = new Item_tbl();
                ItemInfo.Item_Id = Convert.ToInt32(txtiid.Text);
                ItemInfo.Item_Name = txtiname.Text;
                ItemInfo.Item_Description = txt_d.Text;
                ItemInfo.Supplier_Id = int .Parse(txt_s.Text);
                ItemInfo.Price = Convert.ToInt32(txtre_o.Text);
                mesg = ServiceClientObject.UpdateItemDetails(ItemInfo);
                MessageBox.Show(mesg);
                cleartxt();
            }
            else
                cleartxt();
        }

        private void idelt_b_Click(object sender, RoutedEventArgs e)
        {
            
            String mesg;
            mesg = ServiceClientObject.DeleteItemDetails(Convert.ToInt32(txtiid.Text));
            MessageBox.Show(mesg);
        }

        private void b_home_Click(object sender, RoutedEventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Close();
        }

        private void b_clear_Click(object sender, RoutedEventArgs e)
        {
            cleartxt();
        }

        public void cleartxt()
        {
            txtiid.Clear();
            txtiname.Clear();
            txt_d.Clear();
            txt_s.Clear();
            txtre_o.Clear();
        }

        private void txt_s_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void b_cancle_Click(object sender, RoutedEventArgs e)
        {

        }
       

    }
}
