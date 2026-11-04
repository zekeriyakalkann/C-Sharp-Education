using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _54__ArryaList_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerListesi = new ArrayList();
            do
            {

                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Değer ekleme");
                Console.WriteLine("2 - Değer listeleme");
                Console.WriteLine("3 - Değer ara");
                Console.WriteLine("4 - Değer düzenle");
                Console.WriteLine("5 - Değer sil");
                Console.WriteLine("6 - Uygulama çıkış");
                Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
                kullaniciSecim = Console.ReadLine();


                switch (kullaniciSecim)
                {
                    case "1":
                        Console.WriteLine("Lütfen eklemek istediğiniz değeri giriniz: ");
                        int eklenecekDeger = int.Parse(Console.ReadLine());
                        degerListesi.Add(eklenecekDeger);
                        Console.WriteLine("Değeriniz başarılı bir şekilde eklendi...");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "2":
                        Console.WriteLine("Listedeki değerler: ");
                        foreach (int i in degerListesi)
                        {
                            Console.Write(degerListesi[i] + " ");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Lütfen aramak istediğiniz değeri giriniz: ");
                        int kullaniciArananDeger = int.Parse(Console.ReadLine());
                        bool kontrol = degerListesi.Contains(kullaniciArananDeger);
                        if (kontrol)
                        {
                            Console.WriteLine("Değer listede mevcuttur...");
                        }
                        else
                        {
                            Console.WriteLine("Değer listede mevcut değildir...");
                        }

                        break;
                    case "4":
                        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                        Console.WriteLine("1 - Değerleri küçükten büyüğe sıralama");
                        Console.WriteLine("2 - Değerleri ters çevirme");
                        Console.WriteLine("3 - Önce küçükten büyüğe sırala sonra ise ters çevir");
                        string kullaniciSecim2 = Console.ReadLine();
                        if (kullaniciSecim2 == "1")
                        {
                            degerListesi.Sort();
                            Console.WriteLine("Değerlerin sıralanmış hali: ");
                            Console.WriteLine(degerListesi);
                        }
                        else if (kullaniciSecim2 == "2")
                        {
                            degerListesi.Reverse();
                            Console.WriteLine("Değerlerin ters çevrilmiş hali: ");
                            Console.WriteLine(degerListesi);
                        }
                        else if (kullaniciSecim2 == "3")
                        {
                            degerListesi.Sort();
                            degerListesi.Reverse();
                            Console.WriteLine("Değerlerin önce küçükten büyüğe sıralanışı sonra ise ters çevrilmiş hali: ");
                            Console.WriteLine(degerListesi);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı bir tuşlama yaptınız. Lütfen tekrar deneyiniz: ");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Lütfen silmek istediğiniz değeri giriniz: ");
                        int silinecekDeger = int.Parse(Console.ReadLine());
                        degerListesi.Remove(silinecekDeger);
                        Console.WriteLine("Değer silindikten sonraki dizi: " + degerListesi);
                        break;
                    case "6":
                        Console.WriteLine("Uygulamadan çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Hatalı bir tuşlama yaptınız...");
                        break;
                }
            } while (kullaniciSecim != "6");

        }
    }
}
