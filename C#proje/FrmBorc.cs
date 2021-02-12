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
    public partial class FrmBorc : Form
    {
        public FrmBorc()
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
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());
                

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
         }

        private void FrmBorc_Load(object sender, EventArgs e)
        {
            maglumatygorkez();
        }
    }
}
