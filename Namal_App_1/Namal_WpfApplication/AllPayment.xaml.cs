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
    /// Interaction logic for AllPayment.xaml
    /// </summary>
    public partial class GetAllPayment : Window
    {
        Service1Client Namal_client = new Service1Client();
        public GetAllPayment()
        {
            InitializeComponent();
            Payment_tbl[] ptbl = Namal_client.GetAllPayments();

            foreach (var v in ptbl)
            {
                listBox.Text = listBox.Text + v.Payment_Invoice_Id.ToString()  +"  "+  v.Amount.ToString()  +"  "+  v.Payment_Date 
                     +"  "+   v.Supplier_Id.ToString() +"\n";
            }
            
        }

      


        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Payment P = new Payment();
            P.Show();
            this.Close();
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Close();
        }

      
        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    
    }
}
