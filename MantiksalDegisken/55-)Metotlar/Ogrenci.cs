using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _55__Metotlar
{
    public class Ogrenci        //Bütün uygulama içerisinde bu class ı kullanabilmek için public erişim belirleyicisini kullanmaktayız...
                                //ve buradaki Ogrenci bizim nesnemiz olmaktadır.
    {
        public void SelamlaOgrenci()    //Burada metodu ve classı farklı yapmamızın sebebi farklı staticler içerisinden de bu class ve metotlara
                                        //ulaşmak istediğimiz içindir.
        {
            Console.WriteLine("Merhaba öğrenci.");

            //Bir metot tanımlamak için aşağıdaki genel şablon kullanılmaktadır: 
            /*
             * 
             * [Erişim belirleyicisi, GeriyeDönenDeğer, (parametreler(geriye değer dönüyorsa yazılır.))]
             * {
             *      //Metot içi çalışacak kodlar...
             * }
             * 
             * Erişim Belirleyicileri: 
             * Public: Benim Classıma ulaşan herkesin bu metoda da ulaşmasını istersem kullanırım.
             * 
             * Private: Sadece oluşturmuş olduğum class içerisindeki metotlara ulaşmak istenirse bu erişim belirleyicisi kullanılmaktadır.
             * 
             * Buradan aşağıdakiler daha çok polimorfizm yardımı ile kullanılacak olan erişim belirleyicileridir.
             * 
             * Protected: Sadece miras alan classlarda kullanılabilecek bir erişim belirleyicisidir.
             * 
             * Internal: İlgili kütüphane yardımıyla ulaşabileceğiniz classları belirlemeye yarayan bir erişim belirleyicisidir.
             * 
             * Internal Protected: Hem ilgili kütüphane yardımıyla hem de miras alındıysa yani kalıtıldıysa ulaşılabilen erişim belirleyicisidir.
             *              
             */



        }
        private void OgrenciMetot1(string OgrenciAdı, string OgrenciSoyadi)  //Void aslında geriye değer döndürmeme üzerine kuruludur.
                                                                             //Yani return anahtar kelimesini kullanmayız. Ama parametre alabiliriz. Bu nokta önemlidir. Dikkat edelim...
        {
            Console.WriteLine("Öğrenci bilgileri: {0} {1}", OgrenciAdı, OgrenciSoyadi);
        }
        //OgrenciMetot1 isimli metodun erişim belirleyicisini private olarak değiştirir isek bu metoda sadece Ogrenci isimli sınıfta artık ulaşabiliriz.

        public void OgrenciMetot2()
        {
            OgrenciMetot1("Zekeriya", "Kalkan");    //Bu şekilde bir kullanım ile de private erişim belirleyicisi içindeki bir kodu farklı yerlerde
                                                    //Çalıştırabiliriz.
        }
    }
}









