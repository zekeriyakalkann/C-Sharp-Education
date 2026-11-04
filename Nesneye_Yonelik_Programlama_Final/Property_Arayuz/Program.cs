using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Arayuz
{
    public interface ICanlilar
    {
        string CanliTur { get; set; }
        int CanliYas { get; set; }
        public void EkranaYaz()
        {
            Console.WriteLine("Canlılar arayüzü");
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
