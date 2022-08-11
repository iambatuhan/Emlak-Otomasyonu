using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace EmlakOtomasyon
{
    public partial class MailAt : Form
    {
        public MailAt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Mail Göndermek İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                MailMessage mesajım = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("emlakotomasyonu@outlook.com", "Emlak123456");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
         
                istemci.EnableSsl = true;
                mesajım.To.Add(textBox1.Text);
                mesajım.From = new MailAddress("emlakotomasyonu@outlook.com");
                mesajım.Subject = textBox2.Text;
                mesajım.Body = textBox3.Text;
                istemci.Send(mesajım);
                MessageBox.Show("Mailiniz gönderilmiştir");
            }
        }
    }
}