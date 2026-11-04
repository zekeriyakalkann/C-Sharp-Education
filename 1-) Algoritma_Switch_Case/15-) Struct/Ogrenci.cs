namespace _15___Struct
{
    public struct Ogrenci   //Değer tipli olarak çalışır.
    {
        public Ogrenci(int numara, string adi, string soyAdi, bool cinsiyet=true)
        {
            //Console.WriteLine("Otomatik Çalıştı.");   Bu kısımda bu constructor kaç kere çalışır ise bu yazıyı her seferinde en başa yazma özelliğine sahiptir.
            Numara = numara;
            Adi = adi;
            SoyAdi = soyAdi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } //Property - İlk özelliğimizi tanımlamış olduk
        public string Adi {  get; set; }
        public string SoyAdi { get; set; }
        public bool Cinsiyet { get; set; }

        //Geçersiz kılmak - Ezmek - Override 

        public override string ToString()
        {
            return $"{Numara} " +
                $"{Adi} " +
                $"{SoyAdi} " +
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }
}


//Numaraya 10 değerini atama işlemini set; yolu ile yaptık. Bu kapsülleme olarak da geçmektedir.
//Get komutu ise bu satırlar içerisinde yapılan işlemleri okumaya yarar. Set ifadesi kaldırılır ise main metodu
//içerisindeki atama işlemini gerçekleştiremeyiz. Heap bölgede 2 ayrı değişken tek bir ifadeyi gösterse dahi 
//bellekte yani heap bölgede ayrı ayrı tutulacağından bu değer tipli davranış olarak adlandırılır. Yani bir değişkende 
//değeri değiştirir isek öbür değişkende değer tipli davranışa özgü olarak bir değişim gözleyemeyiz. Referans tipli
//davranışta bu durum tersine dönmektedir.