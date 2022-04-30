using System;

namespace lab01_01._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            // Wyświetlanie liczb od 100 do 1, podzielnych przez 3 i niepodzielnych przez 2 - FOR
            for (int i = 100; i > 0; i--)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine(" ");
            // Wyświetlanie liczb od 100 do 1, podzielnych przez 3 i niepodzielnych przez 2 - WHILE
            int j = 100;
            while (j > 0)
            {
                if (j % 3 == 0 && j % 2 != 0)
                {
                    Console.Write(j + " ");
                }
                j--;
            }

            Console.WriteLine(" ");
            // Wyświetlanie liczb od 100 do 1, podzielnych przez 3 i niepodzielnych przez 2 - DO ... WHILE
            int k = 100;
            do
            {
                if( k % 3 == 0 && k % 2 != 0)
                {
                    Console.Write(k + " ");
                }
                k--;
            } while (k > 0);

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 2");

            int[][] tab = new int[4][];
            tab[0] = new int[1];
            tab[1] = new int[2];
            tab[2] = new int[3];
            tab[3] = new int[4];

            int licznik = 1;
            for (int i = 0; i < tab.Length; i++)
            { 
                for (int x = 0; x < tab[i].Length; x++)
                {
                    
                }
            }
            Console.Write(tab);

            Console.WriteLine(" ");
            Console.WriteLine("Zadanie 3");
        }
    }
}
