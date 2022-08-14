using System;

namespace while_for_each_loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            // while dongusu
            // 1 den baslayarak konsoldan girilen sayiya(dahil) kadar ortalama hesaplayıp yazdıran program
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri konsola yazdır
            char karakter = 'a';
            while (karakter < 'z')
            {
                Console.WriteLine(karakter);
                karakter++;
            }

            Console.WriteLine("***** forEach ******");
            string[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
