using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Isim = "Tuna";
            musteri1.SoyIsim = "Tezcan";
            musteri1.Yas = 28;

            Musteri musteri2 = new Musteri();
            musteri2.Isim = "Uğur";
            musteri2.SoyIsim = "Çınar";
            musteri2.Yas = 27;

            Musteri musteri3 = new Musteri();
            musteri3.Isim = "Buğra";
            musteri3.SoyIsim = "Çuhacı";
            musteri3.Yas = 26;

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri3);
            musteriManager.Listele(Musteriler);
        }
    }
}
