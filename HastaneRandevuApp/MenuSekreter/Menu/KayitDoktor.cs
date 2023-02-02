using EntityLayer.Tables;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneRandevuApp
{
    public partial class KayitDoktor : Form
    {
        public KayitDoktor()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            var tc = TxtTckn.Text;
            var telefon = TxtTel.Text;
            var adsoyad = TxtName.Text;
            var sifre = TxtPassword.Text;
            var bransid = TxtBransId.Text;

            Doktor doktor = new Doktor();
            doktor.Tckn = tc;
            doktor.Phone = telefon;
            doktor.Name = adsoyad;
            doktor.Password = sifre;
            doktor.BransId = Convert.ToInt32(bransid);

            Context c = new Context();
            c.Doktors.Add(doktor);
            c.SaveChanges();

            TxtTckn.Text = "";
            TxtTel.Text = "";
            TxtName.Text = "";
            TxtPassword.Text = "";
            TxtBransId.Text = "";

            DoktorListesi.DataSource = c.Doktors.ToList();
            DoktorListesi.Columns.Remove("Brans");
            DoktorListesi.Columns.Remove("BransId");
        }

        private void KayitDoktor_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            DoktorListesi.DataSource = c.Doktors.ToList();
            DoktorListesi.Columns.Remove("Brans");
            DoktorListesi.Columns.Remove("BransId");

            TxtId.Visible = false;
            TxtBransId.Visible = false;

            var brans = c.Branss.ToList();
            foreach(var i in brans)
            {
                BransListesi.Items.Add(i.Name);
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            var id = TxtId.Text;
            int idd = Convert.ToInt32(id);
            doktor.Id = idd;

            var tc = TxtTckn.Text;
            var telefon = TxtTel.Text;
            var adsoyad = TxtName.Text;
            var sifre = TxtPassword.Text;
            var bransid = TxtBransId.Text;

            doktor.Tckn = tc;
            doktor.Phone = telefon;
            doktor.Name = adsoyad;
            doktor.Password = sifre;
            doktor.BransId = Convert.ToInt32(bransid);

            Context c = new Context();
            c.Doktors.Update(doktor);
            c.SaveChanges();

            TxtTckn.Text = "";
            TxtTel.Text = "";
            TxtName.Text = "";
            TxtPassword.Text = "";

            DoktorListesi.DataSource = c.Doktors.ToList();
            DoktorListesi.Columns.Remove("Brans");
            DoktorListesi.Columns.Remove("BransId");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            var id = TxtId.Text;
            int idd = Convert.ToInt32(id);
            doktor.Id = idd;

            Context c = new Context();
            c.Doktors.Remove(doktor);
            c.SaveChanges();

            DoktorListesi.DataSource = c.Doktors.ToList();
            DoktorListesi.Columns.Remove("Brans");
            DoktorListesi.Columns.Remove("BransId");
        }

        private void DoktorListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = DoktorListesi.CurrentRow.Cells[0].Value.ToString();
            TxtTckn.Text = DoktorListesi.CurrentRow.Cells[3].Value.ToString();
            TxtTel.Text = DoktorListesi.CurrentRow.Cells[2].Value.ToString();
            TxtName.Text = DoktorListesi.CurrentRow.Cells[1].Value.ToString();
            TxtPassword.Text = DoktorListesi.CurrentRow.Cells[4].Value.ToString();
        }

        private void BransListesi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Context c = new Context();
            var brans = BransListesi.SelectedItem;
            var bransid = c.Branss.Where(x => x.Name == brans).Select(y => y.Id).FirstOrDefault();
            TxtBransId.Text =Convert.ToString(bransid);
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            MenuSekreter menuSekreter = new MenuSekreter();
            menuSekreter.Show();
            this.Hide();
        }
    }
}
