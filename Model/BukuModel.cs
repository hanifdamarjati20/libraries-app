using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PerpusDong.Model
{
    class BukuModel
    {
        //object class connection
        private SqlConnection conn;
        private SqlCommand command;

        //declare 
        private string query;
        private bool hasil;

        //call db connection
        public BukuModel()
        {
            conn = KoneksiDatabase.GetConnection();
        }

        //declare attribute
        private string kdBuku;
        private string namaBuku;
        private string tahunBuku;
        private string bahasaBuku;
        private string pengarangBuku;
        private string penerbitBuku;
        private string hargaBuku;

        //fungsi set
        public void SetKdBuku(string value)
        {
            kdBuku = value;
        }
        public void SetNamaBuku(string value)
        {
            namaBuku = value;
        }
        public void SetTahunBuku(string value)
        {
            tahunBuku = value;
        }
        public void SetBahasaBuku(string value)
        {
            bahasaBuku = value;
        }
        public void SetPengarangBuku(string value)
        {
            pengarangBuku = value;
        }
        public void SetPenerbitBuku(string value)
        {
            penerbitBuku = value;
        }
        public void SetHargaBuku(string value)
        {
            hargaBuku = value;
        }

        //insert buku
        public Boolean InsertBuku()
        {
            hasil = false;
            try
            {
                query = "INSERT INTO buku VALUES ('" +kdBuku+"','"+namaBuku+"','"+tahunBuku+"','"+bahasaBuku+"','"
                                                     +pengarangBuku+"','"+penerbitBuku+"','"+hargaBuku+"')";
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

        //fungsi select buku
        public DataSet SelectBuku()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM buku";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "buku");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }
    }
}
