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

        private void picTas_Click(object sender, EventArgs e)
        {
            Oyun("tas");
        }

        private void picKagit_Click(object sender, EventArgs e)
        {
            Oyun("kagit");
        }

        private void picMakas_Click(object sender, EventArgs e)
        {
            Oyun("makas");
        }
        private void Oyun(string oyuncuSecim)
        {
            string[] secimler = { "tas", "kagit", "makas" };
            string bilgisayarSecim = secimler[random.Next(secimler.Length)];

            //Oyuncunun seçimi
            if (oyuncuSecim == "tas")
                picOyuncu.Image = picTas.Image;
            else if (oyuncuSecim == "kagit")
                picOyuncu.Image = picKagit.Image;
            else if (oyuncuSecim == "makas")
                picOyuncu.Image = picMakas.Image;

            //Bilgisayar seçimi
            if (bilgisayarSecim == "tas")
                picBilgisayar.Image = picTas.Image;
            else if (bilgisayarSecim == "kagit")
                picBilgisayar.Image = picKagit.Image;
            else if (bilgisayarSecim == "makas")
                picBilgisayar.Image = picMakas.Image;

            if (oyuncuSecim == bilgisayarSecim)
            {
                MessageBox.Show("Berabere !", "Oyun Durumu Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if ((oyuncuSecim == "tas" && bilgisayarSecim == "makas")
                || (oyuncuSecim == "kagit" && bilgisayarSecim == "tas")
                || (oyuncuSecim == "makas" && bilgisayarSecim == "kagit"))
            {
                oyuncuSkor++; lblOyuncuSkor.Text = oyuncuSkor.ToString();
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
