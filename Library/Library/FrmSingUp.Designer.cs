namespace Library
{
    partial class FrmSingUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSingUp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_Tarih = new System.Windows.Forms.DateTimePicker();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.rb_kadin = new System.Windows.Forms.RadioButton();
            this.mask_tel = new System.Windows.Forms.MaskedTextBox();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "   KAYIT OL EKRANI   ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.date_Tarih);
            this.panel1.Controls.Add(this.rb_erkek);
            this.panel1.Controls.Add(this.rb_kadin);
            this.panel1.Controls.Add(this.mask_tel);
            this.panel1.Controls.Add(this.btn_sign_up);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.txt_adres);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_soyad);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(139, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 496);
            this.panel1.TabIndex = 2;
            // 
            // date_Tarih
            // 
            this.date_Tarih.CustomFormat = "yyyy-MM-dd";
            this.date_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Tarih.Location = new System.Drawing.Point(208, 165);
            this.date_Tarih.Name = "date_Tarih";
            this.date_Tarih.Size = new System.Drawing.Size(168, 23);
            this.date_Tarih.TabIndex = 28;
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.BackColor = System.Drawing.Color.White;
            this.rb_erkek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_erkek.Location = new System.Drawing.Point(306, 201);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(73, 21);
            this.rb_erkek.TabIndex = 26;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek    ";
            this.rb_erkek.UseVisualStyleBackColor = false;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.BackColor = System.Drawing.SystemColors.Window;
            this.rb_kadin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_kadin.Location = new System.Drawing.Point(214, 201);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(83, 21);
            this.rb_kadin.TabIndex = 25;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın      ";
            this.rb_kadin.UseVisualStyleBackColor = false;
            // 
            // mask_tel
            // 
            this.mask_tel.Location = new System.Drawing.Point(208, 240);
            this.mask_tel.Mask = "(999) 000-0000";
            this.mask_tel.Name = "mask_tel";
            this.mask_tel.Size = new System.Drawing.Size(171, 23);
            this.mask_tel.TabIndex = 24;
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_sign_up.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sign_up.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sign_up.Location = new System.Drawing.Point(123, 443);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(183, 38);
            this.btn_sign_up.TabIndex = 20;
            this.btn_sign_up.Text = "Kayıt Ol";
            this.btn_sign_up.UseVisualStyleBackColor = false;
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(208, 405);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(168, 23);
            this.txt_password.TabIndex = 19;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(205, 364);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(174, 23);
            this.txt_Username.TabIndex = 18;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(208, 277);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(171, 23);
            this.txt_adres.TabIndex = 17;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(205, 314);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(174, 23);
            this.txt_email.TabIndex = 16;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(208, 121);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(171, 23);
            this.txt_soyad.TabIndex = 12;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(208, 83);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(171, 23);
            this.txt_ad.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGreen;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(51, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Şifre               ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGreen;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(51, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kullanıcı Adı  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(53, 277);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adres             ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(53, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email              ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(51, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon No     ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(54, 165);
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
            this.label4.Location = new System.Drawing.Point(53, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cinsiyet          ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(53, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyadı            ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(53, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı                  ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(403, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmSingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmSingUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSingUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_password;
        private TextBox txt_Username;
        private TextBox txt_email;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btn_sign_up;
        private RadioButton rb_erkek;
        private RadioButton rb_kadin;
        private MaskedTextBox mask_tel;
        private TextBox txt_adres;
        private DateTimePicker date_Tarih;
        private PictureBox pictureBox2;
    }
}