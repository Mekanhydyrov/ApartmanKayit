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
    public partial class FrmAnaSahypa : Form
    {
        public FrmAnaSahypa()
        {
            InitializeComponent();
        }

        private void BtnKwrtira_Click(object sender, EventArgs e)
        {
            FrmKwartireler kwartire = new FrmKwartireler();
            kwartire.ShowDialog();
            //this.Hide();
        }

        private void FrmAnaSahypa_Load(object sender, EventArgs e)
        {
 
        }

        private void BtnBelligeAl_Click(object sender, EventArgs e)
        {
            VerilerGoster veri = new VerilerGoster();
            veri.ShowDialog();
            //this.Hide();
        }

        private void BtnSurat_Click(object sender, EventArgs e)
        {
            FrmSuratlar su = new FrmSuratlar();
            su.ShowDialog();
            //this.Hide();
        }

        private void BtnMaglumat_Click(object sender, EventArgs e)
        {
            FrmBorc borc = new FrmBorc();
            borc.ShowDialog();
            
        }

        private void BtnHakymyzda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DevExpress Programyny ulanyp Binadaky Ýaşaýan kişleriň belligini alan program Ýanwar-29-2020 !!!");
        }

        private void BtnCykys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
