using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_dot_net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz program, obliczający przybliżoną wartość liczby PI z wykorzystaniem metody Monte Carlo,
            // a następnie uzyskaną wartość zapisać do dowolnego pliku.
            void zadanie()
            {
                Console.WriteLine("Podaj liczbę punktów n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int k = 0;
                double x, y;
                Random rand = new Random();

                if(n < 3)
                {
                    Console.WriteLine("Błąd!");
                }
                else
                {
                    for(int i = 0; i < n; i++)
                    {
                        x = rand.NextDouble() * 2;
                        y = rand.NextDouble() * 2;
                        if(Math.Sqrt((x-1)*(x-1)+(y-1)*(y-1)) <= 1)
                        {
                            k++;
                        }
                    }
                    decimal returnVal = 4 * k / (decimal)n;
                    Console.WriteLine("Liczba PI w przybliżeniu wynosi: " + returnVal.ToString());
                }
            }

            zadanie();
            Console.ReadKey();
        }
    }
}
