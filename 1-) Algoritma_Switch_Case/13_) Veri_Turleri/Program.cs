using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Veri_Turleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * - - - - - - - - - buradaki ilk çizgi işaretçi biti almaktadır. 0 = pozitif ve 1 = negatif değerlerini sadece tutmaktadır. 
             * İşaretçi bit 1 ise sonuç eksi olarak gelir, 0 ise artı olarak sonıuç bize gelmektedir.
             * SByte eksili ve artılı değerleri bir arada tutarken byte 0 ve artılı değerleri tutmaktadır.
             * 1 byte = 8 bite karşılık gelmektedir.
             * SByte ya da Byte = 1 byte
             * int16 = 2 byte
             * int32 = 4 byte
             * int64 = 8 byte şeklinde bir alan kaplamaktadır.
             */

            /*
             *SByte (Signed Byte) negatif ve pozitif değerleri temsil etmek için kullanılır ve işaretli bir veri tipidir. SByte'da en soldaki bit (ilk bit), sayının 
             *pozitif veya negatif olduğunu belirtir. Bu bit, işaret biti olarak adlandırılır.
             *
             *0: Pozitif bir sayı.
             *1: Negatif bir sayı.
             *Geriye kalan 7 bit ise sayının büyüklüğünü gösterir.
             *Örneğiniz: 1 0 0 0 0 0 0 0
             *Bu durumda:
             *İlk bit 1, yani sayının negatif olduğunu gösterir.
             *0 0 0 0 0 0 0 kısmı ise değeri temsil eder.
             *Değeri Hesaplamak: İkili Koddan Onlu Koda Dönüşüm
             *Negatif sayılar, bilgisayar biliminde iki'nin tümleyeni (two's complement) yöntemiyle temsil edilir.
             *1 0 0 0 0 0 0 0 bit dizisi iki'nin tümleyeni formatında -128 değerini temsil eder.
             *Bu yüzden 1 0 0 0 0 0 0 0 ikili dizisi, SByte veri türünde -128 anlamına gelir. 
             * Sbyte 1 bitlik işaretli olan max tutacağı veri sayısı -128 ve 127 arasındadır. (Bu değerler de buna dahildir.)
             * 
             * Byte ta ise işaretçi 0 olduğunda ötürü 0 ve 255 arasında veri sayısı almaktadır.
             */

            /*
             *Bit düzeyinde işlemler, daha az bellek kullanımı, hızlı işlem yapma, donanımı doğrudan kontrol etme ve veri iletimini 
             *optimize etme gibi birçok temel avantaj sağlar. Özellikle düşük seviyeli programlama veya donanım odaklı 
             *projelerde bit manipülasyonunu anlamak, yazılımın hem verimli hem de uyumlu çalışmasına büyük katkı sağlar. 
             */
        }
    }
}
