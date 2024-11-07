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
    /// Interaction logic for DaftarBukuPage.xaml
    /// </summary>
    public partial class DaftarBukuPage : Window
    {
        //1. private object controller
        private Controller.BukuController cBuku;

        public DaftarBukuPage()
        {
            InitializeComponent();
            //2. instance
            cBuku = new Controller.BukuController(this);
            cBuku.SelectBuku();
        }

        private void btnInputBuku_Click(object sender, RoutedEventArgs e)
        {
            View.InputBukuPage bp = new View.InputBukuPage();
            bp.Show();
            this.Close();
        }

        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            View.MainMenuPage mmp = new View.MainMenuPage();
            mmp.Show();
            this.Close();
        }

        private void btnDaftarBuku_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anda Sudah di Halaman Daftar Buku :)", "Gagal");
        }
    }
}
