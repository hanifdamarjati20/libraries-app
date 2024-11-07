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
    /// Interaction logic for BukuPage.xaml
    /// </summary>
    public partial class InputBukuPage : Window
    {
        //1. private object controller
        private Controller.BukuController cBuku;

        public InputBukuPage()
        {
            InitializeComponent();
            //2. instance
            cBuku = new Controller.BukuController(this);
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            cBuku.InsertBuku();
            MessageBox.Show("Data Buku Telah Disimpan :)", "Sukses");
        }
        private void btnDaftarBuku_Click(object sender, RoutedEventArgs e)
        {
            View.DaftarBukuPage dbp = new View.DaftarBukuPage();
            dbp.Show();
            this.Close();
        }
        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            View.MainMenuPage mmp = new View.MainMenuPage();
            mmp.Show();
            this.Close();
        }
        private void btnInputBuku_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anda Sudah di Halaman Input Buku :)", "Gagal");
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtKdBuku.Text = "";
            txtNama.Text = "";
            dtpTahun.Text = "";
            txtBahasa.Text = "";
            txtPengarang.Text = "";
            txtPenerbit.Text = "";
            txtHarga.Text = "";
        }
    }
}
