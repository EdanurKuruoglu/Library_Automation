using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class FrmHomePage : Form
    {

        MySqlConnection connection;
        public FrmHomePage()
        {
            InitializeComponent();
            connection = Program.connection;
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            connection.Close();
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmAddMember FrmAddMember = new FrmAddMember();
            FrmAddMember.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmAddPersonel FrmAddPersonel = new FrmAddPersonel();
            FrmAddPersonel.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmBooksShow FrmBooksShow = new FrmBooksShow();
            FrmBooksShow.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmAddBooks FrmAddBooks = new FrmAddBooks();
            FrmAddBooks.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmMemberManagement FrmMemberManagement = new FrmMemberManagement();
            FrmMemberManagement.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmPersonelManagement FrmPersonelManagement = new FrmPersonelManagement();
            FrmPersonelManagement.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmBookBorrowing FrmBookBorrowing = new FrmBookBorrowing();
            FrmBookBorrowing.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmBookManagement FrmBookManagement = new FrmBookManagement();
            FrmBookManagement.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();
        }
    }
}


