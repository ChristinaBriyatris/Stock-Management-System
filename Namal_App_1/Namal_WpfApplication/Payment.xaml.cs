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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        Service1Client Namal_client = new Service1Client();
        public Payment()
        {
            InitializeComponent();
        }

      

            private void btn2_Click_2(object sender, RoutedEventArgs e) //Calling deleting method from wcf service1 delete_Payment method*\
            {
            Namal_client.DeletePayment(int.Parse(txt_Pid.Text));

            MessageBox.Show("Deleted");

            Home mw = new Home();
            mw.Show();
            this.Close();


            //Namal_client.DeletePayment(int.Parse(txt_Pid.Text));
            //MessageBox.Show("Deleted");  
            //ClearAll();
        }

        private void ClearAll()
        {
            txt_Amount.Text = "";
            //txtI_Id.Text = "";
            txt_Pid.Text = "";
            datePicker1.Text = "";
            textBox.Text = "";
            txt_Sid.Text = "";
        }

            private void btn3_Click_3(object sender, RoutedEventArgs e)
            {
                ClearAll();
            }

            private void btn5_Click_5(object sender, RoutedEventArgs e)
            {
               var v = Namal_client.Search_Payments(int.Parse(textBox.Text));

            if (v.Length > 0)
            {
                txt_Pid.Text = textBox.Text;


                for (int i = 0; i < 2; i++)
                {
                    txt_Amount.Text = v[0];
                    datePicker1.Text = v[1];
                    
                }
            }
            else
            {
                MessageBox.Show("The specified item not found","Not Found",MessageBoxButton.OK,MessageBoxImage.Question);
            }

                
            }

            private void btn1_Click(object sender, RoutedEventArgs e)
            {
            try

                {


                if (MessageBox.Show("Are You sure You want to Add", "Add Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Namal_client.Add_Payment(int.Parse(txt_Pid.Text), DateTime.Now, float.Parse(txt_Amount.Text), int.Parse(txt_Sid.Text));

                    MessageBox.Show("Successfully Added!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Payment_Invoice_Id");

            }


            }

            private void btn4_Click(object sender, RoutedEventArgs e)
            {
                Home H = new Home();
                H.Show();
                this.Close();
            }

        private void btn6_Click(object sender, RoutedEventArgs e)
        { 
            GetAllPayment A = new GetAllPayment ();
            A.Show();
            this.Close();
        }

      
    }
    }

