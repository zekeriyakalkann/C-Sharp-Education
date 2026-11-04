using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zafer_Comert_Ileri_Seviye
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

/*
 * Veri Yapıları (Data Structures) = Veri yapısı, veriye erişimi, verinin depolanmasını ve verinin organizasyonunu temsil eden bir kavramdır. 
 * Her bir veri yapsısını eğitim boyunca bir koleksiyon olarak kullanmaya gayret edeceğiz.
 * Bir veri yapısı, veri değerleri, veriler arasındaki ilişkiler ve verilere uygulanabilecek işlevler veya işlemlerin bir koleksiyonudur. 
 * Genellikle verimli veri yapıları, verimli algoritmaların anahtarlarıdır.
 * Veri tipleri değer tipli ve referans tipli olmak üzere 2 ye ayrılmaktadır. Değer tipli verilere örnek olarak struct ve enum örnek olarak verilebilir.
 * Referans tipli verilere örnek olarak class, interface ve delegate örnek olarak verilebilmektedir.
 * Değer tipindeki bir ifadenin değerini stack bölgede tutarken referans tipli bir ifadenin değerini heap bölgede tutmaktayız.
 * 2 tane referans tipli değişken heap bölgede aynı noktayı tutabilir. Bu değer 2 den fazla bir değer olarak da karşımıza çıkabilmektedir.
 * stack bölgedeki referans tipli değişkenler heap bölgede eğer aynı yeri gösteriyorsa heap bölgede yapılan bir değişiklik, stack bölgede
 * kaç adet referans tipli değişken bu heap bölgedeki referans tipli değişkeni gösterirse onlar da heap bölgeye göre hepsi güncellenir.
 * yerleşik veri tiplerine (değer tipli) örnek olarak short, int, double, char, decimal... örnekler çoğaltılabilmektedir.
 * referans tipli verilere örnek olarak string, object, dynamic.... gibi örnekler daha da çoğaltılabilmektedir.
 * Kullanıcı taraflı değer tipli veri tipinde struct kullanılır.
 * Kullanıcı taraflı referans tipli veri tipinde class kullanılmaktadır.
 * Biz genelde class kullanacağız. Çünkü classlar referans tipli davrandığından ötürü daha kapsamlı çalışmalar yapmamıza olanak sağlamaktadır.
 * Aslında nesnenin bize sağladığı özellikleri kullanabilmek için classları kullanmaktayız.
 * 
 * 
 */