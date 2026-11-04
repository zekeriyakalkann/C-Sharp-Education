using System;
using System.Net.Http.Headers;

public class Universite
{
    public string Adi;
    public int KurulusYili;

    // Yapıcı metot
    public Universite(string adi, int kurulusYili)
    {
        Adi = adi;
        KurulusYili = kurulusYili;
        Console.WriteLine($"Universite {Adi}, {KurulusYili} yılında kuruldu.");
    }
    ~Universite()
    {
        Console.WriteLine($"Universite {Adi} nesnesi yok ediliyor.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Universite Uni = new Universite("Bitlis Eren Üniversitesi",2007);   //Bu şekilde bir yapıcı metot kullanımında atamaları yaparak direk yazdırma işlemi yapılabilir.

        Console.WriteLine("Universite nesnesi ile yeni işlemler yapılıyor...");

        
        Console.ReadKey();
         
    }
}

