using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PerpusDong.Controller
{
    class PeminjamanController
    {
        //declare object
        private View.InputPeminjamanPage vInputPeminjaman;
        private Model.PeminjamanModel mPeminjaman;
        private View.DaftarPeminjamanPage vDaftarPeminjaman;
        private View.InputPengembalianPage vInputPengembalian;

        public PeminjamanController(View.InputPeminjamanPage vInputPeminjaman)
        {
            this.vInputPeminjaman = vInputPeminjaman;
            mPeminjaman = new Model.PeminjamanModel();
        }
        public PeminjamanController(View.InputPengembalianPage vInputPengembalian)
        {
            this.vInputPengembalian = vInputPengembalian;
            mPeminjaman = new Model.PeminjamanModel();
        }

        public PeminjamanController(View.DaftarPeminjamanPage vDaftarPeminjaman)
        {
            this.vDaftarPeminjaman = vDaftarPeminjaman;
            mPeminjaman = new Model.PeminjamanModel();
        }

        //fungsi update pengembalian
        public bool UpdatePengembalian()
        {
            mPeminjaman.SetKdPinjam(vInputPengembalian.txtKdPeminjaman.Text);
            mPeminjaman.SetTanggalKembali(vInputPengembalian.dtpTanggalKembali.Text);
            mPeminjaman.SetStatusPinjam(vInputPengembalian.txtStatusPinjam.Text);
            bool hasil = mPeminjaman.UpdatePengembalian();
            return hasil;
        }

        //fungsi insert peminjaman
        public bool InsertPeminjaman()
        {
            mPeminjaman.SetKdPinjam(vInputPeminjaman.txtKdPeminjaman.Text);
            mPeminjaman.SetIdAnggota(vInputPeminjaman.txtIdAnggota.Text);
            mPeminjaman.SetNamaAnggota(vInputPeminjaman.txtNamaAnggota.Text);
            mPeminjaman.SetKdBuku(vInputPeminjaman.txtKdBuku.Text);
            mPeminjaman.SetNamaBuku(vInputPeminjaman.txtNamaBuku.Text);
            mPeminjaman.SetTanggalPinjam(vInputPeminjaman.dtpTanggalPinjam.Text);
            mPeminjaman.SetTanggalKembali(vInputPeminjaman.dtpTanggalKembali.Text);
            mPeminjaman.SetStatusPinjam(vInputPeminjaman.txtStatusPinjam.Text);
            bool hasil = mPeminjaman.InsertPeminjaman();
            return hasil;
        }

        public void SelectPeminjaman()
        {
            DataSet data = mPeminjaman.SelectPeminjaman();
            vDaftarPeminjaman.dgDaftarPeminjaman.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}
