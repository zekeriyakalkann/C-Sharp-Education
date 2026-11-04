namespace Windows_Form
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

        class Universite
        {
            public int kurulus_yili = 2007;
            public string uni_adi = "Bitlis Eren Üniversitesi";

            public string Yaz()
            {
                return "Üniversite Adý: " + uni_adi + "\nKuruluþ Yýlý: " + kurulus_yili;
            }
        }
        private void lb1_Click(object sender, EventArgs e)
        {



        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Universite Uni = new Universite();

            lb1.Text += Uni.Yaz();

            Universite Uni2 = new Universite();

            Uni2.uni_adi = "Batman Üniversitesi";
            Uni2.kurulus_yili = 2004;

            lb1.Text += Uni2.Yaz();
        }
        class Universite2
        {
            int Uni_Yili = 2007;
            string Uni_adi = "Bitlis Eren Üniversitesi";

            public Universite2()
            {
                MessageBox.Show(Uni_adi + " " + Uni_Yili + "yýlýnda kuruldu.");
            }

            public Universite2(int _uni_Yili)
            {
                _uni_Yili = Uni_Yili;
                MessageBox.Show(Uni_adi + " " + Uni_Yili + "yýlýnda kuruldu.");
            }

            //public Universite2(string _Uniadi, int _uni_yili )
            //{
            //    _Uniadi = Uni_adi;
            //    _uni_yili = Uni_Yili;
            //    MessageBox.Show(Uni_adi + " " + Uni_Yili + "yýlýnda kuruldu.");

            //}

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //new Universite2();
            //new Universite2(2000);
            

            //new Universite2("Bitlis Eren Üniversitesi", 2007);

        }

        class Alistirma
        {
            public static int  a = 15;
            public int b = 17;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Alistirma als1 = new Alistirma();
            Alistirma als2 = new Alistirma();
            Alistirma.a = 33;
            lb1.Text = Convert.ToString(Alistirma.a);

        }
    }
}
