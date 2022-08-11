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
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullanıcıGiris frm = new KullanıcıGiris();
            frm.Show();
       ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiriş frm1 = new AdminGiriş();
            frm1.Show();
      
        }
    }
}
