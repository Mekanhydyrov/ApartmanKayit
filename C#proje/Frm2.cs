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
    public partial class FrmKwartireler : Form
    {
        public FrmKwartireler()
        {
            InitializeComponent();
        }

        private void renk()
        {
            BtnKwrtira1.BackColor = Color.Gray;
            BtnKwrtira2.BackColor = Color.Gray;
            BtnKwrtira3.BackColor = Color.Gray;
            BtnKwrtira4.BackColor = Color.Gray;
            BtnKwrtira5.BackColor = Color.Gray;
            BtnKwrtira6.BackColor = Color.Gray;
            BtnKwrtira7.BackColor = Color.Gray;
            BtnKwrtira8.BackColor = Color.Gray;

        }

        private void BtnKwrtira1_Click(object sender, EventArgs e)
        {
            renk();
            BtnKwrtira1.BackColor = Color.Red;
            LblAdFami.Text = "Guwanch Yazgulyyew";
        }

        private void FrmKwartireler_Load(object sender, EventArgs e)
        {
            renk();
        }

        private void BtnKwrtira2_Click(object sender, EventArgs e)
        {
            renk();
            BtnKwrtira2.BackColor = Color.Red;
            LblAdFami.Text = "Selim Geldiyyew";
        }

        private void BtnKwrtira3_Click(object sender, EventArgs e)
        {
            renk();
            BtnKwrtira3.BackColor = Color.Red;
            LblAdFami.Text = "Aylar Jumayew";
        }

        private void BtnKwrtira4_Click(object sender, EventArgs e)
        {
            renk();
            BtnKwrtira4.BackColor = Color.Red;
            LblAdFami.Text = "Serhat Yazlyyew";
        }

        private void BtnKwrtira5_Click(object sender, EventArgs e)
        {
            renk();
            BtnKwrtira5.BackColor = Color.Red;
            LblAdFami.Text = "Toyly Yazgulyyew";
        }

        private void BtnKwrtira6_Click(object sender, EventArgs e)
        {
            renk();
            BtnKwrtira6.BackColor = Color.Red;
            LblAdFami.Text = "Guwanch Saparow";
        }

        private void BtnKwrtira7_Click(object sender, EventArgs e)
        {
            renk();
            BtnKwrtira7.BackColor = Color.Red;
            LblAdFami.Text = "Lale Yazlyyew";
        }

        private void BtnKwrtira8_Click(object sender, EventArgs e)
        {
            renk();
            BtnKwrtira8.BackColor = Color.Red;
            LblAdFami.Text = "Çynar Döwranow";
        }
    }
}
