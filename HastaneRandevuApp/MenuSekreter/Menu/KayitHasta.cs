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
    public partial class KayitHasta : Form
    {
        public KayitHasta()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            var tc = TxtTckn.Text;
            var telefon = TxtTel.Text;
            var adsoyad = TxtName.Text;

            Hasta hasta = new Hasta();
            hasta.Tckn = tc;
            hasta.Phone = telefon;
            hasta.Name = adsoyad;

            Context c = new Context();
            c.Hastas.Add(hasta);
            c.SaveChanges();

            TxtTckn.Text = "";
            TxtTel.Text = "";
            TxtName.Text = "";

            HastaListesi.DataSource = c.Hastas.ToList();
            HastaListesi.Columns.Remove("Durum");
        }

        private void KayitHasta_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            HastaListesi.DataSource = c.Hastas.ToList();
            HastaListesi.Columns.Remove("Durum");
            TxtId.Visible = false;
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            var id = TxtId.Text;
            int idd = Convert.ToInt32(id);
            hasta.Id = idd;

            var tc = TxtTckn.Text;
            var telefon = TxtTel.Text;
            var adsoyad = TxtName.Text;

            hasta.Tckn = tc;
            hasta.Phone = telefon;
            hasta.Name = adsoyad;

            Context c = new Context();
            c.Hastas.Update(hasta);
            c.SaveChanges();

            TxtTckn.Text = "";
            TxtTel.Text = "";
            TxtName.Text = "";

            HastaListesi.DataSource = c.Hastas.ToList();
            HastaListesi.Columns.Remove("Durum");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            var id = TxtId.Text;
            int idd = Convert.ToInt32(id);
            hasta.Id = idd;

            Context c = new Context();
            c.Hastas.Remove(hasta);
            c.SaveChanges();

            HastaListesi.DataSource = c.Hastas.ToList();
            HastaListesi.Columns.Remove("Durum");
        }

        private void HastaListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = HastaListesi.CurrentRow.Cells[0].Value.ToString();
            TxtTckn.Text = HastaListesi.CurrentRow.Cells[3].Value.ToString();
            TxtTel.Text = HastaListesi.CurrentRow.Cells[2].Value.ToString();
            TxtName.Text = HastaListesi.CurrentRow.Cells[1].Value.ToString();
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            MenuSekreter menuSekreter = new MenuSekreter();
            menuSekreter.Show();
            this.Hide();
        }
    }
}
