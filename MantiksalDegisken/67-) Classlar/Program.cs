using _65___Classlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64___Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musteri classında yaptığımız overload artık buradaki nesnelerde default değeri değiştirmek için kullanılabilir.
            //Musteri(); kısmındaki açılıp kapanan parantez aslında bize oluşturulan değerlere bir şey atamadan önceki default değerlerini ver anlamına gelmektedir.
            Musteri M1 = new Musteri(); //Musteri(); kısmı bir yapıcı metottur. new kısmı ile nesnemizi örnekliyoruz. M1 nesne örneğimizin ismi.
            M1.TCkimliknumara = "23123209965";
            M1.isim = "Zekeriya";
            M1.soyisim = "Kalkan";
            M1.cinsiyet = 101110;

            Musteri M2 = M1;

            M2.TCkimliknumara = "123232131323";
            M1.soyisim = "MASTARCIOĞLU";        //Burası aslında referans tipli bir davranışa örnektir. 2 nesne de de yapılan ayrı ayrı değişimlerden
            //her 2 nesne de etkilenmektedir. 

            M2 = null;
            M1 = null;

            //Burada stake bölgedeki nesnelerim komple null olduğundan dolayı heap bölgedeki veri kümesini gösteren bir nesne kalmaz. 
            //Bu yüzden ise o veri kümesi gc adında bir noktaya taşınır ve ramden düşer ve bu verilere tekrar ulaşamayız. 
            //Bu yüzden heap bölgedeki bu verileri bir şekilde veri kaybı yaşamamak için tutmamız gerekmektedir.    

            string isim = M1.isim;

        }
    }
}
