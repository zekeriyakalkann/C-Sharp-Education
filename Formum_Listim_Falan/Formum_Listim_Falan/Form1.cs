namespace Formum_Listim_Falan
{
    public partial class Form1 : Form
    {
        public class Otomobil
        {
            private int yil;
            private string marka;
            private static int arac_sayisi = 124;
            private object label1;

            public int Yil
            {
                set
                {
                    if (value < 2000 || value > 2024)
                    {
                        MessageBox.Show("Yanlýþ deðer girdiniz");
                    }

                    else
                    {
                        this.yil = value;
                    }
                }

                get
                {
                    return this.yil;

                }
            }

            public string Marka
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        MessageBox.Show("Bu deðer boþ ya da null olamaz! ");
                    }

                    else
                    {
                        this.marka = value;
                    }
                }

                get
                {
                    if (string.IsNullOrEmpty(this.marka))
                    {
                        return "MARKASIZ";
                    }

                    else
                    {
                        return this.marka;
                    }
                }
            }

            public static int Arac_sayisi
            {
                get { return Otomobil.arac_sayisi; }
            }
            private void Form1_Load(object sender, EventArgs e)
            {
                Otomobil oto = new Otomobil();

                oto.yil = 2007;
                oto.marka = "Calender";
                label1.Text = $"Araç yýlý: {oto.yil}, Araç model: {oto.marka}, Araç sayýsý: {arac_sayisi} ";

            }
        }
    }
}
