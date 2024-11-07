using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PerpusDong.Controller
{
    class PetugasController
    {
        //declare object
        private View.LoginPage vLogin;
        private Model.PetugasModel mPetugas;
        private View.PetugasPage vPetugas;

        //deklarasi variabel static untuk menampung nama user yang login ke dalam aplikasi
        public static String id;
        public static String nama;
        public static String telepon;
        public static String password;

        //constuctor LoginPage Parameter
        public PetugasController(View.LoginPage vLogin)
        {
            this.vLogin = vLogin;
            mPetugas = new Model.PetugasModel();
        }
        public PetugasController(View.PetugasPage vPetugas)
        {
            this.vPetugas = vPetugas;
            mPetugas = new Model.PetugasModel();
        }

        //fungsi login
        public bool LoginPetugas()
        {
            bool hasil = mPetugas.Login(vLogin.txtIDLogin.Text, vLogin.txtPasswordLogin.Password);
            return hasil;
        }
        //fungsi update
        public bool UpdatePetugas()
        {
            mPetugas.SetIdPetugas(vPetugas.txtIdPetugas.Text);
            mPetugas.SetNamaPetugas(vPetugas.txtNamaPetugas.Text);
            mPetugas.SetTeleponPetugas(vPetugas.txtTeleponPetugas.Text);
            mPetugas.SetPassword(vPetugas.txtPassword.Password);
            bool hasil = mPetugas.UpdatePetugas();
            return hasil;
        }
        
        //fungsi insert
        public bool InsertPetugas()
        {
            mPetugas.SetIdPetugas(vPetugas.txtIdPetugas.Text);
            mPetugas.SetNamaPetugas(vPetugas.txtNamaPetugas.Text);
            mPetugas.SetTeleponPetugas(vPetugas.txtTeleponPetugas.Text);
            mPetugas.SetPassword(vPetugas.txtPassword.Password);
            bool hasil = mPetugas.InsertPetugas();
            return hasil;
        }

        //fungsi refresh
        public void SelectPetugas()
        {
            DataSet data = mPetugas.SelectPetugas();
            vPetugas.dgPetugas.ItemsSource = data.Tables[0].DefaultView;
        }

        //fungsi select + search
        public void SelectSeacrhPetugas()
        {
            DataSet data = mPetugas.SelectSeacrhPetugas(vPetugas.txtCari.Text, vPetugas.txtCari.Text);
            vPetugas.dgPetugas.ItemsSource = data.Tables[0].DefaultView;        
        }
    }
}
