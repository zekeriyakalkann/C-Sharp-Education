using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64__Classalr
{
    public class Musteri
    {
        //Müşterinin temel bilgilerini burada saklayacağız.
        /*
         * TC kimlik numarası
         * İsim
         * Soyisim
         * Cinsiyet
         * 
         * şeklinde şimdilik bu kısmı sınırlandırabiliriz.
         */

        //Yapıcı Metot: 

        public Musteri()    //Classın başlangıç durumunu ayaralamak ve örnek oluşturma sürecinde gerekli başlatma işlemlerini gerçekleştirmek için kullanılır.
        {
            //TCkimliknumarasi = "23647771289";   //Bu işleme ezme adı verilir. Veriyi istediğimiz default değere çevirmemize yaramaktadır.
            //Bu şekilde yorum satırı haline getirdiğimizde değerler default olarak kalır.
        }
        public Musteri(string _tckimlikno)
        {
            TCkimliknumarasi = _tckimlikno;
        }

        public Musteri(string _tckimlikno, string _isim)
        {
            TCkimliknumarasi = _tckimlikno;
            isim = _isim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TCkimliknumarasi = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }
        //Bu kısımda yapıcı metotların bir kaç farklı kısmını görmüş olduk. Bunlara göre işlemleri yapacağız.


        //Burada müşteri sınfımızı tanımladık ve altına müşteri için gerekli olan verileri yazdık. Şimdi ise bunların
        //tanımlamasını yapacağız: 

        public string isim;
        public string soyisim;
        public string TCkimliknumarasi;
        public int cinsiyet; //101101 ise Erkek 101102 ise Kadın olarak adlandırmasını yapacağız. Burayı farklı bir kısımda kullanacağımız için bu şekilde bir tanımlama yaptık.

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TCkimliknumarasi);
            return kontrol;
        }

        private bool MusteriKontrolDatabase(string tckimliknumarasi)
        {
            //Database e gidilir. Müşterinin tc sine göre daha önce kayıt edilip edilmediği bilgisi sorgulanır.

            return true;
        }

    }
}
