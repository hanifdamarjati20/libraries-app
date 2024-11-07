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

namespace PerpusDong.View
{
    /// <summary>
    /// Interaction logic for PetugasPage.xaml
    /// </summary>
    public partial class PetugasPage : Window
    {
        //1. private object controller
        private Controller.PetugasController cPetugas;

        public PetugasPage()
        {
            InitializeComponent();
            //2. instance
            cPetugas = new Controller.PetugasController(this);
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            cPetugas.SelectPetugas();
            txtIdPetugas.Text = "";
            txtNamaPetugas.Text = "";
            txtTeleponPetugas.Text = "";
            txtPassword.Password = "";
        }

        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {
            cPetugas.InsertPetugas();
        }

        private void btnSimpan_Click(object sender, RoutedEventArgs e)
        {
            cPetugas.UpdatePetugas();
            MessageBox.Show("Data Berhasil di Simpan :)", "Sukses");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtIdPetugas.Text = "";
            txtNamaPetugas.Text = "";
            txtTeleponPetugas.Text = "";
            txtPassword.Password = "";   
        }

        private void btnCari_Click(object sender, RoutedEventArgs e)
        {
            cPetugas.SelectSeacrhPetugas();
        }

        private void btnKembali_Click(object sender, RoutedEventArgs e)
        {
            View.MainMenuPage mmp = new View.MainMenuPage();
            mmp.Show();
            this.Close();
        }
    }
}
