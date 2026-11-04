using Kalitim.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim
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

        private void button1_Click(object sender, EventArgs e)
        {
            Akademik A1 = new Akademik();
            Dersler dersler = new Dersler();
            A1.ad = "Zekeriya";
            A1.soyad = "Kalkan";
            A1.akademik_unvan = "Ordinaryus";
            A1.tc_no = "21549965745";
            label1.Text = A1.akademik_unvan;
            A1.BilgiYaz();
            //Akademik A2 = new Akademik();
            //label1.Text = ((Calisanlar)A2).Ekrana_yaz();// Bu şekilde bu ifade kullanılmaktadır.
            Calisanlar A3 = new Akademik(); //Bu şekilde de kalıtım yolu ile bu tip bir nesne oluşumu yapabilmekteyiz. Bu da çok nadir de olsa kullanılabilmektedir.
            label1.Text = A3.Ekrana_yaz();
        }
    }
}
