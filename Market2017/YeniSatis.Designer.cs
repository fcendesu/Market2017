namespace Market2017
{
    partial class YeniSatis
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMusteriAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMusteriID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Barkodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.labelTutar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satış Tarihi";
            // 
            // labelMusteriAdi
            // 
            this.labelMusteriAdi.BackColor = System.Drawing.Color.OliveDrab;
            this.labelMusteriAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMusteriAdi.Location = new System.Drawing.Point(132, 29);
            this.labelMusteriAdi.Name = "labelMusteriAdi";
            this.labelMusteriAdi.Size = new System.Drawing.Size(204, 20);
            this.labelMusteriAdi.TabIndex = 2;
            this.labelMusteriAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri";
            // 
            // labelMusteriID
            // 
            this.labelMusteriID.BackColor = System.Drawing.Color.Goldenrod;
            this.labelMusteriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMusteriID.Location = new System.Drawing.Point(305, 3);
            this.labelMusteriID.Name = "labelMusteriID";
            this.labelMusteriID.Size = new System.Drawing.Size(55, 23);
            this.labelMusteriID.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkodu,
            this.Tanimi,
            this.BirimAdi,
            this.Miktar,
            this.BirimFiyat,
            this.Tutar});
            this.dataGridView1.Location = new System.Drawing.Point(11, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(650, 160);
            this.dataGridView1.TabIndex = 15;
            // 
            // Barkodu
            // 
            this.Barkodu.DataPropertyName = "Barkodu";
            this.Barkodu.HeaderText = "Barkodu";
            this.Barkodu.Name = "Barkodu";
            this.Barkodu.Width = 80;
            // 
            // Tanimi
            // 
            this.Tanimi.DataPropertyName = "Tanimi";
            this.Tanimi.HeaderText = "Tanımı";
            this.Tanimi.Name = "Tanimi";
            this.Tanimi.Width = 140;
            // 
            // BirimAdi
            // 
            this.BirimAdi.DataPropertyName = "BirimAdi";
            this.BirimAdi.HeaderText = "Birimi";
            this.BirimAdi.Name = "BirimAdi";
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            this.BirimFiyat.HeaderText = "BirimFiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            // 
            // Tutar
            // 
            this.Tutar.DataPropertyName = "Tutar";
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Barkod";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(443, 20);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 69);
            this.textBox3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Açıklama";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelTutar
            // 
            this.labelTutar.BackColor = System.Drawing.Color.OliveDrab;
            this.labelTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTutar.Location = new System.Drawing.Point(537, 290);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(124, 20);
            this.labelTutar.TabIndex = 25;
            this.labelTutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(471, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "TOPLAM";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(601, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 26);
            this.button2.TabIndex = 22;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Yeni Satış";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Market2017.Properties.Resources.Search_16x16;
            this.button1.Location = new System.Drawing.Point(141, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Market2017.Properties.Resources.Search_16x16;
            this.button3.Location = new System.Drawing.Point(333, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 20);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // YeniSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(684, 326);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelMusteriID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMusteriAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "YeniSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniSatis";
            this.Load += new System.EventHandler(this.YeniSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label labelMusteriID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labelMusteriAdi;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox textBox1;
    }
}