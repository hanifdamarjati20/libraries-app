using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PerpusDong.Model
{
    class AnggotaModel
    {
        //object class connection
        private SqlConnection conn;
        private SqlCommand command;

        //declare 
        private string query;
        private bool hasil;

        //call db connection
        public AnggotaModel()
        {
            conn = KoneksiDatabase.GetConnection();
        }

        //declare attribute
        private string idAnggota;
        private string namaAnggota;
        private string teleponAnggota;
        private string alamatAnggota;
        private string jenisKelaminAnggota;
        private string tempatLahirAnggota;
        private string tanggalLahirAnggota;
        private string tanggalDaftar;


        //fungsi set
        public void SetIdAnggota(string value)
        {
            idAnggota = value;
        }
        public void SetNamaAnggota(string value)
        {
            namaAnggota = value;
        }
        public void SetTeleponAnggota(string value)
        {
            teleponAnggota = value;
        }
        public void SetAlamatAnggota(string value)
        {
            alamatAnggota = value;
        }
        public void SetJenisKelaminAnggota(string value)
        {
            jenisKelaminAnggota = value;
        }
        public void SetTempatLahirAnggota(string value)
        {
            tempatLahirAnggota = value;
        }
        public void SetTanggalLahirAnggota(string value)
        {
            tanggalLahirAnggota = value;
        }
        public void SetTanggalDaftar(string value)
        {
            tanggalDaftar = value;
        }

        //insert buku
        public Boolean InsertAnggota()
        {
            hasil = false;
            try
            {
                query = "INSERT INTO anggota VALUES ('" + idAnggota + "','" + namaAnggota + "','" + teleponAnggota + "','" + alamatAnggota + "','"
                    + jenisKelaminAnggota + "','" + tempatLahirAnggota + "','" + tanggalLahirAnggota + "','" + tanggalDaftar + "')";
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

        //fungsi select anggota
        public DataSet SelectAnggota()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM anggota";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "anggota");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }
    }
}
