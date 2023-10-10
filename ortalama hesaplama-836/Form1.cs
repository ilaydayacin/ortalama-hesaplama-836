using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_hesaplama_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, performans1, performans2;
            double sonuc;

            sinav1 = Convert.ToDouble(txt1.Text);
            sinav2 = Convert.ToDouble(txt2.Text);
            performans1= Convert.ToDouble(txt3.Text);
            performans2= Convert.ToDouble(txt4.Text);

            sonuc = (sinav1 + sinav2 + performans1 + performans2) / 4;

            if (sonuc < 50)
            {
                lblDurum.Text = "Aldığı belge; " + "sınıfta kaldı";
            }
            else if (sonuc >= 50 && sonuc < 70)
            {
                lblDurum.Text = "Aldığı belge; " + "sınıftan geçti";
            }
            else if (sonuc>=70 && sonuc < 85)
            {
                lblDurum.Text = "Aldığı belge; " + "teşekkür belgesi";
            }
            else if (sonuc>=85 && sonuc <= 100)
            {
                lblDurum.Text = "Aldığı belge; " + "takdir belgesi";
            }
        }
    }
}
