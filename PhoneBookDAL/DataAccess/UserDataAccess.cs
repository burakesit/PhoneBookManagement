using PhoneBookEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDAL.Manager
{
    public class UserDataAccess
    {
        public UserDataAccess()
        {
            //connection stringi oluştur.
            string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=AdoNetUygulama;Trusted_Connection=True";
            //Bağlantı oluştur
            _sqlConnection = new SqlConnection(_connectionString);
        }
        SqlConnection _sqlConnection;
        public int Insert(User user)
        {
            //Sorgunu oluştur
            string _query = "INSERT INTO Person (Name,SurName,Phone) VALUES (@Name,@SurName,@Phone)";
            SqlCommand _sqlCommand = new SqlCommand(_query, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@Name", user.Name);
            _sqlCommand.Parameters.AddWithValue("@SurName", user.SurName);
            _sqlCommand.Parameters.AddWithValue("@Phone", user.Phone);
            
            //Bağlantıyı aç
            if (_sqlConnection.State != ConnectionState.Open)
            {
                _sqlConnection.Open();

            }
            //Sorguyu çalıştır
            int affectedRows = _sqlCommand.ExecuteNonQuery();
           
            if (_sqlConnection.State != ConnectionState.Closed)
            {
                _sqlConnection.Close();

            }
            return affectedRows;

            
        }
        public List<User> GetUser()
        {
            string _query = "Select * from Person";
            SqlCommand _sqlCommand = new SqlCommand(_query, _sqlConnection);
            if (_sqlConnection.State!=ConnectionState.Open)
            {
                _sqlConnection.Open();
            }
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
            List<User> users = new List<User>();
            User user = null;
            while (sqlDataReader.Read())
            {
                user = new User();
                user.ID = Convert.ToInt32(sqlDataReader["ID"]);
                user.Name = sqlDataReader["Name"].ToString();
                user.SurName = sqlDataReader["SurName"].ToString();
                user.Phone = sqlDataReader["Phone"].ToString();
                users.Add(user);
            }
            if (_sqlConnection.State != ConnectionState.Closed)
            {
                _sqlConnection.Close();

            }
            return users;
        }
    }
}
