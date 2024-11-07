using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PerpusDong.Model
{
    class PetugasModel
    {
        //object class Connection
        private SqlConnection conn;
        private SqlCommand command;

        //declare variabel
        private string query;
        private bool hasil;

        //constructor
        public PetugasModel()
        {
            conn = KoneksiDatabase.GetConnection();
        }

        //declare attribute
        private string idPetugas;
        private string namaPetugas;
        private string teleponPetugas;
        private string password;
        
        public void SetIdPetugas(string data)
        {
            idPetugas = data;
        }
        public void SetNamaPetugas(string data)
        {
            namaPetugas = data;
        }

        public void SetTeleponPetugas(string data)
        {
            teleponPetugas = data;
        }
        public void SetPassword(string data)
        {
            password = data;
        }

        //fungsi login
        public bool Login(string id, string password)
        {
            query = "SELECT * FROM petugas WHERE id_petugas = '" + id + "'" +
                    "AND password = '" + password + "'";
            conn.Open();

            command = conn.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == id) &&
                    (reader.GetString(3).ToString() == password))
                {
                    Controller.PetugasController.id = reader.GetString(0).ToString();
                    Controller.PetugasController.nama = reader.GetString(1).ToString();
                    Controller.PetugasController.telepon = reader.GetString(2).ToString();
                    Controller.PetugasController.password = reader.GetString(3).ToString();
                    hasil = true;
                }
                else
                {
                    hasil = false;
                }
            }
            conn.Close();
            return hasil;
        }

        //fungsi untuk mengubah data
        public Boolean UpdatePetugas()
        {
            hasil = false;
            try
            {
                query = "UPDATE petugas SET nama_petugas ='" + namaPetugas + "'," + 
                        "telepon_petugas ='" + teleponPetugas + "'," + 
                        "password ='" + password + 
                        "' WHERE id_petugas ='" + idPetugas + "'";
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

        public Boolean InsertPetugas()
        {
            hasil = false;
            try
            {
                query = "INSERT INTO petugas VALUES ('"+idPetugas+"','"+namaPetugas+"','"+teleponPetugas+"','"+password+"')";
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

        //fungsi select + seacrh data
        public DataSet SelectSeacrhPetugas(string id, string nama)
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM petugas WHERE id_petugas LIKE '%" + id + "%' OR " + 
                                      "nama_petugas LIKE '%" + nama + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "petugas");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }

        //fungsi select data
        public DataSet SelectPetugas()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM petugas";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "petugas");
                conn.Close();
            }
            catch (SqlException)
            {

            }
            return ds;
        }
    }
}
