﻿using System;

namespace for_loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir
            Console.WriteLine("Lütfen sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {   
                // komutlar
                if (i%2 == 1)
                    Console.WriteLine(i);
                
            } 

            // 1 ile 1000 arasindaki tek ve cift sayilarin kendi icindeki toplamlarini ekrana yazdirma
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek toplam: " + tekToplam);
            Console.WriteLine("Cift toplam: " + ciftToplam);

            // break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

            
        }
    }
}