using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Library
{
    public partial class FrmAddPersonel : Form
    {
        MySqlConnection connection;
        public FrmAddPersonel()
        {
            InitializeComponent();
            connection = Program.connection;
        }
        private void personel_listele_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "personel_goruntule";
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["personel_id"], reader["personel_name"], reader["personel_surname"], reader["personel_birthday"], reader["personel_gender"], reader["personel_number"], reader["personel_address"], reader["personel_mail"], reader["job_name"], reader["personel_start_day"], reader["personelname"], reader["personel_password"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmHomePage FrmHomePage = new FrmHomePage();
            FrmHomePage.Show();
            this.Hide();
        }

        private void combobx_pozisyon_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "job_show"; // Saklı yordamın adı
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                combobx_pozisyon.Items.Clear(); // Combobox'ı temizle
                while (reader.Read())
                {
                    combobx_pozisyon.Items.Add(reader["Job"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                connection.Close();
            }
        }

        private void btn_personel_ekle_Click_1(object sender, EventArgs e)
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

                string mail = txt_email.Text;
                string duzeltilmisNumara = Regex.Replace(mask_tel.Text, @"[^0-9]", "").Trim();
                string tamNumara = "0" + duzeltilmisNumara;


                string personelQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personelname = @username UNION SELECT COUNT(*) FROM library_1.users WHERE username = @username";
                string passwordQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_password = @password UNION SELECT COUNT(*) FROM library_1.users WHERE user_password = @password";
                string phoneQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_number = @phone UNION SELECT COUNT(*) FROM library_1.users WHERE user_number = @phone";
                string mailQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_mail = @mail UNION SELECT COUNT(*) FROM library_1.users WHERE user_mail = @mail";

                // Job_id sorgusu
                string jobIdQuery = "SELECT job_id FROM jobs WHERE job_name = @jobName";

                using (MySqlCommand personelCommand = new MySqlCommand(personelQuery, connection))
                using (MySqlCommand passwordCommand = new MySqlCommand(passwordQuery, connection))
                using (MySqlCommand phoneCommand = new MySqlCommand(phoneQuery, connection))
                using (MySqlCommand mailCommand = new MySqlCommand(mailQuery, connection))
                using (MySqlCommand jobIdCommand = new MySqlCommand(jobIdQuery, connection))
                {
                    connection.Open();

                    // Kullanıcı adı kontrolü
                    personelCommand.Parameters.AddWithValue("@username", personelName);
                    int personelCount = Convert.ToInt32(personelCommand.ExecuteScalar());
                    if (personelCount > 0)
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
                    phoneCommand.Parameters.AddWithValue("@phone", tamNumara);
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

                    // Job_id sorgusu
                    string selectedJobName = combobx_pozisyon.Text; // Seçilen pozisyonun adını alın
                    int jobId;
                    jobIdCommand.Parameters.AddWithValue("@jobName", selectedJobName);
                    jobId = Convert.ToInt32(jobIdCommand.ExecuteScalar());
                    

                    // Kayıt işlemi
                    bool erkekSecildi = rb_erkek.Checked;
                    bool kadinSecildi = rb_kadin.Checked;

                    date_Tarih.Format = DateTimePickerFormat.Custom;
                    date_Tarih.CustomFormat = "yyyy-MM-dd 00:00:00";

                    string query = "INSERT INTO library_1.personels (personel_name, personel_surname, personel_birthday, personel_gender, personel_number, personel_address, personel_mail, job_id, personel_start_day, personelname, personel_password) " +
                                    "VALUES (@isim, @soyisim, @dogum_tarihi, @cinsiyet, @telefon, @adres, @mail, @pozisyon, @baslama_tarihi, @kullanici_adi, @sifre)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@isim", txt_ad.Text);
                        command.Parameters.AddWithValue("@soyisim", txt_soyad.Text);
                        command.Parameters.AddWithValue("@dogum_tarihi", date_Tarih.Value);
                        command.Parameters.AddWithValue("@cinsiyet", erkekSecildi ? "Erkek" : "Kadın");
                        command.Parameters.AddWithValue("@telefon", tamNumara);
                        command.Parameters.AddWithValue("@adres", txt_adres.Text);
                        command.Parameters.AddWithValue("@mail", txt_email.Text);
                        command.Parameters.AddWithValue("@pozisyon", jobId);
                        command.Parameters.AddWithValue("@baslama_tarihi", date_job.Text);
                        command.Parameters.AddWithValue("@kullanici_adi", personel_adi.Text);
                        command.Parameters.AddWithValue("@sifre", personel_sifre.Text);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();

                    MessageBox.Show("Kayıt başarıyla eklendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }
        }

    }
}
