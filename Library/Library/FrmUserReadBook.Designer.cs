namespace Library
{
    partial class FrmUserReadBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserReadBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pixture_back = new System.Windows.Forms.PictureBox();
            this.lbl_okunank = new System.Windows.Forms.Label();
            this.book_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_borrowings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixture_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 606);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_ISBN,
            this.book_name,
            this.author_name,
            this.total_borrowings});
            this.dataGridView1.Location = new System.Drawing.Point(46, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(665, 490);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Controls.Add(this.pixture_back);
            this.panel5.Controls.Add(this.lbl_okunank);
            this.panel5.Location = new System.Drawing.Point(46, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(665, 52);
            this.panel5.TabIndex = 37;
            // 
            // pixture_back
            // 
            this.pixture_back.Image = ((System.Drawing.Image)(resources.GetObject("pixture_back.Image")));
            this.pixture_back.Location = new System.Drawing.Point(629, 0);
            this.pixture_back.Name = "pixture_back";
            this.pixture_back.Size = new System.Drawing.Size(36, 28);
            this.pixture_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pixture_back.TabIndex = 47;
            this.pixture_back.TabStop = false;
            this.pixture_back.Click += new System.EventHandler(this.pixture_back_Click);
            // 
            // lbl_okunank
            // 
            this.lbl_okunank.AutoSize = true;
            this.lbl_okunank.BackColor = System.Drawing.Color.Gold;
            this.lbl_okunank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_okunank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_okunank.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_okunank.Location = new System.Drawing.Point(116, 9);
            this.lbl_okunank.Name = "lbl_okunank";
            this.lbl_okunank.Size = new System.Drawing.Size(419, 34);
            this.lbl_okunank.TabIndex = 33;
            this.lbl_okunank.Text = "          OKUDUĞUM  KİTAPLAR            ";
            this.lbl_okunank.Click += new System.EventHandler(this.lbl_okunank_Click);
            // 
            // book_ISBN
            // 
            this.book_ISBN.HeaderText = "Kitap ISBN";
            this.book_ISBN.Name = "book_ISBN";
            this.book_ISBN.Width = 160;
            // 
            // book_name
            // 
            this.book_name.HeaderText = "Kitap Adı";
            this.book_name.Name = "book_name";
            this.book_name.Width = 160;
            // 
            // author_name
            // 
            this.author_name.HeaderText = "Yazar Adı";
            this.author_name.Name = "author_name";
            this.author_name.Width = 150;
            // 
            // total_borrowings
            // 
            this.total_borrowings.HeaderText = "Ödünç Alma Sayısı";
            this.total_borrowings.Name = "total_borrowings";
            this.total_borrowings.Width = 150;
            // 
            // FrmUserReadBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 573);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUserReadBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserReadBook";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixture_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Label lbl_okunank;
        private PictureBox pixture_back;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn total_borrowings;
        private DataGridViewTextBoxColumn author_name;
        private DataGridViewTextBoxColumn book_ISBN;
    }
}