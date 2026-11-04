using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme_get_set
{
    public class Öğrenci
    {
        private string isim ;
        private int tc;

        public void Setisim(string _isim)
        {
            isim = _isim;
        }

        public string Getisim()
        {
            return isim;
        }
        //Bu kısım bir kalıptır. Kapsülleme işlemlerinde bu şekilde kullanım yapmak gerekir. Bu şekilde alışmalıyız. 

    }
}
