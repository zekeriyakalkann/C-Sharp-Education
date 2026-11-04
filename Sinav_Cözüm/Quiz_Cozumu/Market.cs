using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Cozumu
{
    public class Market
    {
        public string urunAdi;
        public string kategori;
        public double Fiyat;

        public Market(string _urunAdi, string _kategori, double _Fiyat)
        {
            urunAdi = _urunAdi;
            kategori = _kategori;
            Fiyat = _Fiyat;
        }


    }
}
