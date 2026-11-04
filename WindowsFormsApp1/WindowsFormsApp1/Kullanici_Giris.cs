using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kullanici_Giris : Form
    {
        public Kullanici_Giris()
        {
            InitializeComponent();
        }

        private void Kullanici_Giris_Load(object sender, EventArgs e)
        {
            Sistem_Cikis sistem_Cikis = new Sistem_Cikis();

            sistem_Cikis.Show();


        }
    }
}
