using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tas_Kagit_Makas
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int oyuncuSkor = 0;
        private int bilgisayarSkor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picTas_Click(object sender, EventArgs e)
        {
            Oyun("taş");
        }

        private void picKagit_Click(object sender, EventArgs e)
        {
            Oyun("kağıt");
        }

        private void picMakas_Click(object sender, EventArgs e)
        {
            Oyun("makas");
        }

        private void Oyun(string oyuncuSecim)
        {
            string[] secimler = { "taş", "kağıt", "makas" };
            string bilgisayarSecim = secimler[random.Next(secimler.Length)];

            if (oyuncuSecim == "taş")
                picOyuncu.Image = picTas.Image;
            else if (oyuncuSecim == "kağıt")
                picOyuncu.Image = picKagit.Image;
            else if (oyuncuSecim == "makas")
                picOyuncu.Image = picMakas.Image;

            if (bilgisayarSecim == "taş")
                picBilgisayar.Image = picTas.Image;
            else if (bilgisayarSecim == "kağıt")
                picBilgisayar.Image = picKagit.Image;
            else if (bilgisayarSecim == "makas")
                picBilgisayar.Image = picMakas.Image;

            if (oyuncuSecim == bilgisayarSecim)
            {
                MessageBox.Show("Beraberlik", "Oyun berabere !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if ((oyuncuSecim == "taş" && bilgisayarSecim == "makas") || (oyuncuSecim == "kağıt" && bilgisayarSecim == "taş")
                || (oyuncuSecim == "makas" && bilgisayarSecim == "kağıt"))
            {
                oyuncuSkor++;
                lblOyuncuSkor.Text = oyuncuSkor.ToString();
            }

            else
            {
                bilgisayarSkor++;
                lblBilgisayarSkor.Text = bilgisayarSkor.ToString();
            }
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            oyuncuSkor = 0;
            bilgisayarSkor = 0;
            lblOyuncuSkor.Text = "0";
            lblBilgisayarSkor.Text = "0";
            picOyuncu.Image = null;
            picBilgisayar.Image = null;
        }
    }
}
