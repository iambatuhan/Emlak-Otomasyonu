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


    public partial class PersonelSifre : Form
    {
        public PersonelSifre()
        {
            InitializeComponent();
        }
        BaglanSınıf bgl = new BaglanSınıf();
        public void SifreGöster()
        {
            listView1.Items.Clear();
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand komut = new SqlCommand("select*from PersonelGiris2", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["Kullanici"].ToString());

                ekle.SubItems.Add(oku["Sifresi"].ToString());
                listView1.Items.Add(ekle);
           
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cvp == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(bgl.Adres);
                con.Open();
                SqlCommand kmt = new SqlCommand("insert into PersonelGiris2(Kullanici,Sifresi)values('" + textBox1.Text + "','" + textBox2.Text + "')", con);
                kmt.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt işlemi tamalanmıştır:");
            }
            else
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SifreGöster();
        }


        int Id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(bgl.Adres);
                con.Open();
                SqlCommand komut = new SqlCommand("update PersonelGiris2 set Kullanici='" + textBox1.Text + "',Sifresi='" + textBox2.Text + "'where Id=" + Id + "", con);
                komut.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(bgl.Adres);
                con.Open();
                SqlCommand komut = new SqlCommand("delete from PersonelGiris2 where Id=(" + Id + ")", con);
                komut.ExecuteNonQuery();
                con.Close();
                SifreGöster();
            }
        }
    }
}