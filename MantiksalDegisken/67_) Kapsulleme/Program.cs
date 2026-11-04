using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67___Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            //M1.id = 1;
            M1.isim = "Zekeriya";
            M1.soyisim = "Kalkan";

            //M1.emailAdres = "zeki.kalkan33@gmail.com"; //Bu kısımda şu an hata alıyoruz. Çünkü erişim belirtecimizi private olarak güncelledik. (Field)

            M1.EmailAdres = "zeki.kalkan33@gmail.com"; //Property ile Private olan field ımızı artık görünür kılabildik.
            //Yalnız burada private olarak açtığımız field ımıza oluşturmuş olduğumuz property içerisinde set komutuna bir ayarlama yapmadığımızdan ötürü
            //yani sadece görünür kıldığımızdan ötürü null olarak default değeri döndü. Şimdi bunu set ederek artık değerin default değer olarak dönmesine
            //engel olacağız. Bunun için de set komutu içerisinde value değerini kullanarak bu default değeri artık düzenleyeceğiz.

            Console.Write(M1.EmailAdres);
            

            // 1. Field değer ataması yapılamasın ama değer okunabilsin.

            Console.WriteLine($"Müşteri ID: {M1.ID.ToString()}");
            //M1.ID = 10; //Bunu bu şekilde verilen sorudaki gibi değiştirememiz gerekmektedir. Bunun için de set komutunda ufak bir değişiklik yapılması gerekmektedir.



            Console.ReadKey();
        }
    }
}
/*
            * Musteri classımız içerisinde bazı alanları özelleştirmek istediğimizde biz kapsülleme kullanmaktayız. 
            * Field değer ataması yapılamasın ama değer okunabilsin.
            * Field değer ataması yapılsın ama değer okunamasın. Bu tip kullanımlar kapsüllemeye örnek kullanımlar olarak karşımıza çıkmaktadır.
            * Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun. Bu da kapsülleme örneğidir.
            * Field değer ataması yapılsın ve değer okunsun ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
            */

//Class
//Field
//Property
//Get & Set