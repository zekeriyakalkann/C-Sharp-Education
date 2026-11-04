using System;

namespace Protected_Internal1
{
    public class Mesaj
    {
        protected internal string mesajım = "Merhaba çikolatam";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesaj mesaj = new Mesaj();
            Console.WriteLine(mesaj.mesajım);
            Console.ReadKey();
        }
    }
}
