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
    public partial class SatışlarıGörüntüle : Form
    {
        public SatışlarıGörüntüle()
        {
            InitializeComponent();
        }
        BaglanSınıf bgl = new BaglanSınıf();
        public void SatıslarıGoruntule()
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand komut = new SqlCommand("select*from EvSatis1", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["PAdiSoyadi"].ToString());
                ekle.SubItems.Add(oku["SAdiSoyadi"].ToString());
                ekle.SubItems.Add(oku["AdiSoyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Durumu"].ToString());
                ekle.SubItems.Add(oku["Ilce"].ToString());
                ekle.SubItems.Add(oku["Mahalle"].ToString());
                ekle.SubItems.Add(oku["SokakNo"].ToString());
                ekle.SubItems.Add(oku["BinaYas"].ToString());
                ekle.SubItems.Add(oku["MetreKare"].ToString());
                ekle.SubItems.Add(oku["DogalGaz"].ToString());
                ekle.SubItems.Add(oku["OdaSayisi"].ToString());
                ekle.SubItems.Add(oku["Ozellik"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                ekle.SubItems.Add(oku["SatisTarihi"].ToString());
                ekle.SubItems.Add(oku["Komisyon"].ToString());
                listView1.Items.Add(ekle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void SatışlarıGörüntüle_Load(object sender, EventArgs e)
        {
            SatıslarıGoruntule();
        }
    }
}
