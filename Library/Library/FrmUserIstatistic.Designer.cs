namespace Library
{
    partial class FrmUserIstatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserIstatistic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pixture_back = new System.Windows.Forms.PictureBox();
            this.personel_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixture_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 439);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personel_count,
            this.user_count,
            this.kitap_count,
            this.yazar_count});
            this.dataGridView1.Location = new System.Drawing.Point(28, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(657, 297);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.pixture_back);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(28, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 75);
            this.panel2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gold;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(34, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(581, 34);
            this.label13.TabIndex = 34;
            this.label13.Text = "                     KÜTÜPHANE İSTATİSTİKLERİ                  ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pixture_back
            // 
            this.pixture_back.Image = ((System.Drawing.Image)(resources.GetObject("pixture_back.Image")));
            this.pixture_back.Location = new System.Drawing.Point(621, 0);
            this.pixture_back.Name = "pixture_back";
            this.pixture_back.Size = new System.Drawing.Size(36, 28);
            this.pixture_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pixture_back.TabIndex = 48;
            this.pixture_back.TabStop = false;
            this.pixture_back.Click += new System.EventHandler(this.pixture_back_Click);
            // 
            // personel_count
            // 
            this.personel_count.HeaderText = "Personel Sayısı";
            this.personel_count.Name = "personel_count";
            this.personel_count.Width = 160;
            // 
            // user_count
            // 
            this.user_count.HeaderText = "Kullanıcı Sayısı";
            this.user_count.Name = "user_count";
            this.user_count.Width = 160;
            // 
            // kitap_count
            // 
            this.kitap_count.HeaderText = "Kitap Sayısı";
            this.kitap_count.Name = "kitap_count";
            this.kitap_count.Width = 160;
            // 
            // yazar_count
            // 
            this.yazar_count.HeaderText = "Yazar Sayısı";
            this.yazar_count.Name = "yazar_count";
            this.yazar_count.Width = 150;
            // 
            // FrmUserIstatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 438);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUserIstatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserIstatistic";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixture_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label13;
        private PictureBox pixture_back;
        private DataGridViewTextBoxColumn personel_count;
        private DataGridViewTextBoxColumn user_count;
        private DataGridViewTextBoxColumn kitap_count;
        private DataGridViewTextBoxColumn yazar_count;
    }
}