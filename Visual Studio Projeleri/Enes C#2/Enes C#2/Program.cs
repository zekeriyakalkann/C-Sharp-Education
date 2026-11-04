using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Enes_C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Zekeriya Kalkan");
            //Console.Write("Sait");
            //Console.Write("Berzan");
            //Console.ReadLine();
            //Uygulama 1 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Byte veri tipi: 0-255 arasındaki değerleri tutmaya yarayan veri tipi olarak adlandırılır.

            //byte birinci = 5
            //byte ikinci = 28
            // byte janci = 256; // Burada hata vermesinin nedeni byte ın 0-255 değer aralığında olmasıdır. Eksi değerler girildiğinde de hata alırız
            //byte ucuncu = 255
            //byte maxdeger = byte.MaxValue
            //byte mindeger = byte.MinValue;

            //Console.WriteLine(birinci);
            //Console.WriteLine(ikinci);
            //Console.WriteLine(ucuncu);
            //Console.WriteLine(maxdeger);
            //Console.WriteLine(mindeger);
            //Console.ReadLine();
            //Uygulama 2 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Short veri tipi: -32768 ile 32767 arasındaki değerleri tanımlayabilmektedir.

            //short birinci = -50;
            //short ikinci = -25500;
            //short ucuncu = -2345;
            //short maxdeger = short.MaxValue;
            //short mindeger = short.MinValue;

            //Console.WriteLine(birinci);
            //Console.WriteLine(ikinci);
            //Console.WriteLine(ucuncu);
            //Console.WriteLine(maxdeger);
            //Console.WriteLine(mindeger);
            //Console.ReadLine();
            //Uygulama 3 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // int veri tipi: -2.147.483.648 ile 2.147.483.647 arasındaki değerleri tanımlayabilmektedir.
            // 4 byte yer kaplar bellekte int

            //int birinci = 150000;
            //int ikinci = -500000;
            //int maxdeger = int.MaxValue;
            //int mindeger = int.MinValue;

            //Console.WriteLine(birinci);
            //Console.WriteLine(ikinci);
            //Console.WriteLine(maxdeger);
            //Console.WriteLine(mindeger);
            //Console.ReadLine();
            //Uygulama 4 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //long veri tipi: –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 arasında değer depolayabilmektedir.
            // 8 Byte ram bellekte yer kaplamaktadır. 

            //long birinci = 12134342124;
            //long ikinci = 7121274612874212;
            //long maxdeger = long.MaxValue;
            //long mindeger = long.MinValue;

            //Console.WriteLine(birinci);
            //Console.WriteLine(ikinci);  
            //Console.WriteLine(maxdeger);
            //Console.WriteLine(mindeger);
            //Console.ReadLine();
            //Uygulama 5 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Float veri tipi: Ondalıklı sayıları gösterir ve 7 8 basamağa kadar depolayabilir.

            //float ondalikli1 = 35.54f;
            //float ondalikli2 = 121.33221f;
            //float maxdeger = float.MaxValue;
            //float mindeger = float.MinValue;

            //Console.WriteLine(ondalikli1);
            //Console.WriteLine(ondalikli2);
            //Console.WriteLine(maxdeger);
            //Console.WriteLine(mindeger);
            //Console.ReadLine();
            //Uygulama 6 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Double veri tipi: 8 byte yer kaplar ve 15 basamaklı sayılara kadar ondalıklı sayıları tanımlayabilmektedir.

            //double ondalikli1 = 21.321;
            //double ondalikli2 = 1112.98303;
            //double maxdeger = double.MaxValue;
            //double mindeger = double.MinValue;

            //Console.WriteLine(ondalikli1);
            //Console.WriteLine(ondalikli2);
            //Console.WriteLine(maxdeger);
            //Console.WriteLine(mindeger);
            //Console.ReadLine();
            //Uygulama 7 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Char veri tipi: Tek bir karakteri tutmak için kullanılır. 'a' tek tırnakla tutulmalıdır.

            //char karakter1 = 'z';
            //char karakter2 = 'e';
            //char karakter3 = 'k';
            //char karakter4 = 'i';

            //Console.WriteLine(karakter1);
            //Console.WriteLine(karakter2);
            //Console.WriteLine(karakter3);
            //Console.WriteLine(karakter4);
            //Console.ReadLine();
            //Uygulama 8 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // String veri tipi:

            //string isim = "Zekeriya";
            //string isim2 = "Gamze";
            //string metin = "Zekeriya Gamze'ye sürpriz yapacak :)";

            //Console.WriteLine(isim);
            //Console.WriteLine(isim2);
            //Console.WriteLine(metin);
            //Console.ReadLine();
            //Uygulama 9 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //bool veri tipi: Sadece tek bir karakteri tutmaya yarar.

            //bool kontrol1 = false;
            //bool kontrol2 = true;
            //bool sonuc1 = 3 > 1;
            //bool sonuc2 = 3 < 1;

            //Console.WriteLine(sonuc1);
            //Console.WriteLine(sonuc2);
            //Console.ReadLine();
            //Uygulama 10 bitti. 

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Object veri tipi: Her şeyi içerisinde tutabilir. Bool, int, string....

            //object a = 3;
            //object b = "Gamze";
            //object c = 'G';
            //object d = 3.21;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.ReadLine();
            //Uygulama 11 bitti. 

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Toplama ve çıkarma operatörleri: 
            //int sayi1 = 5;
            //int sayi2 = 12;
            //int sonuc = sayi1 + sayi2;

            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            //int sayi1 = 5;
            //int sayi2 = 20;
            //int sayi3 = 30;
            //int sayi4 = 12;
            //int sonuc = (sayi1 + sayi2 + sayi3) - sayi4;

            //Console.WriteLine(sonuc);
            //Console.ReadLine();
            //Uygulama 12 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Çarpma ve bölme operatörleri:
            //int sayi1 = 7;
            //int sayi2 = 6;
            //int sonuc = sayi1 * sayi2;

            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            //int sayi1 = 20;
            //int sayi2 = 10;
            //int sonuc = sayi1/sayi2;

            //Console.WriteLine(sonuc);
            //Console.ReadLine();
            //Uygulama 13 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Mod alma % operatörü:
            //int sayi1 = 20;
            //int sayi2 = 3;

            //Console.WriteLine(sayi1%sayi2);  // İnt ile illa tanımlamak gerekmiyor direkt Cw içine de bu şekilde yazılabilmektedir. Buna da dikkat edelim.
            //Console.ReadLine();
            //Uygulama 14 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Arttırma ve azaltma operatörleri:

            //int sayi = 20;
            //sayi++;
            //sayi--;
            //Console.WriteLine(sayi);
            //Console.ReadLine();
            //Uygulama 15 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Eşittir operatörü: ==

            //int sayi1 = 2;
            //int sayi2 = 2;

            //bool kontrolet = 2 == 2;
            //Console.WriteLine(kontrolet);
            //Console.ReadLine();
            //Uygulama 16 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Eşit değildir operatörü: !=

            //int sayi1 = 2;
            //int sayi2 = 5;

            //bool KontrolEt = sayi1 != sayi2;
            //Console.WriteLine(KontrolEt);
            //Console.ReadLine();
            //Uygulama 17 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Büyüktür ve büyük eşittir operatörü: >, >=

            //int yas = 18;

            //bool kontrolet = yas >= 18;

            //Console.WriteLine(kontrolet);
            //Console.ReadLine();
            //ya da bunu büyüktür operatörü ile de yapabilirdim.
            //Uygulama 18 bitti. 

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Küçüktür ve küçük eşittir operatörleri: <, <= 

            //int yas = 15;
            //bool KontrolEt = yas < 14;
            //Console.WriteLine(KontrolEt);
            //Console.ReadLine();
            // Ya da bunu küçük eşittir kullanarak da yapabilirdik. 
            //Uygulama 19 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Ve operatörü: & simgesi budur. && olarak kullanılır. 2 adet koyulmalıdır.

            //int sayi1 = 5;
            //int sayi2 = 5;
            //int sayi3 = 10;

            //bool KontrolEt = sayi1 == sayi2 && sayi1 < sayi3;

            //Console.WriteLine(KontrolEt);
            //Console.ReadLine();
            //Uygulama 20 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Veya operatörü: "|" sembolü budur. Kullanılırken || şeklinde iki tane koyulmalıdır. Aynı ve(&&) operatörü gibi.

            //int sayi1 = 2;
            //int sayi2 = 3;
            //int sayi3 = 4;

            //bool KontrolEt = sayi3 == sayi1 || sayi1 > sayi2;

            //Console.WriteLine(KontrolEt);
            //Console.ReadLine();
            //Uygulama 21 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Değildir operatörü: ! şeklinde kullanılır.

            //bool a = true;

            //Console.WriteLine(!a);
            //Console.ReadLine();
            //Uygulama 22 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Ek operatörler: += -= *= /= 

            //int a = 6;

            //a = a + 3;

            //a += 3;

            //a = a - 3;

            //a -= 3;

            //a = a * 3;

            //a *= 3;

            //a = a / 3;

            //a /= 3;

            //Console.WriteLine("a'nın değeri:"+a); // Burada a değerinin yanına + koymamızın sebebi iki farklı işlemi birleştirmek içindir. Yoksa kodumuz bize hata verecektir.
            //Console.ReadLine();
            //Uygulama 23 bitti. 

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Kullanıcıdan değer alma Console.readline(); ile 

            //Console.WriteLine("Adınızı Giriniz : ");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Soyadınız Giriniz : ");
            //string soyisim = Console.ReadLine();

            //Console.WriteLine("Kullancının Adı : "+ isim);
            //Console.WriteLine("Kullancının Soyadı :"+  soyisim);
            //Console.WriteLine("Verdiğiniz bilgilerden dolayı teşekkür ederiz.");
            //Console.ReadLine();
            //Uygulama 24 bitti. 

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Tür dönüşümleri nedir nasıl yapılır ?

            //int a = 5;
            //byte b = (byte)a;

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(b);
            //Console.ReadLine();

            //string sayi1 = "2";
            //string sayi2 = "3";

            //int a = int.Parse(sayi1);
            //int b = int.Parse(sayi2);
            //Console.WriteLine(a + b);
            //Console.ReadLine();

            //Stringten int'e Dönüştürme int.Parse ile

            //string sayi1 = "3";
            //string sayi2 = "4";

            //int a = int.Parse(sayi1);
            //int b = int.Parse(sayi2);

            //Console.WriteLine(a+b);
            //Console.ReadLine();

            // STRİNG VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME      Convert.ToInt ile 

            //string sayi1 = "5";
            //string sayi2 = "10";
            //int a = Convert.ToInt32(sayi1);
            //int b = Convert.ToInt32(sayi2);
            //Console.WriteLine(a + b);   
            //Console.ReadLine();

            //İNT VERİ TİPİNDEN STRİNGE DÖNÜŞTÜRME :

            //int sayi1 = 5;
            //int sayi2 = 10;

            //string a = sayi1.ToString();
            //string b = sayi2.ToString();

            //Console.WriteLine(a+b);
            //Console.WriteLine(b+a);
            //Console.ReadLine(); 

            // DOUBLE VERİ TİPİNDEN İNT E DÖNÜŞTÜRME

            //double sayi = 5.33;
            //int a = Convert.ToInt32(sayi);

            //Console.WriteLine(a);
            //Console.ReadLine();

            //KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLMAKTADIR. 

            //Console.WriteLine("Lütfen yaşınızı giriniz : ");

            //string kullanici_yas = Console.ReadLine();

            //int kullanici_yasInt = Convert.ToInt32(kullanici_yas);

            //Console.WriteLine(kullanici_yas);
            //Console.WriteLine(kullanici_yasInt);
            //Console.ReadLine();

            // Kullancıdan 2 tane sayı alan ve bu iki saynın toplamını yazdıran kod sistemini aşağıya yaz.

            //Console.WriteLine("birinci sayiyi giriniz");
            //string sayi1 = Console.ReadLine();

            //Console.WriteLine("ikinci sayiyi giriniz");
            //string sayi2 = Console.ReadLine();

            //int sayi1İnt = int.Parse(sayi1);
            //int sayi2İnt = int.Parse(sayi2);

            //Console.WriteLine("İki sayinin toplamı" + (sayi1İnt + sayi2İnt));
            //Console.ReadLine();
            //Uygulama 25 bitti. 

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //if ve else basit yapıları :
            //Öğrencinin notu 50 den büyükse başarılı değilse başarısız yazdıran kodu yazınız.

            //int not = 75;
            //if (not>50)
            //{
            //    Console.WriteLine("Dersi Geçtiniz");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Dersten kaldınız.");
            //    Console.ReadLine();
            //}
            //Uygulama 26 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //else if nedir ve çalışma mantığı nedir ?

            //Kullanıcıdan 3 adet not alan ve bu notların ortalamasını al
            //Eğer 80-100 arasında ise A+ yazdır
            //60-80 arasında ise A yazdır.
            //40-60 arasındaysa B+ yazdır.
            //20-40 arasında ise F yazdır.

            //Console.WriteLine("Lütfen 1. notu giriniz : ");

            //int not1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. notu giriniz : ");

            //int not2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. notu giriniz : ");

            //int not3 = Convert.ToInt32(Console.ReadLine());

            //int sonuc = (not1 + not2 + not3) / 3;

            //if (sonuc >= 80 && sonuc <= 100)
            //{
            //    Console.WriteLine("A+ aldınız.");
            //    Console.ReadLine();
            //}
            //else if (sonuc >= 60 && sonuc <= 79)
            //{
            //    Console.WriteLine("A aldınız.");
            //    Console.ReadLine();
            //}
            //else if (sonuc >= 40 && sonuc <= 59)
            //{
            //    Console.WriteLine("B+ aldınız.");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("F aldınız.");
            //    Console.ReadLine();
            //}
            //Uygulama 27 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //BASİT BİR MİNİ ATM UYGULAMASI YAPACAĞIZ.
            //Kullanıcıya ne yapmak isediğini soracağız.
            //1) bakiye görüntüleme
            //2 ) Para çekme 
            // 3 ) Para yatırma 
            // Q ya basınca da çıkış yaptıracağız.

            //int bakiye = 10000;

            //Console.WriteLine("ATM'mize hoşgeldiniz.");
            //Console.WriteLine("Yapmak istediğiniz işlemi lütfen seçiniz:");

            //string secim =(Console.ReadLine());

            //if (secim == "1")
            //{
            //    Console.WriteLine("Bakiyeniz : ");
            //    Console.ReadLine();
            //}
            //else if (secim == "2")
            //{
            //    Console.WriteLine("Çekmek istediğiniz tutarı giriniz : ");
            //    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Kalan bakiyeniz : "+ (bakiye-cekilecek_tutar));
            //    Console.ReadLine();
            //    {
            //        if (cekilecek_tutar <= bakiye)
            //        {
            //            Console.WriteLine("Kalan bakiyeniz : " + (bakiye - cekilecek_tutar));
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bakiyenizden fazla para çekemezsiniz.");
            //            Console.ReadLine();
            //        }


            //    }
            //}
            //else if(secim == "3")
            //{
            //    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz : ");
            //    int yatirilacak_tutar = Convert.ToInt32((Console.ReadLine()));
            //    Console.WriteLine("Toplam bakiyeniz : " + (bakiye + yatirilacak_tutar));
            //    Console.ReadLine();
            //}
            //else if (secim=="Q")
            //{
            //    Console.WriteLine("ATM'den çıkış yapılıyor...");
            //    Console.WriteLine("Çıkış yapıldı. Sağlıklı günler dileriz...");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen geçerli bir değer giriniz : ");
            //    Console.ReadLine();
            //}
            //Uygulama 28 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Beden kitle indesi : kilo/(boy*boy)
            //Beden kitle indeksi 18 den küçük ise zayıf
            //Beden kitle indeksi 18 25 aralığında ise normal 
            // Beden kitle indeksi 25 ten büyükse kişi şişmandır.

            //Console.WriteLine("Kilonuzu giriniz : ");
            //int kilo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Boyunuzu giriniz : ");
            //double boy = Convert.ToDouble(Console.ReadLine());

            //double bke = kilo / (boy * boy);
            //if (bke < 18 ) 
            //{
            //    Console.WriteLine("Zayıfsınız.");
            //    Console.ReadLine();
            //}
            //else if(bke >=18 &&  bke <= 25)
            //{
            //    Console.WriteLine("Normalsiniz.");
            //    Console.ReadLine();
            //}
            //else if (bke > 25)
            //{
            //    Console.WriteLine("Şişmansınız.");
            //    Console.ReadLine();
            //}
            //Uygulama 29 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Switch ile uygulama ve bilgilendirme :
            //Mini ATM uygulamasını tekrar yapacağız ama bu sefer switch case ile beraber yapalım.
            //1-) Bakiye yükleme 
            //2-) Para çekme 
            //3-) Para yatırma
            //4-) çıkış yap 
            // Bu 4 değer dışında verilen değerleri hatalı olarak kabul et.

            //int bakiye = 700;

            //Console.WriteLine("ATM'ye hoşgeldiniz...");
            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : ");
            //Console.WriteLine("1-) Bakiye görüntüle");
            //Console.WriteLine("2-) Para Çek");
            //Console.WriteLine("3-) Para Yatır");
            //Console.WriteLine("4-) Çıkış Yap");

            //string secim = Console.ReadLine();

            //switch (secim)
            //{
            //    case "1":
            //        Console.WriteLine("Bakiyeniz :" + bakiye);
            //        Console.ReadLine();
            //        break;
            //    case "2":
            //        Console.WriteLine("Çekmek istediğiniz tutar : ");
            //        int cekimtutari = Convert.ToInt32(Console.ReadLine());

            //        if (cekimtutari > bakiye)
            //        {
            //            Console.WriteLine("Bakiyenizden fazla para çekemezsiniz.");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kalan bakiyeniz" + (bakiye-cekimtutari));
            //            Console.ReadLine();
            //        }
            //        break;
            //    case "3":
            //        Console.WriteLine("Yatırmak istediğiniz tutar :");
            //        int yatirmatutar = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Yeni bakiyeniz :"+ (bakiye+yatirmatutar));
            //        Console.ReadLine() ;
            //        break ;
            //    case "4":
            //        Console.WriteLine("Hesabınızdan çıkış yapılıyor... Sağlıklı günler dileriz.");
            //        Console.ReadLine();
            //        break;
            //    default:
            //        Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            //        Console.ReadLine();
            //        break;
            //}
            //Case kısımlarında klavyeden yapılan tuşlama ile geçerli değere gidilir mesela case"2" gibi bir değer verilir ise biz klavyeden 2 ye bastığımızda case 2 içine girer ve onun içindeki işlemleri sırası ile yapar.
            //Default kısmında ise tanımlanan case değerlerinden farklı bir değer girilirse bilgilendirme amacı ile ekranda bir hata yazısı verdirmeye yaramaktadır.
            //Uygulama 30 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //For döngüsüne giriş ve örnekler :
            //1 den 10 a kadar olan sayıları alt alta ekrana yazdıran programı kodlayınız.

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //1 den 10 a kadar olan sayıları yazdıran kod

            //for (int i = 0; i<=10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //0 dan 10 a kadar olan çift sayıları yazdıran kod

            //for (int i = 1; i<= 10; i++)
            //{
            //    for(int j = 1; j<=i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadLine();
            //Uygulama 31 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //While döngüsü : For döngüsünün bir alternatifidir.
            //1 den 10 a kadar olan sayıların alt alta dizilimini veren kodu yaz

            //int a = 1;

            //while (a <= 10)       {
            //    Console.WriteLine(a);
            //    a++;    // Eğer bu arrtırma operatörünü kullanmaz isek sonsuz bir döngü içinde sadece a değerini görürüz.
            //}
            //Console.ReadLine();

            //10 dan 0 a kadar olan sayılardan çift olanları ekrana veren kodu yaz.

            //int a = 10;

            //while (a>=0) 
            //{
            //    Console.WriteLine(a);
            //    a -= 2;     // a=a-2 de yazılabilir. Bunu da unutmayalım. 
            //}
            //Console.ReadLine();

            //Uygulama 32 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Do while döngüsü : 

            //1 den 10 a kadar olan sayıların alt alta dizilimini veren kodu yaz 

            //int a = 1;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //} while (a<=10);
            //Console.ReadLine() ;

            //1 den 100 e kadar olan sayıların toplamını veren kodu yaz. 
            //int a = 1;
            //int toplam = 0;

            //do
            //{
            //    toplam += a;
            //    a++;

            //} while (a<=100);
            //Console.WriteLine("1'den 100'e kadar olan sayıların toplamı : " + toplam);
            //Console.ReadLine(); 

            //Uygulama 33 bitti. 

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Break ve Continue anahtar kelimeleri :

            //for (int a = 1; a<=10; a++)
            //{
            //    if (a == 7)
            //    {
            //        break;      //Döngü 7 ye geldiğinde işlemi kırar ve ekranda en son 6 sayısı yazar.
            //    }
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();

            //Uygulama 34 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Çarpım tablosu örneği for döngüsü ile :

            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine(i + "x" + j + "=" + (i * j));
            //    }
            //}
            //Console.ReadLine();
            //Uygulama 35 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Kullanıcı giriş sayfası uygulaması yapacağız.
            //Kullanıcı bilgileri doğru girerse Tebrikler Başarılı Bir Şekilde Giriş Yaptınız.
            //Yanlış girerse 3 hak tanıyalım ve döngü bu 3 hak bitene kadar devam etsin. 

            //int haksayisi = 3;

            //while (true) 
            //{
            //    Console.WriteLine("Kullanıcı adını giriniz : ");
            //    string kullaniciadi = Console.ReadLine();
            //    Console.WriteLine("Şifrenizi giriniz : ");
            //    string sifre = Console.ReadLine();
            //    if(kullaniciadi == "Gamze" && sifre=="123")
            //    { 
            //            Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız :)");
            //            break; 
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yanlış kullanıcı adı veya şifre. Tekrar deneyiniz.");

            //        if (haksayisi > 0)
            //        {
            //            haksayisi -= 1;
            //        }
            //    }
            //    if (haksayisi == 0)
            //    {
            //        Console.WriteLine("Hakkınız bitmiştir. Bir daha giriş yapamazsınız.");
            //        break;
            //    }
            //}
            //Console.ReadLine();
            //Uygulama 36 bitti. 

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Kullanıcıdan bir sayı alacağız 0 dan başlayıp aldığımız sayıya kadar toplayacağız ve girdiği sayıya
            //böleceğiz eğer ortalama 50 den büyükse 50 den büyüktür küçükse 50 den küçüktür
            //şeklinde ekrana yazdıracağız.


            //Console.WriteLine("Bir sayı giriniz : ");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    toplam += sayi;
            //}
            //double ortalama = toplam / sayi;

            //if(ortalama > 50) 
            //{
            //    Console.WriteLine("Ortalamanız 50'den büyüktür.");
            //    Console.ReadLine(); 
            //}
            //else if (ortalama == 50)
            //{
            //    Console.WriteLine("Ortalamanız 50'dir.");
            //    Console.ReadLine(); 
            //}
            //else
            //{
            //    Console.WriteLine("Ortalamanız 50'den küçüktür.");
            //    Console.ReadLine();
            //}
            //Uygulama 37 bitti. 

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //DİZİLER : [] parantez yardımı ile diziler oluşturulur. Atanan bir değişkenin birden fazla değer tutabilmesini sağlar.

            //int[] sayilar = new int[4];

            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;
            //sayilar[3] = 4;

            //for (int i = 0; i < sayilar.Length; i++) //Length dediğimiz şey dizinin uzunluğunu temsil eder. Yani döngünün 4 sefer dönmesini sağlar.
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.ReadLine();

            //Uygulama 38 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Uygulama 37 nin bir benzerini yapcaz ama bu sefer string char ve double veri tipleri ile :

            //string[] isimler = { "Zekeriya", "Cemile", "Mustafa", "Gamze" };

            //Console.WriteLine(isimler[3]);      //Hepsini yazdırmayacak isek for döngüsü kullanmadan bu şekilde de yapılabilir.
            //Console.ReadLine();

            //Char ve double da da aynı mantık geçerlidir. Onun için örnek koymayacağım.
            //Uygulama 39 bitti.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Dizinin elemanlarını kullanıcıdan alacağız.

            //int[] sayilar = new int[4];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine("Dizinin"+(i+0)+".index değerini giriniz : ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());     //Buradaki for döngüsünü kullanıcının değerleri kendisinin girebilmesi için oluşturduk.

            //}
            //Console.WriteLine("************************");

            //for (int i = 0; i<sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.ReadLine();

            //Uygulama 40 bitt. 

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //ForEach Döngüsü : 

            //string[] isimler = { "Zekeriya", "Nazlıgül", "Elçi", "Gamze", "Ayata" };

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);     // Burada köşeli parantez içine yazdığımız değerler bize index olarak dönmektedir. Bunu o yüzden yazmak zorundayız. 
            //}
            //Console.ReadLine();

            //Bunu şimdi de foreach döngüsü ile beraber yapmaya çalışalım : 

            //string[] isimler = { "Zekeriya", "Nazlıgül", "Elçi", "Gamze", "Ayata" };

            //foreach (string a in isimler)
            //{
            //    Console.WriteLine(a);

            //}
            //Console.ReadLine();

            //Uygulama 42 bitti. 

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Kullanıcının girdiği sayı dizi içinde var mı ? Kontrol eden varsa kaç tane olduğunu söyleyen yoksa da
            //Yoktur diye uyaran programı kodlayınız. 

            //int[] sayilar = { 10, 20, 30, 10, 10, 20, 30, 5, 85, 40, 19, 36, 74, 50, 60, 30, 25, 70, 15, 25, 65, 65, 45, 45, 40, 40, 75 };
            //int adet = 0;
            //int sayi;

            //Console.Write("Lütfen bir sayı giriniz : ");
            //sayi = Convert.ToInt32(Console.ReadLine());   

            //for (int i = 0; i<sayilar.Length; i++)
            //{
            //    if (sayi == sayilar[i])
            //    {
            //        adet++;
            //    }
            //}
            //if (adet == 0)
            //{
            //    Console.WriteLine("Girdiğiniz değer dizide bulunamadı");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı dizide bulundu.");
            //    Console.WriteLine("Adet : "+ adet);
            //}
            //Console.ReadLine() ;

            //Uygulama 43 bitti.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++


            //int[] sayi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //int enb = sayi[0];

            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    if (sayi[i] > enb)
            //    {
            //        enb = sayi[i];
            //    }
            //}
            //Console.WriteLine("En büyük sayınız : " + enb );
            //Console.ReadLine();

            //Uygulama 44 bitti. 

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Dizideki birden fazla terkar eden sayıların kaç tane olduğunu bulunuz.

            /*int[] dizi1 = { 8, 5, 8, 9, 9, 10 };
            int sayi = 0;
            int tekrarSayisi = 0;
            int geciciTekrar = 1;

            for (int i = 0; i < dizi1.Length - 1; i++)
            {
                if (dizi1[i] == dizi1[i + 1])
                {
                    geciciTekrar++;
                }
                if (i == dizi1.Length - 2 || dizi1[i] != dizi1[i + 1])
                {
                    tekrarSayisi = geciciTekrar;
                    sayi = dizi1[i];
                    if (geciciTekrar > tekrarSayisi)
                    {
                        tekrarSayisi = geciciTekrar;
                        sayi = dizi1[i];
                    }
                    geciciTekrar = 1;
                }
            }

            Console.WriteLine(sayi + "Sayısı en çok tekrarlanmıştır. Ve bu sayı " + tekrarSayisi + "kez tekrar edilmiştir.");
            Console.ReadLine();*/

            /*for (int i = 5;i>=1; i--)
            {
                for(int j = 0;j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }*/

            //Burada yıldızları 5 yıldızdan 1 yıldıza kadar alt alta örüntü şeklinde oruşturuyoruz...

            


        }
    }
}