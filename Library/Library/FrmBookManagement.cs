using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class FrmBookManagement : Form
    {
        MySqlConnection connection;
        public FrmBookManagement()
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

        private void lbl_odunc_kitap_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string  viewName= "borrowing_show";
                string query = $"SELECT * FROM { viewName}";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear(); // DataGridView'ı temizle

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["borrowing_id"], reader["user_id"], reader["user_name"], reader["user_surname"], reader["book_name"], reader["book_ISBN"], reader["book_lending_date"], reader["book_due_date"], reader["borrowing_state"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
                connection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ödünç tablosu
            if (e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                MessageBox.Show("Boş bir satır seçtiniz!");
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Geçerli bir satır seçildiğinden emin olun
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string borrowing_id = selectedRow.Cells[0].Value.ToString();
                string user_id = selectedRow.Cells[1].Value.ToString();
                string isbn = selectedRow.Cells[5].Value.ToString();

                odunc_id.Text = borrowing_id;
                txt_userid.Text = user_id;
                txt_isbn.Text = isbn;

            }
        }

        private void btn_teslim_et_Click(object sender, EventArgs e)
        {
             try
             {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                        foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                        {
                            connection.Open();
                            Int64 borrowId = Convert.ToInt64(selectedRow.Cells["borrowing_id"].Value);
                            Int64 userId = Convert.ToInt64(selectedRow.Cells["user_id"].Value);
                            string userName = selectedRow.Cells["user_name"].Value.ToString();
                            string userSurname = selectedRow.Cells["user_surname"].Value.ToString();
                            string bookName = selectedRow.Cells["book_name"].Value.ToString();
                            Int64 bookISBN = Convert.ToInt64(selectedRow.Cells["book_ISBN"].Value);
                            DateTime lendingDate = Convert.ToDateTime(selectedRow.Cells["book_lending_date"].Value);
                            DateTime dueDate = Convert.ToDateTime(selectedRow.Cells["book_due_date"].Value);
                            string borrowingState = selectedRow.Cells["borrowing_state"].Value.ToString();


                            // Diğer tabloya ekleme işlemi
                            string insertQuery = "INSERT INTO book_returned (borrowing_id, user_id, user_name, user_surname, book_name, book_ISBN, book_lending_date, book_due_date, borrowing_state) VALUES (@BorrowId, @UserId, @UserName, @UserSurname, @BookName, @BookISBN, @LendingDate, @DueDate, @BorrowingState)";

                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@BorrowId", borrowId);
                                insertCommand.Parameters.AddWithValue("@UserId", userId);
                                insertCommand.Parameters.AddWithValue("@UserName", userName);
                                insertCommand.Parameters.AddWithValue("@UserSurname", userSurname);
                                insertCommand.Parameters.AddWithValue("@BookName", bookName);
                                insertCommand.Parameters.AddWithValue("@BookISBN", bookISBN);
                                insertCommand.Parameters.AddWithValue("@LendingDate", lendingDate);
                                insertCommand.Parameters.AddWithValue("@DueDate", dueDate);
                                insertCommand.Parameters.AddWithValue("@BorrowingState", borrowingState);
                                insertCommand.ExecuteNonQuery();
                            }

                            string deleteQuery = "DELETE FROM library_1.book_borrowing WHERE borrowing_id = @borrowId"; // Corrected column name

                            // Seçilen satırı silme işlemi
                            int rowIndex = selectedRow.Index;
                            dataGridView1.Rows.Remove(selectedRow);

                            using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@BorrowId", borrowId);
                                deleteCommand.Parameters.AddWithValue("@UserId", userId);
                                deleteCommand.Parameters.AddWithValue("@UserName", userName);
                                deleteCommand.Parameters.AddWithValue("@UserSurname", userSurname);
                                deleteCommand.Parameters.AddWithValue("@BookName", bookName);
                                deleteCommand.Parameters.AddWithValue("@BookISBN", bookISBN);
                                deleteCommand.Parameters.AddWithValue("@LendingDate", lendingDate);
                                deleteCommand.Parameters.AddWithValue("@DueDate", dueDate);
                                deleteCommand.Parameters.AddWithValue("@BorrowingState", borrowingState);
                                deleteCommand.ExecuteNonQuery();
                            }
                            MessageBox.Show("Kitap Teslim Edildi.");

                            string updateQuery = "UPDATE library_1.books SET book_number = book_number + 1 WHERE book_ISBN = @BookISBN";

                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@BookISBN", bookISBN);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir satır seçin.");
                    }
                
                    
               
             }
             catch (Exception ex)
             {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
             }
            finally
             {
                connection.Close();
             }
        }

        private void lbl_teslim_gecmis_Click(object sender, EventArgs e)
        { 
            try
             {
                    connection.Open();
                    string procedureName = "delivery";
                    MySqlCommand command = new MySqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader reader = command.ExecuteReader();
                    data_teslim_tarihi.Rows.Clear(); // DataGridView'ı temizle
                  
                    while (reader.Read())
                    {
                        data_teslim_tarihi.Rows.Add(reader["borrowing_id"], reader["user_id"], reader["user_name"], reader["user_surname"], reader["book_name"], reader["book_ISBN"], reader["book_lending_date"], reader["book_due_date"],reader["borrowing_state"], reader["penalty"]);
                    }
                    connection.Close();


            }
            catch (Exception ex)
            {
               MessageBox.Show("Hata: " + ex.Message.ToString());
               connection.Close();
             }
        }


        private void ode_teslim_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_teslim_tarihi.SelectedRows.Count > 0)
                {
                    if (ode.Checked)
                    {



                        foreach (DataGridViewRow selectedRow in data_teslim_tarihi.SelectedRows)
                        {
                            connection.Open();
                            Int64 borrowId = Convert.ToInt64(selectedRow.Cells["borrow_id"].Value);
                            Int64 userId = Convert.ToInt64(selectedRow.Cells["userid"].Value);
                            string userName = selectedRow.Cells["username"].Value.ToString();
                            string userSurname = selectedRow.Cells["usersurname"].Value.ToString();
                            string bookName = selectedRow.Cells["bookname"].Value.ToString();
                            Int64 bookISBN = Convert.ToInt64(selectedRow.Cells["bookISBN"].Value);
                            DateTime lendingDate = Convert.ToDateTime(selectedRow.Cells["lending"].Value);
                            DateTime dueDate = Convert.ToDateTime(selectedRow.Cells["due"].Value);
                            string borrowState = selectedRow.Cells["borrow_state"].Value.ToString();
                            Int64 penalty = Convert.ToInt64(selectedRow.Cells["penalty"].Value);


                            // Diğer tabloya ekleme işlemi
                            string insertQuery = "INSERT INTO book_returned (borrowing_id, user_id, user_name, user_surname, book_name, book_ISBN, book_lending_date, book_due_date, borrowing_state) VALUES (@BorrowId, @UserId, @UserName, @UserSurname, @BookName, @BookISBN, @LendingDate, @DueDate, @BorrowingState)";

                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@BorrowId", borrowId);
                                insertCommand.Parameters.AddWithValue("@UserId", userId);
                                insertCommand.Parameters.AddWithValue("@UserName", userName);
                                insertCommand.Parameters.AddWithValue("@UserSurname", userSurname);
                                insertCommand.Parameters.AddWithValue("@BookName", bookName);
                                insertCommand.Parameters.AddWithValue("@BookISBN", bookISBN);
                                insertCommand.Parameters.AddWithValue("@LendingDate", lendingDate);
                                insertCommand.Parameters.AddWithValue("@DueDate", dueDate);
                                insertCommand.Parameters.AddWithValue("@BorrowingState", borrowState);
                                insertCommand.ExecuteNonQuery();
                            }


                            // Seçilen satırı silme işlemi
                            int rowIndex = selectedRow.Index;
                            data_teslim_tarihi.Rows.Remove(selectedRow);

                            MessageBox.Show("Kitap Teslim Edildi.");

                            string updateQuery = "UPDATE library_1.books SET book_number = book_number + 1 WHERE book_ISBN = @BookISBN";

                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@BookISBN", bookISBN);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin.");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void data_teslim_tarihi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                MessageBox.Show("Boş bir satır seçtiniz!");
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Geçerli bir satır seçildiğinden emin olun
            {
                DataGridViewRow selectedRow = data_teslim_tarihi.Rows[e.RowIndex];
                string borrowing_id = selectedRow.Cells[0].Value.ToString();
                string user_id = selectedRow.Cells[1].Value.ToString();
                string isbn = selectedRow.Cells[5].Value.ToString();
                string para = selectedRow.Cells[9].Value.ToString();

                txt_gecikmis_id.Text = borrowing_id;
                txt_g_userid.Text = user_id;
                textBox_isbn.Text = isbn;
                lbl_para.Text = para + " tl";

            }
        }

    }
}
