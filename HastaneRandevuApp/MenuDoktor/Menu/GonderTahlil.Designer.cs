namespace HastaneRandevuApp
{
    partial class GonderTahlil
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
            this.MailTxt = new System.Windows.Forms.TextBox();
            this.KonuTxt = new System.Windows.Forms.TextBox();
            this.IcerikTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gonder = new System.Windows.Forms.Button();
            this.Kapat = new System.Windows.Forms.Button();
            this.Dosya = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MailTxt
            // 
            this.MailTxt.Location = new System.Drawing.Point(161, 22);
            this.MailTxt.Name = "MailTxt";
            this.MailTxt.Size = new System.Drawing.Size(125, 27);
            this.MailTxt.TabIndex = 1;
            // 
            // KonuTxt
            // 
            this.KonuTxt.Location = new System.Drawing.Point(161, 69);
            this.KonuTxt.Name = "KonuTxt";
            this.KonuTxt.Size = new System.Drawing.Size(125, 27);
            this.KonuTxt.TabIndex = 2;
            // 
            // IcerikTxt
            // 
            this.IcerikTxt.Location = new System.Drawing.Point(161, 116);
            this.IcerikTxt.Name = "IcerikTxt";
            this.IcerikTxt.Size = new System.Drawing.Size(125, 27);
            this.IcerikTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 40);
            this.label2.TabIndex = 267;
            this.label2.Text = "Mail göndermek için kişi seçimini yapınız.\r\nGönderilecek dosyayı yükleyerek gönde" +
    "riniz.";
            // 
            // Gonder
            // 
            this.Gonder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gonder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Gonder.ForeColor = System.Drawing.Color.White;
            this.Gonder.Location = new System.Drawing.Point(56, 223);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(230, 38);
            this.Gonder.TabIndex = 266;
            this.Gonder.Text = "Mail Gönder";
            this.Gonder.UseVisualStyleBackColor = false;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // Kapat
            // 
            this.Kapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kapat.BackColor = System.Drawing.Color.Brown;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(308, 1);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(42, 30);
            this.Kapat.TabIndex = 263;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // Dosya
            // 
            this.Dosya.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Dosya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dosya.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dosya.ForeColor = System.Drawing.Color.White;
            this.Dosya.Location = new System.Drawing.Point(150, 164);
            this.Dosya.Name = "Dosya";
            this.Dosya.Size = new System.Drawing.Size(136, 38);
            this.Dosya.TabIndex = 268;
            this.Dosya.Text = "Dosya Seçiniz";
            this.Dosya.UseVisualStyleBackColor = false;
            this.Dosya.Click += new System.EventHandler(this.Dosya_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 269;
            this.label3.Text = "E-Posta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 270;
            this.label4.Text = "Konu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 271;
            this.label5.Text = "İçerik :";
            // 
            // GonderTahlil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 327);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dosya);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IcerikTxt);
            this.Controls.Add(this.KonuTxt);
            this.Controls.Add(this.MailTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GonderTahlil";
            this.Text = "GonderTahlil";
            this.Load += new System.EventHandler(this.GonderTahlil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MailTxt;
        private System.Windows.Forms.TextBox KonuTxt;
        private System.Windows.Forms.TextBox IcerikTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Gonder;
        public System.Windows.Forms.Button Kapat;
        public System.Windows.Forms.Button Dosya;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}