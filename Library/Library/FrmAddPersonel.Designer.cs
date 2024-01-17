namespace Library
{
    partial class FrmAddPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPersonel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.personel_listele = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_personel_ekle = new System.Windows.Forms.Button();
            this.date_job = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.combobx_pozisyon = new System.Windows.Forms.ComboBox();
            this.personel_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.personel_adi = new System.Windows.Forms.TextBox();
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
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 786);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.personel_listele);
            this.panel3.Location = new System.Drawing.Point(26, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 61);
            this.panel3.TabIndex = 35;
            // 
            // personel_listele
            // 
            this.personel_listele.BackColor = System.Drawing.Color.Gold;
            this.personel_listele.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personel_listele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.personel_listele.Location = new System.Drawing.Point(157, 13);
            this.personel_listele.Name = "personel_listele";
            this.personel_listele.Size = new System.Drawing.Size(289, 39);
            this.personel_listele.TabIndex = 36;
            this.personel_listele.Text = "     PERSONEL LİSTELE      ";
            this.personel_listele.UseVisualStyleBackColor = false;
            this.personel_listele.Click += new System.EventHandler(this.personel_listele_Click_1);
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
            this.personel_password});
            this.dataGridView1.Location = new System.Drawing.Point(26, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(608, 565);
            this.dataGridView1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_personel_ekle);
            this.panel2.Controls.Add(this.date_job);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.combobx_pozisyon);
            this.panel2.Controls.Add(this.personel_sifre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.personel_adi);
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
            this.panel2.Location = new System.Drawing.Point(666, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 642);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_personel_ekle
            // 
            this.btn_personel_ekle.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_personel_ekle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_personel_ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_personel_ekle.Location = new System.Drawing.Point(96, 577);
            this.btn_personel_ekle.Name = "btn_personel_ekle";
            this.btn_personel_ekle.Size = new System.Drawing.Size(183, 43);
            this.btn_personel_ekle.TabIndex = 43;
            this.btn_personel_ekle.Text = "Kayıt Et";
            this.btn_personel_ekle.UseVisualStyleBackColor = false;
            this.btn_personel_ekle.Click += new System.EventHandler(this.btn_personel_ekle_Click_1);
            // 
            // date_job
            // 
            this.date_job.CustomFormat = "yyyy-MM-dd";
            this.date_job.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_job.Location = new System.Drawing.Point(164, 433);
            this.date_job.Name = "date_job";
            this.date_job.Size = new System.Drawing.Size(200, 23);
            this.date_job.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGreen;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(19, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "Giriş Tarihi     ";
            // 
            // combobx_pozisyon
            // 
            this.combobx_pozisyon.FormattingEnabled = true;
            this.combobx_pozisyon.Location = new System.Drawing.Point(164, 392);
            this.combobx_pozisyon.Name = "combobx_pozisyon";
            this.combobx_pozisyon.Size = new System.Drawing.Size(200, 23);
            this.combobx_pozisyon.TabIndex = 39;
            this.combobx_pozisyon.Click += new System.EventHandler(this.combobx_pozisyon_Click);
            // 
            // personel_sifre
            // 
            this.personel_sifre.Location = new System.Drawing.Point(164, 528);
            this.personel_sifre.Name = "personel_sifre";
            this.personel_sifre.Size = new System.Drawing.Size(200, 23);
            this.personel_sifre.TabIndex = 32;
            this.personel_sifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL EKLE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGreen;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(19, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Personel Şifre";
            // 
            // personel_adi
            // 
            this.personel_adi.Location = new System.Drawing.Point(164, 481);
            this.personel_adi.Name = "personel_adi";
            this.personel_adi.Size = new System.Drawing.Size(200, 23);
            this.personel_adi.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGreen;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(18, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Adı                  ";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(164, 97);
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
            this.label12.Location = new System.Drawing.Point(19, 476);
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
            this.label2.Location = new System.Drawing.Point(18, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadı            ";
            // 
            // mask_tel
            // 
            this.mask_tel.Location = new System.Drawing.Point(164, 260);
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
            this.rb_erkek.Location = new System.Drawing.Point(275, 214);
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
            this.date_Tarih.Location = new System.Drawing.Point(164, 175);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Size = new System.Drawing.Size(200, 23);
            this.date_Tarih.TabIndex = 28;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(164, 346);
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
            this.label9.Location = new System.Drawing.Point(19, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pozisyonu      ";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(164, 302);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(200, 23);
            this.txt_adres.TabIndex = 17;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.BackColor = System.Drawing.SystemColors.Window;
            this.rb_kadin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_kadin.Location = new System.Drawing.Point(164, 214);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(111, 21);
            this.rb_kadin.TabIndex = 25;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın             ";
            this.rb_kadin.UseVisualStyleBackColor = false;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(164, 138);
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
            this.label7.Location = new System.Drawing.Point(19, 346);
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
            this.label5.Location = new System.Drawing.Point(19, 173);
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
            this.label4.Location = new System.Drawing.Point(19, 214);
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
            this.label8.Location = new System.Drawing.Point(19, 302);
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
            this.label6.Location = new System.Drawing.Point(19, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon No     ";
            // 
            // FrmAddPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 784);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddPersonel";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private TextBox personel_sifre;
        private Label label11;
        private TextBox personel_adi;
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
        private ComboBox combobx_pozisyon;
        private DateTimePicker date_job;
        private Label label10;
        private Button btn_personel_ekle;
        private Panel panel3;
        private Button personel_listele;
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
        private PictureBox pictureBox1;
    }
}