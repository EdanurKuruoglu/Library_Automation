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
    public partial class FrmAddBooks : Form
    {
        MySqlConnection connection;
        public FrmAddBooks()
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

        private void kitap_listele_Click(object sender, EventArgs e)
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
                    dataGridView1.Rows.Add(reader["book_ISBN"], reader["book_name"], reader["author_name"], reader["genre_name"], reader["book_page"], reader["book_publication_year"], reader["publisher_name"], reader["book_number"],reader["language_name"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }


        }

        private void combobx_tur_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "genre_show"; // Saklı yordamın adı
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                combobx_tur.Items.Clear(); // Combobox'ı temizle
                while (reader.Read())
                {
                    combobx_tur.Items.Add(reader["Genre"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                connection.Close();
            }

            
        }

        private void combobx_publisher_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "publisher_show"; // Saklı yordamın adı
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                combobx_publisher.Items.Clear(); // Combobox'ı temizle
                while (reader.Read())
                {
                    combobx_publisher.Items.Add(reader["Publisher"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                connection.Close();
            }
        }

        private void combobx_dil_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "language_show"; // Saklı yordamın adı
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                combobx_dil.Items.Clear(); // Combobox'ı temizle
                while (reader.Read())
                {
                    combobx_dil.Items.Add(reader["Language"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                connection.Close();
            }
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
                try
                {
                    string personelName = personel_adi.Text;
                    string personelPassword = personel_sifre.Text;

                    if (!Program.Injection(personelName) || !Program.Injection(personelPassword))
                    {
                        MessageBox.Show("Geçersiz kullanıcı adı veya şifre");
                        personel_adi.Text = "";
                        personel_sifre.Text = "";
                        return;
                    }

                // Sorgu ile eşleşmeyi kontrol etmek için kullanılacak sorgular
                string personelQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personelname = @personel_name";
                    string p_passwordQuery = "SELECT COUNT(*) FROM library_1.personels WHERE personel_password = @personel_password";

                    using (MySqlCommand personelCommand = new MySqlCommand(personelQuery, connection))
                    using (MySqlCommand passwordCommand = new MySqlCommand(p_passwordQuery, connection))
                    {
                        connection.Open();

                        // Kullanıcı adı kontrolü
                        personelCommand.Parameters.AddWithValue("@personel_name", personelName);
                        int personelCount = Convert.ToInt32(personelCommand.ExecuteScalar());
                        if (personelCount == 0)
                        {
                            MessageBox.Show("Bu personelin adı bulunamadı!");
                            connection.Close();
                            return;
                        }

                        // Şifre kontrolü
                        passwordCommand.Parameters.AddWithValue("@personel_password", personelPassword);
                        int passwordCount = Convert.ToInt32(passwordCommand.ExecuteScalar());
                        if (passwordCount == 0)
                        {
                            MessageBox.Show("Bu personelin şifresi yanlış girildi!");
                            connection.Close();
                            return;
                        }

                        // Kayıt işlemleri burada yer alacak
                        string duzeltilmis_isbn = Regex.Replace(mask_isbn.Text, @"[^0-9]", "").Trim();
                        string book_isbnQuery = "SELECT COUNT(*) FROM library_1.books WHERE book_ISBN = @book_isbn";
                        string authorIdQuery = "SELECT author_id FROM authors WHERE author_name = @authorName";
                        string genreIdQuery = "SELECT genre_id FROM genres WHERE genre_name = @genreName";
                        string publisherIdQuery = "SELECT publisher_id FROM publishers WHERE publisher_name = @publisherName";
                        string languageIdQuery = "SELECT language_id FROM languages WHERE language_name = @languageName";


                    // Comboboxtan veri ekleme Mysql - yazar_id
                    string selectedauthorName = combobx_yazar.Text; // ComboBox'ta seçilen değeri al
                    string authorsQuery = "INSERT INTO authors (author_name) VALUES (@authorName)";
                    using (MySqlCommand command = new MySqlCommand(authorsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@authorName", selectedauthorName);
                        command.ExecuteNonQuery();
                    }

                    // Comboboxtan veri ekleme Mysql - genre_id
                    string selectedgenreName = combobx_tur.Text; // ComboBox'ta seçilen değeri al
                    string tursQuery = "INSERT INTO genres (genre_name) VALUES (@genreName)";
                    using (MySqlCommand command = new MySqlCommand(tursQuery, connection))
                    {
                        command.Parameters.AddWithValue("@genreName", selectedgenreName);
                        command.ExecuteNonQuery();
                    }

                    // Comboboxtan veri ekleme Mysql - publisher_id
                    string selectedpublisherName = combobx_publisher.Text; // ComboBox'ta seçilen değeri al
                    string publisherQuery = "INSERT INTO publishers (publisher_name) VALUES (@publisherName)";
                    using (MySqlCommand command = new MySqlCommand(publisherQuery, connection))
                    {
                        command.Parameters.AddWithValue("@publisherName", selectedpublisherName);
                        command.ExecuteNonQuery();
                    }

                    // Comboboxtan veri ekleme Mysql - language_id
                    string selectedlanguageName = combobx_dil.Text; // ComboBox'ta seçilen değeri al
                    string languageQuery = "INSERT INTO languages (language_name) VALUES (@languageName)";
                    using (MySqlCommand command = new MySqlCommand(languageQuery, connection))
                    {
                        command.Parameters.AddWithValue("@languageName", selectedlanguageName);
                        command.ExecuteNonQuery();
                    }

                    using (MySqlCommand languageIdCommand = new MySqlCommand(languageIdQuery, connection))
                        using (MySqlCommand publisherIdCommand = new MySqlCommand(publisherIdQuery, connection))
                        using (MySqlCommand genreIdCommand = new MySqlCommand(genreIdQuery, connection))
                        using (MySqlCommand authorIdCommand = new MySqlCommand(authorIdQuery, connection))
                        using (MySqlCommand bookCommand = new MySqlCommand(book_isbnQuery, connection))
                        {
                            // Kitap ISBN kontrolü
                            bookCommand.Parameters.AddWithValue("@book_isbn", duzeltilmis_isbn);
                            int passCount = Convert.ToInt32(bookCommand.ExecuteScalar());
                            if (passCount > 0)
                            {
                                MessageBox.Show("Bu kitap veritabanında var!");
                                connection.Close();
                                return;
                            }

                            // Author_id sorgusu
                            string selectedAuthorName = combobx_yazar.Text; // Seçilen pozisyonun adını alın
                            int authorId;
                            authorIdCommand.Parameters.AddWithValue("@authorName", selectedAuthorName);
                            authorId = Convert.ToInt32(authorIdCommand.ExecuteScalar());

                            // Genre_id sorgusu
                            string selectedGenreName = combobx_tur.Text; // Seçilen pozisyonun adını alın
                            int genreId;
                            genreIdCommand.Parameters.AddWithValue("@genreName", selectedGenreName);
                            genreId = Convert.ToInt32(genreIdCommand.ExecuteScalar());

                            // Publisher_id
                            string selectedPublisherName = combobx_publisher.Text; // Seçilen pozisyonun adını alın
                            int publisherId;
                            publisherIdCommand.Parameters.AddWithValue("@publisherName", selectedPublisherName);
                            publisherId = Convert.ToInt32(publisherIdCommand.ExecuteScalar());

                            // Language_id
                            string selectedLanguageName = combobx_dil.Text; // Seçilen pozisyonun adını alın
                            int languageId;
                            languageIdCommand.Parameters.AddWithValue("@languageName", selectedLanguageName);
                            languageId = Convert.ToInt32(languageIdCommand.ExecuteScalar());

                            // Kayıt işlemi
                            date_basim.Format = DateTimePickerFormat.Custom;
                            date_basim.CustomFormat = "yyyy-MM-dd 00:00:00";

                            string query = "INSERT INTO library_1.books (book_ISBN, book_name, author_id, genre_id, book_page, book_publication_year, publisher_id, book_number, language_id) " +
                                           "VALUES (@isbn, @kitap_adi, @yazar_id, @tur_id, @sayfa, @basim, @yayinevi_id, @adet, @dil_id)";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@isbn", duzeltilmis_isbn);
                                command.Parameters.AddWithValue("@kitap_adi", txt_book_ad.Text);
                                command.Parameters.AddWithValue("@yazar_id", authorId);
                                command.Parameters.AddWithValue("@tur_id", genreId);
                                command.Parameters.AddWithValue("@sayfa", txt_page.Text);
                                command.Parameters.AddWithValue("@basim", date_basim.Text);
                                command.Parameters.AddWithValue("@yayinevi_id", publisherId);
                                command.Parameters.AddWithValue("@adet", txt_adet.Text);
                                command.Parameters.AddWithValue("@dil_id", languageId);

                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Kayıt başarıyla eklendi!");
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message.ToString());
                    connection.Close();
                }
            

        }

        private void combobx_yazar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "author_show"; // Saklı yordamın adı
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                combobx_yazar.Items.Clear(); // Combobox'ı temizle
                while (reader.Read())
                {
                    combobx_yazar.Items.Add(reader["Author_name"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                connection.Close();
            }
        }
    }
}
