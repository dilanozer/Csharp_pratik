using System;

namespace hata_yonetimi
{
    class Program
    {
        public static void Main(string[] args)
        {
            try // kontrol edilmek istenilen kod blogu
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
            }
            catch(Exception ex) // ex=hata
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally // her sekilde calisacak kod blogu--opsiyonel
            {
                Console.WriteLine("İslem tamamlandi.");
            }

            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex) 
            {
                Console.WriteLine("Cok kucuk veya cok buyuk deger girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İslem basariyla tamamlandi");
            }
            
           
        }
    }
}
