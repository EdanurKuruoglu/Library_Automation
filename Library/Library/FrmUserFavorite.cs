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
    public partial class FrmUserFavorite : Form
    {
        MySqlConnection connection;
        int userid;
        public FrmUserFavorite(int userId)
        {
            InitializeComponent();
            connection = Program.connection;
            this.userid = userId;

        }

        private void txt_book_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_book_search.Text;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string procedureName = "book_search";

                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@search_value", "%" + searchValue + "%");

                MySqlDataReader reader = command.ExecuteReader();

                dataGridViewBook.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridViewBook.Rows.Add(reader["book_ISBN"], reader["book_name"], reader["author_name"], reader["book_page"], reader["publisher_name"], reader["book_number"], reader["language_name"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
            }
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            connection.Close();
            FrmUserHomePage FrmUserHomePage = new FrmUserHomePage(userid);
            FrmUserHomePage.Show();
            this.Hide();
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridViewBook.Rows[e.RowIndex];
                    string kitapad = selectedRow.Cells[1].Value.ToString();
                    string bookISBN = selectedRow.Cells[0].Value.ToString();
                    txt_id.Text = userid.ToString();
                    txt_kitap_adi.Text = kitapad;
                    mask_isbn.Text = bookISBN;
                    string duzeltilmis_isbn = Regex.Replace(mask_isbn.Text, @"[^0-9]", "").Trim();

                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        string procedureName = "CheckBookFavorite";
                        MySqlCommand command = new MySqlCommand(procedureName, connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userid", userid);
                        command.Parameters.AddWithValue("@bookISBN", duzeltilmis_isbn);

                        // Saklı yordamdan dönen favori durumu alın
                        MySqlParameter favoritestateParam = new MySqlParameter("@favoritestate", MySqlDbType.VarChar, 25);
                        favoritestateParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(favoritestateParam);

                        command.ExecuteNonQuery();

                        // Favori durumunu alın
                        string favoriDurumu = favoritestateParam.Value.ToString();
                        connection.Close();
                        if (favoriDurumu == "Evet")
                        {
                            radio_evet.Checked = true;
                            radio_hayir.Checked = false;
                        }
                        else if (favoriDurumu == "Hayır")
                        {
                            radio_evet.Checked = false;
                            radio_hayir.Checked = true;
                        }
                        else
                        {
                            radio_evet.Checked = false;
                            radio_hayir.Checked = false;
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

        private void kitap_listele_Click(object sender, EventArgs e)
        {
            LoadFavoriteBooks(userid);
        }

        private void LoadFavoriteBooks(int userid)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string procedureName = "fav_book_show";
                MySqlCommand command = new MySqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userid", userid);
                MySqlDataReader reader = command.ExecuteReader();

                dataGridViewfav.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridViewfav.Rows.Add(reader["isbn"], reader["bookname"], reader["authorname"], reader["genre_name"], reader["bookpage"], reader["book_publication_year"], reader["publishername"], reader["booknumber"], reader["languagename"], reader["book_update"]);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
            }
        }

        private void pic_fav_Click(object sender, EventArgs e)
        {
                string book_isbn = mask_isbn.Text;
                string userid = txt_id.Text;
                string duzeltilmis_isbn = Regex.Replace(book_isbn, @"[^0-9]", "").Trim();
                string favoriDurumu = radio_evet.Checked ? "Evet" : "Hayır";

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string procedureName = "user_book_favorite";
                    MySqlCommand command = new MySqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userid", userid);
                    command.Parameters.AddWithValue("@bookISBN", duzeltilmis_isbn);
                    command.Parameters.AddWithValue("@favoritestate", favoriDurumu);

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        if (favoriDurumu == "Evet")
                        {
                            MessageBox.Show("Favori eklendi.");
                        }
                        else if (favoriDurumu == "Hayır")
                        {
                            MessageBox.Show("Favori kaldırıldı.");
                        }
                        connection.Close();
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
