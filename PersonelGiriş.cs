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
    public partial class PersonelGiriş : Form
    {
        public PersonelGiriş()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N3V3VD3;Initial Catalog=EmlakOtomasyonu;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               string sql = "select*from PersonelGiris2 where Kullanici=@KullaniciAdi AND Sifresi=@Sifre";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", textBox1.Text.Trim()); ;
                SqlParameter prm2 = new SqlParameter("Sifre", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, con);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    AnaSayfa form = new AnaSayfa();
                    form.Show();
                    this.Hide();
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış bir giriş yaptınız");
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
            
                if (textBox1.TextLength > 0)
                {
                    textBox1.Text = char.ToUpper(textBox1.Text[0]).ToString() + textBox1.Text.Substring(1);
                    textBox1.SelectionStart = textBox1.TextLength;
                }

            }

        private void AdminGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
