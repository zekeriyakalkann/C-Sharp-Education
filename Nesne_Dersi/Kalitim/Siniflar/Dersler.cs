using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim.Siniflar
{
    public class Dersler : Akademik
    {
        public string ders_adi = "nesneye yönelik programlama";
        public int ders_saati = 13;
        public int ders_id = 1;

        public Dersler() : base("Dr. Öğr. Üyesi", "Mühendislik Fakültesi", 8)
        {
            MessageBox.Show($"Ders adı: {ders_adi} \n Ders saati: {ders_saati}");
        }
    }
}
