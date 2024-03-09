namespace Market2017
{
    partial class MusteriListesi
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(70, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(177, 20);
            this.textBox6.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdiSoyadi,
            this.Telefonu,
            this.Adresi,
            this.Bakiye});
            this.dataGridView1.Location = new System.Drawing.Point(13, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(463, 218);
            this.dataGridView1.TabIndex = 23;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.DataPropertyName = "AdiSoyadi";
            this.AdiSoyadi.HeaderText = "AdiSoyadi";
            this.AdiSoyadi.Name = "AdiSoyadi";
            // 
            // Telefonu
            // 
            this.Telefonu.DataPropertyName = "Telefonu";
            this.Telefonu.HeaderText = "Telefonu";
            this.Telefonu.Name = "Telefonu";
            // 
            // Adresi
            // 
            this.Adresi.DataPropertyName = "Adresi";
            this.Adresi.HeaderText = "Adresi";
            this.Adresi.Name = "Adresi";
            // 
            // Bakiye
            // 
            this.Bakiye.DataPropertyName = "Bakiye";
            this.Bakiye.HeaderText = "Bakiye";
            this.Bakiye.Name = "Bakiye";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(401, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Seç";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(401, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Hepsi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "AdiSoyadi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(488, 298);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MusteriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.MusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bakiye;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}