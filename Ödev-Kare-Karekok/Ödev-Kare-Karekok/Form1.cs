using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_Kare_Karekok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKare_Click(object sender, EventArgs e)
        {
            int sayı, sonuc = 0;
            sayı = Convert.ToInt32(textBox1.Text);
            sonuc = sayı * sayı;
            MessageBox.Show("Sonuç:" + sonuc);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı = Convert.ToDouble(textBox2.Text);
            double sonuc = Convert.ToDouble(Math.Sqrt(sayı));
            MessageBox.Show("Sonuç:" + sonuc.ToString("0.00"));
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = Convert.ToDouble(txtTaban.Text);
            y = Convert.ToDouble(txtÜs.Text);
            z = Math.Pow(x, y);

            txtSonuç.Text = z.ToString("0.00");
        }
    }
}
