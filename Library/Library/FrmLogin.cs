using MySql.Data.MySqlClient;
using System.Data;

namespace Library
{
    public partial class FrmLogin : Form
    {
        
        MySqlConnection connection;
        public FrmLogin()
        {
            InitializeComponent();
            connection = Program.connection;
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        { 
            try
                {
                    string kullaniciAdi = txt_username.Text;
                    string sifre = txt_password.Text;

                    if (!Program.Injection(kullaniciAdi) || !Program.Injection(sifre))
                    {
                        MessageBox.Show("Geçersiz kullanýcý adý veya þifre");
                        txt_username.Text = "";
                        txt_password.Text = "";
                        return;
                    }

                    if (string.IsNullOrEmpty(kullaniciAdi))
                    {
                        MessageBox.Show("Kullanýcý adý boþ olamaz!");
                        return;
                    }

                    if (string.IsNullOrEmpty(sifre))
                    {
                        MessageBox.Show("Þifre boþ olamaz!");
                        return;
                    }

                    string loginProcedure = "login_check";
                    MySqlCommand loginCommand = new MySqlCommand(loginProcedure, connection);
                    loginCommand.CommandType = CommandType.StoredProcedure;
                    loginCommand.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    loginCommand.Parameters.AddWithValue("@sifre", sifre);
                    loginCommand.Parameters.Add("@result", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                    string userInfoProcedure = "login_user_check";
                    MySqlCommand userInfoCommand = new MySqlCommand(userInfoProcedure, connection);
                    userInfoCommand.CommandType = CommandType.StoredProcedure;
                    userInfoCommand.Parameters.AddWithValue("@adi", kullaniciAdi);
                    userInfoCommand.Parameters.AddWithValue("@sifresi", sifre);
                    userInfoCommand.Parameters.Add("@result2", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    userInfoCommand.Parameters.Add("@name_id", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                    connection.Open();

                    loginCommand.ExecuteNonQuery();
                    userInfoCommand.ExecuteNonQuery();

                    int result = loginCommand.Parameters["@result"].Value != DBNull.Value ? Convert.ToInt32(loginCommand.Parameters["@result"].Value) : 0;
                    int result2 = userInfoCommand.Parameters["@result2"].Value != DBNull.Value ? Convert.ToInt32(userInfoCommand.Parameters["@result2"].Value) : 0;
                    int userId = userInfoCommand.Parameters["@name_id"].Value != DBNull.Value ? Convert.ToInt32(userInfoCommand.Parameters["@name_id"].Value) : 0;

                connection.Close();

                    // Kullanýcý türüne göre ilgili formu açabilirsiniz
                    if (result > 0 || result2 > 0)
                    {
                        MessageBox.Show("Giriþ baþarýlý!");
                        if (result2 > 0)
                        {
                            FrmUserHomePage FrmUserHomePage = new FrmUserHomePage(userId);
                            FrmUserHomePage.Show();
                        }
                        if (result > 0)
                        {
                            FrmHomePage FrmHomePage = new FrmHomePage();
                            FrmHomePage.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz kullanýcý adý ve þifre");
                        txt_username.Text = "";
                        txt_password.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    connection.Close();
                }
            


            
           
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Tuþ giriþini engelle
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Tuþ giriþini engelle
                btn_login.Focus();
            }
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {   connection.Close(); 
            FrmSingUp frmSignUp = new FrmSingUp();
            frmSignUp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}


