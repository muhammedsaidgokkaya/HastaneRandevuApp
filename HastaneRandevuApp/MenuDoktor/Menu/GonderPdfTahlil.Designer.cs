namespace HastaneRandevuApp
{
    partial class GonderPdfTahlil
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
            this.PDFYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TahlilTxt = new System.Windows.Forms.TextBox();
            this.Kapat = new System.Windows.Forms.Button();
            this.RandevuList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RandevuList)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFYap
            // 
            this.PDFYap.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PDFYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDFYap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PDFYap.ForeColor = System.Drawing.Color.White;
            this.PDFYap.Location = new System.Drawing.Point(637, 246);
            this.PDFYap.Name = "PDFYap";
            this.PDFYap.Size = new System.Drawing.Size(179, 38);
            this.PDFYap.TabIndex = 260;
            this.PDFYap.Text = "PDF\'e Dönüştür";
            this.PDFYap.UseVisualStyleBackColor = false;
            this.PDFYap.Click += new System.EventHandler(this.PDFYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 259;
            this.label1.Text = "Tahlil :";
            // 
            // TahlilTxt
            // 
            this.TahlilTxt.Location = new System.Drawing.Point(586, 37);
            this.TahlilTxt.Multiline = true;
            this.TahlilTxt.Name = "TahlilTxt";
            this.TahlilTxt.Size = new System.Drawing.Size(274, 203);
            this.TahlilTxt.TabIndex = 258;
            // 
            // Kapat
            // 
            this.Kapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kapat.BackColor = System.Drawing.Color.Brown;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(838, 1);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(42, 30);
            this.Kapat.TabIndex = 257;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // RandevuList
            // 
            this.RandevuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RandevuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandevuList.Location = new System.Drawing.Point(12, 11);
            this.RandevuList.Name = "RandevuList";
            this.RandevuList.RowHeadersWidth = 51;
            this.RandevuList.RowTemplate.Height = 29;
            this.RandevuList.Size = new System.Drawing.Size(506, 339);
            this.RandevuList.TabIndex = 256;
            this.RandevuList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RandevuList_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 40);
            this.label2.TabIndex = 261;
            this.label2.Text = "PDF\'e dönüştürmek istediğiniz \r\nTahlilleri tablodan seçiniz.";
            // 
            // GonderPdfTahlil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PDFYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TahlilTxt);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.RandevuList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GonderPdfTahlil";
            this.Text = "GonderPdfTahlil";
            this.Load += new System.EventHandler(this.GonderPdfTahlil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RandevuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button PDFYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TahlilTxt;
        public System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.DataGridView RandevuList;
        private System.Windows.Forms.Label label2;
    }
}