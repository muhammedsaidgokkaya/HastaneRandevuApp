using EntityLayer;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneRandevuApp
{
    public partial class GonderPdfTahlil : Form
    {
        Context c = new Context();

        public GonderPdfTahlil()
        {
            InitializeComponent();
        }

        private void GonderPdfTahlil_Load(object sender, EventArgs e)
        {
            //datagridview randevular Listelenmiştir ve görünmesini
            //istemediğimiz kolonlar remove edilmiştir.
            RandevuList.DataSource = c.Randevus.ToList();
            RandevuList.Columns.Remove("Id");
            RandevuList.Columns.Remove("Secim");
            RandevuList.Columns.Remove("Saat");
            RandevuList.Columns.Remove("Hasta");
            RandevuList.Columns.Remove("HastaId");
            RandevuList.Columns.Remove("Doktor");
            RandevuList.Columns.Remove("DoktorId");
            RandevuList.Columns.Remove("Brans");
            RandevuList.Columns.Remove("BransId");
        }

        private void RandevuList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview hangi kolonun texte geleceği belirtilmiştir.
            TahlilTxt.Text = RandevuList.CurrentRow.Cells[0].Value.ToString();
        }

        private void PDFYap_Click(object sender, EventArgs e)
        {
            //pdf
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "PDF DOSYALARI(*.pdf)|*.pdf";
            file.Title = "Pdf Dosyası Oluşturma";
            if (file.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(file.FileName, FileMode.Create);
                Document pdf = new Document();
                PdfWriter.GetInstance(pdf, dosya);
                pdf.Open();
                pdf.AddCreationDate();
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "CP1254", true);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.NORMAL); ;
                Paragraph paragraph = new Paragraph(TahlilTxt.Text, font);
                pdf.Add(paragraph);
                pdf.Close();
            }

            TahlilTxt.Text = "";

            MessageBox.Show("İşlem Başarılı.");
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            MenuDoktor menuDoktor = new MenuDoktor();
            menuDoktor.Show();
            this.Hide();
        }
    }
}
