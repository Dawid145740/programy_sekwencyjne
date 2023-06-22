using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Random rand = new Random();
        int liczba;
        int licznikLosowanWersja1 = 0;
        int licznikLosowanWersja2 = 0;
        int licznikParzystychWersja1 = 0;
        int licznikParzystychWersja2 = 0;

        Console.WriteLine($"Wylosowane liczby parzyste ({n} liczb) - Wersja 1:");
        while (licznikParzystychWersja1 < n)
        {
            liczba = rand.Next(-8, 9);
            licznikLosowanWersja1++;

            if (liczba % 2 == 0)
            {
                Console.Write(liczba);
                licznikParzystychWersja1++;

                if (licznikParzystychWersja1 < n)
                    Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Liczba losowań - Wersja 1: {licznikLosowanWersja1}");

        Console.WriteLine();

        Console.WriteLine($"Wylosowane liczby parzyste ({n} liczb) - Wersja 2:");
        while (licznikParzystychWersja2 < n)
        {
            liczba = rand.Next(-4, 5) * 2;
            licznikLosowanWersja2++;

            Console.Write(liczba);
            licznikParzystychWersja2++;

            if (licznikParzystychWersja2 < n)
                Console.Write(", ");
        }

        Console.WriteLine();
        Console.WriteLine($"Liczba losowań - Wersja 2: {licznikLosowanWersja2}");
    }
}
