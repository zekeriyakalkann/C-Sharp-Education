using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66___Class_Uygulama
{
    public class AracBilgileri
    {
        public string aracmarka;
        public string model;
        public int modelyil;
        public decimal km;
        public string yakitTipi;
        public string vitestipi;
        public decimal alisfiyat;
        public decimal satisfiyat;
        public decimal maxindirimtutari;
        public decimal fiyat;

        public AracBilgileri()
        {

        }

        public AracBilgileri(string _aracmarka)
        {
            aracmarka = _aracmarka;
        }

        public AracBilgileri(string _aracmarka, string _model)
        {
            aracmarka = _aracmarka;
            model = _model;
        }

        public AracBilgileri(string _aracmarka, string _model, int _modelyil)
        {
            aracmarka = _aracmarka;
            model = _model;
            modelyil = _modelyil;
        }

        public AracBilgileri(string _aracmarka, string _model, int _modelyil, long _km)
        {
            aracmarka = _aracmarka;
            model = _model;
            modelyil = _modelyil;
            km = _km;
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = satisfiyat - maxindirimtutari;

            if (_fiyat < fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi.");
            }

            else
            {
                this.fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi.");
            }







        }
    }
