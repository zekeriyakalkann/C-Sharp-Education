using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69___Static_Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static: Nesne örneği alınmadan ulaşabildiğimiz metot, sınıf, field.... Uzatabiliriz...

            //Stack bölge içerisinde pointer ımız oluştu.
            Ogrenci O1; //Heap bölgeye geçebilmesi isin new anahtar sözcüğü ile işaretlenmesi gerekmektedir.

            //Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan
            //static field, metot, class static dediğimiz bölgede oluşturuldu.

            Ogrenci.Test2();


            O1 = new Ogrenci();
            //Stack bölgede pointer => kendisini heap bölgede tamamladı... Static olmayan tanımlarını tamamladı.
            O1.Test(); //Nesne örneği alındıktan sonra Test adındaki metoduma ulaşabildim.

            /* STATİC KAVRAMI GERÇEK HAYATTA NERELERDE KULLANILMAKTADIR ?
             * 
             * 1-) Helper.cs => Kontroller içi kullanılır. Yani her projede gerekli olan noktalar için kullanılır. Bu classı her projede 
             * kullanabiliriz. Aslında bir projeye bağımlı olmayan classların kullanımıdır diyebiliriz.
             * 2-) Oluşturmuş olduğumuz nesnemizin => bağımlılığı farklı class lara olduğu için (proje içerisinde özel olduğu için) nesne
             * içerisinde static metot tanımları yapılır.
             * 3-) Class içerisinde bir field (static) tanımı yapar ilgili field içerisine bir değer ataması yaparız. Daha sonra uygulama içerisinde 
             * N farklı yerde oluşturmuş olduğumuz static field ımıza ulaşır değerin okumasını yaparız.
             * 4-) 
             * 
             * 
             */
        }
    }
}
//O1 Pointer ı stack bölgede olduğu için bunu new ile işaretleyip heap bölgeye taşıdıktan sonra içerisindekileri kullanabilmekteyiz.
//Aslında new ile işaretleme yapıldığında heap bölgeye taşındığından dolayı artık static olmayan ve erişime açık olan field ları ya da
//metotları heap bölgede görünür getirmiş ve kullanabilmiş olduk.
//Lakin static kısmı da O1 pointer ından bağımsız olarak static adı verilen bölgede direk sınıf adlarını kullanabildiğimiz bir alandır.
//Static ile oluşturulan bir field ya da metodun yapıcı metotları olduğundan ötürü direk olarak static kısmında alanları oluşmuş oldu.
//Static metotlar , static olmayan metotlar içerisinden çağırılabilir.
//Static olan metotlar sadece static olan metotları çağırabilir. Static olmayan metotları çağıramaz.


