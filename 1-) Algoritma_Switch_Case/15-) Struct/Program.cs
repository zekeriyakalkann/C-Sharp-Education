using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Struct
{
    public class Program  //Referans tipli çalışır.
    { 
        static void Main(string[] args)
        {
            var ogrenciListesi = new List<Ogrenci>() {

                  new Ogrenci(10, "Zekeriya", "Kalkan"),
                  new Ogrenci(20, "Selim", "Demir", true),
                  new Ogrenci(30, "Hüseyin", "NazlıElçi", false),
                  new Ogrenci(40, "Zekeriya", "Palaoğlu"),
            };

            ogrenciListesi.ForEach(o => Console.WriteLine(o));

            Console.ReadKey();
        }
    }
}


//Numaraya 10 değerini atama işlemini set; yolu ile yaptık. Bu kapsülleme olarak da geçmektedir.
//Get komutu ise bu satırlar içerisinde yapılan işlemleri okumaya yarar. Set ifadesi kaldırılır ise main metodu
//içerisindeki atama işlemini gerçekleştiremeyiz. Heap bölgede 2 ayrı değişken tek bir ifadeyi gösterse dahi 
//stack bölgede ayrı ayrı tutulacağından bu değer tipli davranış olarak adlandırılır. Yani bir değişkende 
//değeri değiştirir isek öbür değişkende değer tipli davranışa özgü olarak bir değişim gözleyemeyiz. Referans tipli
//davranışta bu durum tersine dönmektedir.