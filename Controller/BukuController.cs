using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PerpusDong.Controller
{
    class BukuController
    {
        //declare object
        private View.InputBukuPage vInputBuku;
        private Model.BukuModel mBuku;
        private View.DaftarBukuPage vDaftarBuku;

        public BukuController(View.InputBukuPage vInputBuku)
        {
            this.vInputBuku = vInputBuku;
            mBuku = new Model.BukuModel();
        }

        public BukuController(View.DaftarBukuPage vDaftarBuku)
        {
            this.vDaftarBuku = vDaftarBuku;
            mBuku = new Model.BukuModel();
        }

        //fungsi insert buku
        public bool InsertBuku()
        {
            mBuku.SetKdBuku(vInputBuku.txtKdBuku.Text);
            mBuku.SetNamaBuku(vInputBuku.txtNama.Text);
            mBuku.SetTahunBuku(vInputBuku.dtpTahun.Text);
            mBuku.SetBahasaBuku(vInputBuku.txtBahasa.Text);
            mBuku.SetPengarangBuku(vInputBuku.txtPengarang.Text);
            mBuku.SetPenerbitBuku(vInputBuku.txtPenerbit.Text);
            mBuku.SetHargaBuku(vInputBuku.txtHarga.Text);
            bool hasil = mBuku.InsertBuku();
            return hasil;
        }

        //fungsi select buku
        public void SelectBuku()
        {
            DataSet data = mBuku.SelectBuku();
            vDaftarBuku.dgDaftarBuku.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}
