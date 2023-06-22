using System;

class Program
{
    static void Main()
    {
        int x = WprowadzLiczbe("Podaj liczbę naturalną x: ");
        int n = WprowadzLiczbe("Podaj liczbę całkowitą nieujemną n: ");

        long wynik = ObliczPotegowanie(x, n);
        long wynikBiblioteka = (long)Math.Pow(x, n);

        Console.WriteLine("Wynik obliczony algorytmem: " + wynik);
        Console.WriteLine("Wynik obliczony przy pomocy funkcji bibliotecznej: " + wynikBiblioteka);

        if (wynik == wynikBiblioteka)
        {
            Console.WriteLine("Wyniki są zgodne.");
        }
        else
        {
            Console.WriteLine("Wyniki są różne.");
        }
    }

    static int WprowadzLiczbe(string komunikat)
    {
        int liczba;
        bool poprawnaLiczba;

        do
        {
            Console.Write(komunikat);
            poprawnaLiczba = int.TryParse(Console.ReadLine(), out liczba);

            if (!poprawnaLiczba)
            {
                Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie.");
            }
        } while (!poprawnaLiczba);

        return liczba;
    }

    static long ObliczPotegowanie(int x, int n)
    {
        long wynik = x;
        int iteracje = n - 1;
        int mnoznik = x;

        while (iteracje > 0)
        {
            for (int i = 0; i < x; i++)
            {
                wynik += mnoznik;
            }

            mnoznik = (int)wynik;
            iteracje--;
        }

        return wynik;
    }
}
