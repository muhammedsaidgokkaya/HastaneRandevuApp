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
    public partial class KayitSekreter : Form
    {
        public KayitSekreter()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            var tc = TxtTckn.Text;
            var telefon = TxtTel.Text;
            var adsoyad = TxtName.Text;
            var sifre = TxtPassword.Text;

            Sekreter sekreter = new Sekreter();
            sekreter.Tckn = tc;
            sekreter.Phone = telefon;
            sekreter.Name = adsoyad;
            sekreter.Password = sifre;

            Context c = new Context();
            c.Sekreters.Add(sekreter);
            c.SaveChanges();

            TxtTckn.Text = "";
            TxtTel.Text = "";
            TxtName.Text = "";
            TxtPassword.Text = "";

            SekreterListesi.DataSource = c.Sekreters.ToList();
        }

        private void KayitSekreter_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            SekreterListesi.DataSource = c.Sekreters.ToList();
            TxtId.Visible = false;
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            Sekreter sekreter = new Sekreter();
            var id = TxtId.Text;
            int idd = Convert.ToInt32(id);
            sekreter.Id = idd;

            var tc = TxtTckn.Text;
            var telefon = TxtTel.Text;
            var adsoyad = TxtName.Text;
            var sifre = TxtPassword.Text;

            sekreter.Tckn = tc;
            sekreter.Phone = telefon;
            sekreter.Name = adsoyad;
            sekreter.Password = sifre;

            Context c = new Context();
            c.Sekreters.Update(sekreter);
            c.SaveChanges();

            TxtTckn.Text = "";
            TxtTel.Text = "";
            TxtName.Text = "";
            TxtPassword.Text = "";

            SekreterListesi.DataSource = c.Sekreters.ToList();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            Sekreter sekreter = new Sekreter();
            var id = TxtId.Text;
            int idd = Convert.ToInt32(id);
            sekreter.Id = idd;

            Context c = new Context();
            c.Sekreters.Remove(sekreter);
            c.SaveChanges();

            SekreterListesi.DataSource = c.Sekreters.ToList();
        }

        private void SekreterListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = SekreterListesi.CurrentRow.Cells[0].Value.ToString();
            TxtTckn.Text = SekreterListesi.CurrentRow.Cells[3].Value.ToString();
            TxtTel.Text = SekreterListesi.CurrentRow.Cells[2].Value.ToString();
            TxtName.Text = SekreterListesi.CurrentRow.Cells[1].Value.ToString();
            TxtPassword.Text = SekreterListesi.CurrentRow.Cells[4].Value.ToString();
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            MenuSekreter menuSekreter = new MenuSekreter();
            menuSekreter.Show();
            this.Hide();
        }
    }
}
