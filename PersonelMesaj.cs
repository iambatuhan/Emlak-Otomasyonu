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
    public partial class PersonelMesaj : Form
    {
        public PersonelMesaj()
        {
            InitializeComponent();
        }
        BaglanSınıf bgl = new BaglanSınıf();



        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand komut = new SqlCommand("insert into AdminMesaj(PAdiSoyad,Mesaj)values('" + textBox1.Text + "','" + richTextBox1.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            richTextBox1.Clear();
            MessageBox.Show("Mesajınız gönderilmiştir");

        }
    }
}
