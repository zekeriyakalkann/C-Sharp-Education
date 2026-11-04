using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisimmetotpratik
{
    public class Öğrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;

        public Öğrenci(int _ogrenciNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulismi)
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;
        }
        public void ogrencibilgilerinigoster()
        {
            Console.WriteLine("Öğrenci numarası : "+ ogrenciNo);
            Console.WriteLine("Öğrenci ismi : "+ isim);
            Console.WriteLine("Öğrenci soyisimi : " + soyisim);
            Console.WriteLine("Öğrencinin okul ismi : " + okulismi);
            Console.WriteLine("Öğrencinin birinci vizesi : " + vize1);
            Console.WriteLine("Öğrencinin ikinci vizesi : " + vize2);
            Console.WriteLine("Öğrencinin final notu : " + final);
        }
        public double ogrencinotubul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void ogrencigetir()
        {
            Console.WriteLine("Öğrencinin okul ismi : " + okulismi);

        }
    }
}
