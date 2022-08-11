using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class AdminSayfası : Form
    {
        public AdminSayfası()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayıtlarıGöster form = new KayıtlarıGöster();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelSifre frm1 = new PersonelSifre();
            frm1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void AdminSayfası_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatışlarıGörüntüle frm = new SatışlarıGörüntüle();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MailAt frm = new MailAt();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminMesajları frm = new AdminMesajları();
            frm.Show();
        }
    }
}
