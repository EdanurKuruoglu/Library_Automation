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
    public partial class FrmBooksShow : Form
    {
        MySqlConnection connection;
        public FrmBooksShow()
        {
            InitializeComponent();
            connection = Program.connection;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmHomePage FrmHomePage = new FrmHomePage();
            FrmHomePage.Show();
            this.Hide();
        }

        private void lbl_kitap_listele_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "book_show";
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["book_ISBN"], reader["book_name"], reader["author_name"], reader["genre_name"], reader["book_page"], reader["book_publication_year"], reader["publisher_name"], reader["book_number"], reader["language_name"]);
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

        private void pic_arama_Click(object sender, EventArgs e)
        {
                string ad = txt_ara.Text.Trim();

                // Veritabanı sorgusu ile eşleşen verileri getirme
                string procedureName = "book_arama";

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
                                dataGridView1.Rows.Add(reader["book_ISBN"], reader["book_name"], reader["author_name"], reader["genre_name"], reader["book_page"], reader["book_publication_year"], reader["publisher_name"], reader["book_number"],reader["language_name"],reader["book_update"]);

                        }
                    }
                    }

                    if (dataGridView1.Rows.Count == 0)
                    {
                        // Eşleşen veri bulunamadı
                        MessageBox.Show("Bu ada sahip kitap bulunamadı.");
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

        private void FillComboBoxWithAuthorNames(string selectedAuthorName)
        {
            combobx_yazar.Items.Clear(); // Önceki verileri temizle

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT author_name FROM library_1.authors", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string authorName = reader["author_name"].ToString();
                            combobx_yazar.Items.Add(authorName);

                            if (authorName == selectedAuthorName) // Seçili iş adını işaretle
                                combobx_yazar.SelectedItem = authorName;
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

        private void FillComboBoxWithGenreNames(string selectedGenreName)
        {
            combobx_tur.Items.Clear(); // Önceki verileri temizle

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT genre_name FROM library_1.genres", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string genreName = reader["genre_name"].ToString();
                            combobx_tur.Items.Add(genreName);

                            if (genreName == selectedGenreName) // Seçili iş adını işaretle
                                combobx_tur.SelectedItem = genreName;
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

        private void FillComboBoxWithPublisherNames(string selectedPublisherName)
        {
            combobx_publisher.Items.Clear(); // Önceki verileri temizle

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT publisher_name FROM library_1.publishers", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string publisherName = reader["publisher_name"].ToString();
                            combobx_publisher.Items.Add(publisherName);

                            if (publisherName == selectedPublisherName) // Seçili iş adını işaretle
                                combobx_publisher.SelectedItem = publisherName;
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

        private void FillComboBoxWithLanguageNames(string selectedLanguageName)
        {
            combobx_dil.Items.Clear(); // Önceki verileri temizle

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT language_name FROM library_1.languages", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string languageName = reader["language_name"].ToString();
                            combobx_dil.Items.Add(languageName);

                            if (languageName == selectedLanguageName) // Seçili iş adını işaretle
                                combobx_dil.SelectedItem = languageName;
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
                string book_ISBN = selectedRow.Cells[0].Value.ToString();
                string book_name = selectedRow.Cells[1].Value.ToString();
                date_basim.Value = (DateTime)selectedRow.Cells["book_publication_year"].Value;
                string book_page = selectedRow.Cells[4].Value.ToString();
                string book_number = selectedRow.Cells[7].Value.ToString();


                string authorName = selectedRow.Cells["author_name"].Value.ToString();
                FillComboBoxWithAuthorNames(authorName);

                string genreName = selectedRow.Cells["genre_name"].Value.ToString();
                FillComboBoxWithGenreNames(genreName);

                string publisherName = selectedRow.Cells["publisher_name"].Value.ToString();
                FillComboBoxWithPublisherNames(publisherName);

                string languageName = selectedRow.Cells["language_name"].Value.ToString();
                FillComboBoxWithLanguageNames(languageName);

                mask_isbn.Text = book_ISBN;
                txt_book_ad.Text = book_name;
                txt_page.Text = book_page;
                txt_adet.Text = book_number;
            }
        }

        private void pic_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mask_isbn.Text))// Seçili bir satır olduğundan emin olun
            {
                string isbn = Regex.Replace(mask_isbn.Text, @"[^0-9]", "").Trim();

                DialogResult result = MessageBox.Show("Seçili kullanıcıyı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Veritabanından kullanıcıyı silme işlemi
                        connection.Open();
                        string query = "DELETE FROM library_1.books WHERE book_ISBN = @isbn";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@isbn", isbn);
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
                            if (rowId == isbn)
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
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.");
                }
            }
        }

        private void pic_guncelle_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(mask_isbn.Text))
                {
                    string isbn = Regex.Replace(mask_isbn.Text, @"[^0-9]", "").Trim();
                    string ad = txt_book_ad.Text;
                    string yazar = combobx_yazar.Text;
                    string tur = combobx_tur.Text;
                    string sayfa = txt_page.Text;
                    DateTime basim = date_basim.Value;
                    string yayinevi = combobx_publisher.Text;
                    string adet = txt_adet.Text;
                    string dil = combobx_dil.Text;

                    try
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand("UpdateBook", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@isbn", isbn);
                            command.Parameters.AddWithValue("@ad", ad);
                            command.Parameters.AddWithValue("@yazar", yazar);
                            command.Parameters.AddWithValue("@tur", tur);
                            command.Parameters.AddWithValue("@sayfa", sayfa);
                            command.Parameters.AddWithValue("@basim", basim);
                            command.Parameters.AddWithValue("@yayinevi", yayinevi);
                            command.Parameters.AddWithValue("@adet", adet);
                            command.Parameters.AddWithValue("@dil", dil);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            string rowId = row.Cells[0].Value.ToString();
                            if (rowId == null)
                            {
                                MessageBox.Show("id bulunamadı");
                            }
                            if (rowId == isbn)
                            {
                                DataGridViewRow selectedRow = row;
                                selectedRow.Cells["book_ISBN"].Value = isbn;
                                selectedRow.Cells["book_name"].Value = ad;
                                selectedRow.Cells["author_name"].Value = yazar;
                                selectedRow.Cells["genre_name"].Value = tur;
                                selectedRow.Cells["book_page"].Value = sayfa;
                                selectedRow.Cells["book_publication_year"].Value = basim;
                                selectedRow.Cells["publisher_name"].Value = yayinevi;
                                selectedRow.Cells["book_number"].Value = adet;
                                selectedRow.Cells["language_name"].Value = dil;
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
