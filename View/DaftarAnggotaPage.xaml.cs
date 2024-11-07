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
    /// Interaction logic for AnggotaPage.xaml
    /// </summary>
    public partial class DaftarAnggotaPage : Window
    {
        //1. private object controller
        private Controller.AnggotaController cAnggota;

        public DaftarAnggotaPage()
        {
            InitializeComponent();
            //2. instance
            cAnggota = new Controller.AnggotaController(this);
            cAnggota.SelectAnggota();
        }

        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            View.MainMenuPage mmp = new View.MainMenuPage();
            mmp.Show();
            this.Close();
        }

        private void btnInputAnggota_Click (object sender, RoutedEventArgs e)
        {
            View.InputAnggotaPage iap = new View.InputAnggotaPage();
            iap.Show();
            this.Close();
        }

        private void btnDaftarAnggota_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anda Sudah di Halaman Daftar Anggota :)", "Gagal");
        }
    }
}
