namespace HastaneRandevuApp
{
    partial class EkleTahlil
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
            this.RandevuList = new System.Windows.Forms.DataGridView();
            this.Kapat = new System.Windows.Forms.Button();
            this.TahlilTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Kaydet = new System.Windows.Forms.Button();
            this.RndIdTxt = new System.Windows.Forms.TextBox();
            this.HastaIdTxt = new System.Windows.Forms.TextBox();
            this.DoktorIdTxt = new System.Windows.Forms.TextBox();
            this.BransIdTxt = new System.Windows.Forms.TextBox();
            this.BransTxt = new System.Windows.Forms.TextBox();
            this.DoktorTxt = new System.Windows.Forms.TextBox();
            this.GunTxt = new System.Windows.Forms.TextBox();
            this.HastaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RandevuList)).BeginInit();
            this.SuspendLayout();
            // 
            // RandevuList
            // 
            this.RandevuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RandevuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandevuList.Location = new System.Drawing.Point(12, 12);
            this.RandevuList.Name = "RandevuList";
            this.RandevuList.RowHeadersWidth = 51;
            this.RandevuList.RowTemplate.Height = 29;
            this.RandevuList.Size = new System.Drawing.Size(654, 348);
            this.RandevuList.TabIndex = 240;
            this.RandevuList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RandevuList_CellClick);
            // 
            // Kapat
            // 
            this.Kapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kapat.BackColor = System.Drawing.Color.Brown;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(980, 2);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(42, 30);
            this.Kapat.TabIndex = 241;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // TahlilTxt
            // 
            this.TahlilTxt.Location = new System.Drawing.Point(728, 59);
            this.TahlilTxt.Multiline = true;
            this.TahlilTxt.Name = "TahlilTxt";
            this.TahlilTxt.Size = new System.Drawing.Size(274, 203);
            this.TahlilTxt.TabIndex = 242;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 243;
            this.label1.Text = "Tahlil :";
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kaydet.ForeColor = System.Drawing.Color.White;
            this.Kaydet.Location = new System.Drawing.Point(804, 268);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(129, 38);
            this.Kaydet.TabIndex = 244;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // RndIdTxt
            // 
            this.RndIdTxt.Location = new System.Drawing.Point(532, 21);
            this.RndIdTxt.Name = "RndIdTxt";
            this.RndIdTxt.Size = new System.Drawing.Size(125, 27);
            this.RndIdTxt.TabIndex = 245;
            // 
            // HastaIdTxt
            // 
            this.HastaIdTxt.Location = new System.Drawing.Point(532, 120);
            this.HastaIdTxt.Name = "HastaIdTxt";
            this.HastaIdTxt.Size = new System.Drawing.Size(125, 27);
            this.HastaIdTxt.TabIndex = 246;
            // 
            // DoktorIdTxt
            // 
            this.DoktorIdTxt.Location = new System.Drawing.Point(532, 87);
            this.DoktorIdTxt.Name = "DoktorIdTxt";
            this.DoktorIdTxt.Size = new System.Drawing.Size(125, 27);
            this.DoktorIdTxt.TabIndex = 248;
            // 
            // BransIdTxt
            // 
            this.BransIdTxt.Location = new System.Drawing.Point(532, 54);
            this.BransIdTxt.Name = "BransIdTxt";
            this.BransIdTxt.Size = new System.Drawing.Size(125, 27);
            this.BransIdTxt.TabIndex = 249;
            // 
            // BransTxt
            // 
            this.BransTxt.Location = new System.Drawing.Point(532, 190);
            this.BransTxt.Name = "BransTxt";
            this.BransTxt.Size = new System.Drawing.Size(125, 27);
            this.BransTxt.TabIndex = 252;
            // 
            // DoktorTxt
            // 
            this.DoktorTxt.Location = new System.Drawing.Point(532, 223);
            this.DoktorTxt.Name = "DoktorTxt";
            this.DoktorTxt.Size = new System.Drawing.Size(125, 27);
            this.DoktorTxt.TabIndex = 251;
            // 
            // GunTxt
            // 
            this.GunTxt.Location = new System.Drawing.Point(532, 154);
            this.GunTxt.Name = "GunTxt";
            this.GunTxt.Size = new System.Drawing.Size(125, 27);
            this.GunTxt.TabIndex = 250;
            // 
            // HastaTxt
            // 
            this.HastaTxt.Location = new System.Drawing.Point(532, 256);
            this.HastaTxt.Name = "HastaTxt";
            this.HastaTxt.Size = new System.Drawing.Size(125, 27);
            this.HastaTxt.TabIndex = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 40);
            this.label2.TabIndex = 256;
            this.label2.Text = "Tahlil sonucu eklemek istediğiniz \r\nrandevuyu seçiniz.";
            // 
            // EkleTahlil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HastaTxt);
            this.Controls.Add(this.BransTxt);
            this.Controls.Add(this.DoktorTxt);
            this.Controls.Add(this.GunTxt);
            this.Controls.Add(this.BransIdTxt);
            this.Controls.Add(this.DoktorIdTxt);
            this.Controls.Add(this.HastaIdTxt);
            this.Controls.Add(this.RndIdTxt);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TahlilTxt);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.RandevuList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EkleTahlil";
            this.Text = "EkleTahlil";
            this.Load += new System.EventHandler(this.EkleTahlil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RandevuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RandevuList;
        public System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.TextBox TahlilTxt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.TextBox RndIdTxt;
        private System.Windows.Forms.TextBox HastaIdTxt;
        private System.Windows.Forms.TextBox DoktorIdTxt;
        private System.Windows.Forms.TextBox BransIdTxt;
        private System.Windows.Forms.TextBox BransTxt;
        private System.Windows.Forms.TextBox DoktorTxt;
        private System.Windows.Forms.TextBox GunTxt;
        private System.Windows.Forms.TextBox HastaTxt;
        private System.Windows.Forms.Label label2;
    }
}