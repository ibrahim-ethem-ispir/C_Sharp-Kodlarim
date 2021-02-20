using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Kadedildi : " + musteri.Adi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi  "+musteri.Adi + musteri.Soyadi);
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Musteri listelendi...");
        }
    }
}
