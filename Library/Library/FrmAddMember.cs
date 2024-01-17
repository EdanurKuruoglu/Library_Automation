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
    public partial class FrmAddMember : Form
    {
        MySqlConnection connection;
        public FrmAddMember()
        {
            InitializeComponent();
            connection = Program.connection;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmHomePage FrmHomePage = new FrmHomePage();
            FrmHomePage.Show();
            this.Hide();
        }

        private void user_show_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "kullanici_goruntule";
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["user_id"], reader["user_name"], reader["user_surname"], reader["user_birthday"], reader["user_gender"], reader["user_number"], reader["user_address"], reader["user_mail"], reader["username"], reader["user_password"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string personelName = personel_adi.Text;
                string password = personel_sifre.Text;

                if (!Program.Injection(personelName) || !Program.Injection(password))
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre");
                    personel_adi.Text = "";
                    personel_sifre.Text = "";
                    return;
                }

                // Sorgu ile eşleşmeyi kontrol etmek için kullanılacak sorgular
                string personelQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personelname = @usernamep";
                string passwordQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_password = @passwordp";

                using (MySqlCommand personelCommand = new MySqlCommand(personelQuery, connection))
                using (MySqlCommand passwordCommand = new MySqlCommand(passwordQuery, connection))
                {
                    connection.Open();

                    // Kullanıcı adı kontrolü
                    personelCommand.Parameters.AddWithValue("@usernamep", personelName);
                    int personelCount = Convert.ToInt32(personelCommand.ExecuteScalar());
                    if (personelCount == 0)
                    {
                        MessageBox.Show("Bu personel adı bulunamadı!");
                        connection.Close();
                        return;
                    }

                    // Şifre kontrolü
                    passwordCommand.Parameters.AddWithValue("@passwordp", password);
                    int passwordCount = Convert.ToInt32(passwordCommand.ExecuteScalar());
                    if (passwordCount == 0)
                    {
                        MessageBox.Show("Bu personelin şifresi yanlış girildi!");
                        connection.Close();
                        return;
                    }

                    // Kayıt işlemleri burada yer alacak
                    string kullaniciAdi = txt_Username.Text;
                    string kullanicisifre = txt_password.Text;
                    string mail = txt_email.Text;
                    string duzeltilmisNumara = Regex.Replace(mask_tel.Text, @"[^0-9]", "").Trim();
                    string tamNumara = "0" + duzeltilmisNumara;
                    


                    string userQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personelname = @username UNION SELECT COUNT(*) FROM library_1.users WHERE username = @username";
                    string userpasswordQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_password = @password UNION SELECT COUNT(*) FROM library_1.users WHERE user_password = @password";
                    string phoneQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_number = @phone UNION SELECT COUNT(*) FROM library_1.users WHERE user_number = @phone";
                    string mailQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_mail = @mail UNION SELECT COUNT(*) FROM library_1.users WHERE user_mail = @mail";


                    using (MySqlCommand userCommand = new MySqlCommand(userQuery, connection))
                    using (MySqlCommand passCommand = new MySqlCommand(userpasswordQuery, connection))
                    using (MySqlCommand phoneCommand = new MySqlCommand(phoneQuery, connection))
                    using (MySqlCommand mailCommand = new MySqlCommand(mailQuery, connection))
                    {
                        // Kullanıcı adı kontrolü
                        userCommand.Parameters.AddWithValue("@username", kullaniciAdi);
                        int userCount = Convert.ToInt32(userCommand.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!");
                            connection.Close();
                            return;
                        }

                        // Şifre kontrolü
                        passCommand.Parameters.AddWithValue("@password", kullanicisifre);
                        int passCount = Convert.ToInt32(passCommand.ExecuteScalar());
                        if (passCount > 0)
                        {
                            MessageBox.Show("Bu şifre zaten kullanılıyor!");
                            connection.Close();
                            return;
                        }

                        // Telefon numarası kontrolü
                        phoneCommand.Parameters.AddWithValue("@phone", duzeltilmisNumara);
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

                        string query = "INSERT INTO library_1.users (user_name, user_surname, user_birthday, user_gender, user_number, user_address, user_mail, username, user_password) " +
                                        "VALUES (@isim, @soyisim, @dogum_tarihi, @cinsiyet, @telefon, @adres, @mail, @kullanici_adi, @sifre)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@isim", txt_ad.Text);
                            command.Parameters.AddWithValue("@soyisim", txt_soyad.Text);
                            command.Parameters.AddWithValue("@dogum_tarihi", date_Tarih.Value);
                            command.Parameters.AddWithValue("@cinsiyet", erkekSecildi ? "Erkek" : "Kadın");
                            command.Parameters.AddWithValue("@telefon", tamNumara);
                            command.Parameters.AddWithValue("@adres", txt_adres.Text);
                            command.Parameters.AddWithValue("@mail", txt_email.Text);
                            command.Parameters.AddWithValue("@kullanici_adi", txt_Username.Text);
                            command.Parameters.AddWithValue("@sifre", txt_password.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Kayıt başarıyla eklendi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
