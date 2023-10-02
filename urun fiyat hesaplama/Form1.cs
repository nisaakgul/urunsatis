using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urun_fiyat_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Miktar_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(txtFiyar.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);

            int tutar= fiyat * miktar;

            lblTutar.Text = tutar.ToString();
        }
    }
}
