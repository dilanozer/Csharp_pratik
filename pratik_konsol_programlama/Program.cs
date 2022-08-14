// See https://aka.ms/new-console-template for more information
using System;			
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Console.WriteLine("İsminizi Giriniz:");
		string name = Console.ReadLine();
		Console.WriteLine("Soyisminizi Giriniz:");
		string surname = Console.ReadLine();
		Console.WriteLine("Merhaba " + name + " " + surname);
	}
}

