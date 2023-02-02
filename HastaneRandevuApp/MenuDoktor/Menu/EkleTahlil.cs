using EntityLayer;
using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HastaneRandevuApp
{
    public partial class EkleTahlil : Form
    {
        Context c = new Context();

        public EkleTahlil()
        {
            InitializeComponent();
        }

        private void EkleTahlil_Load(object sender, EventArgs e)
        {
            //datagridview randevular Listelenmiştir ve görünmesini
            //istemediğimiz kolonlar remove edilmiştir.
            RandevuList.DataSource = c.Randevus.ToList();
            RandevuList.Columns.Remove("Secim");
            RandevuList.Columns.Remove("Saat");
            RandevuList.Columns.Remove("Hasta");
            RandevuList.Columns.Remove("Doktor");
            RandevuList.Columns.Remove("Brans");
            
            RndIdTxt.Visible = false;
            BransIdTxt.Visible = false;
            DoktorIdTxt.Visible = false;
            HastaIdTxt.Visible = false;
            BransTxt.Visible = false;
            DoktorTxt.Visible = false;
            HastaTxt.Visible = false;
            GunTxt.Visible = false;
        }

        private void RandevuList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview hangi kolonlar hangi texte geleceği belirtilmiştir.
            RndIdTxt.Text = RandevuList.CurrentRow.Cells[0].Value.ToString();
            TahlilTxt.Text = RandevuList.CurrentRow.Cells[1].Value.ToString();
            GunTxt.Text = RandevuList.CurrentRow.Cells[2].Value.ToString();
            HastaIdTxt.Text = RandevuList.CurrentRow.Cells[3].Value.ToString();
            HastaTxt.Text = RandevuList.CurrentRow.Cells[4].Value.ToString();
            DoktorIdTxt.Text = RandevuList.CurrentRow.Cells[5].Value.ToString();
            DoktorTxt.Text = RandevuList.CurrentRow.Cells[6].Value.ToString();
            BransIdTxt.Text = RandevuList.CurrentRow.Cells[7].Value.ToString();
            BransTxt.Text = RandevuList.CurrentRow.Cells[8].Value.ToString();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            //randevu tablosundan nesne oluşturup
            //rndıdtxte id bilgisi verilmiştir.
            Randevu randevu = new Randevu();
            var id = RndIdTxt.Text;
            int idd = Convert.ToInt32(id);
            randevu.Id = idd;
            //brans tablosundan nesne oluşturup
            //bransıdtxte id bilgisi verilmiştir.
            var idbrans = BransIdTxt.Text;
            int iddbranss = Convert.ToInt32(idbrans);
            randevu.BransId = iddbranss;
            //doktor tablosundan nesne oluşturup
            //doktorıdtxte id bilgisi verilmiştir.
            var iddoktor = DoktorIdTxt.Text;
            int idddoktor = Convert.ToInt32(iddoktor);
            randevu.DoktorId = idddoktor;
            //hasta tablosundan nesne oluşturup
            //hastaıdtxte id bilgisi verilmiştir.
            var idhasta = HastaIdTxt.Text;
            int iddhasta = Convert.ToInt32(idhasta);
            randevu.HastaId = iddhasta;
            //randevu tablosuna göndermek için ilgili
            //textlere bilgiler gelmiştir.
            var tahlil = TahlilTxt.Text;
            randevu.Tahlil = tahlil;
            var brans = BransTxt.Text;
            randevu.BransName = brans;
            var doktor = DoktorTxt.Text;
            randevu.DoktorName = doktor;
            var hasta = HastaTxt.Text;
            randevu.HastaName = hasta;
            var tarih = GunTxt.Text;
            randevu.Gun = tarih;
            //altta kayıt yapılmıştır.
            Context c = new Context();
            c.Randevus.Update(randevu);
            c.SaveChanges();
            //textboxların içi boşaltılmıştır.
            TahlilTxt.Text = "";
            RndIdTxt.Text = "";
            BransIdTxt.Text = "";
            DoktorIdTxt.Text = "";
            HastaIdTxt.Text = "";
            BransTxt.Text = "";
            DoktorTxt.Text = "";
            HastaTxt.Text = "";
            GunTxt.Text = "";
            //datagridview tekrar Listelenmiştir ve görünmesini
            //istemediğimiz kolonlar remove edilmiştir.
            RandevuList.DataSource = c.Randevus.ToList();
            RandevuList.Columns.Remove("Secim");
            RandevuList.Columns.Remove("Saat");
            RandevuList.Columns.Remove("Hasta");
            RandevuList.Columns.Remove("Doktor");
            RandevuList.Columns.Remove("Brans");

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
