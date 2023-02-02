namespace HastaneRandevuApp
{
    partial class MenuDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDoktor));
            this.Cikis = new System.Windows.Forms.Button();
            this.RandevuTahlilMail = new System.Windows.Forms.Button();
            this.RandevuTahlil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RandevuList = new System.Windows.Forms.DataGridView();
            this.TahlilPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RandevuList)).BeginInit();
            this.SuspendLayout();
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cikis.ForeColor = System.Drawing.Color.White;
            this.Cikis.Location = new System.Drawing.Point(-2, 172);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(271, 55);
            this.Cikis.TabIndex = 237;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // RandevuTahlilMail
            // 
            this.RandevuTahlilMail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.RandevuTahlilMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandevuTahlilMail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandevuTahlilMail.ForeColor = System.Drawing.Color.White;
            this.RandevuTahlilMail.Location = new System.Drawing.Point(-2, 113);
            this.RandevuTahlilMail.Name = "RandevuTahlilMail";
            this.RandevuTahlilMail.Size = new System.Drawing.Size(271, 66);
            this.RandevuTahlilMail.TabIndex = 213;
            this.RandevuTahlilMail.Text = "Tahlil Sonuçlarını Gönder";
            this.RandevuTahlilMail.UseVisualStyleBackColor = false;
            this.RandevuTahlilMail.Click += new System.EventHandler(this.RandevuTahlilMail_Click);
            // 
            // RandevuTahlil
            // 
            this.RandevuTahlil.BackColor = System.Drawing.Color.DarkSlateGray;
            this.RandevuTahlil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandevuTahlil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandevuTahlil.ForeColor = System.Drawing.Color.White;
            this.RandevuTahlil.Location = new System.Drawing.Point(-2, -1);
            this.RandevuTahlil.Name = "RandevuTahlil";
            this.RandevuTahlil.Size = new System.Drawing.Size(271, 66);
            this.RandevuTahlil.TabIndex = 212;
            this.RandevuTahlil.Text = "Randevu Tahlili Ekle";
            this.RandevuTahlil.UseVisualStyleBackColor = false;
            this.RandevuTahlil.Click += new System.EventHandler(this.RandevuTahlil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 171);
            this.label1.TabIndex = 238;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // RandevuList
            // 
            this.RandevuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RandevuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandevuList.Location = new System.Drawing.Point(285, 12);
            this.RandevuList.Name = "RandevuList";
            this.RandevuList.RowHeadersWidth = 51;
            this.RandevuList.RowTemplate.Height = 29;
            this.RandevuList.Size = new System.Drawing.Size(408, 385);
            this.RandevuList.TabIndex = 239;
            // 
            // TahlilPdf
            // 
            this.TahlilPdf.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TahlilPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TahlilPdf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TahlilPdf.ForeColor = System.Drawing.Color.White;
            this.TahlilPdf.Location = new System.Drawing.Point(-2, 58);
            this.TahlilPdf.Name = "TahlilPdf";
            this.TahlilPdf.Size = new System.Drawing.Size(271, 61);
            this.TahlilPdf.TabIndex = 240;
            this.TahlilPdf.Text = "Tahlil Sonuçlarını PDF Yap";
            this.TahlilPdf.UseVisualStyleBackColor = false;
            this.TahlilPdf.Click += new System.EventHandler(this.TahlilPdf_Click);
            // 
            // MenuDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 416);
            this.Controls.Add(this.TahlilPdf);
            this.Controls.Add(this.RandevuList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.RandevuTahlilMail);
            this.Controls.Add(this.RandevuTahlil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuDoktor";
            this.Text = "MenuDoktor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuDoktor_FormClosing);
            this.Load += new System.EventHandler(this.MenuDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RandevuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Cikis;
        public System.Windows.Forms.Button RandevuTahlilMail;
        public System.Windows.Forms.Button RandevuTahlil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RandevuList;
        public System.Windows.Forms.Button TahlilPdf;
    }
}