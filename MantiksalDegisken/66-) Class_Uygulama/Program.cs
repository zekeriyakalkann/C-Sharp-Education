using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _66___Class_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AracBilgileri Arac1 = new AracBilgileri();
            Arac1.aracmarka = "Ford";
            Arac1.model = "Mustang";
            Arac1.modelyil = 1987;
            Arac1.km = 250000;
            Arac1.yakitTipi = "Benzin";
            Arac1.vitestipi = "Düz";
            Arac1.alisfiyat = 1000000;
            Arac1.satisfiyat = 1250000;
            Arac1.maxindirimtutari = 50000;
            //Arac1.fiyat = 0;
            BilgileriGoruntule(Arac1.aracmarka, Arac1.model, Arac1.modelyil, Arac1.km, Arac1.yakitTipi,Arac1.vitestipi, Arac1.satisfiyat);
            Arac1.FiyatAta(1100000);
            Console.ReadKey();

            //Ana olarak şema bu şekildedir. 

        }

        static void BilgileriGoruntule(string aracmarka, string model, int modelyil, decimal km, string yakitTipi, string vitestipi, decimal satisfiyat)
        {
            Console.WriteLine("Araç Bilgileri şu şekildedir:");
            Console.Write("{0} marka, {1} model, {2} model yılı, {3} kilometre, yakıt tipi {4}, {5} vites, fiyat: {6}", aracmarka, model, modelyil, km, yakitTipi, vitestipi, satisfiyat);
        }
    }
}
