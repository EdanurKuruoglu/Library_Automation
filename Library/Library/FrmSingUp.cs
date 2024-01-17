using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class FrmSingUp : Form
    {
        MySqlConnection connection;
        public FrmSingUp()
        {
            InitializeComponent();
            connection = Program.connection;

        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txt_Username.Text;
                string password = txt_password.Text;
                string mail = txt_email.Text;
                string duzeltilmisNumara = Regex.Replace(mask_tel.Text, @"[^0-9]", "").Trim();


                if (!Program.Injection(userName) || !Program.Injection(password))
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre");
                    txt_Username.Text = "";
                    txt_password.Text = "";
                    return;
                }


                string userQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personelname = @username UNION SELECT COUNT(*) FROM library_1.users WHERE username = @username";
                string passwordQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_password = @password UNION SELECT COUNT(*) FROM library_1.users WHERE user_password = @password";
                string phoneQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_number = @phone UNION SELECT COUNT(*) FROM library_1.users WHERE user_number = @phone";
                string mailQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_mail = @mail UNION SELECT COUNT(*) FROM library_1.users WHERE user_mail = @mail";

                using (MySqlCommand userCommand = new MySqlCommand(userQuery, connection))
                using (MySqlCommand passwordCommand = new MySqlCommand(passwordQuery, connection))
                using (MySqlCommand phoneCommand = new MySqlCommand(phoneQuery, connection))
                using (MySqlCommand mailCommand = new MySqlCommand(mailQuery, connection))
                {
                    connection.Open();

                    // Kullanıcı adı kontrolü
                    userCommand.Parameters.AddWithValue("@username", userName);
                    int userCount = Convert.ToInt32(userCommand.ExecuteScalar());
                    if (userCount > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!");
                        connection.Close();
                        return;
                    }

                    // Şifre kontrolü
                    passwordCommand.Parameters.AddWithValue("@password", password);
                    int passwordCount = Convert.ToInt32(passwordCommand.ExecuteScalar());
                    if (passwordCount > 0)
                    {
                        MessageBox.Show("Bu şifre zaten kullanılıyor!");
                        connection.Close();
                        return;
                    }

                    // Telefon numarası kontrolü
                    phoneCommand.Parameters.AddWithValue("@phone", duzeltilmisNumara.PadLeft(11, '0'));
                    int phoneCount = Convert.ToInt32(phoneCommand.ExecuteScalar());
                    if (phoneCount > 0)
                    {
                        MessageBox.Show("Bu telefon numarası zaten kullanılıyor!");
                        connection.Close();
                        return;
                    }

                    // E-posta kontrolü
                    mailCommand.Parameters.AddWithValue("@mail", mail);
                    int mailCount = Convert.ToInt32(mailCommand.ExecuteScalar());
                    if (mailCount > 0)
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kullanılıyor!");
                        connection.Close();
                        return;
                    }

                    // Kayıt işlemi
                    bool erkekSecildi = rb_erkek.Checked;
                    bool kadinSecildi = rb_kadin.Checked;

                    date_Tarih.Format = DateTimePickerFormat.Custom;
                    date_Tarih.CustomFormat = "yyyy-MM-dd 00:00:00";

                    string query = "INSERT INTO library_1.users (user_name, user_surname, user_birthday, user_gender, user_number, user_mail, user_address, username, user_password) " +
                                   "VALUES (@isim, @soyisim, @dogum_tarihi, @cinsiyet, @telefon, @mail, @adres, @kullanici_adi, @sifre)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@isim", txt_ad.Text);
                        command.Parameters.AddWithValue("@soyisim", txt_soyad.Text);
                        command.Parameters.AddWithValue("@dogum_tarihi", date_Tarih.Value);
                        command.Parameters.AddWithValue("@cinsiyet", erkekSecildi ? "Erkek" : "Kadın");
                        command.Parameters.AddWithValue("@telefon", duzeltilmisNumara);
                        command.Parameters.AddWithValue("@mail", txt_email.Text);
                        command.Parameters.AddWithValue("@adres", txt_adres.Text);
                        command.Parameters.AddWithValue("@kullanici_adi", txt_Username.Text);
                        command.Parameters.AddWithValue("@sifre", txt_password.Text);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();

                    MessageBox.Show("Kayıt başarıyla eklendi!");
                    FrmLogin FrmLogin = new FrmLogin();
                    FrmLogin.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();
        }
    }    
}
