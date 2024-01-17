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
    public partial class FrmMemberManagement : Form
    {
        MySqlConnection connection;
        public FrmMemberManagement()
        {
            InitializeComponent();
            connection = Program.connection;
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmHomePage FrmHomePage = new FrmHomePage();
            FrmHomePage.Show();
            this.Hide(); ;

        }

        private void kullanici_listele_Click(object sender, EventArgs e)
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
                    dataGridView1.Rows.Add(reader["user_id"], reader["user_name"], reader["user_surname"], reader["user_birthday"], reader["user_gender"], reader["user_number"], reader["user_address"], reader["user_mail"], reader["username"], reader["user_password"], reader["user_update"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }
        }

        private void picture_ara_Click(object sender, EventArgs e)
        {

            string ad = txt_ad_ara.Text.Trim();
            string soyad = txt_soyad_ara.Text.Trim();

            // Veritabanı sorgusu ile eşleşen verileri getirme
            string query = "SELECT * FROM library_1.users WHERE user_name = @ad AND user_surname = @soyad";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@soyad", soyad);

                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // Önceki verileri temizle

                        while (reader.Read())
                        {
                            // Veritabanından okunan verileri DataGridView'e ekleyin
                            dataGridView1.Rows.Add(reader["user_id"], reader["user_name"], reader["user_surname"], reader["user_birthday"], reader["user_gender"], reader["user_number"], reader["user_address"], reader["user_mail"], reader["username"], reader["user_password"], reader["user_update"]);
                        }

                        if (dataGridView1.Rows.Count == 0)
                        {
                            // Eşleşen veri bulunamadı
                            MessageBox.Show("Bu ad ve soyada sahip kişi bulunamadı.");
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


        private void txt_ad_ara_Click(object sender, EventArgs e)
        {
            txt_ad_ara.Clear();
        }

        private void txt_soyad_ara_Click(object sender, EventArgs e)
        {
            txt_soyad_ara.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if(e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                MessageBox.Show("Boş bir satır seçtiniz!");
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Geçerli bir satır seçildiğinden emin olun
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string user_id = selectedRow.Cells[0].Value.ToString();
                string user_name = selectedRow.Cells[1].Value.ToString();
                string user_surname = selectedRow.Cells[2].Value.ToString();
                date_Tarih.Value = (DateTime)selectedRow.Cells["user_birthday"].Value;
                string user_number = selectedRow.Cells[5].Value.ToString();
                string user_address = selectedRow.Cells[6].Value.ToString();
                string user_mail = selectedRow.Cells[7].Value.ToString();
                string username = selectedRow.Cells[8].Value.ToString();
                string user_password = selectedRow.Cells[9].Value.ToString();

                // TextBox'lara verileri aktarın
                if (selectedRow.Cells["user_gender"].Value.ToString() == "Erkek")
                {
                    rb_erkek.Checked = true;
                }
                else if (selectedRow.Cells["user_gender"].Value.ToString() == "Kadın")
                {
                    rb_kadin.Checked = true;
                }
                string phoneNumber = user_number.TrimStart('0');

                
                txt_id.Text = user_id;
                txt_ad.Text = user_name;
                txt_soyad.Text = user_surname;
                mask_tel.Text = phoneNumber;
                txt_adres.Text = user_address;
                txt_email.Text = user_mail;
                txt_username.Text = username;
                txt_user_password.Text = user_password;
            }
        }

        private void pic_sil_Click(object sender, EventArgs e)
        {   if (!string.IsNullOrEmpty(txt_id.Text))// Seçili bir satır olduğundan emin olun
            {
                string id = txt_id.Text;

                

                DialogResult result = MessageBox.Show("Seçili kullanıcıyı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Veritabanından kullanıcıyı silme işlemi
                            connection.Open();
                            string query = "DELETE FROM library_1.users WHERE user_id = @id";
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
                    string username = txt_username.Text;
                    string password = txt_user_password.Text;

                    if (!Program.Injection(username) || !Program.Injection(password))
                    {
                        MessageBox.Show("Geçersiz kullanıcı adı veya şifre");
                        txt_username.Text = "";
                        txt_user_password.Text = "";
                        return;
                    }


                try
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand("UpdateUser", connection))
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
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                         foreach (DataGridViewRow row in dataGridView1.Rows)
                         {
                            string rowId = row.Cells[0].Value.ToString();

                            if (rowId == id)
                            {
                            DataGridViewRow selectedRow = row;
                            selectedRow.Cells["user_id"].Value = id;
                            selectedRow.Cells["user_name"].Value = ad;
                            selectedRow.Cells["user_surname"].Value = soyad;
                            selectedRow.Cells["user_birthday"].Value = birthday;
                            selectedRow.Cells["user_gender"].Value = gender;
                            selectedRow.Cells["user_number"].Value = tamNumara;
                            selectedRow.Cells["user_address"].Value = address;
                            selectedRow.Cells["user_mail"].Value = mail;
                            selectedRow.Cells["username"].Value = username;
                            selectedRow.Cells["user_password"].Value = password;
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

        
    }
}
