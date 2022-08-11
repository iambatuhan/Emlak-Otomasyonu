using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmlakOtomasyon
{
    public partial class KayıtlarıGöster : Form
    {
        public KayıtlarıGöster()
        {
            InitializeComponent();
        }
        BaglanSınıf bgl = new BaglanSınıf();

        public void evlerigoster()
        {
            listView1.Items.Clear();
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand komut = new SqlCommand("select*from EvKayıt", con);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["id"].ToString();
                ekle.SubItems.Add(read["AdiSoyadi"].ToString());
                ekle.SubItems.Add(read["Telefon"].ToString());
                ekle.SubItems.Add(read["Mail"].ToString());
                ekle.SubItems.Add(read["Durumu"].ToString());
                ekle.SubItems.Add(read["Ilce"].ToString());
                ekle.SubItems.Add(read["Mahalle"].ToString());
                ekle.SubItems.Add(read["SokakNo"].ToString());
                ekle.SubItems.Add(read["BinaYas"].ToString());
                ekle.SubItems.Add(read["MetreKare"].ToString());
                ekle.SubItems.Add(read["DogalGaz"].ToString());
                ekle.SubItems.Add(read["OdaSayisi"].ToString());
                ekle.SubItems.Add(read["Ozellik"].ToString());
                ekle.SubItems.Add(read["Fiyat"].ToString());
                ekle.SubItems.Add(read["KayitTarih"].ToString());
                listView1.Items.Add(ekle);

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            evlerigoster();
        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[10].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[11].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[12].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[13].Text;

            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[14].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(bgl.Adres);
                con.Open();
                SqlCommand komut = new SqlCommand("delete from EvKayıt where id=(" + id + ")", con);
                komut.ExecuteNonQuery();
                con.Close();
                evlerigoster();
            }
            
           
               
            }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(bgl.Adres);
                con.Open();
                SqlCommand komut = new SqlCommand("update EvKayıt set AdiSoyadi='" + textBox1.Text + "',Telefon='" + maskedTextBox1.Text + "',Mail='" + textBox2.Text + "',Durumu='" + comboBox1.Text + "',Ilce='" + comboBox2.Text + "',Mahalle='" + textBox3.Text + "',SokakNo='" + textBox4.Text + "',BinaYas='" + textBox5.Text + "',MetreKare='" + textBox6.Text+ "',DogalGaz='" + comboBox3.Text + "',OdaSayisi='"+comboBox4.Text+"',Ozellik='"+textBox7.Text+"',Fiyat='"+textBox8.Text+ "'where id=" + id + "", con);
                komut.ExecuteNonQuery();
                con.Close();
                evlerigoster();
            }
            else
            {
                MessageBox.Show("Güncelleme Yapılamadı");


            }
        }
    }
    }

