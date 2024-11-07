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
using System.Data.SqlClient;

namespace PerpusDong.View
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        //declare object controller
        private Controller.PetugasController cPetugas;

        public LoginPage()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //WindowState = WindowState.Maximized;
            //instance controller
            cPetugas = new Controller.PetugasController(this);
        }

        public void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (cPetugas.LoginPetugas() == true)
            {
                View.MainMenuPage mainmenu = new View.MainMenuPage();
                mainmenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Maaf id atau password anda salah :)", "Gagal");
                txtIDLogin.Text = "";
                txtPasswordLogin.Password = "";
            }
        }
    }
}
