using PhoneBookBLL.Management;
using PhoneBookEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookUI
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            userManager = new UserManager();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            FillListView();
        }
        UserManager userManager;

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                User user = new User
                {
                    Name = txtName.Text,
                    SurName = txtSurname.Text,
                    Phone = mtxtPhone.Text
                };
                int affectedRows = userManager.Insert(user);
                MessageBox.Show(affectedRows > 0 ? "Kayıt Başarılı" : "Kayıt Başarısız");
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            ////Database'e data kayıt etmek istiyorum 
            ////connection stringi oluştur.
            //string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=AdoNetUygulama;Trusted_Connection=True";
            ////Bağlantı oluştur
            //SqlConnection _sqlConnection = new SqlConnection(_connectionString);
            
            ////Sorgunu oluştur
            //string _query = "INSERT INTO Person (Name,SurName,Phone) VALUES (@Name,@SurName,@Phone)";
            //SqlCommand _sqlCommand = new SqlCommand(_query,_sqlConnection);
            //_sqlCommand.Parameters.AddWithValue("@Name", user.Name);
            //_sqlCommand.Parameters.AddWithValue("@SurName", user.SurName);
            //_sqlCommand.Parameters.AddWithValue("@Phone", user.Phone);
            ////Bağlantıyı aç
            //if (_sqlConnection.State!=ConnectionState.Open)
            //{
            //_sqlConnection.Open();

            //}
            ////Sorguyu çalıştır
            //int affectedRows = _sqlCommand.ExecuteNonQuery();
            //MessageBox.Show(affectedRows>0? "Kayıt Başarılı":"Kayıt Başarısız");
            ////Bağlantıyı kapat
            //if (_sqlConnection.State!=ConnectionState.Closed)
            //{
            //_sqlConnection.Close();

            //}

            ////Select Sorgusu yazar tüm datayı alır.Listview a basarım.

        }

        private void FillListView()
        {
            ListViewItem lvi;
            lvPerson.Items.Clear();
            foreach (User item in userManager.GetUsers())
            {
                lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Phone);
                lvPerson.Items.Add(lvi);
            }
        }
    }
}
