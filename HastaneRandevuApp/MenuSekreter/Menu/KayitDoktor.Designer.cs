namespace HastaneRandevuApp
{
    partial class KayitDoktor
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
            this.Sil = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoktorListesi = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtBransId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BransListesi = new System.Windows.Forms.ComboBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtTckn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Kapat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoktorListesi)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sil
            // 
            this.Sil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sil.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sil.ForeColor = System.Drawing.Color.White;
            this.Sil.Location = new System.Drawing.Point(820, 425);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(124, 38);
            this.Sil.TabIndex = 32;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Guncelle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guncelle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Guncelle.ForeColor = System.Drawing.Color.White;
            this.Guncelle.Location = new System.Drawing.Point(624, 425);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(124, 38);
            this.Guncelle.TabIndex = 27;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DoktorListesi);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(540, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 293);
            this.panel2.TabIndex = 31;
            // 
            // DoktorListesi
            // 
            this.DoktorListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoktorListesi.BackgroundColor = System.Drawing.Color.White;
            this.DoktorListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoktorListesi.Location = new System.Drawing.Point(-1, -1);
            this.DoktorListesi.Name = "DoktorListesi";
            this.DoktorListesi.RowHeadersWidth = 51;
            this.DoktorListesi.RowTemplate.Height = 29;
            this.DoktorListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoktorListesi.Size = new System.Drawing.Size(479, 293);
            this.DoktorListesi.TabIndex = 0;
            this.DoktorListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoktorListesi_CellClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label10);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(540, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(479, 61);
            this.panel4.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(141, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Doktor Listele";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TxtBransId);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.BransListesi);
            this.panel3.Controls.Add(this.TxtId);
            this.panel3.Controls.Add(this.Kaydet);
            this.panel3.Controls.Add(this.TxtTel);
            this.panel3.Controls.Add(this.TxtName);
            this.panel3.Controls.Add(this.TxtPassword);
            this.panel3.Controls.Add(this.TxtTckn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(32, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 293);
            this.panel3.TabIndex = 29;
            // 
            // TxtBransId
            // 
            this.TxtBransId.Location = new System.Drawing.Point(12, 15);
            this.TxtBransId.Name = "TxtBransId";
            this.TxtBransId.Size = new System.Drawing.Size(51, 27);
            this.TxtBransId.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Branş Seçiniz :";
            // 
            // BransListesi
            // 
            this.BransListesi.FormattingEnabled = true;
            this.BransListesi.Location = new System.Drawing.Point(227, 19);
            this.BransListesi.Name = "BransListesi";
            this.BransListesi.Size = new System.Drawing.Size(167, 28);
            this.BransListesi.TabIndex = 15;
            this.BransListesi.SelectionChangeCommitted += new System.EventHandler(this.BransListesi_SelectionChangeCommitted);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(12, 62);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(51, 27);
            this.TxtId.TabIndex = 14;
            // 
            // Kaydet
            // 
            this.Kaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kaydet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kaydet.ForeColor = System.Drawing.Color.White;
            this.Kaydet.Location = new System.Drawing.Point(335, 236);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(124, 38);
            this.Kaydet.TabIndex = 12;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(213, 107);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(193, 27);
            this.TxtTel.TabIndex = 9;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(213, 152);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(193, 27);
            this.TxtName.TabIndex = 10;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(213, 200);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(193, 27);
            this.TxtPassword.TabIndex = 11;
            // 
            // TxtTckn
            // 
            this.TxtTckn.Location = new System.Drawing.Point(213, 62);
            this.TxtTckn.Name = "TxtTckn";
            this.TxtTckn.Size = new System.Drawing.Size(193, 27);
            this.TxtTckn.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(69, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(69, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "TC Kimlik No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(32, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 61);
            this.panel1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(141, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor Kayıt";
            // 
            // Kapat
            // 
            this.Kapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kapat.BackColor = System.Drawing.Color.Brown;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(1012, 1);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(42, 30);
            this.Kapat.TabIndex = 33;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // KayitDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 479);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayitDoktor";
            this.Text = "KayitDoktor";
            this.Load += new System.EventHandler(this.KayitDoktor_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoktorListesi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Sil;
        public System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DoktorListesi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BransListesi;
        private System.Windows.Forms.TextBox TxtId;
        public System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtTckn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBransId;
        public System.Windows.Forms.Button Kapat;
    }
}