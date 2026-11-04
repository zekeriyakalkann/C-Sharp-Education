using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Cözüm
{
    public class Kitap
    {
        public string Adi;
        public int SayfaSayisi;
        //public int İlkBasimYili;

        public Kitap(string _Adi, int _SayfaSayisi) //int _İlkBasimYili)
        {
            Adi = _Adi;
            SayfaSayisi = _SayfaSayisi;
            //İlkBasimYili = _İlkBasimYili;   //Yukarıda oluşturduğumuz attribute ları yapıcı metot içerisinde hepsini belirtmemiz gerekmektedir.
        }

        //public int KitapYasi(int SuAnkiTarih)   //Random ve Datetime gibi classların içerisinde buradakine benzer işlemler kullanılmaktadır.
        //{
        //    return SuAnkiTarih - İlkBasimYili;
        //}






    }
}
