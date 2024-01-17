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
    public partial class FrmUserHomePage : Form
    {
        MySqlConnection connection;
        int userid;
        public FrmUserHomePage(int userid)
        {
            InitializeComponent();
            connection = Program.connection;
            this.userid = userid;


            string adi, soyadi;

            using (MySqlCommand command = new MySqlCommand("user_info", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userid", userid);
                command.Parameters.Add("@ad", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                command.Parameters.Add("@soyad", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();

                adi = command.Parameters["@ad"].Value.ToString();
                soyadi = command.Parameters["@soyad"].Value.ToString();

                connection.Close();
            }

            lbl_isim.Text = "Merhaba, " + adi + " " + soyadi;

        }

        private void picture_back_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();
        }

        private void pic_goruntule_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserBooksShow FrmUserBooksShow = new FrmUserBooksShow(userid);
            FrmUserBooksShow.Show();
            this.Hide();
        }

        private void pic_okuduklarim_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserReadBook FrmUserReadBook = new FrmUserReadBook(userid);
            FrmUserReadBook.Show();
            this.Hide();
        }

        private void pic_istatistik_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserIstatistic FrmUserIstatistic = new FrmUserIstatistic(userid);
            FrmUserIstatistic.Show();
            this.Hide();
        }

        private void pic_odunc_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserBookBorrowing FrmUserBookBorrowing = new FrmUserBookBorrowing(userid);
            FrmUserBookBorrowing.Show();
            this.Hide();
        }

        private void pic_fav_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserFavorite FrmUserFavorite = new FrmUserFavorite(userid);
            FrmUserFavorite.Show();
            this.Hide();
        }
    }
}
