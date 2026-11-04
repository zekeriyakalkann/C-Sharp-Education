using System;

class Kedi : Hayvan
{
    // Özel değişkenler (private fields)
    private string tuyRengi;

    // Yapıcı metotlar (constructors)
    public Kedi() : base()
    {
        tuyRengi = "Bilinmiyor";
    }

    public Kedi(string isim) : base(isim)
    {
        tuyRengi = "Bilinmiyor";
    }

    public Kedi(string isim, int yas, string tur, string cinsiyet, string renk, string tuyRengi) : base(isim, yas, tur, cinsiyet, renk)
    {
        this.tuyRengi = tuyRengi;
    }

    // Özellikler (properties) - Kapsülleme (encapsulation)
    public string TuyRengi
    {
        get { return tuyRengi; }
        set { tuyRengi = value; }
    }

    // Metotlar
    public void Miyavla()
    {
        Console.WriteLine("Kedi miyavlıyor...");
    }

    public void Tirman()
    {
        Console.WriteLine("Kedi tırmanıyor...");
    }
}


