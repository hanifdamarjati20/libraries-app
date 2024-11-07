using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PerpusDong.Model
{
    class PeminjamanModel
    {
        //object class connection
        private SqlConnection conn;
        private SqlCommand command;

        //declare 
        private string query;
        private bool hasil;

        //call db connection
        public PeminjamanModel()
        {
            conn = KoneksiDatabase.GetConnection();
        }

        //declare attribute
        private string kdPinjam;
        private string idAnggota;
        private string namaAnggota;
        private string kdBuku;
        private string namaBuku;
        private string tanggalPinjam;
        private string tanggalKembali;
        private string statusPinjam;

        //fungsi set
        public void SetKdPinjam(string value)
        {
            kdPinjam = value;
        }
        public void SetIdAnggota(string value)
        {
            idAnggota = value;
        }
        public void SetNamaAnggota(string value)
        {
            namaAnggota = value;
        }
        public void SetKdBuku(string value)
        {
            kdBuku = value;
        }
        public void SetNamaBuku(string value)
        {
            namaBuku = value;
        }
        public void SetTanggalPinjam(string value)
        {
            tanggalPinjam = value;
        }
        public void SetTanggalKembali(string value)
        {
            tanggalKembali = value;
        }
        public void SetStatusPinjam(string value)
        {
            statusPinjam = value;
        }

        //insert peminjaman
        public Boolean InsertPeminjaman()
        {
            hasil = false;
            try
            {
                query = "INSERT INTO peminjaman VALUES ('" + kdPinjam + "','" + idAnggota + "','" + namaAnggota + "','" + kdBuku + "','"
                                                           + namaBuku + "','" + tanggalPinjam + "','"
                                                           + tanggalKembali + "','" + statusPinjam + "')";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                conn.Close();
            }
            catch (SqlException)
            {
                hasil = false;
            }
            return hasil;
        }

        //fungsi select peminjaman
        public DataSet SelectPeminjaman()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM peminjaman";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "peminjaman");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        } 

        //update pengembalian
        public Boolean UpdatePengembalian()
        {
            hasil = false;
            try
            {
                query = "UPDATE peminjaman SET tanggal_pinjam = '" + tanggalPinjam + ", tanggal_kembali '" + tanggalKembali + ", status_pinjam '" + statusPinjam + "' WHERE kd_pinjam = '" + kdPinjam + "'";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                conn.Close();
            }
            catch (SqlException)
            {
                hasil = false;
            }
            return hasil;
        }
    }
}
