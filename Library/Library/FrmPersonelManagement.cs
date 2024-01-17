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
    public partial class FrmPersonelManagement : Form
    {
        MySqlConnection connection;
        public FrmPersonelManagement()
        {
            InitializeComponent();
            connection = Program.connection;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmHomePage FrmHomePage = new FrmHomePage();
            FrmHomePage.Show();
            this.Hide();
        }

        private void pic_ara_Click(object sender, EventArgs e)
        {   string ad = txt_ara.Text.Trim();

                // Veritabanı sorgusu ile eşleşen verileri getirme
                string procedureName = "personel_arama";

                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ad", ad);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Veritabanından okunan verileri DataGridView'e ekleyin
                            dataGridView1.Rows.Add(reader["personel_id"], reader["personel_name"], reader["personel_surname"], reader["personel_birthday"], reader["personel_gender"], reader["personel_number"], reader["personel_address"], reader["personel_mail"], reader["job_name"], reader["personel_start_day"], reader["personelname"], reader["personel_password"], reader["personel_update"]);
                        }
                    }
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    // Eşleşen veri bulunamadı
                    MessageBox.Show("Bu ada sahip kişi bulunamadı.");
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

        private void lbl_personel_listele_Click(object sender, EventArgs e)
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
                    dataGridView1.Rows.Add(reader["personel_id"], reader["personel_name"], reader["personel_surname"], reader["personel_birthday"], reader["personel_gender"], reader["personel_number"], reader["personel_address"], reader["personel_mail"], reader["job_name"], reader["personel_start_day"], reader["personelname"], reader["personel_password"], reader["personel_update"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }
        }

        private void txt_ara_Click(object sender, EventArgs e)
        {
            txt_ara.Clear();
        }

        private void pic_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))// Seçili bir satır olduğundan emin olun
            {
                string id = txt_id.Text;



                DialogResult result = MessageBox.Show("Seçili kullanıcıyı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Veritabanından kullanıcıyı silme işlemi
                        connection.Open();
                        string query = "DELETE FROM library_1.personels WHERE personel_id = @id";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();

                        MessageBox.Show("Kullanıcı başarıyla silindi.");
                        // DataGridView'deki her bir satırı döngü ile kontrol etme
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            // Satırın ID hücresindeki değeri al
                            string rowId = row.Cells[0].Value.ToString();

                            // TextBox'taki ID değeriyle eşleşen satırı bulduysanız
                            if (rowId == id)
                            {
                                // Satırı DataGridView'dan kaldırma
                                dataGridView1.Rows.Remove(row);
                                break; // İşlemi sonlandır
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.");
            }

        }

        private void pic_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                string id = txt_id.Text;
                string ad = txt_ad.Text;
                string soyad = txt_soyad.Text;
                DateTime birthday = date_Tarih.Value;
                string gender = rb_erkek.Checked ? "Erkek" : "Kadın";
                string duzeltilmisNumara = Regex.Replace(mask_tel.Text, @"[^0-9]", "").Trim();
                string tamNumara = "0" + duzeltilmisNumara;
                string address = txt_adres.Text;
                string mail = txt_email.Text;
                string job = combx_job.Text;
                DateTime start_day = date_Start.Value;
                string personelname = txt_personelname.Text;
                string password = txt_personel_password.Text;

                if (!Program.Injection(personelname) || !Program.Injection(password))
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre");
                    txt_personelname.Text = "";
                    txt_personel_password.Text = "";
                    return;
                }


                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdatePersonel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", ad);
                        command.Parameters.AddWithValue("@surname", soyad);
                        command.Parameters.AddWithValue("@birthday", birthday);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@number", tamNumara);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@mail", mail);
                        command.Parameters.AddWithValue("@job", job);
                        command.Parameters.AddWithValue("@start_day", start_day);
                        command.Parameters.AddWithValue("@personelname", personelname);
                        command.Parameters.AddWithValue("@password", password);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string rowId = row.Cells[0].Value.ToString();
                        if( rowId == null)
                        {
                            MessageBox.Show("id bulunamadı");
                        }
                        if (rowId == id)
                        {
                            DataGridViewRow selectedRow = row;
                            selectedRow.Cells["Id"].Value = id;
                            selectedRow.Cells["personel_name"].Value = ad;
                            selectedRow.Cells["personel_surname"].Value = soyad;
                            selectedRow.Cells["personel_birthday"].Value = birthday;
                            selectedRow.Cells["personel_gender"].Value = gender;
                            selectedRow.Cells["personel_number"].Value = tamNumara;
                            selectedRow.Cells["personel_address"].Value = address;
                            selectedRow.Cells["personel_mail"].Value = mail;
                            selectedRow.Cells["job_name"].Value = job;
                            selectedRow.Cells["personel_start_day"].Value = start_day;
                            selectedRow.Cells["personelname"].Value = personelname;
                            selectedRow.Cells["personel_password"].Value = password;
                            break; // İşlemi sonlandır
                        }
                    }



                    MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçin.");
            }
        }
    
        private void FillComboBoxWithJobNames(string selectedJobName)
        {
                combx_job.Items.Clear(); // Önceki verileri temizle

                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT job_name FROM library_1.jobs", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string jobName = reader["job_name"].ToString();
                                combx_job.Items.Add(jobName);

                                if (jobName == selectedJobName) // Seçili iş adını işaretle
                                    combx_job.SelectedItem = jobName;
                            }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                MessageBox.Show("Boş bir satır seçtiniz!");
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Geçerli bir satır seçildiğinden emin olun
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string personel_id = selectedRow.Cells[0].Value.ToString();
                string personel_name = selectedRow.Cells[1].Value.ToString();
                string personel_surname = selectedRow.Cells[2].Value.ToString();
                date_Tarih.Value = (DateTime)selectedRow.Cells["personel_birthday"].Value;
                string personel_number = selectedRow.Cells[5].Value.ToString();
                string personel_address = selectedRow.Cells[6].Value.ToString();
                string personel_mail = selectedRow.Cells[7].Value.ToString();
                // job start day
                date_Start.Value = (DateTime)selectedRow.Cells["personel_start_day"].Value;
                string personelname = selectedRow.Cells[10].Value.ToString();
                string personel_password = selectedRow.Cells[11].Value.ToString();

                // TextBox'lara verileri aktarın
                if (selectedRow.Cells["personel_gender"].Value.ToString() == "Erkek")
                {
                    rb_erkek.Checked = true;
                }
                else if (selectedRow.Cells["personel_gender"].Value.ToString() == "Kadın")
                {
                    rb_kadin.Checked = true;
                }
                string phoneNumber = personel_number.TrimStart('0');
                string jobName = selectedRow.Cells["job_name"].Value.ToString();
                FillComboBoxWithJobNames(jobName);

                txt_id.Text = personel_id;
                txt_ad.Text = personel_name;
                txt_soyad.Text = personel_surname;
                mask_tel.Text = phoneNumber;
                txt_adres.Text = personel_address;
                txt_email.Text = personel_mail;
                txt_personelname.Text = personelname;
                txt_personel_password.Text = personel_password;
            }
        }

    }
}
