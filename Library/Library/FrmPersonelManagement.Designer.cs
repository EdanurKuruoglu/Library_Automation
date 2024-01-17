namespace Library
{
    partial class FrmPersonelManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_start_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_personel_listele = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_ara = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.date_Start = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.combx_job = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pic_guncelle = new System.Windows.Forms.PictureBox();
            this.pic_sil = new System.Windows.Forms.PictureBox();
            this.txt_personel_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_personelname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mask_tel = new System.Windows.Forms.MaskedTextBox();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.date_Tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.rb_kadin = new System.Windows.Forms.RadioButton();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ara)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 778);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.personel_name,
            this.personel_surname,
            this.personel_birthday,
            this.personel_gender,
            this.personel_number,
            this.personel_address,
            this.personel_mail,
            this.job_name,
            this.personel_start_day,
            this.personelname,
            this.personel_password,
            this.personel_update});
            this.dataGridView1.Location = new System.Drawing.Point(21, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(608, 577);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // personel_name
            // 
            this.personel_name.HeaderText = "Name";
            this.personel_name.Name = "personel_name";
            this.personel_name.Width = 70;
            // 
            // personel_surname
            // 
            this.personel_surname.HeaderText = "Surname";
            this.personel_surname.Name = "personel_surname";
            this.personel_surname.Width = 70;
            // 
            // personel_birthday
            // 
            this.personel_birthday.HeaderText = "Birthday";
            this.personel_birthday.Name = "personel_birthday";
            // 
            // personel_gender
            // 
            this.personel_gender.HeaderText = "Gender";
            this.personel_gender.Name = "personel_gender";
            this.personel_gender.Width = 50;
            // 
            // personel_number
            // 
            this.personel_number.HeaderText = "Tel";
            this.personel_number.Name = "personel_number";
            this.personel_number.Width = 85;
            // 
            // personel_address
            // 
            this.personel_address.HeaderText = "Address";
            this.personel_address.Name = "personel_address";
            // 
            // personel_mail
            // 
            this.personel_mail.HeaderText = "Mail";
            this.personel_mail.Name = "personel_mail";
            this.personel_mail.Width = 90;
            // 
            // job_name
            // 
            this.job_name.HeaderText = "Job";
            this.job_name.Name = "job_name";
            this.job_name.Width = 80;
            // 
            // personel_start_day
            // 
            this.personel_start_day.HeaderText = "Start Day";
            this.personel_start_day.Name = "personel_start_day";
            // 
            // personelname
            // 
            this.personelname.HeaderText = "Personel Name";
            this.personelname.Name = "personelname";
            this.personelname.Width = 70;
            // 
            // personel_password
            // 
            this.personel_password.HeaderText = "Password";
            this.personel_password.Name = "personel_password";
            this.personel_password.Width = 70;
            // 
            // personel_update
            // 
            this.personel_update.HeaderText = "Update";
            this.personel_update.Name = "personel_update";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.Controls.Add(this.lbl_personel_listele);
            this.panel4.Location = new System.Drawing.Point(21, 698);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 58);
            this.panel4.TabIndex = 4;
            // 
            // lbl_personel_listele
            // 
            this.lbl_personel_listele.AutoSize = true;
            this.lbl_personel_listele.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_personel_listele.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_personel_listele.ForeColor = System.Drawing.Color.Black;
            this.lbl_personel_listele.Location = new System.Drawing.Point(162, 11);
            this.lbl_personel_listele.Name = "lbl_personel_listele";
            this.lbl_personel_listele.Size = new System.Drawing.Size(281, 32);
            this.lbl_personel_listele.TabIndex = 1;
            this.lbl_personel_listele.Text = "  PERSONELLERİ LİSTELE  ";
            this.lbl_personel_listele.Click += new System.EventHandler(this.lbl_personel_listele_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.pic_ara);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_ara);
            this.panel3.Location = new System.Drawing.Point(21, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 62);
            this.panel3.TabIndex = 2;
            // 
            // pic_ara
            // 
            this.pic_ara.BackColor = System.Drawing.Color.White;
            this.pic_ara.Image = ((System.Drawing.Image)(resources.GetObject("pic_ara.Image")));
            this.pic_ara.Location = new System.Drawing.Point(553, 18);
            this.pic_ara.Name = "pic_ara";
            this.pic_ara.Size = new System.Drawing.Size(45, 32);
            this.pic_ara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_ara.TabIndex = 16;
            this.pic_ara.TabStop = false;
            this.pic_ara.Click += new System.EventHandler(this.pic_ara_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkOrange;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "ARAMA";
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ara.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ara.Location = new System.Drawing.Point(109, 18);
            this.txt_ara.Multiline = true;
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(438, 32);
            this.txt_ara.TabIndex = 0;
            this.txt_ara.Text = "  Kullanıcı Adı Girin";
            this.txt_ara.Click += new System.EventHandler(this.txt_ara_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.date_Start);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.combx_job);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pic_guncelle);
            this.panel2.Controls.Add(this.pic_sil);
            this.panel2.Controls.Add(this.txt_personel_password);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_personelname);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_ad);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.mask_tel);
            this.panel2.Controls.Add(this.rb_erkek);
            this.panel2.Controls.Add(this.date_Tarih);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_adres);
            this.panel2.Controls.Add(this.rb_kadin);
            this.panel2.Controls.Add(this.txt_soyad);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(647, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 732);
            this.panel2.TabIndex = 1;
            //this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(172, 91);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(200, 23);
            this.txt_id.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkGreen;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(27, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 25);
            this.label17.TabIndex = 43;
            this.label17.Text = "Id                    ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(351, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // date_Start
            // 
            this.date_Start.CustomFormat = "yyyy-MM-dd";
            this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Start.Location = new System.Drawing.Point(172, 472);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(200, 23);
            this.date_Start.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Giriş Tarihi     ";
            // 
            // combx_job
            // 
            this.combx_job.FormattingEnabled = true;
            this.combx_job.Location = new System.Drawing.Point(172, 428);
            this.combx_job.Name = "combx_job";
            this.combx_job.Size = new System.Drawing.Size(200, 23);
            this.combx_job.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Gold;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(224, 682);
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
            this.label15.Location = new System.Drawing.Point(71, 682);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "         Sil          ";
            // 
            // pic_guncelle
            // 
            this.pic_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("pic_guncelle.Image")));
            this.pic_guncelle.Location = new System.Drawing.Point(224, 629);
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
            this.pic_sil.Location = new System.Drawing.Point(71, 629);
            this.pic_sil.Name = "pic_sil";
            this.pic_sil.Size = new System.Drawing.Size(100, 50);
            this.pic_sil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_sil.TabIndex = 34;
            this.pic_sil.TabStop = false;
            this.pic_sil.Click += new System.EventHandler(this.pic_sil_Click);
            // 
            // txt_personel_password
            // 
            this.txt_personel_password.Location = new System.Drawing.Point(172, 564);
            this.txt_personel_password.Name = "txt_personel_password";
            this.txt_personel_password.Size = new System.Drawing.Size(200, 23);
            this.txt_personel_password.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "  PERSONEL İŞLEMLERİ  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGreen;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(27, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Personel Şifre";
            // 
            // txt_personelname
            // 
            this.txt_personelname.Location = new System.Drawing.Point(172, 517);
            this.txt_personelname.Name = "txt_personelname";
            this.txt_personelname.Size = new System.Drawing.Size(200, 23);
            this.txt_personelname.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGreen;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(26, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Adı                  ";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(172, 133);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(200, 23);
            this.txt_ad.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkGreen;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(27, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Personel Adı  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadı            ";
            // 
            // mask_tel
            // 
            this.mask_tel.Location = new System.Drawing.Point(172, 296);
            this.mask_tel.Mask = "(999) 000-0000";
            this.mask_tel.Name = "mask_tel";
            this.mask_tel.Size = new System.Drawing.Size(200, 23);
            this.mask_tel.TabIndex = 24;
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.BackColor = System.Drawing.Color.White;
            this.rb_erkek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_erkek.Location = new System.Drawing.Point(283, 250);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(89, 21);
            this.rb_erkek.TabIndex = 26;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek        ";
            this.rb_erkek.UseVisualStyleBackColor = false;
            // 
            // date_Tarih
            // 
            this.date_Tarih.CustomFormat = "yyyy-MM-dd";
            this.date_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Tarih.Location = new System.Drawing.Point(172, 211);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Size = new System.Drawing.Size(200, 23);
            this.date_Tarih.TabIndex = 28;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(172, 382);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 23);
            this.txt_email.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGreen;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(27, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pozisyonu      ";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(172, 338);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(200, 23);
            this.txt_adres.TabIndex = 17;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.BackColor = System.Drawing.SystemColors.Window;
            this.rb_kadin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_kadin.Location = new System.Drawing.Point(172, 250);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(111, 21);
            this.rb_kadin.TabIndex = 25;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın             ";
            this.rb_kadin.UseVisualStyleBackColor = false;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(172, 174);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(200, 23);
            this.txt_soyad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(27, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email              ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(27, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(27, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cinsiyet          ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(27, 338);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adres             ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(27, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon No     ";
            // 
            // FrmPersonelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 781);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPersonelManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelManagement";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ara)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox combx_job;
        private Label label16;
        private Label label15;
        private PictureBox pic_guncelle;
        private PictureBox pic_sil;
        private TextBox txt_personel_password;
        private Label label1;
        private Label label11;
        private TextBox txt_personelname;
        private Label label13;
        private TextBox txt_ad;
        private Label label12;
        private Label label2;
        private MaskedTextBox mask_tel;
        private RadioButton rb_erkek;
        private DateTimePicker date_Tarih;
        private TextBox txt_email;
        private Label label9;
        private TextBox txt_adres;
        private RadioButton rb_kadin;
        private TextBox txt_soyad;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label6;
        private DateTimePicker date_Start;
        private Label label3;
        private Panel panel4;
        private Label lbl_personel_listele;
        private Panel panel3;
        private PictureBox pic_ara;
        private Label label10;
        private TextBox txt_ara;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn personel_name;
        private DataGridViewTextBoxColumn personel_surname;
        private DataGridViewTextBoxColumn personel_birthday;
        private DataGridViewTextBoxColumn personel_gender;
        private DataGridViewTextBoxColumn personel_number;
        private DataGridViewTextBoxColumn personel_address;
        private DataGridViewTextBoxColumn personel_mail;
        private DataGridViewTextBoxColumn job_name;
        private DataGridViewTextBoxColumn personel_start_day;
        private DataGridViewTextBoxColumn personelname;
        private DataGridViewTextBoxColumn personel_password;
        private DataGridViewTextBoxColumn personel_update;
        private TextBox txt_id;
        private Label label17;
    }
}