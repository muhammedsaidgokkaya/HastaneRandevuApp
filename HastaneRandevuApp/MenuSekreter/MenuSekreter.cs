using com.itextpdf.text.pdf;
using EntityLayer;
using EntityLayer.Tables;
using Microsoft.EntityFrameworkCore;
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
    public partial class MenuSekreter : Form
    {
        Context c = new Context();

        public MenuSekreter()
        {
            InitializeComponent();
        }

        private void MenuSekreter_Load(object sender, EventArgs e)
        {
            BransIdTxt.Visible = false;
            DoktorIdTxt.Visible = false;
            HastaIdTxt.Visible = false;
            SilincekSaat.Visible = false;
            TahlilTxt.Visible = false;

            var branslar = c.Branss.ToList();
            var hastalar = c.Hastas.Where(x => x.durum == 0).ToList();

            foreach (var j in branslar)
            {
                BransSecimi.Items.Add(j.Name);
            }

            foreach (var k in hastalar)
            {
                HastaSecimi.Items.Add(k.Name);
            }
        }

        private void BransSecimi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var bransname = BransSecimi.SelectedItem;
            var bransid = c.Branss.Where(x => x.Name == bransname).Select(y => y.Id).FirstOrDefault();
            BransTxt.Text = Convert.ToString(bransname);
            BransIdTxt.Text = Convert.ToString(bransid);

            var doktors = c.Doktors.Where(x => x.BransId == bransid).ToList();
            DoktorSecimi.Items.Clear();
            foreach (var i in doktors)
            {
                DoktorSecimi.Items.Add(i.Name);
            }
        }

        private void DoktorSecimi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var doktorname = DoktorSecimi.SelectedItem;
            var doktorid = c.Doktors.Where(x => x.Name == doktorname).Select(y => y.Id).FirstOrDefault();
            DoktorTxt.Text = Convert.ToString(doktorname);
            DoktorIdTxt.Text = Convert.ToString(doktorid);
        }

        private void HastaSecimi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var hastaname = HastaSecimi.SelectedItem;
            var hastaid = c.Hastas.Where(x => x.Name == hastaname).Select(y => y.Id).FirstOrDefault();
            HastaTxt.Text = Convert.ToString(hastaname);
            HastaIdTxt.Text = Convert.ToString(hastaid);
        }

        private void Tarih_DateSelected(object sender, DateRangeEventArgs e)
        {
            SaatList.Items.Clear();
            var tarih = Tarih.SelectionRange.Start.ToShortDateString();
            TarihTxt.Text = tarih;

            var tarih1 = TarihTxt.Text;
            var tarihh = Convert.ToString(tarih1);

            var g = c.Tarihs.Where(x => x.Name == tarihh).Select(y => y.Id).FirstOrDefault();
            var saat = c.TarihSaats.Where(x => x.TarihId == g).Include(y => y.Saat).Include(z => z.Tarih).ToList();
            foreach (var a in saat)
            {
                SaatList.Items.Add(a.Saat.Name);
            }
        }

        private void HastaSecimi_SelectedValueChanged(object sender, EventArgs e)
        {
            var hastaname = HastaSecimi.SelectedItem.ToString();
            Context c = new Context();
            var id = c.Hastas.Where(x => x.Name == hastaname).Select(y => y.Id).FirstOrDefault();
            var hasta = c.Hastas.Find(id);
            hasta.durum = 0;
        }

        private void SaatList_SelectedValueChanged(object sender, EventArgs e)
        {
            var a = SaatList.SelectedItem.ToString();
            Context c = new Context();
            var id = c.Saats.Where(x => x.Name == a).Select(y => y.Id).FirstOrDefault();
            SilincekSaat.Text = id.ToString();
            SaatTxt.Text = SaatList.Text;
        }

        private void RandevuKaydet_Click(object sender, EventArgs e)
        {
            Randevu d = new Randevu();

            d.BransId = Convert.ToInt32(BransIdTxt.Text);
            d.BransName = BransTxt.Text;
            d.DoktorId = Convert.ToInt32(DoktorIdTxt.Text);
            d.DoktorName = DoktorTxt.Text;
            d.HastaId = Convert.ToInt32(HastaIdTxt.Text);
            d.HastaName = HastaTxt.Text;
            d.Gun = TarihTxt.Text;
            d.Saat = SaatTxt.Text;
            d.Tahlil = TahlilTxt.Text;

            c.Randevus.Add(d);
            c.SaveChanges();

            BransTxt.Text = "";
            DoktorTxt.Text = "";
            HastaTxt.Text = "";
            TarihTxt.Text = "";
            SaatTxt.Text = "";

            MessageBox.Show("Başarıyla Kaydedildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var hastaid = HastaIdTxt.Text;
            int hastaId = Convert.ToInt32(hastaid);
            var hast = c.Hastas.Find(hastaId);
            hast.durum = 1;
            c.SaveChanges();

            var id = SilincekSaat.Text;
            int Id = Convert.ToInt32(id);
            var silincek = c.Saats.Find(Id);
            c.Saats.Remove(silincek);
            c.SaveChanges();
            SaatList.Items.Clear();

            MenuSekreter menuSekreter = new MenuSekreter();
            menuSekreter.Show();
            this.Hide();
        }

        private void DoktorEkle_Click(object sender, EventArgs e)
        {
            KayitDoktor kayitDoktor = new KayitDoktor();
            kayitDoktor.Show();
            this.Hide();
        }

        private void HastaEkle_Click(object sender, EventArgs e)
        {
            KayitHasta kayitHasta = new KayitHasta();
            kayitHasta.Show();
            this.Hide();
        }

        private void SekreterEkle_Click(object sender, EventArgs e)
        {
            KayitSekreter kayitSekreter = new KayitSekreter();
            kayitSekreter.Show();
            this.Hide();
        }

        private void Randevular_Click(object sender, EventArgs e)
        {
            ListeRandevu listeRandevu = new ListeRandevu();
            listeRandevu.Show();
            this.Hide();
        }

        private void TarihSaat_Click(object sender, EventArgs e)
        {
            KayitTarihSaat kayitTarihSaat = new KayitTarihSaat();
            kayitTarihSaat.Show();
            this.Hide();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
