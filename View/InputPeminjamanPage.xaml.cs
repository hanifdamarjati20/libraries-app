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
    /// Interaction logic for InputPeminjamanPage.xaml
    /// </summary>
    public partial class InputPeminjamanPage : Window
    {
        //1. private object controller
        private Controller.PeminjamanController cPeminjaman;

        public InputPeminjamanPage()
        {
            InitializeComponent();
            //2. instance
            cPeminjaman = new Controller.PeminjamanController(this);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            cPeminjaman.InsertPeminjaman();
            MessageBox.Show("Data Peminjaman Telah Disimpan :)", "Sukses");
        }

        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            View.MainMenuPage mmp = new View.MainMenuPage();
            mmp.Show();
            this.Close();
        }

        private void btnInputPeminjaman_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anda Sudah di Halaman Input Peminjaman :)", "Gagal");
        }

        private void btnDaftarPeminjaman_Click(object sender, RoutedEventArgs e)
        {
            View.DaftarPeminjamanPage dmp = new View.DaftarPeminjamanPage();
            dmp.Show();
            this.Close();
        }

        private void btnInputPengembalian_Click(object sender, RoutedEventArgs e)
        {
            View.InputPengembalianPage ipp = new View.InputPengembalianPage();
            ipp.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtKdPeminjaman.Text = "";
            txtIdAnggota.Text = "";
            txtNamaAnggota.Text = "";
            txtKdBuku.Text = "";
            txtNamaBuku.Text = "";
            dtpTanggalPinjam.Text = "";
            dtpTanggalKembali.Text = "";
            txtStatusPinjam.Text = "";
        }
    }
}
