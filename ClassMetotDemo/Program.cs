using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "İbrahim ethem";
            musteri1.Soyadi = "İspir";
            musteri1.id = 50468524;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Eren";
            musteri2.Soyadi = "Kala";
            musteri2.id = 25489654;

            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.MusteriEkle(musteri1);
            musteriEkle.MusteriEkle(musteri2);

            MusteriManager musterisil = new MusteriManager();
            musterisil.MusteriSil(musteri2);

            
            Musteri[] musteriList = new Musteri[] {musteri1,musteri2 };
            foreach (var musteri in musteriList)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.id);
            }
            MusteriManager musteriListe = new MusteriManager();
            musteriListe.MusteriListele(musteri1);
            musteriListe.MusteriListele(musteri2);
        }
    }
}
