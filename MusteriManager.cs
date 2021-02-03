using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("*******MÜŞTERİ EKLENİYOR********");
            Console.WriteLine(musteri.Id + " " + musteri.AdSoyad + " " + musteri.Yas + " " + musteri.HesapBakiyesi+"TL");
            Console.WriteLine("Müşteri Eklendi");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("********mÜŞTERİ SİLİNİYOR********");
            Console.WriteLine(musteri.Id + " " + musteri.AdSoyad + " " + musteri.Yas + " " + musteri.HesapBakiyesi+"TL");
            Console.WriteLine("Müşteri Silindi");
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("*******Müşteriler Listeleniyor*******");
            Console.WriteLine("Müşterinin Id'si: " + musteri.Id);
            Console.WriteLine("Müşterinin Adı Soyadı: " + musteri.AdSoyad);
            Console.WriteLine("Müşterinin Yaşı: " + musteri.Yas);
            Console.WriteLine("Müşterinin Hesap Bakiyesi: " + musteri.HesapBakiyesi+"TL");
            Console.WriteLine("----------");
            
        } 
    }
}
