using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67___Kapsulleme
{
    internal class Musteri
    {
        //Class => field
        public Musteri()
        {
            this.id = IDBul();
        }
        int id;

        public int ID
        {
            private set //Bu şekilde bir kullanımda kod içerisinde değişimin yapıldığı kısım hata verir. Biz set içerisini boş bırakarak bunu yapar isek kod bu noktada hata vermez ama değer de değişmez. Bu sağlıklı bir durum değildir. O yüzden seti private olarak yalıtmak doğru bir kullanım olacaktır.
            {
                this.id = value;
            }

            get
            {
                return this.id;
            }
        }

        public string isim;
        public string soyisim;
        private string emailAdres;


        //Yalıtım = Kapsülleme demektir.
        //Class => property

        public string EmailAdres    //Bu şekilde bir tanımlama yapıldığı zaman field dan property yani özelliğe dönüştürmüş olduk.
        {
            //get;    //Classı çağıran programcıya datanın gösterildiği kısımdır.
            //set;    //Private olarak işaretlediğimiz field a değer atamasını yaptığımız kısım olarak kullanılmaktadır...

            set
            {
                this.emailAdres = value;
            }

            get
            {
                return this.emailAdres;
            }
            //Buradaki işlemler sayesinde artık emailAdres şeklinde private olarak tanımladığım field da property ye verilen değeri bize gösterecektir.
            //Yani hem property hem de emailAdres field ı aynı ifadeyi gösterecektir.
        }

        private int IDBul()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);

        }
    }
}
