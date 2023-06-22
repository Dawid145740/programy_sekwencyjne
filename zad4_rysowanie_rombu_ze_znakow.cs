using System;

class Program
{
    static void Main()
    {
        int liczbaWierszy = WprowadzLiczbeWierszy();

        if (liczbaWierszy == -1)
        {
            Console.WriteLine("Podano nieprawidłową wartość. Program zostanie zakończony.");
            return;
        }

        char obramowanie = LosujZnak(new char[] { '#', '@', '|', '*' });
        char wnetrze = LosujZnak(new char[] { '.', ':', '-', '+' });

        int polowaWierszy = (liczbaWierszy - 1) / 2;

        
        for (int i = 0; i <= polowaWierszy; i++)
        {
            RysujWiersz(obramowanie, wnetrze, polowaWierszy, i);
        }

      
        for (int i = polowaWierszy - 1; i >= 0; i--)
        {
            RysujWiersz(obramowanie, wnetrze, polowaWierszy, i);
        }
    }

    static int WprowadzLiczbeWierszy()
    {
        int liczbaWierszy;
        int liczbaNieprawidlowychWartosci = 0;

        do
        {
            Console.Write("Podaj liczbę wierszy rombu (nieparzysta, >= 3): ");
            if (int.TryParse(Console.ReadLine(), out liczbaWierszy) && liczbaWierszy >= 3 && liczbaWierszy % 2 != 0)
            {
                return liczbaWierszy;
            }

            liczbaNieprawidlowychWartosci++;
        } while (liczbaNieprawidlowychWartosci < 3);

        return -1;
    }

    static char LosujZnak(char[] znaki)
    {
        Random rand = new Random();
        int indeks = rand.Next(znaki.Length);
        return znaki[indeks];
    }

    static void RysujWiersz(char obramowanie, char wnetrze, int polowaWierszy, int numerWiersza)
    {
        int liczbaSpacji = polowaWierszy - numerWiersza;
        int liczbaZnakow = 2 * numerWiersza + 1;

        for (int i = 0; i < liczbaSpacji; i++)
        {
            Console.Write(" ");
        }

        Console.Write(obramowanie);

        for (int i = 0; i < liczbaZnakow; i++)
        {
            Console.Write(wnetrze);
        }

        Console.WriteLine(obramowanie);
    }
}
