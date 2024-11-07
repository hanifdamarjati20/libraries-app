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
    /// Interaction logic for Peminjaman.xaml
    /// </summary>
    public partial class DaftarPeminjamanPage : Window
    {
        //1. private object controller
        private Controller.PeminjamanController cPeminjaman;

        public DaftarPeminjamanPage()
        {
            InitializeComponent();
            //2. instance
            cPeminjaman = new Controller.PeminjamanController(this);
            cPeminjaman.SelectPeminjaman();
        }

        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            View.MainMenuPage mmp = new View.MainMenuPage();
            mmp.Show();
            this.Close();
        }

        private void btnInputPeminjaman_Click(object sender, RoutedEventArgs e)
        {
            View.InputPeminjamanPage imp = new View.InputPeminjamanPage();
            imp.Show();
            this.Close();
        }

        private void btnInputPengembalian_Click(object sender, RoutedEventArgs e)
        {
            View.InputPengembalianPage ipp = new View.InputPengembalianPage();
            ipp.Show();
            this.Close();
        }

        private void btnDaftarPeminjaman_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anda Sudah di Halaman Daftar Peminjaman :)", "Gagal");
        }
    }
    
}
