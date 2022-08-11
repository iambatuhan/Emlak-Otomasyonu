using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace EmlakOtomasyon
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KonutKayıt form = new KonutKayıt();
            form.Show();

        }


        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EvleriGöster form2 = new EvleriGöster();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminGiriş form3 = new AdminGiriş();
            form3.Show();
            
            }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PersonelMesaj frm = new PersonelMesaj();
            frm.Show();
        }
    }
}
