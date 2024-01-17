namespace Library
{
    partial class FrmBooksShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooksShow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pic_guncelle = new System.Windows.Forms.PictureBox();
            this.pic_sil = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_kitap_listele = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pic_arama = new System.Windows.Forms.PictureBox();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.mask_isbn = new System.Windows.Forms.MaskedTextBox();
            this.combobx_yazar = new System.Windows.Forms.ComboBox();
            this.date_basim = new System.Windows.Forms.DateTimePicker();
            this.combobx_publisher = new System.Windows.Forms.ComboBox();
            this.combobx_dil = new System.Windows.Forms.ComboBox();
            this.txt_page = new System.Windows.Forms.TextBox();
            this.combobx_tur = new System.Windows.Forms.ComboBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.txt_book_ad = new System.Windows.Forms.TextBox();
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
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sil)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-7, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 721);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Controls.Add(this.combobx_yazar);
            this.panel5.Controls.Add(this.date_basim);
            this.panel5.Controls.Add(this.combobx_publisher);
            this.panel5.Controls.Add(this.combobx_dil);
            this.panel5.Controls.Add(this.txt_page);
            this.panel5.Controls.Add(this.combobx_tur);
            this.panel5.Controls.Add(this.txt_adet);
            this.panel5.Controls.Add(this.txt_book_ad);
            this.panel5.Controls.Add(this.mask_isbn);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.pic_guncelle);
            this.panel5.Controls.Add(this.pic_sil);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Location = new System.Drawing.Point(644, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(386, 619);
            this.panel5.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGreen;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(36, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "Dil                   ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkGreen;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(36, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 25);
            this.label12.TabIndex = 50;
            this.label12.Text = "Adet                ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkGreen;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(35, 304);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(128, 25);
            this.label17.TabIndex = 49;
            this.label17.Text = "Basım Yılı       ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DarkGreen;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(35, 341);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 25);
            this.label18.TabIndex = 48;
            this.label18.Text = "Yayınevi          ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DarkGreen;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(33, 267);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 25);
            this.label19.TabIndex = 47;
            this.label19.Text = "Sayfa Sayısı    ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.DarkGreen;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(36, 192);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 25);
            this.label20.TabIndex = 46;
            this.label20.Text = "Yazar Adı       ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.DarkGreen;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(35, 228);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 25);
            this.label21.TabIndex = 45;
            this.label21.Text = "Tür                 ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DarkGreen;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(35, 148);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 25);
            this.label22.TabIndex = 44;
            this.label22.Text = "Kitap Adı        ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.DarkGreen;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(35, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 25);
            this.label23.TabIndex = 43;
            this.label23.Text = "Kitap ISBN     ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(351, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Gold;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(217, 564);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 20);
            this.label24.TabIndex = 38;
            this.label24.Text = "  Güncelle      ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Gold;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(64, 564);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 20);
            this.label25.TabIndex = 37;
            this.label25.Text = "         Sil          ";
            // 
            // pic_guncelle
            // 
            this.pic_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("pic_guncelle.Image")));
            this.pic_guncelle.Location = new System.Drawing.Point(217, 511);
            this.pic_guncelle.Name = "pic_guncelle";
            this.pic_guncelle.Size = new System.Drawing.Size(101, 50);
            this.pic_guncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_guncelle.TabIndex = 35;
            this.pic_guncelle.TabStop = false;
            this.pic_guncelle.Click += new System.EventHandler(this.pic_guncelle_Click);
            // 
            // pic_sil
            // 
            this.pic_sil.Image = ((System.Drawing.Image)(resources.GetObject("pic_sil.Image")));
            this.pic_sil.Location = new System.Drawing.Point(65, 511);
            this.pic_sil.Name = "pic_sil";
            this.pic_sil.Size = new System.Drawing.Size(100, 50);
            this.pic_sil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_sil.TabIndex = 34;
            this.pic_sil.TabStop = false;
            this.pic_sil.Click += new System.EventHandler(this.pic_sil_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.DarkOrange;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(84, 41);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(215, 32);
            this.label26.TabIndex = 0;
            this.label26.Text = "  KİTAP İŞLEMLERİ  ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.Controls.Add(this.lbl_kitap_listele);
            this.panel4.Location = new System.Drawing.Point(21, 595);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 58);
            this.panel4.TabIndex = 4;
            // 
            // lbl_kitap_listele
            // 
            this.lbl_kitap_listele.AutoSize = true;
            this.lbl_kitap_listele.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_kitap_listele.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kitap_listele.ForeColor = System.Drawing.Color.Black;
            this.lbl_kitap_listele.Location = new System.Drawing.Point(188, 15);
            this.lbl_kitap_listele.Name = "lbl_kitap_listele";
            this.lbl_kitap_listele.Size = new System.Drawing.Size(233, 32);
            this.lbl_kitap_listele.TabIndex = 1;
            this.lbl_kitap_listele.Text = "  KİTAPLARI LİSTELE  ";
            this.lbl_kitap_listele.Click += new System.EventHandler(this.lbl_kitap_listele_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pic_arama);
            this.panel3.Controls.Add(this.txt_ara);
            this.panel3.Location = new System.Drawing.Point(21, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 73);
            this.panel3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkOrange;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "ARAMA";
            // 
            // pic_arama
            // 
            this.pic_arama.BackColor = System.Drawing.Color.White;
            this.pic_arama.Image = ((System.Drawing.Image)(resources.GetObject("pic_arama.Image")));
            this.pic_arama.Location = new System.Drawing.Point(553, 18);
            this.pic_arama.Name = "pic_arama";
            this.pic_arama.Size = new System.Drawing.Size(45, 32);
            this.pic_arama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_arama.TabIndex = 16;
            this.pic_arama.TabStop = false;
            this.pic_arama.Click += new System.EventHandler(this.pic_arama_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ara.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_ara.Location = new System.Drawing.Point(110, 18);
            this.txt_ara.Multiline = true;
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(437, 32);
            this.txt_ara.TabIndex = 0;
            this.txt_ara.Text = "  Kitap Adını Girin";
            this.txt_ara.Click += new System.EventHandler(this.txt_ara_Click);
            // 
            // mask_isbn
            // 
            this.mask_isbn.Location = new System.Drawing.Point(190, 115);
            this.mask_isbn.Mask = "999-9-999999-99-9";
            this.mask_isbn.Name = "mask_isbn";
            this.mask_isbn.Size = new System.Drawing.Size(171, 23);
            this.mask_isbn.TabIndex = 69;
            // 
            // combobx_yazar
            // 
            this.combobx_yazar.FormattingEnabled = true;
            this.combobx_yazar.Location = new System.Drawing.Point(190, 192);
            this.combobx_yazar.Name = "combobx_yazar";
            this.combobx_yazar.Size = new System.Drawing.Size(171, 23);
            this.combobx_yazar.TabIndex = 103;
            // 
            // date_basim
            // 
            this.date_basim.Location = new System.Drawing.Point(190, 304);
            this.date_basim.Name = "date_basim";
            this.date_basim.Size = new System.Drawing.Size(171, 23);
            this.date_basim.TabIndex = 102;
            // 
            // combobx_publisher
            // 
            this.combobx_publisher.FormattingEnabled = true;
            this.combobx_publisher.Location = new System.Drawing.Point(190, 341);
            this.combobx_publisher.Name = "combobx_publisher";
            this.combobx_publisher.Size = new System.Drawing.Size(171, 23);
            this.combobx_publisher.TabIndex = 101;
            // 
            // combobx_dil
            // 
            this.combobx_dil.FormattingEnabled = true;
            this.combobx_dil.Location = new System.Drawing.Point(190, 427);
            this.combobx_dil.Name = "combobx_dil";
            this.combobx_dil.Size = new System.Drawing.Size(171, 23);
            this.combobx_dil.TabIndex = 100;
            // 
            // txt_page
            // 
            this.txt_page.Location = new System.Drawing.Point(190, 267);
            this.txt_page.Name = "txt_page";
            this.txt_page.Size = new System.Drawing.Size(171, 23);
            this.txt_page.TabIndex = 99;
            // 
            // combobx_tur
            // 
            this.combobx_tur.FormattingEnabled = true;
            this.combobx_tur.Location = new System.Drawing.Point(190, 228);
            this.combobx_tur.Name = "combobx_tur";
            this.combobx_tur.Size = new System.Drawing.Size(171, 23);
            this.combobx_tur.TabIndex = 98;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(190, 386);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(171, 23);
            this.txt_adet.TabIndex = 97;
            // 
            // txt_book_ad
            // 
            this.txt_book_ad.Location = new System.Drawing.Point(190, 148);
            this.txt_book_ad.Name = "txt_book_ad";
            this.txt_book_ad.Size = new System.Drawing.Size(171, 23);
            this.txt_book_ad.TabIndex = 96;
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(608, 476);
            this.dataGridView1.TabIndex = 7;
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
            // FrmBooksShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 669);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBooksShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBooksShow";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sil)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label lbl_kitap_listele;
        private Panel panel3;
        private Label label10;
        private PictureBox pic_arama;
        private TextBox txt_ara;
        private Panel panel5;
        private Label label11;
        private Label label12;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private PictureBox pictureBox5;
        private Label label24;
        private Label label25;
        private PictureBox pic_guncelle;
        private PictureBox pic_sil;
        private Label label26;
        private MaskedTextBox mask_isbn;
        private ComboBox combobx_yazar;
        private DateTimePicker date_basim;
        private ComboBox combobx_publisher;
        private ComboBox combobx_dil;
        private TextBox txt_page;
        private ComboBox combobx_tur;
        private TextBox txt_adet;
        private TextBox txt_book_ad;
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
    }
}