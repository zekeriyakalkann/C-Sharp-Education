using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classs_ve_metotlar
{
    public class araba
    {
        public int kapisayisi;
        public string arabarengi;

        public araba(int _kapisayisi, string _arabarengi)      //Buradaki kısım yapıcı metot olarak adlandırılır. 
        {
            kapisayisi = _kapisayisi;
            arabarengi = _arabarengi;
        }

        public void arabacalistir()
        {
            Console.WriteLine("Araba çalışıyor...");
        }

        public void kapilarikilitle()
        {
            Console.WriteLine("Kapılar kilitleniyor ");
        }
    }
}
