using System;

namespace dizi_metodlari
{
    class Program
    {
        public static void Main(string[] args)
        {
            // sort
            Console.WriteLine("***** Array Sort *****");
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};
            Console.WriteLine("***** Sirasiz Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("***** Sirali Dizi *****");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-----------------------");
            // clear
            Console.WriteLine("***** Array Clear *****");
            // sayiDizisi elemanlari kullanarak 2.indexten itibaren 2 tane elemani 0'lar
            Array.Clear(sayiDizisi, 2,2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-----------------------");
            // reverse
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-----------------------");
            // indexOf
            Console.WriteLine("***** Array indexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));
            Console.WriteLine("-----------------------");
            // resize
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            
        }
    }
}
