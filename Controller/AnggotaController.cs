using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PerpusDong.Controller
{
    class AnggotaController
    {
        //declare object
        private View.InputAnggotaPage vInputAnggota;
        private Model.AnggotaModel mAnggota;
        private View.DaftarAnggotaPage vDaftarAnggota;

        public AnggotaController(View.InputAnggotaPage vInputAnggota)
        {
            this.vInputAnggota = vInputAnggota;
            mAnggota = new Model.AnggotaModel();
        }
        public AnggotaController(View.DaftarAnggotaPage vDaftarAnggota)
        {
            this.vDaftarAnggota = vDaftarAnggota;
            mAnggota = new Model.AnggotaModel();
        }

        //fungsi insert anggota
        public bool InsertAnggota()
        {
            mAnggota.SetIdAnggota(vInputAnggota.txtIdAnggota.Text);
            mAnggota.SetNamaAnggota(vInputAnggota.txtNama.Text);
            mAnggota.SetTeleponAnggota(vInputAnggota.txtTelepon.Text);
            mAnggota.SetAlamatAnggota(vInputAnggota.txtAlamat.Text);
            mAnggota.SetJenisKelaminAnggota(vInputAnggota.txtGender.Text);
            mAnggota.SetTempatLahirAnggota(vInputAnggota.txtTempatLahir.Text);
            mAnggota.SetTanggalLahirAnggota(vInputAnggota.dtpTanggalLahir.Text);
            mAnggota.SetTanggalDaftar(vInputAnggota.dtpTanggalDaftar.Text);
            bool hasil = mAnggota.InsertAnggota();
            return hasil;
        }

        //fungsi select anggota
        public void SelectAnggota()
        {
            DataSet data = mAnggota.SelectAnggota();
            vDaftarAnggota.dgAnggota.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}
