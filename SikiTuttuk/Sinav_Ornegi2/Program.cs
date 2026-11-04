using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Ornegi2
{
    public class Kayıt
    {
        public string ad;
        public int ogrenci;
        public double gno;
        public Kayıt(string ad, int ogrenci, double gno)
        {
            this.ad = ad;
            this.ogrenci = ogrenci;
            this.gno = gno;
        }
    }

    
    internal class Program
    {
        

         
        static void Main(string[] args)
        {
            
            List<Kayıt> list = new List<Kayıt>()
            {
                new Kayıt("Ayşe", 101, 3.9),
                new Kayıt("Mehmet", 102, 3.8),
                new Kayıt("Ali", 103, 3.9),
                new Kayıt("Zeynep",104,3.7),
                new Kayıt ("Can", 105, 3.8),

            };
            
           

            



        }
    }
}
