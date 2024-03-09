namespace Market2017
{
    partial class Kasa_Listesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipTahsilat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KasaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTahsilat = new System.Windows.Forms.Label();
            this.labelOdeme = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.Musteri,
            this.Tutar,
            this.TipTahsilat,
            this.Aciklama,
            this.KasaID,
            this.AdiSoyadi,
            this.Tip});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(422, 258);
            this.dataGridView1.TabIndex = 5;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.Tarih.DefaultCellStyle = dataGridViewCellStyle7;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // Musteri
            // 
            this.Musteri.DataPropertyName = "Musteri";
            this.Musteri.HeaderText = "Musteri";
            this.Musteri.Name = "Musteri";
            this.Musteri.Visible = false;
            // 
            // Tutar
            // 
            this.Tutar.DataPropertyName = "Tutar";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.Tutar.DefaultCellStyle = dataGridViewCellStyle8;
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            // 
            // TipTahsilat
            // 
            this.TipTahsilat.DataPropertyName = "TipTahsilat";
            this.TipTahsilat.HeaderText = "TipTahsilat";
            this.TipTahsilat.Name = "TipTahsilat";
            this.TipTahsilat.Visible = false;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Visible = false;
            // 
            // KasaID
            // 
            this.KasaID.DataPropertyName = "KasaID";
            this.KasaID.HeaderText = "KasaID";
            this.KasaID.Name = "KasaID";
            this.KasaID.Visible = false;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.DataPropertyName = "AdiSoyadi";
            this.AdiSoyadi.HeaderText = "Musteri";
            this.AdiSoyadi.Name = "AdiSoyadi";
            // 
            // Tip
            // 
            this.Tip.DataPropertyName = "Tip";
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(563, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Hepsi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(359, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Seç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Küçük Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Büyük Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // labelTahsilat
            // 
            this.labelTahsilat.AutoSize = true;
            this.labelTahsilat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelTahsilat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTahsilat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTahsilat.Location = new System.Drawing.Point(443, 184);
            this.labelTahsilat.Name = "labelTahsilat";
            this.labelTahsilat.Size = new System.Drawing.Size(91, 18);
            this.labelTahsilat.TabIndex = 15;
            this.labelTahsilat.Text = "TAHSİLAT :";
            // 
            // labelOdeme
            // 
            this.labelOdeme.AutoSize = true;
            this.labelOdeme.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOdeme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdeme.Location = new System.Drawing.Point(443, 216);
            this.labelOdeme.Name = "labelOdeme";
            this.labelOdeme.Size = new System.Drawing.Size(72, 18);
            this.labelOdeme.TabIndex = 16;
            this.labelOdeme.Text = "ÖDEME :";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(459, 276);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Yeni İşlem";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(182, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Yazdır";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Kasa_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(689, 320);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labelOdeme);
            this.Controls.Add(this.labelTahsilat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kasa_Listesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa_Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipTahsilat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn KasaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTahsilat;
        private System.Windows.Forms.Label labelOdeme;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}