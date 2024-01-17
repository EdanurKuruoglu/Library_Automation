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
    public partial class FrmBookBorrowing : Form
    {   MySqlConnection connection;
        public FrmBookBorrowing()
        {
            InitializeComponent();
            connection = Program.connection;

            date_Tarih.Format = DateTimePickerFormat.Custom;
            date_Tarih.CustomFormat = "yyyy-MM-dd 00:00:00";
            date_Tarih2.Format = DateTimePickerFormat.Custom;
            date_Tarih2.CustomFormat = "yyyy-MM-dd 00:00:00";


        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void lbl_kullanici_listele_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string procedureName = "kullanici_goruntule";
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView2.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader["user_id"], reader["user_name"], reader["user_surname"], reader["user_birthday"], reader["user_gender"], reader["user_number"], reader["user_address"], reader["user_mail"], reader["username"], reader["user_password"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }
        }

        private void pic_kitap_ara_Click(object sender, EventArgs e)
        {
            string ad = txt_bookname.Text.Trim();
            string procedureName = "book_arama";

            dataGridView1.Rows.Clear();

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
                            dataGridView1.Rows.Add(reader["book_ISBN"], reader["book_name"], reader["author_name"], reader["genre_name"], reader["book_page"], reader["book_publication_year"], reader["publisher_name"], reader["book_number"], reader["language_name"], reader["book_update"]);

                        }
                    }
                }

                if (dataGridView1.Rows.Count == 0)
                {
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

        private void txt_bookname_Click(object sender, EventArgs e)
        {
            txt_bookname.Clear();
        }

        private void txt_user_name_Click(object sender, EventArgs e)
        {
            txt_user_name.Clear();
        }

        private void txt_user_surname_Click(object sender, EventArgs e)
        {
            txt_user_surname.Clear();
        }

        private void pic_user_arama_Click(object sender, EventArgs e)
        {


            string ad = txt_user_name.Text.Trim();
            string soyad = txt_user_surname.Text.Trim();

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
                        dataGridView2.Rows.Clear(); // Önceki verileri temizle

                        while (reader.Read())
                        {
                            // Veritabanından okunan verileri DataGridView'e ekleyin
                            dataGridView2.Rows.Add(reader["user_id"], reader["user_name"], reader["user_surname"], reader["user_birthday"], reader["user_gender"], reader["user_number"], reader["user_address"], reader["user_mail"], reader["username"], reader["user_password"], reader["user_update"]);
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
                mask_isbn.Text = book_ISBN;
                txt_ad.Text = book_name;
                string book_number = selectedRow.Cells[7].Value.ToString();


                if (book_number == "0")
                {
                    connection.Open();
                    radio_hayir.Checked = true;
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    radio_evet.Checked = true;
                    connection.Close();
                }

            }
                
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                MessageBox.Show("Boş bir satır seçtiniz!");
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Geçerli bir satır seçildiğinden emin olun
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                string user_id = selectedRow.Cells[0].Value.ToString();
                string user_name = selectedRow.Cells[1].Value.ToString();
                string user_surname = selectedRow.Cells[2].Value.ToString();

                txt_id.Text = user_id;
                txt_name.Text = user_name;
                txt_surname.Text = user_surname;
               
            }
        }

        private void pic_odunc_Click(object sender, EventArgs e)
        {
                try
                {
                    connection.Open();
                    DateTime Tarih = date_Tarih.Value;
                    DateTime Tarih2 = date_Tarih2.Value;

                    string duzeltilmis_isbn = Regex.Replace(mask_isbn.Text, @"[^0-9]", "").Trim();

                    bool evet = radio_evet.Checked;
                    bool hayir = radio_hayir.Checked;

                    string query = "INSERT INTO library_1.book_borrowing (user_id, user_name, user_surname, book_name, book_ISBN, book_lending_date, book_due_date, borrowing_state) VALUES (@user_id, @user_name, @user_surname, @book_name, @book_ISBN, @book_lending_date, @book_due_date, @borrowing_state)";
                    
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        if (evet)
                        {

                            command.Parameters.AddWithValue("@user_id", Convert.ToInt32(txt_id.Text));
                            command.Parameters.AddWithValue("@user_name", txt_name.Text);
                            command.Parameters.AddWithValue("@user_surname", txt_surname.Text);
                            command.Parameters.AddWithValue("@book_name", txt_ad.Text);
                            command.Parameters.AddWithValue("@book_ISBN", duzeltilmis_isbn);
                            command.Parameters.AddWithValue("@book_lending_date", Tarih);
                            command.Parameters.AddWithValue("@book_due_date",Tarih2);
                            command.Parameters.AddWithValue("@borrowing_state","Evet");
                            command.ExecuteNonQuery();
                            
                            MessageBox.Show("Kayıt başarıyla eklendi!");


                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıttaki kitap yok!");
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

    }
}
