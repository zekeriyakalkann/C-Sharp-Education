using System;
using System.Collections.Generic;

// Kitap sınıfı: Kapsülleme örneği
public class Kitap
{
    // Private alanlar
    private string baslik;
    private string yazar;

    // Constructor: Kitap nesnesi oluşturmak için kullanılır
    public Kitap(string baslik, string yazar)
    {
        this.baslik = baslik;
        this.yazar = yazar;
    }

    // Public özellikler: Kitap bilgilerini dışarıya açar
    public string Baslik
    {
        get { return baslik; }
        set { baslik = value; }
    }

    public string Yazar
    {
        get { return yazar; }
        set { yazar = value; }
    }

    // Kitap bilgilerini yazdıran yöntem
    public void BilgileriYazdir()
    {
        Console.WriteLine("Başlık: " + baslik + ", Yazar: " + yazar);
    }
}

// Kullanıcı sınıfı: Kapsülleme örneği
public class Kullanici
{
    // Private alanlar
    private string isim;
    private List<Kitap> oduncAlinanKitaplar;

    // Constructor: Kullanıcı nesnesi oluşturmak için kullanılır
    public Kullanici(string isim)
    {
        this.isim = isim;
        this.oduncAlinanKitaplar = new List<Kitap>();
    }

    // Public özellik: Kullanıcı ismini dışarıya açar
    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }

    // Public özellik: Kullanıcının ödünç aldığı kitapların listesini dışarıya açar
    public List<Kitap> OduncAlinanKitaplar
    {
        get { return oduncAlinanKitaplar; }
    }

    // Kullanıcının bir kitabı ödünç almasını sağlayan yöntem
    public void KitapOduncAl(Kitap kitap)
    {
        oduncAlinanKitaplar.Add(kitap);
    }

    // Kullanıcının ödünç aldığı kitapları yazdıran yöntem
    public void OduncAlinanKitaplariYazdir()
    {
        Console.WriteLine(isim + " tarafından ödünç alınan kitaplar:");
        foreach (Kitap kitap in oduncAlinanKitaplar)
        {
            kitap.BilgileriYazdir();
        }
    }
}

// Arayüz: Kitap ödünç verme işlemleri için soyutlama
public interface IKitapOduncVerme
{
    void KitapOduncAl(Kullanici kullanici, Kitap kitap);
    void KitapIadeEt(Kullanici kullanici, Kitap kitap);
}

// Kütüphane sınıfı: Kalıtım ve arayüz örneği
public class Kutuphane : IKitapOduncVerme
{
    // Private alan: Kütüphanedeki kitapların listesi
    private List<Kitap> kitaplar;

    // Constructor: Kütüphane nesnesi oluşturmak için kullanılır
    public Kutuphane()
    {
        kitaplar = new List<Kitap>();
    }

    // Kütüphaneye kitap ekleyen yöntem
    public void KitapEkle(Kitap kitap)
    {
        kitaplar.Add(kitap);
    }

    // Kullanıcının kütüphaneden kitap ödünç almasını sağlayan yöntem
    public void KitapOduncAl(Kullanici kullanici, Kitap kitap)
    {
        if (kitaplar.Contains(kitap))
        {
            kullanici.KitapOduncAl(kitap);
            kitaplar.Remove(kitap);
            Console.WriteLine(kullanici.Isim + " kitabı ödünç aldı: " + kitap.Baslik);
        }
        else
        {
            Console.WriteLine("Kitap mevcut değil: " + kitap.Baslik);
        }
    }

    // Kullanıcının kitabı iade etmesini sağlayan yöntem
    public void KitapIadeEt(Kullanici kullanici, Kitap kitap)
    {
        if (kullanici.OduncAlinanKitaplar.Contains(kitap))
        {
            kullanici.OduncAlinanKitaplar.Remove(kitap);
            kitaplar.Add(kitap);
            Console.WriteLine(kullanici.Isim + " kitabı iade etti: " + kitap.Baslik);
        }
        else
        {
            Console.WriteLine(kullanici.Isim + " bu kitabı ödünç almamış: " + kitap.Baslik);
        }
    }

    // Kütüphanedeki kitapları listeleyen yöntem
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki kitaplar:");
        foreach (Kitap kitap in kitaplar)
        {
            kitap.BilgileriYazdir();
        }
    }
}

// Program sınıfı: Uygulamanın çalıştırıldığı ana sınıf
class Program
{
    static void Main()
    {
        // Kütüphane ve kullanıcılar oluşturulur
        Kutuphane kutuphane = new Kutuphane();
        Kullanici kullanici1 = new Kullanici("Ali");
        Kullanici kullanici2 = new Kullanici("Ayşe");

        // Kütüphaneye kitaplar eklenir
        Kitap kitap1 = new Kitap("1984", "George Orwell");
        Kitap kitap2 = new Kitap("Hayvan Çiftliği", "George Orwell");

        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);

        // Kitaplar ödünç alınır ve iade edilir
        kutuphane.KitapOduncAl(kullanici1, kitap1);
        kutuphane.KitapOduncAl(kullanici2, kitap2);

        kullanici1.OduncAlinanKitaplariYazdir();
        kullanici2.OduncAlinanKitaplariYazdir();

        kutuphane.KitapIadeEt(kullanici1, kitap1);
        kutuphane.KitapIadeEt(kullanici2, kitap2);

        // Kütüphanedeki kitaplar listelenir
        kutuphane.KitaplariListele();

        // Programın sonunu beklemek için bir tuşa basılması beklenir
        Console.ReadKey();
    }
}
