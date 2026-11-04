using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _70___Static_Field
{
    public class Personel
    {
        public static string domainAdres = "firmam.com";
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        private string emailAdres;
        public string EmailAdres
        {
            get
            {
                return this.emailAdres;
            }
            set
            {
                this.emailAdres = value.ToLower() + "@" + Personel.domainAdres;
            }
        }

        public int Cinsiyet { get; set; }   
    }
}
