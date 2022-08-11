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
    public partial class KonutKayıt : Form
    {
        public KonutKayıt()
        {
            InitializeComponent();
        }
        BaglanSınıf bgl = new BaglanSınıf();


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(bgl.Adres);
                con.Open();
                SqlCommand komut = new SqlCommand("insert into EvKayıt(AdiSoyadi,Telefon,Mail,Durumu,Ilce,Mahalle,SokakNo,BinaYas,MetreKare,DogalGaz,OdaSayisi,Ozellik,Fiyat,KayitTarih,Resim)values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBox9.Text + "')", con);
                komut.ExecuteNonQuery();
                con.Close();
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



                dateTimePicker1.ResetText();

                MessageBox.Show("Kayıt İşlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Kayıt işlemi tamamlanamadı");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox9.Text = openFileDialog1.FileName;

          
        }
    }
}
