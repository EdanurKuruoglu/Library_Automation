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
    public partial class FrmUserBookBorrowing : Form
    {
        MySqlConnection connection;
        int userid;
        public FrmUserBookBorrowing(int userid)
        {
            InitializeComponent();
            connection = Program.connection;
            this.userid = userid;
        }

        private void pixture_back_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserHomePage FrmUserHomePage = new FrmUserHomePage(userid);
            FrmUserHomePage.Show();
            this.Hide();
        }

        private void lbl_odunc_kitap_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "user_book_due";
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userid", userid);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["borrowing_id"], reader["user_id"], reader["user_name"], reader["user_surname"], reader["book_name"], reader["book_ISBN"], reader["book_lending_date"], reader["book_due_date"], reader["borrowing_state"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }
        }

        private void lbl_teslim_gecmis_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "user_book_delivery";
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userid", userid);
                MySqlDataReader reader = command.ExecuteReader();
                data_teslim_tarihi.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    data_teslim_tarihi.Rows.Add(reader["borrow_id"], reader["user_Iid"], reader["username"], reader["usersurname"], reader["bookname"], reader["bookISBN"], reader["lending_date"], reader["due_date"], reader["borrow_state"], reader["penalty"]);
                }
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }
        }
    }

}
