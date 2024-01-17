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
    public partial class FrmUserReadBook : Form
    {
        MySqlConnection connection;
        int userid;
        public FrmUserReadBook(int userid)
        {
            InitializeComponent();
            connection = Program.connection;
            this.userid = userid;
        }

        private void lbl_okunank_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string procedureName = "okunan_kitap";

                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userid", userid);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["book_ISBN"], reader["author_name"], reader["book_name"],  reader["total_borrowings"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }

        }

        private void pixture_back_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserHomePage FrmUserHomePage = new FrmUserHomePage(userid);
            FrmUserHomePage.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
