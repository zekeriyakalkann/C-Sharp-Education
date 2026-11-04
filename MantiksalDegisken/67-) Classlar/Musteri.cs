using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _65___Classlar
{
    public class Musteri
    {
        /*
         * TCkimlik numarası
         * İsim
         * Soyisim
         * Cinsiyet 
         */

        //Oluşturduğumuz nesnelerin kapladığı fieldda bir değer alması gerekmektedir. Bunu ise bize yapıcı metotlar sağlamaktadır.

        //YAPICI METOTLAR (CTOR kısayolu ile direk bir sınıfın yapıcı metodunu oluşturabilmekteyiz.)

        public Musteri()
        {
            //TCkimliknumara = "1234567890";
        }

        public Musteri(string _TCkimliknumara)
        {
            TCkimliknumara = _TCkimliknumara;
        }

        public Musteri(string _TCkimliknumara, string _isim)
        {
            TCkimliknumara = _TCkimliknumara;
            isim = _isim;
        }

        public Musteri(string _TCkimliknumara, string _isim, string _soyisim)
        {
            TCkimliknumara = _TCkimliknumara;
            isim = _isim;
            soyisim = _soyisim;
        }

        public Musteri(string _TCkimliknumara, string _isim, string _soyisim, int _cinsiyet)
        {
            TCkimliknumara = _TCkimliknumara;
            isim = _isim;
            soyisim = _soyisim;
            cinsiyet = _cinsiyet;
        }

        //Burası overload kısmına çok güzel bir örnektir. 

        public string TCkimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet; //101110 - Bay 101111 - Bayan
    }
}
