namespace HastaneRandevuApp
{
    partial class MenuSekreter
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
            this.TahlilTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TarihSaat = new System.Windows.Forms.Button();
            this.RandevuKaydet = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.Randevular = new System.Windows.Forms.Button();
            this.SilincekSaat = new System.Windows.Forms.TextBox();
            this.SaatList = new System.Windows.Forms.ListBox();
            this.HastaIdTxt = new System.Windows.Forms.TextBox();
            this.DoktorIdTxt = new System.Windows.Forms.TextBox();
            this.BransIdTxt = new System.Windows.Forms.TextBox();
            this.BransSecimi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BransTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HastaTxt = new System.Windows.Forms.Label();
            this.DoktorTxt = new System.Windows.Forms.Label();
            this.DoktorSecimi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaatTxt = new System.Windows.Forms.Label();
            this.TarihTxt = new System.Windows.Forms.Label();
            this.HastaSecimi = new System.Windows.Forms.ComboBox();
            this.SekreterEkle = new System.Windows.Forms.Button();
            this.HastaEkle = new System.Windows.Forms.Button();
            this.DoktorEkle = new System.Windows.Forms.Button();
            this.Tarih = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // TahlilTxt
            // 
            this.TahlilTxt.Location = new System.Drawing.Point(490, 409);
            this.TahlilTxt.Name = "TahlilTxt";
            this.TahlilTxt.Size = new System.Drawing.Size(71, 27);
            this.TahlilTxt.TabIndex = 244;
            this.TahlilTxt.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(598, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 171);
            this.label9.TabIndex = 243;
            this.label9.Text = "Randevu eklemek \r\niçin öncelikle branş \r\nseçiniz. Sonrasında \r\ndoktor, hasta, tar" +
    "ih \r\nve gün seçiminizi \r\nyaparak kaydediniz.\r\nLütfen boş alan \r\nbırakmayınız.\r\n\r" +
    "\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 95);
            this.label1.TabIndex = 242;
            this.label1.Text = "Randevu eklemek için öncelikle\r\nbranş seçiniz. Sonrasında doktor, \r\nhasta, tarih " +
    "ve gün seçiminizi yaparak\r\nkaydediniz.\r\n\r\n";
            // 
            // TarihSaat
            // 
            this.TarihSaat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TarihSaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TarihSaat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TarihSaat.ForeColor = System.Drawing.Color.White;
            this.TarihSaat.Location = new System.Drawing.Point(-1, 174);
            this.TarihSaat.Name = "TarihSaat";
            this.TarihSaat.Size = new System.Drawing.Size(271, 61);
            this.TarihSaat.TabIndex = 241;
            this.TarihSaat.Text = "Tarih Ve Saat Ekle";
            this.TarihSaat.UseVisualStyleBackColor = false;
            this.TarihSaat.Click += new System.EventHandler(this.TarihSaat_Click);
            // 
            // RandevuKaydet
            // 
            this.RandevuKaydet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.RandevuKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandevuKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandevuKaydet.ForeColor = System.Drawing.Color.White;
            this.RandevuKaydet.Location = new System.Drawing.Point(354, 442);
            this.RandevuKaydet.Name = "RandevuKaydet";
            this.RandevuKaydet.Size = new System.Drawing.Size(178, 50);
            this.RandevuKaydet.TabIndex = 239;
            this.RandevuKaydet.Text = "Randevu Kaydet";
            this.RandevuKaydet.UseVisualStyleBackColor = false;
            this.RandevuKaydet.Click += new System.EventHandler(this.RandevuKaydet_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cikis.ForeColor = System.Drawing.Color.White;
            this.Cikis.Location = new System.Drawing.Point(-1, 294);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(271, 61);
            this.Cikis.TabIndex = 238;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Randevular
            // 
            this.Randevular.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Randevular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Randevular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Randevular.ForeColor = System.Drawing.Color.White;
            this.Randevular.Location = new System.Drawing.Point(-1, 231);
            this.Randevular.Name = "Randevular";
            this.Randevular.Size = new System.Drawing.Size(271, 66);
            this.Randevular.TabIndex = 237;
            this.Randevular.Text = "Randevular";
            this.Randevular.UseVisualStyleBackColor = false;
            this.Randevular.Click += new System.EventHandler(this.Randevular_Click);
            // 
            // SilincekSaat
            // 
            this.SilincekSaat.Location = new System.Drawing.Point(490, 378);
            this.SilincekSaat.Name = "SilincekSaat";
            this.SilincekSaat.Size = new System.Drawing.Size(71, 27);
            this.SilincekSaat.TabIndex = 236;
            // 
            // SaatList
            // 
            this.SaatList.FormattingEnabled = true;
            this.SaatList.ItemHeight = 20;
            this.SaatList.Location = new System.Drawing.Point(783, 281);
            this.SaatList.Name = "SaatList";
            this.SaatList.Size = new System.Drawing.Size(52, 184);
            this.SaatList.TabIndex = 235;
            this.SaatList.SelectedValueChanged += new System.EventHandler(this.SaatList_SelectedValueChanged);
            // 
            // HastaIdTxt
            // 
            this.HastaIdTxt.Location = new System.Drawing.Point(490, 281);
            this.HastaIdTxt.Name = "HastaIdTxt";
            this.HastaIdTxt.Size = new System.Drawing.Size(71, 27);
            this.HastaIdTxt.TabIndex = 234;
            // 
            // DoktorIdTxt
            // 
            this.DoktorIdTxt.Location = new System.Drawing.Point(490, 241);
            this.DoktorIdTxt.Name = "DoktorIdTxt";
            this.DoktorIdTxt.Size = new System.Drawing.Size(71, 27);
            this.DoktorIdTxt.TabIndex = 233;
            // 
            // BransIdTxt
            // 
            this.BransIdTxt.Location = new System.Drawing.Point(490, 199);
            this.BransIdTxt.Name = "BransIdTxt";
            this.BransIdTxt.Size = new System.Drawing.Size(71, 27);
            this.BransIdTxt.TabIndex = 232;
            // 
            // BransSecimi
            // 
            this.BransSecimi.FormattingEnabled = true;
            this.BransSecimi.Location = new System.Drawing.Point(428, 48);
            this.BransSecimi.Name = "BransSecimi";
            this.BransSecimi.Size = new System.Drawing.Size(133, 28);
            this.BransSecimi.TabIndex = 231;
            this.BransSecimi.SelectionChangeCommitted += new System.EventHandler(this.BransSecimi_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 230;
            this.label11.Text = "Branş :";
            // 
            // BransTxt
            // 
            this.BransTxt.AutoSize = true;
            this.BransTxt.Location = new System.Drawing.Point(409, 206);
            this.BransTxt.Name = "BransTxt";
            this.BransTxt.Size = new System.Drawing.Size(0, 20);
            this.BransTxt.TabIndex = 229;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 228;
            this.label7.Text = "Hasta :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 227;
            this.label8.Text = "Doktor :";
            // 
            // HastaTxt
            // 
            this.HastaTxt.AutoSize = true;
            this.HastaTxt.Location = new System.Drawing.Point(409, 292);
            this.HastaTxt.Name = "HastaTxt";
            this.HastaTxt.Size = new System.Drawing.Size(0, 20);
            this.HastaTxt.TabIndex = 226;
            // 
            // DoktorTxt
            // 
            this.DoktorTxt.AutoSize = true;
            this.DoktorTxt.Location = new System.Drawing.Point(409, 248);
            this.DoktorTxt.Name = "DoktorTxt";
            this.DoktorTxt.Size = new System.Drawing.Size(0, 20);
            this.DoktorTxt.TabIndex = 225;
            // 
            // DoktorSecimi
            // 
            this.DoktorSecimi.FormattingEnabled = true;
            this.DoktorSecimi.Location = new System.Drawing.Point(428, 94);
            this.DoktorSecimi.Name = "DoktorSecimi";
            this.DoktorSecimi.Size = new System.Drawing.Size(133, 28);
            this.DoktorSecimi.TabIndex = 224;
            this.DoktorSecimi.SelectionChangeCommitted += new System.EventHandler(this.DoktorSecimi_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 223;
            this.label6.Text = "Hasta Seçiniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 222;
            this.label4.Text = "Doktor Seçiniz :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 221;
            this.label5.Text = "Branş Seçiniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 220;
            this.label3.Text = "Saat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 219;
            this.label2.Text = "Tarih :";
            // 
            // SaatTxt
            // 
            this.SaatTxt.AutoSize = true;
            this.SaatTxt.Location = new System.Drawing.Point(409, 381);
            this.SaatTxt.Name = "SaatTxt";
            this.SaatTxt.Size = new System.Drawing.Size(0, 20);
            this.SaatTxt.TabIndex = 218;
            // 
            // TarihTxt
            // 
            this.TarihTxt.AutoSize = true;
            this.TarihTxt.Location = new System.Drawing.Point(409, 335);
            this.TarihTxt.Name = "TarihTxt";
            this.TarihTxt.Size = new System.Drawing.Size(0, 20);
            this.TarihTxt.TabIndex = 217;
            // 
            // HastaSecimi
            // 
            this.HastaSecimi.FormattingEnabled = true;
            this.HastaSecimi.Location = new System.Drawing.Point(428, 139);
            this.HastaSecimi.Name = "HastaSecimi";
            this.HastaSecimi.Size = new System.Drawing.Size(133, 28);
            this.HastaSecimi.TabIndex = 216;
            this.HastaSecimi.SelectionChangeCommitted += new System.EventHandler(this.HastaSecimi_SelectionChangeCommitted);
            this.HastaSecimi.SelectedValueChanged += new System.EventHandler(this.HastaSecimi_SelectedValueChanged);
            // 
            // SekreterEkle
            // 
            this.SekreterEkle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SekreterEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SekreterEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SekreterEkle.ForeColor = System.Drawing.Color.White;
            this.SekreterEkle.Location = new System.Drawing.Point(-1, 116);
            this.SekreterEkle.Name = "SekreterEkle";
            this.SekreterEkle.Size = new System.Drawing.Size(271, 66);
            this.SekreterEkle.TabIndex = 215;
            this.SekreterEkle.Text = "Sekreter Ekle";
            this.SekreterEkle.UseVisualStyleBackColor = false;
            this.SekreterEkle.Click += new System.EventHandler(this.SekreterEkle_Click);
            // 
            // HastaEkle
            // 
            this.HastaEkle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.HastaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HastaEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HastaEkle.ForeColor = System.Drawing.Color.White;
            this.HastaEkle.Location = new System.Drawing.Point(-1, 58);
            this.HastaEkle.Name = "HastaEkle";
            this.HastaEkle.Size = new System.Drawing.Size(271, 66);
            this.HastaEkle.TabIndex = 214;
            this.HastaEkle.Text = "Hasta Ekle";
            this.HastaEkle.UseVisualStyleBackColor = false;
            this.HastaEkle.Click += new System.EventHandler(this.HastaEkle_Click);
            // 
            // DoktorEkle
            // 
            this.DoktorEkle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DoktorEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoktorEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoktorEkle.ForeColor = System.Drawing.Color.White;
            this.DoktorEkle.Location = new System.Drawing.Point(-1, -1);
            this.DoktorEkle.Name = "DoktorEkle";
            this.DoktorEkle.Size = new System.Drawing.Size(271, 66);
            this.DoktorEkle.TabIndex = 213;
            this.DoktorEkle.Text = "Doktor Ekle";
            this.DoktorEkle.UseVisualStyleBackColor = false;
            this.DoktorEkle.Click += new System.EventHandler(this.DoktorEkle_Click);
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(573, 36);
            this.Tarih.Name = "Tarih";
            this.Tarih.TabIndex = 212;
            this.Tarih.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Tarih_DateSelected);
            // 
            // MenuSekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 521);
            this.Controls.Add(this.TahlilTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TarihSaat);
            this.Controls.Add(this.RandevuKaydet);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.Randevular);
            this.Controls.Add(this.SilincekSaat);
            this.Controls.Add(this.SaatList);
            this.Controls.Add(this.HastaIdTxt);
            this.Controls.Add(this.DoktorIdTxt);
            this.Controls.Add(this.BransIdTxt);
            this.Controls.Add(this.BransSecimi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BransTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HastaTxt);
            this.Controls.Add(this.DoktorTxt);
            this.Controls.Add(this.DoktorSecimi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaatTxt);
            this.Controls.Add(this.TarihTxt);
            this.Controls.Add(this.HastaSecimi);
            this.Controls.Add(this.SekreterEkle);
            this.Controls.Add(this.HastaEkle);
            this.Controls.Add(this.DoktorEkle);
            this.Controls.Add(this.Tarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSekreter";
            this.Text = "MenuSekreter";
            this.Load += new System.EventHandler(this.MenuSekreter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TahlilTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button TarihSaat;
        public System.Windows.Forms.Button RandevuKaydet;
        public System.Windows.Forms.Button Cikis;
        public System.Windows.Forms.Button Randevular;
        private System.Windows.Forms.TextBox SilincekSaat;
        private System.Windows.Forms.ListBox SaatList;
        private System.Windows.Forms.TextBox HastaIdTxt;
        private System.Windows.Forms.TextBox DoktorIdTxt;
        private System.Windows.Forms.TextBox BransIdTxt;
        private System.Windows.Forms.ComboBox BransSecimi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label BransTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label HastaTxt;
        private System.Windows.Forms.Label DoktorTxt;
        private System.Windows.Forms.ComboBox DoktorSecimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SaatTxt;
        private System.Windows.Forms.Label TarihTxt;
        private System.Windows.Forms.ComboBox HastaSecimi;
        public System.Windows.Forms.Button SekreterEkle;
        public System.Windows.Forms.Button HastaEkle;
        public System.Windows.Forms.Button DoktorEkle;
        private System.Windows.Forms.MonthCalendar Tarih;
    }
}