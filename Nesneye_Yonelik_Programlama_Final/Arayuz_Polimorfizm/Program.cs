using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuz_Polimorfizm
{
    public interface IHareket
    {
        void HareketEt();
    }

    public class Insan : IHareket
    {
        public void HareketEt() 
        {
            Console.WriteLine("İnsan yürüyerek hareket eden bir canlıdır.");
        }
    }

    public class Araba : IHareket 
    {
        public void HareketEt()
        {
            Console.WriteLine("Araba tekerlekleri ile hareket eder.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IHareket insan = new Insan();
            insan.HareketEt();
            IHareket araba = new Araba();
            araba.HareketEt();

            Console.ReadKey(); 
        }
    }
}
