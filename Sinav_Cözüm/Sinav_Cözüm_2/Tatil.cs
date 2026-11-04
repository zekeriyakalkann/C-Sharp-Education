using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Cözüm_2
{
    public class Tatil
    {
        public string destination;
        public int sure;
        public int fiyat;
        public int gunlukdeger;

        public Tatil(string _destination, int _sure, int _fiyat, int _gunlukdeger)
        {
            destination = _destination;
            sure = _sure;
            fiyat = _fiyat;
            gunlukdeger = _gunlukdeger;
        }


    }
}
