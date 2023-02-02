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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GirisSekreter_Click(object sender, EventArgs e)
        {
            //Sekreter bilgileri var mı yok mu kontrol ederek giriş işlemi yapılır.
            var tc = TxtTcknSekreter.Text;
            var sifre = TxtPasswordSekreter.Text;
            Context c = new Context();
            var giris = c.Sekreters.Where(x => x.Tckn == tc && x.Password == sifre).FirstOrDefault();
            if (giris==null)
            {
                MessageBox.Show("Hatalı Giriş","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (giris!=null)
            {
                MenuSekreter menuSekreter = new MenuSekreter();
                menuSekreter.Show();
                this.Hide();
            }
        }

        private void GirisDoktor_Click(object sender, EventArgs e)
        {
            //Doktor bilgileri var mı yok mu kontrol ederek giriş işlemi yapılır.
            var tc = TxtTcknDoktor.Text;
            var sifre = TxtPasswordDoktor.Text;
            Context c = new Context();
            var giris = c.Doktors.Where(x => x.Tckn == tc && x.Password == sifre).FirstOrDefault();
            if (giris == null)
            {
                MessageBox.Show("Hatalı Giriş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (giris != null)
            {
                MenuDoktor menuDoktor = new MenuDoktor();
                menuDoktor.Show();
                this.Hide();
            }
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
