using EntityLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneRandevuApp
{
    public partial class GonderTahlil : Form
    {
        Context c = new Context();

        public GonderTahlil()
        {
            InitializeComponent();
        }

        string DosyaYolu;
        private void Dosya_Click(object sender, EventArgs e)
        {
            //pdf yükleme
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Sonuçlar";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            label1.Text = "Eklendi.";
        }

        private void Gonder_Click(object sender, EventArgs e)
        {
            //mail
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            string kime = MailTxt.Text;
            string konu = KonuTxt.Text;
            string icerik = IcerikTxt.Text;

            sc.Credentials = new NetworkCredential("swggerx@gmail.com", "tltmlfchqcjelvtx");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("swggerx@gmail.com");
            mail.To.Add(kime);
            mail.To.Add(MailTxt.Text);
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            mail.Attachments.Add(new Attachment(DosyaYolu));
            sc.Send(mail);

            MessageBox.Show("Mail Gönderilmiştir.");

            MailTxt.Text = "";
            KonuTxt.Text = "";
            IcerikTxt.Text = "";
            label1.Text = "";
        }

        private void GonderTahlil_Load(object sender, EventArgs e)
        {

        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            MenuDoktor menuDoktor = new MenuDoktor();
            menuDoktor.Show();
            this.Hide();
        }
    }
}
