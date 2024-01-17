namespace Library
{
    partial class FrmBookBorrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookBorrowing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.book_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_publication_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_kullanici_listele = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.kitap_listele = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radio_hayir = new System.Windows.Forms.RadioButton();
            this.radio_evet = new System.Windows.Forms.RadioButton();
            this.mask_isbn = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pic_odunc = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Tarih2 = new System.Windows.Forms.DateTimePicker();
            this.date_Tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_user_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_user_arama = new System.Windows.Forms.PictureBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pic_kitap_ara = new System.Windows.Forms.PictureBox();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_odunc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user_arama)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kitap_ara)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 758);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.user_surname,
            this.user_birthday,
            this.user_gender,
            this.user_number,
            this.user_address,
            this.user_mail,
            this.username,
            this.user_password});
            this.dataGridView2.Location = new System.Drawing.Point(17, 443);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(608, 233);
            this.dataGridView2.TabIndex = 38;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "Id";
            this.user_id.Name = "user_id";
            this.user_id.Width = 50;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "Name";
            this.user_name.Name = "user_name";
            this.user_name.Width = 70;
            // 
            // user_surname
            // 
            this.user_surname.HeaderText = "Surname";
            this.user_surname.Name = "user_surname";
            this.user_surname.Width = 70;
            // 
            // user_birthday
            // 
            this.user_birthday.HeaderText = "Birthday";
            this.user_birthday.Name = "user_birthday";
            this.user_birthday.Width = 60;
            // 
            // user_gender
            // 
            this.user_gender.HeaderText = "Gender";
            this.user_gender.Name = "user_gender";
            this.user_gender.Width = 70;
            // 
            // user_number
            // 
            this.user_number.HeaderText = "Tel";
            this.user_number.Name = "user_number";
            this.user_number.Width = 80;
            // 
            // user_address
            // 
            this.user_address.HeaderText = "Address";
            this.user_address.Name = "user_address";
            this.user_address.Width = 70;
            // 
            // user_mail
            // 
            this.user_mail.HeaderText = "Mail";
            this.user_mail.Name = "user_mail";
            // 
            // username
            // 
            this.username.HeaderText = "user_name";
            this.username.Name = "username";
            // 
            // user_password
            // 
            this.user_password.HeaderText = "Password";
            this.user_password.Name = "user_password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_ISBN,
            this.book_name,
            this.author_name,
            this.genre_name,
            this.book_page,
            this.book_publication_year,
            this.publisher_name,
            this.book_number,
            this.language_name,
            this.book_update});
            this.dataGridView1.Location = new System.Drawing.Point(17, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(608, 163);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.book_name.Width = 80;
            // 
            // author_name
            // 
            this.author_name.HeaderText = "Yazar Adı";
            this.author_name.Name = "author_name";
            this.author_name.Width = 80;
            // 
            // genre_name
            // 
            this.genre_name.HeaderText = "Tür";
            this.genre_name.Name = "genre_name";
            // 
            // book_page
            // 
            this.book_page.HeaderText = "Sayfa Sayısı";
            this.book_page.Name = "book_page";
            this.book_page.Width = 65;
            // 
            // book_publication_year
            // 
            this.book_publication_year.HeaderText = "Basım Yılı";
            this.book_publication_year.Name = "book_publication_year";
            this.book_publication_year.Width = 65;
            // 
            // publisher_name
            // 
            this.publisher_name.HeaderText = "Yayınevi";
            this.publisher_name.Name = "publisher_name";
            this.publisher_name.Width = 70;
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
            this.language_name.Width = 70;
            // 
            // book_update
            // 
            this.book_update.HeaderText = "Update";
            this.book_update.Name = "book_update";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Ivory;
            this.panel7.Controls.Add(this.lbl_kullanici_listele);
            this.panel7.Location = new System.Drawing.Point(17, 682);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(608, 59);
            this.panel7.TabIndex = 36;
            // 
            // lbl_kullanici_listele
            // 
            this.lbl_kullanici_listele.AutoSize = true;
            this.lbl_kullanici_listele.BackColor = System.Drawing.Color.Gold;
            this.lbl_kullanici_listele.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kullanici_listele.ForeColor = System.Drawing.Color.Black;
            this.lbl_kullanici_listele.Location = new System.Drawing.Point(143, 16);
            this.lbl_kullanici_listele.Name = "lbl_kullanici_listele";
            this.lbl_kullanici_listele.Size = new System.Drawing.Size(287, 32);
            this.lbl_kullanici_listele.TabIndex = 1;
            this.lbl_kullanici_listele.Text = "  KULLANICILARI LİSTELE  ";
            this.lbl_kullanici_listele.Click += new System.EventHandler(this.lbl_kullanici_listele_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Ivory;
            this.panel6.Controls.Add(this.kitap_listele);
            this.panel6.Location = new System.Drawing.Point(17, 271);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(608, 59);
            this.panel6.TabIndex = 35;
            // 
            // kitap_listele
            // 
            this.kitap_listele.AutoSize = true;
            this.kitap_listele.BackColor = System.Drawing.Color.Gold;
            this.kitap_listele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kitap_listele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kitap_listele.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitap_listele.Location = new System.Drawing.Point(158, 13);
            this.kitap_listele.Name = "kitap_listele";
            this.kitap_listele.Size = new System.Drawing.Size(256, 34);
            this.kitap_listele.TabIndex = 33;
            this.kitap_listele.Text = "    KİTAPLARI LİSTELE   ";
            this.kitap_listele.Click += new System.EventHandler(this.kitap_listele_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Location = new System.Drawing.Point(646, 572);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 174);
            this.panel5.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(13, 18);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(378, 140);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.Controls.Add(this.txt_surname);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_id);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.radio_hayir);
            this.panel4.Controls.Add(this.radio_evet);
            this.panel4.Controls.Add(this.mask_isbn);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.txt_name);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.pic_odunc);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.date_Tarih2);
            this.panel4.Controls.Add(this.date_Tarih);
            this.panel4.Controls.Add(this.txt_ad);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(646, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 526);
            this.panel4.TabIndex = 20;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(196, 153);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(171, 23);
            this.txt_surname.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(28, 190);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(28, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 100;
            this.label7.Text = "Kullanıcı Adı      ";
            // 
            // radio_hayir
            // 
            this.radio_hayir.AutoSize = true;
            this.radio_hayir.BackColor = System.Drawing.Color.White;
            this.radio_hayir.Enabled = false;
            this.radio_hayir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_hayir.Location = new System.Drawing.Point(284, 347);
            this.radio_hayir.Name = "radio_hayir";
            this.radio_hayir.Size = new System.Drawing.Size(80, 21);
            this.radio_hayir.TabIndex = 99;
            this.radio_hayir.TabStop = true;
            this.radio_hayir.Text = "Hayır      ";
            this.radio_hayir.UseVisualStyleBackColor = false;
            // 
            // radio_evet
            // 
            this.radio_evet.AutoSize = true;
            this.radio_evet.BackColor = System.Drawing.Color.White;
            this.radio_evet.Enabled = false;
            this.radio_evet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_evet.Location = new System.Drawing.Point(196, 347);
            this.radio_evet.Name = "radio_evet";
            this.radio_evet.Size = new System.Drawing.Size(82, 21);
            this.radio_evet.TabIndex = 98;
            this.radio_evet.TabStop = true;
            this.radio_evet.Text = "Evet        ";
            this.radio_evet.UseVisualStyleBackColor = false;
            // 
            // mask_isbn
            // 
            this.mask_isbn.Location = new System.Drawing.Point(196, 228);
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
            this.label6.Location = new System.Drawing.Point(28, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 96;
            this.label6.Text = "Ödünç Durumu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Kitap ISBN         ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(372, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 92;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(196, 114);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 23);
            this.txt_name.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Kullanıcı Soyadı";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Gold;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(144, 491);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(109, 20);
            this.label25.TabIndex = 38;
            this.label25.Text = "   Ödünç Ver    ";
            // 
            // pic_odunc
            // 
            this.pic_odunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_odunc.Image = ((System.Drawing.Image)(resources.GetObject("pic_odunc.Image")));
            this.pic_odunc.Location = new System.Drawing.Point(142, 400);
            this.pic_odunc.Name = "pic_odunc";
            this.pic_odunc.Size = new System.Drawing.Size(111, 88);
            this.pic_odunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_odunc.TabIndex = 31;
            this.pic_odunc.TabStop = false;
            this.pic_odunc.Click += new System.EventHandler(this.pic_odunc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 30;
            this.label2.Tag = " ";
            this.label2.Text = "Teslim Tarihi      ";
            // 
            // date_Tarih2
            // 
            this.date_Tarih2.CustomFormat = "yyyy-MM-dd";
            this.date_Tarih2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Tarih2.Location = new System.Drawing.Point(196, 307);
            this.date_Tarih2.Name = "date_Tarih2";
            this.date_Tarih2.Size = new System.Drawing.Size(171, 23);
            this.date_Tarih2.TabIndex = 29;
            // 
            // date_Tarih
            // 
            this.date_Tarih.CustomFormat = "yyyy-MM-dd";
            this.date_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Tarih.Location = new System.Drawing.Point(196, 266);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Size = new System.Drawing.Size(171, 23);
            this.date_Tarih.TabIndex = 28;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(196, 192);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(171, 23);
            this.txt_ad.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(28, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Veriliş Tarihi      ";
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
            this.label14.Size = new System.Drawing.Size(222, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "   ÖDÜNÇ VERME   ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.txt_user_surname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pic_user_arama);
            this.panel2.Controls.Add(this.txt_user_name);
            this.panel2.Location = new System.Drawing.Point(17, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 101);
            this.panel2.TabIndex = 18;
            // 
            // txt_user_surname
            // 
            this.txt_user_surname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_user_surname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_user_surname.Location = new System.Drawing.Point(284, 53);
            this.txt_user_surname.Multiline = true;
            this.txt_user_surname.Name = "txt_user_surname";
            this.txt_user_surname.Size = new System.Drawing.Size(263, 32);
            this.txt_user_surname.TabIndex = 17;
            this.txt_user_surname.Text = "  Kullanıcı Soyadı Girin";
            this.txt_user_surname.Click += new System.EventHandler(this.txt_user_surname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI ARAMA";
            // 
            // pic_user_arama
            // 
            this.pic_user_arama.BackColor = System.Drawing.Color.White;
            this.pic_user_arama.Image = ((System.Drawing.Image)(resources.GetObject("pic_user_arama.Image")));
            this.pic_user_arama.Location = new System.Drawing.Point(553, 53);
            this.pic_user_arama.Name = "pic_user_arama";
            this.pic_user_arama.Size = new System.Drawing.Size(45, 32);
            this.pic_user_arama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_user_arama.TabIndex = 16;
            this.pic_user_arama.TabStop = false;
            this.pic_user_arama.Click += new System.EventHandler(this.pic_user_arama_Click);
            // 
            // txt_user_name
            // 
            this.txt_user_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_user_name.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_user_name.Location = new System.Drawing.Point(17, 53);
            this.txt_user_name.Multiline = true;
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(261, 32);
            this.txt_user_name.TabIndex = 0;
            this.txt_user_name.Text = "  Kullanıcı Adı Girin";
            this.txt_user_name.Click += new System.EventHandler(this.txt_user_name_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pic_kitap_ara);
            this.panel3.Controls.Add(this.txt_bookname);
            this.panel3.Location = new System.Drawing.Point(17, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 73);
            this.panel3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkOrange;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "KİTAP ARAMA";
            // 
            // pic_kitap_ara
            // 
            this.pic_kitap_ara.BackColor = System.Drawing.Color.White;
            this.pic_kitap_ara.Image = ((System.Drawing.Image)(resources.GetObject("pic_kitap_ara.Image")));
            this.pic_kitap_ara.Location = new System.Drawing.Point(553, 18);
            this.pic_kitap_ara.Name = "pic_kitap_ara";
            this.pic_kitap_ara.Size = new System.Drawing.Size(45, 32);
            this.pic_kitap_ara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_kitap_ara.TabIndex = 16;
            this.pic_kitap_ara.TabStop = false;
            this.pic_kitap_ara.Click += new System.EventHandler(this.pic_kitap_ara_Click);
            // 
            // txt_bookname
            // 
            this.txt_bookname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_bookname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_bookname.Location = new System.Drawing.Point(170, 18);
            this.txt_bookname.Multiline = true;
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(377, 32);
            this.txt_bookname.TabIndex = 0;
            this.txt_bookname.Text = "  Kitap Adını Girin";
            this.txt_bookname.Click += new System.EventHandler(this.txt_bookname_Click);
            // 
            // FrmBookBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 755);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBookBorrowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBookBorrowing";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_odunc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user_arama)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kitap_ara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label10;
        private PictureBox pic_kitap_ara;
        private TextBox txt_bookname;
        private Panel panel2;
        private TextBox txt_user_surname;
        private Label label1;
        private PictureBox pic_user_arama;
        private TextBox txt_user_name;
        private Panel panel5;
        private TextBox textBox2;
        private Panel panel4;
        private TextBox txt_name;
        private Label label4;
        private Label label25;
        private PictureBox pic_odunc;
        private Label label2;
        private DateTimePicker date_Tarih2;
        private DateTimePicker date_Tarih;
        private TextBox txt_ad;
        private Label label5;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox4;
        private Panel panel7;
        private Label lbl_kullanici_listele;
        private Panel panel6;
        private Label kitap_listele;
        private Label label3;
        private Label label6;
        private MaskedTextBox mask_isbn;
        private RadioButton radio_hayir;
        private RadioButton radio_evet;
        private TextBox txt_id;
        private Label label7;
        private Label label8;
        private TextBox txt_surname;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn book_ISBN;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn author_name;
        private DataGridViewTextBoxColumn genre_name;
        private DataGridViewTextBoxColumn book_page;
        private DataGridViewTextBoxColumn book_publication_year;
        private DataGridViewTextBoxColumn publisher_name;
        private DataGridViewTextBoxColumn book_number;
        private DataGridViewTextBoxColumn language_name;
        private DataGridViewTextBoxColumn book_update;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn user_name;
        private DataGridViewTextBoxColumn user_surname;
        private DataGridViewTextBoxColumn user_birthday;
        private DataGridViewTextBoxColumn user_gender;
        private DataGridViewTextBoxColumn user_number;
        private DataGridViewTextBoxColumn user_address;
        private DataGridViewTextBoxColumn user_mail;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn user_password;
    }
}