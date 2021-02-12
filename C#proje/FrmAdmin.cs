using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress_İle_Apartman_Kayıt_Uygulaması___1
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKulAd.Text == "Meko" && TxtSifre.Text == "1234")
            {
                FrmAnaSahypa fr = new FrmAnaSahypa();
                fr.Show();
                this.Hide();
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
