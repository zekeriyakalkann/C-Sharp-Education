using System;

namespace ErişimBelirtecOrnekleri
{
    // Public sınıf her yerden erişilebilir
    public class PublicClass
    {
        // Public değişken: her yerden erişilebilir
        public int publicDegisken = 10;

        // Private değişken: sadece bu sınıf içinde erişilebilir
        private int privateDegisken = 20;

        // Protected değişken: sadece bu sınıf veya bu sınıfı miras alan sınıflarda erişilebilir
        protected int protectedDegisken = 30;

        // Internal değişken: sadece aynı ad alanı (namespace) içindeki sınıflarda erişilebilir
        internal int internalDegisken = 40;

        // Protected internal değişken: aynı ad alanı içinde veya miras alınan sınıflarda erişilebilir
        protected internal int protectedInternalDegisken = 50;

        // Public method: her yerden erişilebilir
        public void PublicMethod()
        {
            Console.WriteLine("Public methoda erişildi.");
        }

        // Private method: sadece bu sınıf içinde erişilebilir
        private void PrivateMethod()
        {
            Console.WriteLine("Private methoda erişildi.");
        }

        // Protected method: sadece bu sınıf veya bu sınıfı miras alan sınıflarda erişilebilir
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected methoda erişildi.");
        }

        // Internal method: sadece aynı ad alanı (namespace) içindeki sınıflarda erişilebilir
        internal void InternalMethod()
        {
            Console.WriteLine("Internal methoda erişildi.");
        }

        // Protected internal method: aynı ad alanı içinde veya miras alınan sınıflarda erişilebilir
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected internal methoda erişildi.");
        }

        // Public methoddan private method çağrılır
        public void CallPrivateMethod()
        {
            PrivateMethod(); // Private method sadece bu sınıf içinde çağrılabilir
        }
    }

    // ProtectedClass, PublicClass'tan miras alır
    public class ProtectedClass : PublicClass
    {
        // Miras alındığı için protected değişken ve methoda erişebilir
        public void AccessProtectedMembers()
        {
            Console.WriteLine($"Protected değişken: {protectedDegisken}");
            ProtectedMethod();
        }
    }

    // Internal sınıf sadece aynı ad alanı (namespace) içindeki sınıflardan erişilebilir
    internal class InternalClass
    {
        public void AccessInternalMembers()
        {
            PublicClass publicClass = new PublicClass();
            Console.WriteLine($"Internal değişken: {publicClass.internalDegisken}");
            publicClass.InternalMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Public sınıf örneği oluşturulur
            PublicClass publicClass = new PublicClass();
            Console.WriteLine($"Public değişken: {publicClass.publicDegisken}");
            publicClass.PublicMethod();

            // Protected sınıf örneği oluşturulur ve protected üyeler erişilir
            ProtectedClass protectedClass = new ProtectedClass();
            protectedClass.AccessProtectedMembers();

            // Internal sınıf örneği oluşturulur ve internal üyeler erişilir
            InternalClass internalClass = new InternalClass();
            internalClass.AccessInternalMembers();

            // Public methoddan private method çağrılır
            publicClass.CallPrivateMethod();

            Console.ReadKey();
        }
    }
}

