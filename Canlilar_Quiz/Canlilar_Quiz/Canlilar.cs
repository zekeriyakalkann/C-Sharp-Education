using System;

class Canlilar
{
    // Özel değişkenler (private fields)
    private string isim;
    private int yas;
    private string tur;

    // Yapıcı metotlar (constructors)
    public Canlilar()
    {
        isim = "Bilinmiyor";
        yas = 0;
        tur = "Bilinmiyor";
    }

    public Canlilar(string isim)
    {
        this.isim = isim;
        yas = 0;
        tur = "Bilinmiyor";
    }

    public Canlilar(string isim, int yas, string tur)
    {
        this.isim = isim;
        this.yas = yas;
        this.tur = tur;
    }

    // Özellikler (properties) - Kapsülleme (encapsulation)
    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }

    public int Yas
    {
        get { return yas; }
        set { yas = value; }
    }

    public string Tur
    {
        get { return tur; }
        set { tur = value; }
    }

    // Metotlar
    public void BilgiVer()
    {
        Console.WriteLine($"İsim: {isim}, Yaş: {yas}, Tür: {tur}");
    }

    public void SesCikar()
    {
        Console.WriteLine("Canlı ses çıkarıyor...");
    }
}


