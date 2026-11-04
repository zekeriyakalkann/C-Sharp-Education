using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_10_Protected
{
    class Ismim
    {
        protected string ad = "Zekeriyasın sen canım benim";
        // Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir.
    }
    class Program : Ismim
    {
        static void Main(string[] args)
        {
            //Ismim i = new Ismim();  //Bu şekilde ulaşamıyoruz. Program classına kalıtım olduğu için Program classından obje oluşturmamız gerekmektedir.
            Program ad = new Program();

            Console.WriteLine(ad.ad);
            Console.ReadLine();
        }
    }
}
