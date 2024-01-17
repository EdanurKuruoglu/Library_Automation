using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class FrmUserBooksShow : Form
    {
        MySqlConnection connection;
        int userid;

        public FrmUserBooksShow(int userid)
        {
            InitializeComponent();
            connection = Program.connection;
            this.userid = userid;
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserHomePage FrmUserHomePage = new FrmUserHomePage(userid);
            FrmUserHomePage.Show();
            this.Hide();
        }

        private void txt_book_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_book_search.Text;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string procedureName = "book_search";

                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@search_value", "%" + searchValue + "%");

                MySqlDataReader reader = command.ExecuteReader();

                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["book_ISBN"], reader["book_name"], reader["author_name"], reader["genre_name"], reader["book_page"], reader["book_publication_year"], reader["publisher_name"], reader["book_number"], reader["language_name"], reader["book_update"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
            }
        }
       
    }
}
