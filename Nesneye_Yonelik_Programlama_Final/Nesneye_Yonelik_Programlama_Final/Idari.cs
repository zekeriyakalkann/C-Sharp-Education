using System;

namespace Nesneye_Yonelik_Programlama_Final
{
    public class Idari : Calisanlar
    {
        public string birimi;
        public string unvan;
        public int personel_id;
        public string calisma_alani;
        public void Idari_bilgi_yaz()
        {
            Console.WriteLine("Unvan : " + unvan + "\nBirimi : " + birimi + "\nÇalışma alanı : " + calisma_alani);
        }
    }
    }

