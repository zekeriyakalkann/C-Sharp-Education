using System;

public class Düğüm
{
    public int Veri;
    public Düğüm Sonraki;

    public Düğüm(int veri)
    {
        Veri = veri;
        Sonraki = null;
    }
}

public class TekYonluBagliListe
{
    private Düğüm bas;

    // Ekleme işlemi (Listenin sonuna ekleme)
    public void Ekle(int veri)
    {
        Düğüm yeniDüğüm = new Düğüm(veri);
        if (bas == null)
        {
            bas = yeniDüğüm;
        }
        else
        {
            Düğüm geçici = bas;
            while (geçici.Sonraki != null)
            {
                geçici = geçici.Sonraki;
            }
            geçici.Sonraki = yeniDüğüm;
        }
    }

    // Silme işlemi (Belirli bir değeri silme)
    public void Sil(int veri)
    {
        if (bas == null) return;

        if (bas.Veri == veri)
        {
            bas = bas.Sonraki;
            return;
        }

        Düğüm geçici = bas;
        while (geçici.Sonraki != null && geçici.Sonraki.Veri != veri)
        {
            geçici = geçici.Sonraki;
        }

        if (geçici.Sonraki != null)
        {
            geçici.Sonraki = geçici.Sonraki.Sonraki;
        }
    }

    // Arama işlemi
    public bool Ara(int veri)
    {
        Düğüm geçici = bas;
        while (geçici != null)
        {
            if (geçici.Veri == veri)
                return true;
            geçici = geçici.Sonraki;
        }
        return false;
    }

    // Listeleme işlemi
    public void Yazdır()
    {
        Düğüm geçici = bas;
        while (geçici != null)
        {
            Console.Write(geçici.Veri + " ");
            geçici = geçici.Sonraki;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        TekYonluBagliListe liste = new TekYonluBagliListe();

        liste.Ekle(10);
        liste.Ekle(20);
        liste.Ekle(30);
        liste.Yazdır(); // Çıktı: 10 20 30

        liste.Sil(20);
        liste.Yazdır(); // Çıktı: 10 30

        Console.WriteLine(liste.Ara(30)); // Çıktı: True
        Console.WriteLine(liste.Ara(40)); // Çıktı: False

        Console.ReadKey();
    }
}
//Benim bu hayattaki amacım nedir ? Kendimi nasıl geliştirebilirim ? Beyin yoksunluğu yaşamamak için neler yapılabilir? 
//Annem gaddar mı ? Babamın bu hayattaki amacı nedir ? 


