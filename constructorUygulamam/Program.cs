using System;

namespace BebekOrnegi
{
    public class Bebek
    {
        // Property tanımları
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        // 1. Constructor (parametresiz - default)
        public Bebek()
        {
            Console.WriteLine("Ingaaaa");
            DogumTarihi = DateTime.Now;
        }

        // 2. Constructor (ad ve soyad parametreli)
        public Bebek(string ad, string soyad)
        {
            Console.WriteLine("Ingaaaa");
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = DateTime.Now;
        }

        // Bilgileri yazdırmak için yardımcı metot
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. constructor ile bebek nesnesi oluşturuluyor (parametresiz)
            Bebek bebek1 = new Bebek();
            bebek1.Ad = "Elif";
            bebek1.Soyad = "Yıldız";
            bebek1.BilgileriYazdir();

            Console.WriteLine();

            // 2. constructor ile bebek nesnesi oluşturuluyor (parametreli)
            Bebek bebek2 = new Bebek("Mert", "Kaya");
            bebek2.BilgileriYazdir();

            Console.ReadLine();
        }
    }
}
