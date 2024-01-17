namespace Library
{
    partial class FrmMemberManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kullanici_listele = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_soyad_ara = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.picture_ara = new System.Windows.Forms.PictureBox();
            this.txt_ad_ara = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.date_Tarih = new System.Windows.Forms.DateTimePicker();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.rb_kadin = new System.Windows.Forms.RadioButton();
            this.mask_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_user_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pic_guncelle = new System.Windows.Forms.PictureBox();
            this.pic_sil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ara)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-9, -22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 691);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.Controls.Add(this.kullanici_listele);
            this.panel4.Location = new System.Drawing.Point(21, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 58);
            this.panel4.TabIndex = 4;
            // 
            // kullanici_listele
            // 
            this.kullanici_listele.AutoSize = true;
            this.kullanici_listele.BackColor = System.Drawing.Color.DarkOrange;
            this.kullanici_listele.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kullanici_listele.ForeColor = System.Drawing.Color.Black;
            this.kullanici_listele.Location = new System.Drawing.Point(165, 15);
            this.kullanici_listele.Name = "kullanici_listele";
            this.kullanici_listele.Size = new System.Drawing.Size(287, 32);
            this.kullanici_listele.TabIndex = 1;
            this.kullanici_listele.Text = "  KULLANICILARI LİSTELE  ";
            this.kullanici_listele.Click += new System.EventHandler(this.kullanici_listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.user_surname,
            this.user_birthday,
            this.user_gender,
            this.user_number,
            this.user_mail,
            this.user_address,
            this.username,
            this.user_password,
            this.user_update});
            this.dataGridView1.Location = new System.Drawing.Point(21, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(608, 455);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.user_gender.Width = 65;
            // 
            // user_number
            // 
            this.user_number.HeaderText = "Tel";
            this.user_number.Name = "user_number";
            this.user_number.Width = 80;
            // 
            // user_mail
            // 
            this.user_mail.HeaderText = "Email";
            this.user_mail.Name = "user_mail";
            this.user_mail.Width = 70;
            // 
            // user_address
            // 
            this.user_address.HeaderText = "Address";
            this.user_address.Name = "user_address";
            this.user_address.Width = 80;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // user_password
            // 
            this.user_password.HeaderText = "Password";
            this.user_password.Name = "user_password";
            // 
            // user_update
            // 
            this.user_update.HeaderText = "Update";
            this.user_update.Name = "user_update";
            this.user_update.Width = 90;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.txt_soyad_ara);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.picture_ara);
            this.panel3.Controls.Add(this.txt_ad_ara);
            this.panel3.Location = new System.Drawing.Point(21, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 73);
            this.panel3.TabIndex = 2;
            // 
            // txt_soyad_ara
            // 
            this.txt_soyad_ara.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_soyad_ara.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_soyad_ara.Location = new System.Drawing.Point(333, 18);
            this.txt_soyad_ara.Multiline = true;
            this.txt_soyad_ara.Name = "txt_soyad_ara";
            this.txt_soyad_ara.Size = new System.Drawing.Size(214, 32);
            this.txt_soyad_ara.TabIndex = 17;
            this.txt_soyad_ara.Text = "  Kullanıcı Soyadı Girin";
            this.txt_soyad_ara.Click += new System.EventHandler(this.txt_soyad_ara_Click);
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
            // picture_ara
            // 
            this.picture_ara.BackColor = System.Drawing.Color.White;
            this.picture_ara.Image = ((System.Drawing.Image)(resources.GetObject("picture_ara.Image")));
            this.picture_ara.Location = new System.Drawing.Point(553, 18);
            this.picture_ara.Name = "picture_ara";
            this.picture_ara.Size = new System.Drawing.Size(45, 32);
            this.picture_ara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_ara.TabIndex = 16;
            this.picture_ara.TabStop = false;
            this.picture_ara.Click += new System.EventHandler(this.picture_ara_Click);
            // 
            // txt_ad_ara
            // 
            this.txt_ad_ara.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ad_ara.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_ad_ara.Location = new System.Drawing.Point(110, 18);
            this.txt_ad_ara.Multiline = true;
            this.txt_ad_ara.Name = "txt_ad_ara";
            this.txt_ad_ara.Size = new System.Drawing.Size(217, 32);
            this.txt_ad_ara.TabIndex = 0;
            this.txt_ad_ara.Text = "  Kullanıcı Adı Girin";
            this.txt_ad_ara.Click += new System.EventHandler(this.txt_ad_ara_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.date_Tarih);
            this.panel2.Controls.Add(this.rb_erkek);
            this.panel2.Controls.Add(this.rb_kadin);
            this.panel2.Controls.Add(this.mask_tel);
            this.panel2.Controls.Add(this.txt_user_password);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Controls.Add(this.txt_adres);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.txt_soyad);
            this.panel2.Controls.Add(this.txt_ad);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pic_back);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pic_guncelle);
            this.panel2.Controls.Add(this.pic_sil);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(645, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 620);
            this.panel2.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(190, 106);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(171, 23);
            this.txt_id.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGreen;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(33, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "Id                     ";
            // 
            // date_Tarih
            // 
            this.date_Tarih.CustomFormat = "yyyy-MM-dd";
            this.date_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Tarih.Location = new System.Drawing.Point(190, 227);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Size = new System.Drawing.Size(171, 23);
            this.date_Tarih.TabIndex = 61;
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.BackColor = System.Drawing.Color.White;
            this.rb_erkek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_erkek.Location = new System.Drawing.Point(288, 263);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(73, 21);
            this.rb_erkek.TabIndex = 60;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek    ";
            this.rb_erkek.UseVisualStyleBackColor = false;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.BackColor = System.Drawing.SystemColors.Window;
            this.rb_kadin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_kadin.Location = new System.Drawing.Point(190, 263);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(83, 21);
            this.rb_kadin.TabIndex = 59;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın      ";
            this.rb_kadin.UseVisualStyleBackColor = false;
            // 
            // mask_tel
            // 
            this.mask_tel.Location = new System.Drawing.Point(190, 302);
            this.mask_tel.Mask = "(999) 000-0000";
            this.mask_tel.Name = "mask_tel";
            this.mask_tel.Size = new System.Drawing.Size(171, 23);
            this.mask_tel.TabIndex = 58;
            // 
            // txt_user_password
            // 
            this.txt_user_password.Location = new System.Drawing.Point(190, 462);
            this.txt_user_password.Name = "txt_user_password";
            this.txt_user_password.Size = new System.Drawing.Size(171, 23);
            this.txt_user_password.TabIndex = 57;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(190, 421);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(171, 23);
            this.txt_username.TabIndex = 56;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(190, 339);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(171, 23);
            this.txt_adres.TabIndex = 55;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(190, 376);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(171, 23);
            this.txt_email.TabIndex = 54;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(190, 183);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(171, 23);
            this.txt_soyad.TabIndex = 53;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(190, 145);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(171, 23);
            this.txt_ad.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(36, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Şifre               ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGreen;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(36, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Kullanıcı Adı  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(35, 339);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Adres             ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(35, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Email              ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(33, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Telefon No     ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(36, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(35, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Cinsiyet          ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(35, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Soyadı            ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGreen;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(35, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 43;
            this.label13.Text = "Adı                  ";
            // 
            // pic_back
            // 
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(351, 0);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(35, 27);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_back.TabIndex = 42;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Gold;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(215, 572);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "  Güncelle      ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gold;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(62, 572);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "         Sil          ";
            // 
            // pic_guncelle
            // 
            this.pic_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("pic_guncelle.Image")));
            this.pic_guncelle.Location = new System.Drawing.Point(215, 519);
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
            this.pic_sil.Location = new System.Drawing.Point(63, 519);
            this.pic_sil.Name = "pic_sil";
            this.pic_sil.Size = new System.Drawing.Size(100, 50);
            this.pic_sil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_sil.TabIndex = 34;
            this.pic_sil.TabStop = false;
            this.pic_sil.Click += new System.EventHandler(this.pic_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "  KULLANICI İŞLEMLERİ  ";
            // 
            // FrmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 669);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMemberManagement";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ara)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label kullanici_listele;
        private DataGridView dataGridView1;
        private Panel panel3;
        private PictureBox picture_ara;
        private Label label10;
        private TextBox txt_ad_ara;
        private Panel panel2;
        private DateTimePicker date_Tarih;
        private RadioButton rb_erkek;
        private RadioButton rb_kadin;
        private MaskedTextBox mask_tel;
        private TextBox txt_user_password;
        private TextBox txt_username;
        private TextBox txt_adres;
        private TextBox txt_email;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label13;
        private PictureBox pic_back;
        private Label label16;
        private Label label15;
        private PictureBox pic_guncelle;
        private PictureBox pic_sil;
        private Label label1;
        private TextBox txt_soyad_ara;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn user_name;
        private DataGridViewTextBoxColumn user_surname;
        private DataGridViewTextBoxColumn user_birthday;
        private DataGridViewTextBoxColumn user_gender;
        private DataGridViewTextBoxColumn user_number;
        private DataGridViewTextBoxColumn user_mail;
        private DataGridViewTextBoxColumn user_address;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn user_password;
        private DataGridViewTextBoxColumn user_update;
        private Label label11;
        private TextBox txt_id;
    }
}