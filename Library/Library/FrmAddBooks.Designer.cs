namespace Library
{
    partial class FrmAddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combobx_yazar = new System.Windows.Forms.ComboBox();
            this.date_basim = new System.Windows.Forms.DateTimePicker();
            this.mask_isbn = new System.Windows.Forms.MaskedTextBox();
            this.combobx_publisher = new System.Windows.Forms.ComboBox();
            this.combobx_dil = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_page = new System.Windows.Forms.TextBox();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.combobx_tur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.personel_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.personel_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_book_ad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kitap_listele = new System.Windows.Forms.Label();
            this.book_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_publication_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 650);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.combobx_yazar);
            this.panel2.Controls.Add(this.date_basim);
            this.panel2.Controls.Add(this.mask_isbn);
            this.panel2.Controls.Add(this.combobx_publisher);
            this.panel2.Controls.Add(this.combobx_dil);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_page);
            this.panel2.Controls.Add(this.btn_sign_up);
            this.panel2.Controls.Add(this.combobx_tur);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.personel_sifre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.personel_adi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_adet);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_book_ad);
            this.panel2.Location = new System.Drawing.Point(608, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 601);
            this.panel2.TabIndex = 3;
            // 
            // combobx_yazar
            // 
            this.combobx_yazar.FormattingEnabled = true;
            this.combobx_yazar.Location = new System.Drawing.Point(209, 173);
            this.combobx_yazar.Name = "combobx_yazar";
            this.combobx_yazar.Size = new System.Drawing.Size(171, 23);
            this.combobx_yazar.TabIndex = 95;
            this.combobx_yazar.Click += new System.EventHandler(this.combobx_yazar_Click);
            // 
            // date_basim
            // 
            this.date_basim.Location = new System.Drawing.Point(209, 285);
            this.date_basim.Name = "date_basim";
            this.date_basim.Size = new System.Drawing.Size(171, 23);
            this.date_basim.TabIndex = 94;
            // 
            // mask_isbn
            // 
            this.mask_isbn.Location = new System.Drawing.Point(209, 91);
            this.mask_isbn.Mask = "999-9-999999-99-9";
            this.mask_isbn.Name = "mask_isbn";
            this.mask_isbn.Size = new System.Drawing.Size(171, 23);
            this.mask_isbn.TabIndex = 35;
            // 
            // combobx_publisher
            // 
            this.combobx_publisher.FormattingEnabled = true;
            this.combobx_publisher.Location = new System.Drawing.Point(209, 322);
            this.combobx_publisher.Name = "combobx_publisher";
            this.combobx_publisher.Size = new System.Drawing.Size(171, 23);
            this.combobx_publisher.TabIndex = 93;
            this.combobx_publisher.Click += new System.EventHandler(this.combobx_publisher_Click);
            // 
            // combobx_dil
            // 
            this.combobx_dil.FormattingEnabled = true;
            this.combobx_dil.Location = new System.Drawing.Point(209, 408);
            this.combobx_dil.Name = "combobx_dil";
            this.combobx_dil.Size = new System.Drawing.Size(171, 23);
            this.combobx_dil.TabIndex = 92;
            this.combobx_dil.Click += new System.EventHandler(this.combobx_dil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_page
            // 
            this.txt_page.Location = new System.Drawing.Point(209, 248);
            this.txt_page.Name = "txt_page";
            this.txt_page.Size = new System.Drawing.Size(171, 23);
            this.txt_page.TabIndex = 90;
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_sign_up.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sign_up.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sign_up.Location = new System.Drawing.Point(132, 540);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(183, 38);
            this.btn_sign_up.TabIndex = 20;
            this.btn_sign_up.Text = "Kayıt Et";
            this.btn_sign_up.UseVisualStyleBackColor = false;
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // combobx_tur
            // 
            this.combobx_tur.FormattingEnabled = true;
            this.combobx_tur.Location = new System.Drawing.Point(209, 209);
            this.combobx_tur.Name = "combobx_tur";
            this.combobx_tur.Size = new System.Drawing.Size(171, 23);
            this.combobx_tur.TabIndex = 89;
            this.combobx_tur.Click += new System.EventHandler(this.combobx_tur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "   KİTAPLARI EKLE   ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGreen;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(54, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 69;
            this.label10.Text = "Kitap ISBN     ";
            // 
            // personel_sifre
            // 
            this.personel_sifre.Location = new System.Drawing.Point(209, 492);
            this.personel_sifre.Name = "personel_sifre";
            this.personel_sifre.Size = new System.Drawing.Size(171, 23);
            this.personel_sifre.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(54, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Kitap Adı        ";
            // 
            // personel_adi
            // 
            this.personel_adi.Location = new System.Drawing.Point(209, 451);
            this.personel_adi.Name = "personel_adi";
            this.personel_adi.Size = new System.Drawing.Size(171, 23);
            this.personel_adi.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(54, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tür                 ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGreen;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(52, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 85;
            this.label11.Text = "Personel Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(55, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Yazar Adı       ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkGreen;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(52, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 84;
            this.label12.Text = "Personel Adı  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(52, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Sayfa Sayısı    ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(54, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "Yayınevi          ";
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(209, 367);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(171, 23);
            this.txt_adet.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(54, 285);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 75;
            this.label8.Text = "Basım Yılı       ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGreen;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(55, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 76;
            this.label9.Text = "Adet                ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(55, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 77;
            this.label2.Text = "Dil                   ";
            // 
            // txt_book_ad
            // 
            this.txt_book_ad.Location = new System.Drawing.Point(209, 129);
            this.txt_book_ad.Name = "txt_book_ad";
            this.txt_book_ad.Size = new System.Drawing.Size(171, 23);
            this.txt_book_ad.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_ISBN,
            this.book_name,
            this.author_id,
            this.genre_id,
            this.book_page,
            this.book_publication_year,
            this.publisher_id,
            this.book_number,
            this.language_id});
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(574, 538);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.kitap_listele);
            this.panel3.Location = new System.Drawing.Point(12, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 57);
            this.panel3.TabIndex = 34;
            // 
            // kitap_listele
            // 
            this.kitap_listele.AutoSize = true;
            this.kitap_listele.BackColor = System.Drawing.Color.Gold;
            this.kitap_listele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kitap_listele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kitap_listele.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitap_listele.Location = new System.Drawing.Point(136, 15);
            this.kitap_listele.Name = "kitap_listele";
            this.kitap_listele.Size = new System.Drawing.Size(256, 34);
            this.kitap_listele.TabIndex = 33;
            this.kitap_listele.Text = "    KİTAPLARI LİSTELE   ";
            this.kitap_listele.Click += new System.EventHandler(this.kitap_listele_Click);
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
            // author_id
            // 
            this.author_id.HeaderText = "Yazar Adı";
            this.author_id.Name = "author_id";
            this.author_id.Width = 80;
            // 
            // genre_id
            // 
            this.genre_id.HeaderText = "Tür";
            this.genre_id.Name = "genre_id";
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
            // publisher_id
            // 
            this.publisher_id.HeaderText = "Yayınevi";
            this.publisher_id.Name = "publisher_id";
            this.publisher_id.Width = 70;
            // 
            // book_number
            // 
            this.book_number.HeaderText = "Adet";
            this.book_number.Name = "book_number";
            this.book_number.Width = 50;
            // 
            // language_id
            // 
            this.language_id.HeaderText = "Dil";
            this.language_id.Name = "language_id";
            this.language_id.Width = 70;
            // 
            // FrmAddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 650);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddBooks";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_sign_up;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label kitap_listele;
        private TextBox txt_page;
        private ComboBox combobx_tur;
        private Label label10;
        private TextBox personel_sifre;
        private Label label3;
        private TextBox personel_adi;
        private Label label4;
        private Label label11;
        private Label label5;
        private Label label12;
        private Label label6;
        private Label label7;
        private TextBox txt_adet;
        private Label label8;
        private Label label9;
        private Label label2;
        private TextBox txt_book_ad;
        private PictureBox pictureBox1;
        private ComboBox combobx_dil;
        private ComboBox combobx_publisher;
        private DateTimePicker date_basim;
        private MaskedTextBox mask_isbn;
        private ComboBox combobx_yazar;
        private DataGridViewTextBoxColumn book_ISBN;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn author_id;
        private DataGridViewTextBoxColumn genre_id;
        private DataGridViewTextBoxColumn book_page;
        private DataGridViewTextBoxColumn book_publication_year;
        private DataGridViewTextBoxColumn publisher_id;
        private DataGridViewTextBoxColumn book_number;
        private DataGridViewTextBoxColumn language_id;
    }
}