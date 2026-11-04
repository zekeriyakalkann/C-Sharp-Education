using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _25_I_Comperablle_Implementatition
{
    public class sehirler : IComparable<sehirler>   //Burası kalıtıma girmektedir. Listemizi 2 ayrı değer olduğu için karşılaştıramadağımızdan ötürü bu yolu seçmekteyiz. Ve bu arayüz ile sort metodunu listemiz için sisteme kazandırmış olacağız.
    {
        public int plakaNo { get; set; }
        public string sehirAdi { get; set; }
        public sehirler(int plakaNo, string sehirAdi)
        {
            this.plakaNo = plakaNo;
            this.sehirAdi = sehirAdi;
        }
        public override string ToString()
        {
            return $"{plakaNo,-5} {sehirAdi,-15}";
        }

        public int CompareTo(sehirler other)
        {
            if (this.plakaNo< other.plakaNo)
            {
                return -1 ;
            }

            else if (this.plakaNo == this.plakaNo)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            var sayilar = new List<int>() { 21, 32, 76, 10, 2, 6, 1, 7 };
            sayilar.ForEach(s => Console.WriteLine(s));
            sayilar.Sort();
            var sehir_plaka = new List<sehirler>()
            {
                new sehirler(33,"Mersin"),
                new sehirler(34,"İstanbul"),
                new sehirler(1,"Adana"),
                new sehirler(13,"Bitlis"),
                new sehirler(6,"Ankara"),
                new sehirler(55,"Samsun"),
                new sehirler(44,"Malatya"),

            };
            sehir_plaka.Sort();
            sehir_plaka.ForEach(s => Console.WriteLine(s));
            Console.ReadKey();
        }
    }
}

//"implement interface" (arayüzü uygulamak), bir sınıfın belirli bir arayüzde (interface) tanımlanan methodları ve
//özellikleri gerçekleştirmesi (uygulaması) anlamına gelir. Bu, sınıfın o arayüzün tanımladığı tüm methodları ve
//özellikleri içermesini ve kendi içersinde bu methodları doldurmasını gerektirir.
