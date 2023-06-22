using System;

class Program
{
    static bool CzyPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        int licznik = 0;
        int aktualnaLiczba = 2;

        Console.WriteLine($"Pierwsze {n} liczb:");

        while (licznik < n)
        {
            if (CzyPierwsza(aktualnaLiczba))
            {
                Console.WriteLine(aktualnaLiczba);
                licznik++;
            }

            aktualnaLiczba++;
        }
    }
}
