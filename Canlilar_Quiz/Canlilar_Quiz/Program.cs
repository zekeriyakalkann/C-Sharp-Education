using System;

class Program
{
    static void Main(string[] args)
    {
        // Canlılar sınıfı örneği
        Canlilar canli = new Canlilar("Ali", 5, "İnsan");
        canli.BilgiVer();
        canli.SesCikar();

        // Hayvan sınıfı örneği
        Hayvan hayvan = new Hayvan("Kopek", 3, "Memeli", "Erkek", "Kahverengi");
        hayvan.BilgiVer();
        hayvan.HareketEt();
        hayvan.Beslen();

        // Kedi sınıfı örneği
        Kedi kedi = new Kedi("Mırmır", 2, "Memeli", "Dişi", "Beyaz", "Uzun");
        kedi.BilgiVer();
        kedi.Miyavla();
        kedi.Tirman();
        Console.WriteLine("Kedi sınıfı, Hayvan ve Canlılar sınıfından türetilmiştir.");

        // Köpek sınıfı örneği
        Kopek kopek = new Kopek("Karabaş", 4, "Memeli", "Erkek", "Siyah", "Kısa");
        kopek.BilgiVer();
        kopek.Havla();
        kopek.Kos();
        Console.WriteLine("Köpek sınıfı, Hayvan ve Canlılar sınıfından türetilmiştir.");

        Console.ReadLine();
    }
}

