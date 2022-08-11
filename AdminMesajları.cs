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
    public partial class AdminMesajları : Form
    {
        public AdminMesajları()
        {
            InitializeComponent();
        }
        BaglanSınıf bgl = new BaglanSınıf();
        public void MesajlarıGöster()
        {
            listView1.Items.Clear();
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand komut = new SqlCommand("select*from AdminMesaj", con);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["Id"].ToString();
                ekle.SubItems.Add(read["PAdiSoyad"].ToString());
                ekle.SubItems.Add(read["Mesaj"].ToString());
                listView1.Items.Add(ekle);

            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            MesajlarıGöster();
        }
    }
}
