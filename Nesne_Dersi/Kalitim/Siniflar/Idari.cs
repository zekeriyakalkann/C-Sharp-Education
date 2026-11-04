using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim.Siniflar
{
    public class Idari:Calisanlar
    {
        public string birimi;
        public string unvan;
        public int personel_id;
        public string calisma_alani;

        public Idari()
        {
            MessageBox.Show("Türetilmiş sınıf çağırıldı.");
        }

        public void Idari_Bilgi_Yaz()
        {
            MessageBox.Show($"Unvan: {unvan} \n Birimi: {birimi} \n Çalışma Alanı: {calisma_alani}");
        }
    }
}
