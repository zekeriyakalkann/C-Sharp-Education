using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cok_arayuz
{
    public interface ISes
    {
        void SesCikar();
    }

    public interface IYuru
    {
        void Yuru();
    }

    public class Robot: ISes, IYuru
    {
        public void Yuru()
        {
            Console.WriteLine("Robot yürüyor...");
        }

        public void SesCikar()
        {
            Console.WriteLine("Robot bip bip ses çıkarıyor...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Yuru();
            robot.SesCikar();
            Console.ReadKey();
        }
    }
}
