using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   //Bu kütüphane default olarak gelmez. ArrayList kullanacağımız zaman bu kütüphaneyi
//buraya eklememiz gerekmektedir. Yoksa hata alırız. Buna dikkat edelim.

//Kütüphane olarak geçmektedir ve ad alanlarında kullanılacak olan başka sınıfları using kütüphanesi sayesinde 
//aktifleştiririz ve kısayollar sayesinde bu verilere kolayca erişebiliriz.
namespace _53___Array_List_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Capacity = 0;
            int Count = 0;
            string[] isimler = new string[10];

            ArrayList A1 = new ArrayList();

            //Burada ArrayList bir sınıf, A1 bu sınıfın bir nesnesi, new ArrayList kısmı ise ArraList sınıfından
            //yen bir nesne oluşturma işlemidir.

            #region Tek değer ekleme

            A1.Add(1);

            Capacity = A1.Capacity;
            Count = A1.Count;

            A1.Add("Zekeriya KALKAN");  //Bu şekilde farklı veri tiplerini direk bir arraylist te toplayabiliriz.

            #endregion

            #region Bir koleksiyona birden fazla değer ekleme 

            ArrayList A2 = new ArrayList();
            A2.Add(2);
            A2.Add(3);
            A2.Add("Ahmet");
            A1.AddRange(A2);    //Burada ise A1 ArrayListine A2 ArrayListinin koleksiyonlarını eklemiş olduk. 
                                //Ve direk A1 değerlerinin peşine ekleyerek devam etmektedir. 
                                //Buradaki A1 ve A2 kısımları koleksiyon olarak adlandırılmaktadır.

            #endregion

            Capacity = A1.Capacity;
            Count = A1.Count;

            #region Capacity ve Count kavramlarının açıklamaları : 

            //Count koleksiyon içerisindeki değerlerin sayısını ifade etmektedir. 
            //Capacity ise bir koleksiyonun alacağı maksimumu değer sayısını ifade etmektedir.

            //Capacity 4 ün katları ile artacaktır. Bu artırımı önceden yazılımcı yapıyordu. Şu anda ise 
            //sistemin kendisi bunu otomatik olarak yapmaktadır. Bu normal dizileri arka plana itmesinini sebebidir.
            #endregion

            #region Elemanlar ile alakalı bilgiler

            Object O1 = A1[3];
            string S1 = A1[3].ToString();   
            int I1 = (int)A1[3];    //Bilinçsiz tür dönüşümü olarak adlandırılmaktadır.

            //Bir index değerindeki elemanı değiştirmek için: 
            A1[0] = "Gamze MASTARCIOĞLU";

            //ToString metodu, bir nesnenin string (metin) temsiline dönüştürülmesini sağlar.
            //Bu metot, her nesnenin içinde tanımlı olduğu Object sınıfından miras alınır ve genellikle nesnenin
            //anlamlı bir şekilde metin olarak ifade edilmesi amacıyla override (geçersiz kılınır) edilir.


            //override, bir alt sınıfın (derived class) üst sınıfta (base class) tanımlanmış bir
            //metodu yeniden tanımlaması anlamına gelir. Bu, alt sınıfın, üst sınıfta var olan bir metodu
            //kendi özel davranışıyla geçersiz kılmasını sağlar.
            #endregion

            #region ArrayListlerde sıralama: 

            //ArrayList elemanlarını A-Z şeklinde sıralama

            A1.Sort();

            //ArrayList elemanlarını ters çevirme

            A1.Reverse();

            #endregion

            #region ArrayList yardımcı komutlar: 

            bool Kontrol1 = A1.Contains("Gamze MASTARCIOĞLU");
            bool Kontrol2 = A1.Contains(900);

            //Burada da değeri kontrol eder ve değer varsa true yoksa false olarak bize döner. 

            object[] dizi1 = A1.ToArray();

            //Bu komut ArrayListi diziye çevirmeye yaramaktadır.




            A1.Clear(); // Bu da siyah ekranda görünen her şeyi temizlememize yaramaktadır.

            A1.TrimToSize();  //Bu komut ile de count kısmını tekrardan boyutlandırabiliriz.

            int indexdeger = A1.IndexOf("Zekeriya KALKAN"); //Bu şekilde de bir değere atamasını yapabiliriz.

            //Koleksiyon içerisindeki elemanların hangi indexte olduğunu bize söyler.

            #endregion

            #region ArrayList içerisindeki koleksiyonu silme 
                
            A1.Remove("Gamze MASTARCIOĞLU");
            A1.RemoveRange(0, 2);   //0. indexten başla ve 2 eleman sil anlamına gelen bir komuttur.
            A1.RemoveAt(1); //Bu da direk olarak ilgili index değerindeki elemanı silmemize yaramaktadır.

            #endregion





        }
    }
}
