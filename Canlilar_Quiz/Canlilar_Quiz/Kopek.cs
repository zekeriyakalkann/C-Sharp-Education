using System;

class Kopek : Hayvan
{
    // Özel değişkenler (private fields)
    private string tuyUzunlugu;

    // Yapıcı metotlar (constructors)
    public Kopek() : base()
    {
        tuyUzunlugu = "Bilinmiyor";
    }

    public Kopek(string isim) : base(isim)
    {
        tuyUzunlugu = "Bilinmiyor";
    }

    public Kopek(string isim, int yas, string tur, string cinsiyet, string renk, string tuyUzunlugu) : base(isim, yas, tur, cinsiyet, renk)
    {
        this.tuyUzunlugu = tuyUzunlugu;
    }

    // Özellikler (properties) - Kapsülleme (encapsulation)
    public string TuyUzunlugu
    {
        get { return tuyUzunlugu; }
        set { tuyUzunlugu = value; }
    }

    // Metotlar
    public void Havla()
    {
        Console.WriteLine("Köpek havlıyor...");
    }

    public void Kos()
    {
        Console.WriteLine("Köpek koşuyor...");
    }
}

