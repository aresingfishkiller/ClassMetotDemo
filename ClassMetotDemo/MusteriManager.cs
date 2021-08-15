using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " " + "ekleme başarılı");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " " + "silme başarılı");
        }
        public void Listele(Musteri[] Musteriler)
        {
            foreach (Musteri musteri in Musteriler)
            {
                Console.WriteLine(musteri.Isim);
            }
        }
    }
}
