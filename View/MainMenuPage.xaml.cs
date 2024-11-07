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

namespace PerpusDong.View
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenuPage : Window
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            View.LoginPage login = new View.LoginPage();
            login.Show();
            this.Close();
        }

        private void btnAnggota_Click(object sender, RoutedEventArgs e)
        {
            View.InputAnggotaPage angpa = new View.InputAnggotaPage();
            angpa.Show();
            this.Close();
        }

        private void btnPeminjaman_Click(object sender, RoutedEventArgs e)
        {
            View.InputPeminjamanPage pemipa = new View.InputPeminjamanPage();
            pemipa.Show();
            this.Close();
        }

        private void btnPetugas_Click(object sender, RoutedEventArgs e)
        {
            View.PetugasPage petupa = new View.PetugasPage();
            petupa.Show();
            this.Close();
        }

        private void btnBuku_Click(object sender, RoutedEventArgs e)
        {
            View.InputBukuPage bukupa = new View.InputBukuPage();
            bukupa.Show();
            this.Close();
        }
    }
}
