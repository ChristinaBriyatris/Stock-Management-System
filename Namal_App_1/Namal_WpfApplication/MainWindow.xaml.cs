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
//using Namal_WpfApplication.N_SServiceReference1;

namespace Namal_WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        N_SServiceReference1.Service1Client ServiceClientObject = new N_SServiceReference1.Service1Client();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lgn_Click(object sender, RoutedEventArgs e)
        {
            String Password = ServiceClientObject.get_pass(txtusername.Text);
            if (txtpassword.Password == Password)
            {
                
                Home H = new Home();
                H.Show();
                this.Close();
            }
            else
                MessageBox.Show("please enter correct Username and Password");
        }

    }
}
