namespace Library
{
    partial class FrmUserFavorite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserFavorite));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewfav = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kitap_listele = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.radio_hayir = new System.Windows.Forms.RadioButton();
            this.radio_evet = new System.Windows.Forms.RadioButton();
            this.mask_isbn = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pic_fav = new System.Windows.Forms.PictureBox();
            this.txt_kitap_adi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.favoriDurumu = new System.Windows.Forms.GroupBox();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.book_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_book_search = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_publication_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languagename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfav)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dataGridViewfav);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dataGridViewBook);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 725);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewfav
            // 
            this.dataGridViewfav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfav.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.bookname,
            this.authorname,
            this.genre_name,
            this.bookpage,
            this.book_publication_year,
            this.publishername,
            this.booknumber,
            this.languagename,
            this.book_update});
            this.dataGridViewfav.Location = new System.Drawing.Point(21, 460);
            this.dataGridViewfav.Name = "dataGridViewfav";
            this.dataGridViewfav.RowTemplate.Height = 25;
            this.dataGridViewfav.Size = new System.Drawing.Size(987, 254);
            this.dataGridViewfav.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.kitap_listele);
            this.panel3.Location = new System.Drawing.Point(21, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 57);
            this.panel3.TabIndex = 35;
            // 
            // kitap_listele
            // 
            this.kitap_listele.AutoSize = true;
            this.kitap_listele.BackColor = System.Drawing.Color.Gold;
            this.kitap_listele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kitap_listele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kitap_listele.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitap_listele.Location = new System.Drawing.Point(299, 11);
            this.kitap_listele.Name = "kitap_listele";
            this.kitap_listele.Size = new System.Drawing.Size(367, 34);
            this.kitap_listele.TabIndex = 33;
            this.kitap_listele.Text = "    FAVORİ KİTAPLARIMI LİSTELE   ";
            this.kitap_listele.Click += new System.EventHandler(this.kitap_listele_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.Controls.Add(this.pic_back);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_id);
            this.panel4.Controls.Add(this.radio_hayir);
            this.panel4.Controls.Add(this.radio_evet);
            this.panel4.Controls.Add(this.mask_isbn);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.pic_fav);
            this.panel4.Controls.Add(this.txt_kitap_adi);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.favoriDurumu);
            this.panel4.Location = new System.Drawing.Point(610, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 364);
            this.panel4.TabIndex = 21;
            // 
            // pic_back
            // 
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(360, 3);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(35, 27);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_back.TabIndex = 74;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(28, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 102;
            this.label8.Text = "Kitap Adı           ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(196, 76);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(171, 23);
            this.txt_id.TabIndex = 101;
            // 
            // radio_hayir
            // 
            this.radio_hayir.AutoSize = true;
            this.radio_hayir.BackColor = System.Drawing.Color.White;
            this.radio_hayir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_hayir.Location = new System.Drawing.Point(287, 201);
            this.radio_hayir.Name = "radio_hayir";
            this.radio_hayir.Size = new System.Drawing.Size(80, 21);
            this.radio_hayir.TabIndex = 99;
            this.radio_hayir.Text = "Hayır      ";
            this.radio_hayir.UseVisualStyleBackColor = false;
            // 
            // radio_evet
            // 
            this.radio_evet.AutoSize = true;
            this.radio_evet.BackColor = System.Drawing.Color.White;
            this.radio_evet.Checked = true;
            this.radio_evet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_evet.Location = new System.Drawing.Point(196, 201);
            this.radio_evet.Name = "radio_evet";
            this.radio_evet.Size = new System.Drawing.Size(82, 21);
            this.radio_evet.TabIndex = 98;
            this.radio_evet.TabStop = true;
            this.radio_evet.Text = "Evet        ";
            this.radio_evet.UseVisualStyleBackColor = false;
            // 
            // mask_isbn
            // 
            this.mask_isbn.Location = new System.Drawing.Point(196, 154);
            this.mask_isbn.Mask = "999-9-999999-99-9";
            this.mask_isbn.Name = "mask_isbn";
            this.mask_isbn.Size = new System.Drawing.Size(171, 23);
            this.mask_isbn.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(28, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 96;
            this.label6.Text = "Favori Durumu  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Kitap ISBN         ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Gold;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(148, 320);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 20);
            this.label25.TabIndex = 38;
            this.label25.Text = "      Ekle      ";
            // 
            // pic_fav
            // 
            this.pic_fav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_fav.Image = ((System.Drawing.Image)(resources.GetObject("pic_fav.Image")));
            this.pic_fav.Location = new System.Drawing.Point(148, 257);
            this.pic_fav.Name = "pic_fav";
            this.pic_fav.Size = new System.Drawing.Size(84, 60);
            this.pic_fav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_fav.TabIndex = 31;
            this.pic_fav.TabStop = false;
            this.pic_fav.Click += new System.EventHandler(this.pic_fav_Click);
            // 
            // txt_kitap_adi
            // 
            this.txt_kitap_adi.Location = new System.Drawing.Point(196, 118);
            this.txt_kitap_adi.Name = "txt_kitap_adi";
            this.txt_kitap_adi.Size = new System.Drawing.Size(171, 23);
            this.txt_kitap_adi.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGreen;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(28, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Kullanıcı ID        ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkOrange;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(82, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "   FAVORİ DURUMU   ";
            // 
            // favoriDurumu
            // 
            this.favoriDurumu.BackColor = System.Drawing.Color.Ivory;
            this.favoriDurumu.Location = new System.Drawing.Point(180, 183);
            this.favoriDurumu.Name = "favoriDurumu";
            this.favoriDurumu.Size = new System.Drawing.Size(200, 49);
            this.favoriDurumu.TabIndex = 103;
            this.favoriDurumu.TabStop = false;
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_ISBN,
            this.book_name,
            this.author_name,
            this.book_page,
            this.publisher_name,
            this.book_number,
            this.language_name});
            this.dataGridViewBook.Location = new System.Drawing.Point(21, 84);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowTemplate.Height = 25;
            this.dataGridViewBook.Size = new System.Drawing.Size(572, 292);
            this.dataGridViewBook.TabIndex = 10;
            this.dataGridViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellClick);
            // 
            // book_ISBN
            // 
            this.book_ISBN.HeaderText = "ISBN";
            this.book_ISBN.Name = "book_ISBN";
            this.book_ISBN.Width = 85;
            // 
            // book_name
            // 
            this.book_name.HeaderText = "Kitap Adı";
            this.book_name.Name = "book_name";
            this.book_name.Width = 90;
            // 
            // author_name
            // 
            this.author_name.HeaderText = "Yazar Adı";
            this.author_name.Name = "author_name";
            this.author_name.Width = 90;
            // 
            // book_page
            // 
            this.book_page.HeaderText = "Sayfa Sayısı";
            this.book_page.Name = "book_page";
            this.book_page.Width = 65;
            // 
            // publisher_name
            // 
            this.publisher_name.HeaderText = "Yayınevi";
            this.publisher_name.Name = "publisher_name";
            this.publisher_name.Width = 80;
            // 
            // book_number
            // 
            this.book_number.HeaderText = "Adet";
            this.book_number.Name = "book_number";
            this.book_number.Width = 50;
            // 
            // language_name
            // 
            this.language_name.HeaderText = "Dil";
            this.language_name.Name = "language_name";
            this.language_name.Width = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_book_search);
            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 56);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "ARAMA        ";
            // 
            // txt_book_search
            // 
            this.txt_book_search.Location = new System.Drawing.Point(132, 16);
            this.txt_book_search.Multiline = true;
            this.txt_book_search.Name = "txt_book_search";
            this.txt_book_search.Size = new System.Drawing.Size(407, 25);
            this.txt_book_search.TabIndex = 72;
            this.txt_book_search.TextChanged += new System.EventHandler(this.txt_book_search_TextChanged);
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.Width = 95;
            // 
            // bookname
            // 
            this.bookname.HeaderText = "Kitap Adı";
            this.bookname.Name = "bookname";
            this.bookname.Width = 95;
            // 
            // authorname
            // 
            this.authorname.HeaderText = "Yazar Adı";
            this.authorname.Name = "authorname";
            this.authorname.Width = 95;
            // 
            // genre_name
            // 
            this.genre_name.HeaderText = "Tür";
            this.genre_name.Name = "genre_name";
            // 
            // bookpage
            // 
            this.bookpage.HeaderText = "Sayfa Sayısı";
            this.bookpage.Name = "bookpage";
            this.bookpage.Width = 90;
            // 
            // book_publication_year
            // 
            this.book_publication_year.HeaderText = "Basım Yılı";
            this.book_publication_year.Name = "book_publication_year";
            this.book_publication_year.Width = 95;
            // 
            // publishername
            // 
            this.publishername.HeaderText = "Yayınevi";
            this.publishername.Name = "publishername";
            this.publishername.Width = 85;
            // 
            // booknumber
            // 
            this.booknumber.HeaderText = "Adet";
            this.booknumber.Name = "booknumber";
            this.booknumber.Width = 95;
            // 
            // languagename
            // 
            this.languagename.HeaderText = "Dil";
            this.languagename.Name = "languagename";
            this.languagename.Width = 90;
            // 
            // book_update
            // 
            this.book_update.HeaderText = "Update";
            this.book_update.Name = "book_update";
            this.book_update.Width = 105;
            // 
            // FrmUserFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 726);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUserFavorite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserFavorite";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfav)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewBook;
        private DataGridViewTextBoxColumn book_ISBN;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn author_name;
        private DataGridViewTextBoxColumn book_page;
        private DataGridViewTextBoxColumn publisher_name;
        private DataGridViewTextBoxColumn book_number;
        private DataGridViewTextBoxColumn language_name;
        private Panel panel2;
        private Label label4;
        private TextBox txt_book_search;
        private Panel panel4;
        private PictureBox pic_back;
        private Label label8;
        private TextBox txt_id;
        private RadioButton radio_hayir;
        private RadioButton radio_evet;
        private MaskedTextBox mask_isbn;
        private Label label6;
        private Label label3;
        private Label label25;
        private PictureBox pic_fav;
        private TextBox txt_kitap_adi;
        private Label label13;
        private Label label14;
        private Panel panel3;
        private Label kitap_listele;
        private DataGridView dataGridViewfav;
        private GroupBox favoriDurumu;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn authorname;
        private DataGridViewTextBoxColumn genre_name;
        private DataGridViewTextBoxColumn bookpage;
        private DataGridViewTextBoxColumn book_publication_year;
        private DataGridViewTextBoxColumn publishername;
        private DataGridViewTextBoxColumn booknumber;
        private DataGridViewTextBoxColumn languagename;
        private DataGridViewTextBoxColumn book_update;
    }
}