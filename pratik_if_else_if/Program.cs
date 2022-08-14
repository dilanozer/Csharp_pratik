﻿using System;

namespace if_else_if
{
    class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time<11)
                Console.WriteLine("Günaydın!");
            else if(time<=18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi Geceler!");
            
            string sonuc = time<=18 ? "İyi Günler" : "İyi Geceler"; // ternary operator -- if
            
            sonuc = time>=6 && time<=11 ? "Günaydin!" : time<=18 ? "İyi Günler!" : "İyi Geceler!"; // if -- else if
            
            Console.WriteLine(sonuc);
        }
    }
}
