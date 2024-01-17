namespace Library
{
    partial class FrmBookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_teslim_tarihi = new System.Windows.Forms.DataGridView();
            this.borrow_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_teslim_gecmis = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_odunc_kitap = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrowing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_lending_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowing_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ode = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gecikmis_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ode_teslim = new System.Windows.Forms.Button();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_g_userid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_teslim_et = new System.Windows.Forms.Button();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.odunc_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_para = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_teslim_tarihi)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.data_teslim_tarihi);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 644);
            this.panel1.TabIndex = 0;
            // 
            // data_teslim_tarihi
            // 
            this.data_teslim_tarihi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_teslim_tarihi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrow_id,
            this.userid,
            this.username,
            this.usersurname,
            this.bookname,
            this.bookISBN,
            this.lending,
            this.due,
            this.borrow_state,
            this.penalty});
            this.data_teslim_tarihi.Location = new System.Drawing.Point(23, 354);
            this.data_teslim_tarihi.Name = "data_teslim_tarihi";
            this.data_teslim_tarihi.RowTemplate.Height = 25;
            this.data_teslim_tarihi.Size = new System.Drawing.Size(579, 258);
            this.data_teslim_tarihi.TabIndex = 37;
            this.data_teslim_tarihi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_teslim_tarihi_CellClick_1);
            //this.data_teslim_tarihi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_teslim_tarihi_CellContentClick);
            // 
            // borrow_id
            // 
            this.borrow_id.HeaderText = "Id";
            this.borrow_id.Name = "borrow_id";
            this.borrow_id.Width = 40;
            // 
            // userid
            // 
            this.userid.HeaderText = "User Id";
            this.userid.Name = "userid";
            this.userid.Width = 40;
            // 
            // username
            // 
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            this.username.Width = 70;
            // 
            // usersurname
            // 
            this.usersurname.HeaderText = "User Surname";
            this.usersurname.Name = "usersurname";
            this.usersurname.Width = 70;
            // 
            // bookname
            // 
            this.bookname.HeaderText = "Book Name";
            this.bookname.Name = "bookname";
            this.bookname.Width = 80;
            // 
            // bookISBN
            // 
            this.bookISBN.HeaderText = "ISBN";
            this.bookISBN.Name = "bookISBN";
            this.bookISBN.Width = 85;
            // 
            // lending
            // 
            this.lending.HeaderText = "Lending Date";
            this.lending.Name = "lending";
            this.lending.Width = 80;
            // 
            // due
            // 
            this.due.HeaderText = "Due Date";
            this.due.Name = "due";
            this.due.Width = 80;
            // 
            // borrow_state
            // 
            this.borrow_state.HeaderText = "State";
            this.borrow_state.Name = "borrow_state";
            // 
            // penalty
            // 
            this.penalty.HeaderText = "Penalty";
            this.penalty.Name = "penalty";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Controls.Add(this.lbl_teslim_gecmis);
            this.panel5.Location = new System.Drawing.Point(23, 296);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(579, 52);
            this.panel5.TabIndex = 36;
            // 
            // lbl_teslim_gecmis
            // 
            this.lbl_teslim_gecmis.AutoSize = true;
            this.lbl_teslim_gecmis.BackColor = System.Drawing.Color.Gold;
            this.lbl_teslim_gecmis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_teslim_gecmis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_teslim_gecmis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_teslim_gecmis.Location = new System.Drawing.Point(72, 11);
            this.lbl_teslim_gecmis.Name = "lbl_teslim_gecmis";
            this.lbl_teslim_gecmis.Size = new System.Drawing.Size(444, 34);
            this.lbl_teslim_gecmis.TabIndex = 33;
            this.lbl_teslim_gecmis.Text = "     TESLİM TARİHİ GEÇMİŞ KİTAPLAR      ";
            this.lbl_teslim_gecmis.Click += new System.EventHandler(this.lbl_teslim_gecmis_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.lbl_odunc_kitap);
            this.panel3.Location = new System.Drawing.Point(23, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 52);
            this.panel3.TabIndex = 36;
            // 
            // lbl_odunc_kitap
            // 
            this.lbl_odunc_kitap.AutoSize = true;
            this.lbl_odunc_kitap.BackColor = System.Drawing.Color.Gold;
            this.lbl_odunc_kitap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_odunc_kitap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_odunc_kitap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_odunc_kitap.Location = new System.Drawing.Point(59, 9);
            this.lbl_odunc_kitap.Name = "lbl_odunc_kitap";
            this.lbl_odunc_kitap.Size = new System.Drawing.Size(470, 34);
            this.lbl_odunc_kitap.TabIndex = 33;
            this.lbl_odunc_kitap.Text = "     ÖDÜNÇ VERİLEN KİTAPLARI LİSTELE      ";
            this.lbl_odunc_kitap.Click += new System.EventHandler(this.lbl_odunc_kitap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowing_id,
            this.user_id,
            this.user_name,
            this.user_surname,
            this.book_name,
            this.book_ISBN,
            this.book_lending_date,
            this.book_due_date,
            this.borrowing_state});
            this.dataGridView1.Location = new System.Drawing.Point(23, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(579, 216);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // borrowing_id
            // 
            this.borrowing_id.HeaderText = "Id";
            this.borrowing_id.Name = "borrowing_id";
            this.borrowing_id.Width = 40;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "User Id";
            this.user_id.Name = "user_id";
            this.user_id.Width = 40;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "User Name";
            this.user_name.Name = "user_name";
            this.user_name.Width = 70;
            // 
            // user_surname
            // 
            this.user_surname.HeaderText = "User Surname";
            this.user_surname.Name = "user_surname";
            this.user_surname.Width = 70;
            // 
            // book_name
            // 
            this.book_name.HeaderText = "Book Name";
            this.book_name.Name = "book_name";
            this.book_name.Width = 80;
            // 
            // book_ISBN
            // 
            this.book_ISBN.HeaderText = "ISBN";
            this.book_ISBN.Name = "book_ISBN";
            this.book_ISBN.Width = 85;
            // 
            // book_lending_date
            // 
            this.book_lending_date.HeaderText = "Lending Date";
            this.book_lending_date.Name = "book_lending_date";
            this.book_lending_date.Width = 80;
            // 
            // book_due_date
            // 
            this.book_due_date.HeaderText = "Due Date";
            this.book_due_date.Name = "book_due_date";
            this.book_due_date.Width = 80;
            // 
            // borrowing_state
            // 
            this.borrowing_state.HeaderText = "State";
            this.borrowing_state.Name = "borrowing_state";
            this.borrowing_state.Width = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.lbl_para);
            this.panel2.Controls.Add(this.ode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_gecikmis_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ode_teslim);
            this.panel2.Controls.Add(this.textBox_isbn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_g_userid);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(625, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 316);
            this.panel2.TabIndex = 22;
            // 
            // ode
            // 
            this.ode.AutoSize = true;
            this.ode.BackColor = System.Drawing.Color.White;
            this.ode.Location = new System.Drawing.Point(207, 202);
            this.ode.Name = "ode";
            this.ode.Size = new System.Drawing.Size(163, 19);
            this.ode.TabIndex = 53;
            this.ode.TabStop = true;
            this.ode.Text = "    Ödendi                             ";
            this.ode.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ücret               ";
            // 
            // txt_gecikmis_id
            // 
            this.txt_gecikmis_id.Location = new System.Drawing.Point(198, 73);
            this.txt_gecikmis_id.Name = "txt_gecikmis_id";
            this.txt_gecikmis_id.Size = new System.Drawing.Size(171, 23);
            this.txt_gecikmis_id.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Ödünç Id        ";
            // 
            // ode_teslim
            // 
            this.ode_teslim.BackColor = System.Drawing.Color.DarkOrange;
            this.ode_teslim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ode_teslim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ode_teslim.Location = new System.Drawing.Point(123, 253);
            this.ode_teslim.Name = "ode_teslim";
            this.ode_teslim.Size = new System.Drawing.Size(144, 38);
            this.ode_teslim.TabIndex = 48;
            this.ode_teslim.Text = "Öde ve Teslim Et";
            this.ode_teslim.UseVisualStyleBackColor = false;
            this.ode_teslim.Click += new System.EventHandler(this.ode_teslim_Click);
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Location = new System.Drawing.Point(200, 158);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(171, 23);
            this.textBox_isbn.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kitap ISBN      ";
            // 
            // txt_g_userid
            // 
            this.txt_g_userid.Location = new System.Drawing.Point(200, 119);
            this.txt_g_userid.Name = "txt_g_userid";
            this.txt_g_userid.Size = new System.Drawing.Size(171, 23);
            this.txt_g_userid.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(32, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kullanıcı ID     ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkOrange;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(32, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "GECİKMİŞ KİTAPLARIN TESLİMİ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.Controls.Add(this.txt_userid);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btn_teslim_et);
            this.panel4.Controls.Add(this.txt_isbn);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.odunc_id);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(625, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 274);
            this.panel4.TabIndex = 21;
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(200, 125);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(171, 23);
            this.txt_userid.TabIndex = 93;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_teslim_et
            // 
            this.btn_teslim_et.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_teslim_et.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_teslim_et.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_teslim_et.Location = new System.Drawing.Point(123, 217);
            this.btn_teslim_et.Name = "btn_teslim_et";
            this.btn_teslim_et.Size = new System.Drawing.Size(144, 38);
            this.btn_teslim_et.TabIndex = 45;
            this.btn_teslim_et.Text = "Teslim Et";
            this.btn_teslim_et.UseVisualStyleBackColor = false;
            this.btn_teslim_et.Click += new System.EventHandler(this.btn_teslim_et_Click);
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(200, 165);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(171, 23);
            this.txt_isbn.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(33, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Kitap ISBN         ";
            // 
            // odunc_id
            // 
            this.odunc_id.Location = new System.Drawing.Point(200, 81);
            this.odunc_id.Name = "odunc_id";
            this.odunc_id.Size = new System.Drawing.Size(171, 23);
            this.odunc_id.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(34, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ödünç Id           ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGreen;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(34, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Kullanıcı ID       ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkOrange;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(102, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "   KİTAP TESLİM   ";
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.BackColor = System.Drawing.Color.White;
            this.lbl_para.Location = new System.Drawing.Point(297, 204);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(0, 15);
            this.lbl_para.TabIndex = 38;
            // 
            // FrmBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 636);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBookManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBookManagement";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_teslim_tarihi)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox_isbn;
        private Label label1;
        private TextBox txt_g_userid;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private Button ode_teslim;
        private Panel panel5;
        private Label lbl_teslim_gecmis;
        private Panel panel3;
        private Label lbl_odunc_kitap;
        private DataGridViewTextBoxColumn borrowing_id;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn user_name;
        private DataGridViewTextBoxColumn user_surname;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn book_ISBN;
        private DataGridViewTextBoxColumn book_lending_date;
        private DataGridViewTextBoxColumn book_due_date;
        private DataGridViewTextBoxColumn borrowing_state;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Button btn_teslim_et;
        private TextBox txt_isbn;
        private Label label5;
        private TextBox odunc_id;
        private Label label4;
        private Label label13;
        private Label label14;
        private TextBox txt_userid;
        private TextBox txt_gecikmis_id;
        private Label label2;
        private Label label3;
        private RadioButton ode;
        private DataGridView data_teslim_tarihi;
        private DataGridViewTextBoxColumn borrow_id;
        private DataGridViewTextBoxColumn userid;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn usersurname;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn bookISBN;
        private DataGridViewTextBoxColumn lending;
        private DataGridViewTextBoxColumn due;
        private DataGridViewTextBoxColumn borrow_state;
        private DataGridViewTextBoxColumn penalty;
        private Label lbl_para;
    }
}