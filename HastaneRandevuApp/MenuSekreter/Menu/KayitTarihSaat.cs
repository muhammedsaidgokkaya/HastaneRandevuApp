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

namespace HastaneRandevuApp
{
    public partial class KayitTarihSaat : Form
    {
        Context c = new Context();
        public KayitTarihSaat()
        {
            InitializeComponent();
        }

        private void Tikla(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            SaatTxt.Text = b.Text;
            SaatIdTxt.Text = b.Text;
        }

        private void KayitTarihSaat_Load(object sender, EventArgs e)
        {
            TarihIdTxt.Visible = false;
            SaatIdTxt.Visible = false;
        }

        private void Tarih_DateSelected(object sender, DateRangeEventArgs e)
        {
            var tarih = Tarih.SelectionRange.Start.ToShortDateString();
            TarihTxt.Text = tarih;
            TarihIdTxt.Text = tarih;
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            Tarih T = new Tarih();
            T.Name = TarihTxt.Text;
            Saat S = new Saat();
            S.Name = SaatTxt.Text;

            var tarihtxt = TarihTxt.Text;
            var saattxt = SaatTxt.Text;

            c.Tarihs.Add(T);
            c.Saats.Add(S);
            c.SaveChanges();

            var tarihid = c.Tarihs.Where(x => x.Name == tarihtxt).Select(y => y.Id).FirstOrDefault();
            var saatid = c.Saats.Where(x => x.Name == saattxt).Select(y => y.Id).FirstOrDefault();

            TarihSaat ts = new TarihSaat();
            ts.TarihId = tarihid;
            ts.SaatId = saatid;

            c.TarihSaats.Add(ts);
            c.SaveChanges();
           
            TarihTxt.Text = "";
            SaatTxt.Text = "";

            MessageBox.Show("Başarıyla Kaydedildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            MenuSekreter menuSekreter = new MenuSekreter();
            menuSekreter.Show();
            this.Hide();
        }
    }
}
