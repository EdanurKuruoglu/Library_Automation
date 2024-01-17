namespace Library
{
    partial class FrmUserBooksShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserBooksShow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_book_search = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.pic_back);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_book_search);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 88);
            this.panel1.TabIndex = 0;
            // 
            // pic_back
            // 
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(813, -2);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(35, 27);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_back.TabIndex = 74;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "ARAMA        ";
            // 
            // txt_book_search
            // 
            this.txt_book_search.Location = new System.Drawing.Point(155, 31);
            this.txt_book_search.Multiline = true;
            this.txt_book_search.Name = "txt_book_search";
            this.txt_book_search.Size = new System.Drawing.Size(677, 25);
            this.txt_book_search.TabIndex = 72;
            this.txt_book_search.TextChanged += new System.EventHandler(this.txt_book_search_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(848, 504);
            this.dataGridView1.TabIndex = 8;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // book_update
            // 
            this.book_update.HeaderText = "Update";
            this.book_update.Name = "book_update";
            // 
            // FrmUserBooksShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUserBooksShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserBooksShow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox txt_book_search;
        private DataGridView dataGridView1;
        private PictureBox pic_back;
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