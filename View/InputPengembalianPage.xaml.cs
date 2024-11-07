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
    /// Interaction logic for InputPengembalianBuku.xaml
    /// </summary>
    public partial class InputPengembalianPage : Window
    {
        //1. private object controller
        private Controller.PeminjamanController cPeminjaman;

        public InputPengembalianPage()
        {
            InitializeComponent();
            //2. instance
            cPeminjaman = new Controller.PeminjamanController(this);
        }

        private void btnInputPeminjaman_Click(object sender, RoutedEventArgs e)
        {
            View.InputPeminjamanPage imp = new View.InputPeminjamanPage();
            imp.Show();
            this.Close();
        }

        private void btnDaftarPeminjaman_Click(object sender, RoutedEventArgs e)
        {
            View.DaftarPeminjamanPage dmp = new View.DaftarPeminjamanPage();
            dmp.Show();
            this.Close();
        }

        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            View.MainMenuPage mmp = new View.MainMenuPage();
            mmp.Show();
            this.Close();
        }

        private void btnInputPengembalian_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anda Sudah di Halaman Daftar Pengembalian :)", "Gagal");
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            cPeminjaman.UpdatePengembalian();
            MessageBox.Show("Data Pengembalian Telah Disimpan :)", "Sukses");
        }

        //declare atribut denda
        //private int TanggalKembali;
        //DateTime TanggalKembali;
        //private int TanggalPinjam;
        //DateTime TanggalPinjam;
        //private int DendaPinjam;
        //DateTime oke;

       /* public string Denda()
        {
            TanggalKembali.AddDays;
            //TanggalKembali = int.Parse(dtpTanggalKembali.Text);
            TanggalPinjam = int.Parse(dtpTanggalPinjam.Text);
            DendaPinjam = (TanggalKembali - TanggalPinjam) * 1000;
            string hasil = DendaPinjam.ToString();
            return hasil;
        } */

        /*private void btnDendaPinjam_Click(object sender, RoutedEventArgs e)
        {
            txtDendaPinjam.Text = Denda();
            //vInputPengembalian.txtDendaPinjam.Content = mPeminjaman.Denda();
            //lblDendaPinjam.Content = Denda();  
        } */
    }
}
