using System;

namespace lab01_01._03
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadanie1()
            {
                // Napisz program wyświetlający w porządku malejącym liczby od 100 do 1 podzielne przez trzy, ale niepodzielne przez 2. 
                // Zadanie wykonaj za pomocą trzech rodzajów pętli(for, while, do ..while)
                Console.WriteLine(" ");
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
                    if (k % 3 == 0 && k % 2 != 0)
                    {
                        Console.Write(k + " ");
                    }
                    k--;
                } while (k > 0);

                Console.WriteLine(" ");
            }

            void Zadanie2()
            {
                // Utwórz tablicę liczb typu int zaprezentowaną poniżej. Wypełnij kolejne komórki wartościami malejącymi od 10 do 1.
                // Do utworzenia tablicy i wypełnienia jej danymi wykorzystaj pętlę typu for.
                Console.WriteLine(" ");
                Console.WriteLine("Zadanie 2");

                int[][] tab = new int[4][];
                tab[0] = new int[1]; // 10
                tab[1] = new int[2]; // 9, 8
                tab[2] = new int[3]; // 7, 6, 5
                tab[3] = new int[4]; // 4, 3, 2, 1

                int licznik = 10;
                for (int i = 0; i < tab.Length; i++)
                {
                    for (int j = 0; j < tab[i].Length; j++)
                    {
                        tab[i][j] = licznik--;
                        Console.Write(tab[i][j] + " ");
                    }
                    Console.WriteLine("");
                }
            }

            void Zadanie3()
            {
                // Utwórz tablicę dwuwymiarową, w której liczba komórek w kolejnych rzędach będzie równa dziesięciu kolejnym wartościom ciągu Fibonacciego,
                // poczynając od elementu o wartości 1 (1, 1, 2, 3, 5 itd.). Wartość każdej komórki powinna być jej numerem w danym wierszu w kolejności malejącej
                // (czyli dla wiersza o długości pięciu komórek kolejne wartości to 5, 4, 3, 2, 1). Zawartość tablicy wyświetl na ekranie
                Console.WriteLine(" ");
                Console.WriteLine("Zadanie 3");

                // Ciąg Fibonacciego -> 0, 1 , [F(n-1) + (Fn-2)] -> 0, 1, 1, 2, 3, 5, 8, 13, 21, 34

                // WYNIK:
                // tab[0] = 1
                // tab[1] = 1
                // tab[2] = 2 1
                // tab[3] = 3 2 1
                // tab[4] = 5 4 3 2 1
                // tab[5] = 8 7 6 5 4 3 2 1
                // tab[6] = 13 12 11 10 9 8 7 6 5 4 3 2 1
                // tab[7] = 21 20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1
                // tab[8] = 34 33 32 31 30 29 28 27 26 25 24 23 22 21 20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1
                // tab[9] = 55 54 53 52 51 50 49 48 47 46 45 43 42 41 40 39 38 37 36 35 34 33 32 31 30 29 28 27 26 25 24 23 22 21 20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1

                int[][] tab = new int[10][];
                tab[0] = new int[1];
                tab[1] = new int[1]; 
                tab[2] = new int[2]; 
                tab[3] = new int[3]; 
                tab[4] = new int[5]; 
                tab[5] = new int[8];
                tab[6] = new int[13];
                tab[7] = new int[21];
                tab[8] = new int[34];
                tab[9] = new int[55];

                //Console.WriteLine(tab.Length);

                for (int i = 0; i < tab.Length; i++)
                {
                    for (int j = 0; j < tab.Length; j++)
                    {
                        if (i == 0 && j == 0 || i == 1 && j == 0)
                        {
                            tab[i][j] = 1;
                            Console.Write("tab[{0}] = ", i);
                            Console.Write(tab[i][j] + " ");
                            break;
                        }
                        else if (i > 1)
                        {
                            tab[i][j] = tab[i - 1][0] + tab[i - 2][0];
                            int ilosc = tab[i][j];

                            Console.Write("tab[{0}] = ", i);

                            for (int k = 0; k < ilosc ; k++)
                            {
                                Console.Write((tab[i][j])-k + " ");
                                
                            }
                            break;
                        }

                    }
                    Console.WriteLine("");
                }
            }
            Zadanie1();
            Zadanie2();
            Zadanie3();
        }
    }
}
