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
    /// Interaction logic for InputAnggotaPage.xaml
    /// </summary>
    public partial class InputAnggotaPage : Window
    {
        //1. private object controller
        private Controller.AnggotaController cAnggota;

        public InputAnggotaPage()
        {
            InitializeComponent();
            //2. instance
            cAnggota = new Controller.AnggotaController(this);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            cAnggota.InsertAnggota();
            MessageBox.Show("Data Anggota Telah Disimpan :)", "Sukses");
        }

        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            View.MainMenuPage mmp = new View.MainMenuPage();
            mmp.Show();
            this.Close();
        }

        private void btnInputAnggota_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anda Sudah di Halaman Input Anggota :)", "Gagal");
        }

        private void btnDaftarAnggota_Click(object sender, RoutedEventArgs e)
        {
            View.DaftarAnggotaPage dap = new View.DaftarAnggotaPage();
            dap.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtIdAnggota.Text = "";
            txtNama.Text = "";
            txtTelepon.Text = "";
            txtAlamat.Text = "";
            txtGender.Text = "";
            txtTempatLahir.Text = "";
            dtpTanggalLahir.Text = "";
            dtpTanggalDaftar.Text = "";
        }
    }
}
