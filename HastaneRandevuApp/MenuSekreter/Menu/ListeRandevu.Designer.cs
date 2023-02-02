namespace HastaneRandevuApp
{
    partial class ListeRandevu
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
            ((System.ComponentModel.ISupportInitialize)(this.RandevuList)).BeginInit();
            this.SuspendLayout();
            // 
            // RandevuList
            // 
            this.RandevuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RandevuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandevuList.Location = new System.Drawing.Point(34, 37);
            this.RandevuList.Name = "RandevuList";
            this.RandevuList.RowHeadersWidth = 51;
            this.RandevuList.RowTemplate.Height = 29;
            this.RandevuList.Size = new System.Drawing.Size(524, 342);
            this.RandevuList.TabIndex = 0;
            // 
            // Kapat
            // 
            this.Kapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kapat.BackColor = System.Drawing.Color.Brown;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(548, 1);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(42, 30);
            this.Kapat.TabIndex = 16;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // ListeRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 406);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.RandevuList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListeRandevu";
            this.Text = "ListeRandevu";
            this.Load += new System.EventHandler(this.ListeRandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RandevuList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RandevuList;
        public System.Windows.Forms.Button Kapat;
    }
}