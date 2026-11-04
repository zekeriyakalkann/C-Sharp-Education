namespace Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kagitPic.Click += pictureBox1_Click;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fotoðrafa týkladýnýz.");
        }
    }
}
