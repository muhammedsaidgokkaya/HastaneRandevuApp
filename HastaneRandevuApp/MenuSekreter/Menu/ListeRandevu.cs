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
    public partial class ListeRandevu : Form
    {
        public ListeRandevu()
        {
            InitializeComponent();
        }

        private void ListeRandevu_Load(object sender, EventArgs e)
        {
            //Randevular listelenmiştir.
            Context c = new Context();
            RandevuList.DataSource = c.Randevus.ToList();
            RandevuList.Columns.Remove("Id");
            RandevuList.Columns.Remove("Secim");
            RandevuList.Columns.Remove("Saat");
            RandevuList.Columns.Remove("HastaId");
            RandevuList.Columns.Remove("Hasta");
            RandevuList.Columns.Remove("DoktorId");
            RandevuList.Columns.Remove("Doktor");
            RandevuList.Columns.Remove("BransId");
            RandevuList.Columns.Remove("Brans");
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            MenuSekreter menuSekreter = new MenuSekreter();
            menuSekreter.Show();
            this.Hide();
        }
    }
}
