using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKimlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            tb_Seri.Enabled = false;
            tb_TC.Enabled =false;
            tb_Soyadi.Enabled = false;
            tb_Adi.Enabled = false;
            tb_BabaAdi.Enabled = false;
            tb_AnaAdi.Enabled =false;
            tb_DogumYeri.Enabled = false;
            tb_DogumTarihi.Enabled = false;
            tb_MedeniHali.Enabled =false;
            tb_Dini.Enabled = false;
            tb_KanGurubu.Enabled = false;
            tb_Il.Enabled =false;
            tb_Ilce.Enabled =false;
            tb_Mahalle.Enabled =false;
            tb_CiltNo.Enabled =false;
            tb_AileNo.Enabled = false;
            tb_SiraNo.Enabled = false;
            tb_VerildigiYer.Enabled = false;
            tb_nedan.Enabled = false;
            tb_KayitNo.Enabled = false;
            tb_VerildigiTarihi.Enabled = false;
            tb_OncekiSoyadi.Enabled =false;
        }

        private void btn_Mavi_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Pembe_Click(object sender, EventArgs e)
        {

        }

    }
}
