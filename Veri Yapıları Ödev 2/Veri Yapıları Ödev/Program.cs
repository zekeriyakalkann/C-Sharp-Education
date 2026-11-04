using System;

class DersNode
{
    public string DersKodu { get; set; }   
    public string HarfNotu { get; set; }   
    public DersNode NextDers { get; set; } 

    public DersNode(string dersKodu, string harfNotu)
    {
        DersKodu = dersKodu;
        HarfNotu = harfNotu;
        NextDers = null;
    }
}

class OgrenciNode
{
    public int OgrenciNo { get; set; }     
    public DersNode DerslerHead { get; set; }  
    public OgrenciNode NextOgrenci { get; set; } 

    public OgrenciNode(int ogrenciNo)
    {
        OgrenciNo = ogrenciNo;
        DerslerHead = null;
        NextOgrenci = null;
    }

    public void DersEkle(string dersKodu, string harfNotu)
    {
        DersNode yeniDers = new DersNode(dersKodu, harfNotu);
        if (DerslerHead == null)
        {
            DerslerHead = yeniDers;
        }
        else
        {
            DersNode temp = DerslerHead;
            while (temp.NextDers != null)
            {
                temp = temp.NextDers;
            }
            temp.NextDers = yeniDers;
        }
    }
}

class OgrenciListesi
{
    private OgrenciNode Head;

    public OgrenciListesi()
    {
        Head = null;
    }

    public void OgrenciEkle(int ogrenciNo)
    {
        OgrenciNode yeniOgrenci = new OgrenciNode(ogrenciNo);
        if (Head == null)
        {
            Head = yeniOgrenci;
        }
        else
        {
            OgrenciNode temp = Head;
            while (temp.NextOgrenci != null)
            {
                temp = temp.NextOgrenci;
            }
            temp.NextOgrenci = yeniOgrenci;
        }
    }

    public OgrenciNode OgrenciBul(int ogrenciNo)
    {
        OgrenciNode temp = Head;
        while (temp != null)
        {
            if (temp.OgrenciNo == ogrenciNo)
                return temp;
            temp = temp.NextOgrenci;
        }
        return null;
    }

    public void DersEkle(int ogrenciNo, string dersKodu, string harfNotu)
    {
        OgrenciNode ogrenci = OgrenciBul(ogrenciNo);
        if (ogrenci != null)
        {
            ogrenci.DersEkle(dersKodu, harfNotu);
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı.");
        }
    }

    public void Listele()
    {
        OgrenciNode tempOgrenci = Head;
        while (tempOgrenci != null)
        {
            Console.WriteLine($"Öğrenci No: {tempOgrenci.OgrenciNo}");
            DersNode tempDers = tempOgrenci.DerslerHead;
            while (tempDers != null)
            {
                Console.WriteLine($"  Ders: {tempDers.DersKodu}, Harf Notu: {tempDers.HarfNotu}");
                tempDers = tempDers.NextDers;
            }
            tempOgrenci = tempOgrenci.NextOgrenci;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        OgrenciListesi ogrenciListesi = new OgrenciListesi();

        Console.Write("Kaç öğrenci gireceksiniz?: ");
        int ogrenciSayisi = int.Parse(Console.ReadLine());

        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.Write($"Öğrenci {i + 1}'in numarasını giriniz: ");
            int ogrenciNo = int.Parse(Console.ReadLine());
            ogrenciListesi.OgrenciEkle(ogrenciNo);

            Console.Write("Bu öğrencinin kaç dersi var?: ");
            int dersSayisi = int.Parse(Console.ReadLine());

            for (int j = 0; j < dersSayisi; j++)
            {
                Console.Write($"Ders {j + 1} kodunu giriniz: ");
                string dersKodu = Console.ReadLine();

                Console.Write($"Ders {j + 1} harf notunu giriniz: ");
                string harfNotu = Console.ReadLine();

                ogrenciListesi.DersEkle(ogrenciNo, dersKodu, harfNotu);
            }
        }

        Console.WriteLine("\nTüm öğrenciler ve ders bilgileri:");
        ogrenciListesi.Listele();
    }
}


