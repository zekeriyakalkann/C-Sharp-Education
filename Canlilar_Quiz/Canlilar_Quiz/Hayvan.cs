using System;

class Hayvan : Canlilar
{
    // Özel değişkenler (private fields)
    private string cinsiyet;
    private string renk;

    // Yapıcı metotlar (constructors)
    public Hayvan() : base()
    {
        cinsiyet = "Bilinmiyor";
        renk = "Bilinmiyor";
    }

    public Hayvan(string isim) : base(isim)
    {
        cinsiyet = "Bilinmiyor";
        renk = "Bilinmiyor";
    }

    public Hayvan(string isim, int yas, string tur, string cinsiyet, string renk) : base(isim, yas, tur)
    {
        this.cinsiyet = cinsiyet;
        this.renk = renk;
    }

    // Özellikler (properties) - Kapsülleme (encapsulation)
    public string Cinsiyet
    {
        get { return cinsiyet; }
        set { cinsiyet = value; }
    }

    public string Renk
    {
        get { return renk; }
        set { renk = value; }
    }

    // Metotlar
    public void HareketEt()
    {
        Console.WriteLine("Hayvan hareket ediyor...");
    }

    public void Beslen()
    {
        Console.WriteLine("Hayvan besleniyor...");
    }
}


