using System;

class Program
{
	static void Main(string[] args)
	{
		// Pobieranie wyniku z matury z matematyki od użytkownika
		Console.WriteLine("Podaj wynik z matury z matematyki:");
		int wynikMatematyka = Convert.ToInt32(Console.ReadLine());

		// Sprawdzanie, czy kandydat spełnia kryterium
		if (wynikMatematyka > 70)
		{
			Console.WriteLine("Możesz ubiegać się o miejsce na studiach.");
		}
		else
		{
			Console.WriteLine("Niestety, Twój wynik z matematyki nie spełnia wymogów.");
		}
	}
}