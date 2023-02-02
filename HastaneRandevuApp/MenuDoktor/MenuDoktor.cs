using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuApp
{
    public partial class MenuDoktor : Form
    {
        public MenuDoktor()
        {
            InitializeComponent();
        }

        private void MenuDoktor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuDoktor_Load(object sender, EventArgs e)
        {
            //datagridview randevular Listelenmiştir ve görünmesini
            //istemediğimiz kolonlar remove edilmiştir.
            Context c = new Context();
            RandevuList.DataSource = c.Randevus.ToList();
            RandevuList.Columns.Remove("Id");
            RandevuList.Columns.Remove("Tahlil");
            RandevuList.Columns.Remove("Secim");
            RandevuList.Columns.Remove("Saat");
            RandevuList.Columns.Remove("HastaId");
            RandevuList.Columns.Remove("Hasta");
            RandevuList.Columns.Remove("DoktorId");
            RandevuList.Columns.Remove("Doktor");
            RandevuList.Columns.Remove("BransId");
            RandevuList.Columns.Remove("Brans");
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void RandevuTahlilMail_Click(object sender, EventArgs e)
        {
            GonderTahlil gonderTahlil = new GonderTahlil();
            gonderTahlil.Show();
            this.Hide();
        }

        private void RandevuTahlil_Click(object sender, EventArgs e)
        {
            EkleTahlil ekleTahlil = new EkleTahlil();
            ekleTahlil.Show();
            this.Hide();
        }

        private void TahlilPdf_Click(object sender, EventArgs e)
        {
            GonderPdfTahlil gonderPdfTahlil = new GonderPdfTahlil();
            gonderPdfTahlil.Show();
            this.Hide();
        }
    }
}
