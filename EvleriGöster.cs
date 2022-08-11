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
    public partial class EvleriGöster : Form
    {
        public EvleriGöster()
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
                ekle.SubItems.Add(read["Resim"].ToString());
                
                listView1.Items.Add(ekle);

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            evlerigoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand komut = new SqlCommand("select *from EvKayıt where  Durumu like '%" + comboBox1.Text + "%'", con);
           
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
                ekle.SubItems.Add(read["Resim"].ToString());
                listView1.Items.Add(ekle);

            }
            con.Close();
        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox10.Text = listView1.SelectedItems[0].SubItems[1].Text;

            comboBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox3.Text= listView1.SelectedItems[0].SubItems[10].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[11].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[12].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[13].Text;
           dateTimePicker2.Text= listView1.SelectedItems[0].SubItems[14].Text;
            
            pictureBox1.ImageLocation= listView1.SelectedItems[0].SubItems[15].Text;




        }

        private void EvleriGöster_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(bgl.Adres);
            con.Open();
            SqlCommand komut = new SqlCommand("insert into EvSatis1(PAdiSoyadi,SAdiSoyadi,AdiSoyadi,Telefon,Mail,Durumu,Ilce,Mahalle,SokakNo,BinaYas,MetreKare,DogalGaz,OdaSayisi,Ozellik,Fiyat,SatisTarihi,Komisyon)values('"+textBox9.Text+"','"+textBox10.Text+"','" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + textBox2.Text + "','" + comboBox5.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "','"+textBox11.Text+"')", con);
           
            komut.ExecuteNonQuery();
            con.Close();
            evlerigoster();
            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox6.Clear();
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox7.Clear();
            textBox8.Clear();



            dateTimePicker2.ResetText();

            MessageBox.Show("Kayıt İşlemi Tamamlandı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
