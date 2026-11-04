using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Mantiksal_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ve operatörü: (&&) şeklinde kullanılır. İki şart da doğru dönerse doğru birisi yanlış dönerse yanlış olur.
            //Bool donenDeger = degisken1 == "Zekeriya" && degisken2 == "123";

            string KullaniciAdi = "Cengiz";
            string sifre = "123";
            

            bool donenDeger = KullaniciAdi == "Cengiz" && sifre == "123";
            Console.WriteLine(donenDeger);
            Console.ReadLine();

            //Bu şekilde yapılmaktadır...

            //Veya operatörü: (||) şeklinde kullanılır. Şartlardan bir tanesi doğruysa sonuç doğru hepsi yanlış olursa false dönecektir.
            //Bool donendeger = degisken1 == "Zekeriya" || degisken2 == "123";  Şeklinde yapılabilir basitçe

            //Ve operatörü (&&) = Bu operatör iki şartın da doğruluğunda kod bloğunun çalışmasını sağlamaktadır.
            //Eğer bu şartlardan bir tanesi yanlışsa kod çalışmayacaktır.

            //Veya operatörü(||) = Bu operatör girilen birden fazla şarttan herhangi bir tanesi doğru ise ilgili
            //kod bloklarının içerisine girip kodun çalışmasını sağlamaya yaramaktadır.





        }
    }
}
