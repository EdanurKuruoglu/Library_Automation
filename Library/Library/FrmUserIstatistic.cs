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
    public partial class FrmUserIstatistic : Form
    {
        MySqlConnection connection;
        int userid;
        public FrmUserIstatistic(int userid)
        {
            InitializeComponent();
            connection = Program.connection;
            this.userid = userid;

         }

        private void label13_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string viewName = "istatik_view";
                string query = $"SELECT * FROM { viewName}";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["personel_count"], reader["user_count"], reader["kitap_count"], reader["yazar_count"]);
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
    }
}
