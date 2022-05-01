using System;
using System.Windows;

namespace _4_dot_net
{
    public class Program
    {
        public Program(int[] tab)
        {
            int tmp;
            for (int j = 0; j < tab.Length - 1; j++)
            {
                for (int babel_i = 0; babel_i < tab.Length - 1; babel_i++)
                {
                    if (tab[babel_i] > tab[babel_i + 1])
                    {
                        tmp = tab[babel_i];
                        tab[babel_i] = tab[babel_i + 1];
                        tab[babel_i + 1] = tmp;
                    }
                }
            }

            foreach (int numer in tab)
                Console.WriteLine(numer);

        }
        static void Main(string[] args)
        {
            // Napisz przykładowy program, w którym zostaną wygenerowane dwa różne wyjątki (ArithmeticException, Exception).
            // Wyświetl na ekranie systemowe komunikaty, (JAK TO ZROBIĆ)?
            void Zadanie1()
            {
                Console.WriteLine("Podaj dwie liczby");
                try
                {
                    string x = Console.ReadLine();
                    string y = Console.ReadLine();
                    int xx = int.Parse(x);
                    int yy = int.Parse(y);
                    Console.WriteLine(xx / yy);
                }

                catch (DivideByZeroException e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                }

            }

            //Napisz program, który pobierze od użytkownika tablice 10 liczb całkowitych. Przekaz tablicę do konstruktora,
            //który posortuje tablicę metodą bąbelkową, i zwróci tablicę do metody main().
            //Wykorzystaj konstrukcję try – catch (np. przekroczenie zakresu tablicy).
            void Zadanie2()
            {
                int[] arr = new int[10];
                Console.WriteLine("Podaj 10 dowolnych liczb: ");
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        string a = Console.ReadLine();
                        int aa = int.Parse(a);
                        arr[i] = aa;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Podane liczby posortowane bąbelkowo: ");
                Program sortowanie = new Program(arr);

            }

            Zadanie1();
            Zadanie2();
            Console.ReadKey();

        }

    }

}
