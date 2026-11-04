using _64__Classalr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64__Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dünya"); //Buradaki Console da bir sınıftır. Using lerin altında kullanılan bir sınıftır.

            //Musteri M1 = new Musteri();     //Buradaki new kısmının yanındaki Musteri(); bir nesne olmuştur.

            Musteri M1 = new Musteri("21958999956");    //Burada oluşturulan yapıcı metotları göreceğiz nesne oluşurken
            //birden fazla var ise içerisinden istediğimizi seçerek kullanabileceğiz. Bunlara ise overload adı verilmektedir.

            //M1 adı altında ise bunun örneklemesinin yapılmasını sağladık. Çünkü Musteri classı içindeki verileri burada kullanacağımız için.

            //M1.  Bu şekilde yapıldığında hata alırız. Çünkü öncesinde veri tiplerine her yerden erişebilmek için 
            //bunları erişim belirleyicisi vasıtasıyla görünür yapmamız gerekmektedir.

            //M1 kısmı aslında yukarıda üretilen nesnedeki bir örnektir. Şöyle düşünebiliriz: Berberler odası
            //bir nesne ise berberler de o nesne altındaki örnekler olarak adlandırılabilir. Ana mantık bu şekildedir.

            M1.TCkimliknumarasi = "219589999560";
            M1.isim = "Zekeriya";
            M1.soyisim = "Kalkan";
            M1.cinsiyet = 101101;

            Musteri M2 = M1;    //Burada yapılan şey müşteri nesnesinin M1 örneğindeki veriler M2 kısmına gelmiştir.

            M2.isim = "Gamze";
            M1.TCkimliknumarasi = "25288887952";


            bool MusteriKontrol = M1.MusteriKontrol();

            //M2 = null;
            //M1 = null;

            //string isim = new Musteri().isim;   //Doğru yazım bu şekiildedir.

            //string isim2 = M2.isim;     //Bu şekilde bir yazımda hata alacağız. Onun için bir üstteki gibi yazmamız gerekmektedir.

            Console.ReadKey();



        }
    }
}
