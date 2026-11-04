namespace Kapsulleme
{
    public partial class Form1 : Form
    {
       public class Otomobil
        {
            private int yil;
            private string marka;
            private static int arac_sayisi = 124;
            public void setYil(int a)
            {
                if (a < 2000 || a > 2024)
                {
                    MessageBox.Show("Yanlýþ bir deðer girdiniz! ");
                }
                else
                {
                    this.yil = a;
                }
            }

            public int getYil()
            {
                return this.yil;
            }

            public void setMarka(string b)
            {
                if (string.IsNullOrEmpty(b))
                    MessageBox.Show("Marka bilgisi boþ ya da null olamaz.");
                else
                    this.marka = b;
            }

            public string getMarka()
            {
                if (string.IsNullOrEmpty(this.marka))
                    return "MARKASIZ";
                else
                    return this.marka;
            }

            public int getArac_Sayisi()
            {
                return Otomobil.arac_sayisi;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();
            oto.setMarka("");
            oto.setYil(2023);
            
            //Otomobil.arac_sayisi = 150;

            label1.Text = "otomobil marka: " + oto.getMarka() + "Otomobil yýlý: " + oto.getYil() + "Araç sayýsý: " +oto.getArac_Sayisi();

        }
    }
}
