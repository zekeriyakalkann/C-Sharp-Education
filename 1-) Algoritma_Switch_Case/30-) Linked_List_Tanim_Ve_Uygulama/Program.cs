using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30___Linked_List_Tanim_Ve_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<T> TEMELLERİ: 
            //Tanımlama
            var sehirler = new LinkedList<string>();    //Generic kütüphane kullandı.

            //Ekleme

            sehirler.AddFirst("Ordu");  
            //LinkedListin en başına ekler.

            sehirler.AddFirst("Trabzon");   
            //Artık Trabzon first kısmında oldu. Ordu ise last kısmına kaydı.

            sehirler.AddLast("İstanbul"); 
            //LinkedList last elemanı artık İstanbul oldu.

            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun"); 
            //Burada Ordu elemanının yerini tespit ettik ve hemen sonrasına Mersin elemanını eklemiş olduk.

            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            //İlk eleman Trabzon, sonraki Ordu, sonraki normalde Samsun idi. Biz onu burada Giresun ile değişimini yapmış olduk.

            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            //Mantık bu şekilde kolayca işlemektedir.  

            sehirler.AddAfter(sehirler.Last.Previous,"Zonguldak ");




            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }


            Console.ReadKey();
        }
    }
}

/*
 * System.Collections.Generic kütüphanesi ile çalışmaktadır.
 * LinkedList<T> şeklinde kullanılmaktadır.
 * Elemanaların hafızadaki konumlarının sıralı olarak organize edilmediği doğrusal bir liste yapısıdır.
 * Doğrusal bir veri yapısıdır.
 * Bağlı listeler düğümlerden oluşur ve her düğüm 2 elemandan oluşmaktadır.
 * Düğümde işaretçi (pointer) ve veriyi tutan bir bölüm vardır. Yani node 2 kısımdan oluşmaktadır.
 * Bir sonraki elemanı göstermek için kullanılan pointer ya da işaretçi next adını almaktadır.
 * bir önceki node u işaret eden pointer a ise previous adı verilmektedir.
 * İlk düğüm first, ikinci düğüm last olarak adlandırılır. First.next dediğimizde ilk düğümden sonrak düğümü işaret ederiz.
 * Last.previous dediğimizde ise son düğümden önceki düğümü ifade etmiş oluruz.
 * Addfirst ya da addlast yaparsak linked listin başına ya da sonuna başka bir düğüm ekleyebiliriz.
 * Bir elemana ulaşmak için tüm listenin dolaşılması gerekmektedir ve veriden hariç bir de pointer kullanıldığından
 * ötürü bellekte fazla yer kaplaması yapacaktır. Bunlar dezavantajlarıdır.
 * Avantajları ise rahat bir şekilde eleman ekleyip çıkarabiliriz ve sürekli boyutlandırma yapmamıza gerek yoktur.
 * Diziden daha karmaşık bir yapı olmasından ötürü bu da bir devavantaj olarak sayılabilmektedir.
 * Ama yine de dizilere göre daha kullanışlı bir yapıya sahiptir. O yüzden sıkça tercih edilmektedir.
 * 
 */
