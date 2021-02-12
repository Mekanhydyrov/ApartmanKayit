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


namespace DevExpress_İle_Apartman_Kayıt_Uygulaması___1
{
    public partial class VerilerGoster : Form
    {
        public VerilerGoster()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0K1CF3Q\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True");
        
        private void maglumatygorkez()
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From aprtksiblgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            maglumatygorkez();
        }

        private void VerilerGoster_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into aprtksiblgi (Ad,Soyad,Daire,Telefon,Mail,Borclar)values ('" + textEdit1.Text.ToString() + "','" + textEdit2.Text.ToString() + "','" + textEdit3.Text.ToString() + "','" + textEdit4.Text.ToString() + "','" + textEdit5.Text.ToString() + "','" + textEdit6.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            maglumatygorkez();
        }

        int id = 0;

        private void BtnArasala_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From aprtksiblgi where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            maglumatygorkez();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textEdit1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textEdit2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textEdit3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textEdit4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textEdit5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textEdit6.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void BtnTamizle_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            textEdit6.Text = "";
            textEdit1.Focus();
        }

        private void BtnTazele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update aprtksiblgi set Ad='" + textEdit1.Text.ToString() + "',Soyad='" + textEdit2.Text.ToString() + "',Daire='" + textEdit3.Text.ToString() + "',Telefon='" + textEdit4.Text.ToString() + "',Mail='" + textEdit5.Text.ToString() + "',Borclar='" + textEdit6.Text.ToString() + "'Where id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            maglumatygorkez();
        }

        private void BtnGozle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from aprtksiblgi where Ad like '%" + textEdit7.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
    }
}
//Data Source=DESKTOP-0K1CF3Q\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True
