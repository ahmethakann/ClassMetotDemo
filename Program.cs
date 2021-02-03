using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.AdSoyad = "Mustafa Taş";
            musteri1.Yas = 42;
            musteri1.HesapBakiyesi = 356.48;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.AdSoyad = "Mehmet Demir";
            musteri2.Yas = 28;
            musteri2.HesapBakiyesi = 2456.78;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.AdSoyad = "Ayşe Gün";
            musteri3.Yas = 33;
            musteri3.HesapBakiyesi = 94.09;

            
            Musteri[] musteri = new Musteri[] {musteri1,musteri2,musteri3 };


            Console.WriteLine("Hoşgeldiniz...");
            Console.WriteLine("Müşteri eklemek için 1'e basın.");
            Console.WriteLine("Müşteri silmek için 2'ye basın.");
            Console.WriteLine("Müşterileri listelemek için 3'e basın.");
           
            int a = Console.Read();
            //Console.WriteLine(a);

            MusteriManager musteriManager = new MusteriManager();
            switch (a)
            {
                case 49:
                    musteriManager.MusteriEkle(musteri3);
                    break;
                case 50:
                    musteriManager.MusteriSil(musteri1); 
                    break;
                case 51:
                    foreach (Musteri musteriler in musteri)
                    {
                        musteriManager.MusteriListele(musteriler);
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }
        }
    }
}
