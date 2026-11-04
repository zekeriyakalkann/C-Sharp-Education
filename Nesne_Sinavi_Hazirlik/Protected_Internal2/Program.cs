using System;


namespace Protected_Internal2
{
    public class Mesaj
    {
        protected internal string mesajım = "Merhaba çikolatam";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mesaj mesaj = new Mesaj();
            Console.WriteLine(mesaj.mesajım);
            Console.ReadKey();
            
        }
    }
}
