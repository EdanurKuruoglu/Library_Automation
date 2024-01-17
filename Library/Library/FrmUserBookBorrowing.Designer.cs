namespace Library
{
    partial class FrmUserBookBorrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserBookBorrowing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_teslim_tarihi = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_teslim_gecmis = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pixture_back = new System.Windows.Forms.PictureBox();
            this.lbl_odunc_kitap = new System.Windows.Forms.Label();
            this.pic_back = new System.Windows.Forms.PictureBox();
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
            this.borrow_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_Iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lending_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_teslim_tarihi)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixture_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.data_teslim_tarihi);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-49, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 665);
            this.panel1.TabIndex = 1;
            // 
            // data_teslim_tarihi
            // 
            this.data_teslim_tarihi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_teslim_tarihi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrow_id,
            this.user_Iid,
            this.username,
            this.usersurname,
            this.bookname,
            this.bookISBN,
            this.lending_date,
            this.due_date,
            this.borrow_state,
            this.penalty});
            this.data_teslim_tarihi.Location = new System.Drawing.Point(61, 395);
            this.data_teslim_tarihi.Name = "data_teslim_tarihi";
            this.data_teslim_tarihi.RowTemplate.Height = 25;
            this.data_teslim_tarihi.Size = new System.Drawing.Size(748, 258);
            this.data_teslim_tarihi.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Controls.Add(this.lbl_teslim_gecmis);
            this.panel5.Location = new System.Drawing.Point(61, 328);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(748, 52);
            this.panel5.TabIndex = 36;
            // 
            // lbl_teslim_gecmis
            // 
            this.lbl_teslim_gecmis.AutoSize = true;
            this.lbl_teslim_gecmis.BackColor = System.Drawing.Color.Gold;
            this.lbl_teslim_gecmis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_teslim_gecmis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_teslim_gecmis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_teslim_gecmis.Location = new System.Drawing.Point(150, 9);
            this.lbl_teslim_gecmis.Name = "lbl_teslim_gecmis";
            this.lbl_teslim_gecmis.Size = new System.Drawing.Size(444, 34);
            this.lbl_teslim_gecmis.TabIndex = 33;
            this.lbl_teslim_gecmis.Text = "     TESLİM TARİHİ GEÇMİŞ KİTAPLAR      ";
            this.lbl_teslim_gecmis.Click += new System.EventHandler(this.lbl_teslim_gecmis_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.pixture_back);
            this.panel3.Controls.Add(this.lbl_odunc_kitap);
            this.panel3.Controls.Add(this.pic_back);
            this.panel3.Location = new System.Drawing.Point(61, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 52);
            this.panel3.TabIndex = 36;
            // 
            // pixture_back
            // 
            this.pixture_back.Image = ((System.Drawing.Image)(resources.GetObject("pixture_back.Image")));
            this.pixture_back.Location = new System.Drawing.Point(712, 0);
            this.pixture_back.Name = "pixture_back";
            this.pixture_back.Size = new System.Drawing.Size(36, 28);
            this.pixture_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pixture_back.TabIndex = 93;
            this.pixture_back.TabStop = false;
            this.pixture_back.Click += new System.EventHandler(this.pixture_back_Click);
            // 
            // lbl_odunc_kitap
            // 
            this.lbl_odunc_kitap.AutoSize = true;
            this.lbl_odunc_kitap.BackColor = System.Drawing.Color.Gold;
            this.lbl_odunc_kitap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_odunc_kitap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_odunc_kitap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_odunc_kitap.Location = new System.Drawing.Point(140, 9);
            this.lbl_odunc_kitap.Name = "lbl_odunc_kitap";
            this.lbl_odunc_kitap.Size = new System.Drawing.Size(470, 34);
            this.lbl_odunc_kitap.TabIndex = 33;
            this.lbl_odunc_kitap.Text = "     ÖDÜNÇ VERİLEN KİTAPLARI LİSTELE      ";
            this.lbl_odunc_kitap.Click += new System.EventHandler(this.lbl_odunc_kitap_Click);
            // 
            // pic_back
            // 
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(747, 0);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(36, 28);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_back.TabIndex = 92;
            this.pic_back.TabStop = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(61, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(748, 231);
            this.dataGridView1.TabIndex = 23;
            // 
            // borrowing_id
            // 
            this.borrowing_id.HeaderText = "Id";
            this.borrowing_id.Name = "borrowing_id";
            this.borrowing_id.Width = 46;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "User Id";
            this.user_id.Name = "user_id";
            this.user_id.Width = 64;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "User Name";
            this.user_name.Name = "user_name";
            this.user_name.Width = 85;
            // 
            // user_surname
            // 
            this.user_surname.HeaderText = "User Surname";
            this.user_surname.Name = "user_surname";
            this.user_surname.Width = 85;
            // 
            // book_name
            // 
            this.book_name.HeaderText = "Book Name";
            this.book_name.Name = "book_name";
            this.book_name.Width = 85;
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
            this.book_lending_date.Width = 85;
            // 
            // book_due_date
            // 
            this.book_due_date.HeaderText = "Due Date";
            this.book_due_date.Name = "book_due_date";
            this.book_due_date.Width = 85;
            // 
            // borrowing_state
            // 
            this.borrowing_state.HeaderText = "State";
            this.borrowing_state.Name = "borrowing_state";
            this.borrowing_state.Width = 85;
            // 
            // borrow_id
            // 
            this.borrow_id.HeaderText = "Id";
            this.borrow_id.Name = "borrow_id";
            this.borrow_id.Width = 40;
            // 
            // user_Iid
            // 
            this.user_Iid.HeaderText = "User Id";
            this.user_Iid.Name = "user_Iid";
            this.user_Iid.Width = 40;
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
            // lending_date
            // 
            this.lending_date.HeaderText = "Lending Date";
            this.lending_date.Name = "lending_date";
            this.lending_date.Width = 80;
            // 
            // due_date
            // 
            this.due_date.HeaderText = "Due Date";
            this.due_date.Name = "due_date";
            this.due_date.Width = 80;
            // 
            // borrow_state
            // 
            this.borrow_state.HeaderText = "State";
            this.borrow_state.Name = "borrow_state";
            this.borrow_state.Width = 65;
            // 
            // penalty
            // 
            this.penalty.HeaderText = "Penalty";
            this.penalty.Name = "penalty";
            // 
            // FrmUserBookBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 653);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUserBookBorrowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserBookBorrowing";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_teslim_tarihi)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixture_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView data_teslim_tarihi;
        private Panel panel5;
        private Label lbl_teslim_gecmis;
        private Panel panel3;
        private Label lbl_odunc_kitap;
        private DataGridView dataGridView1;
        private PictureBox pic_back;
        private PictureBox pixture_back;
        private DataGridViewTextBoxColumn borrowing_id;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn user_name;
        private DataGridViewTextBoxColumn user_surname;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn book_ISBN;
        private DataGridViewTextBoxColumn book_lending_date;
        private DataGridViewTextBoxColumn book_due_date;
        private DataGridViewTextBoxColumn borrowing_state;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn borrow_id;
        private DataGridViewTextBoxColumn user_Iid;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn usersurname;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn bookISBN;
        private DataGridViewTextBoxColumn lending_date;
        private DataGridViewTextBoxColumn due_date;
        private DataGridViewTextBoxColumn borrow_state;
        private DataGridViewTextBoxColumn penalty;
    }
}