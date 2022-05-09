using System;
using System.Collections;
using System.Linq;

namespace Kolekcje
{
    class Program
    {
        // Posortuj listę 20 elementową liczb całkowitych z zakresu od 1 do 50.
        // Wykorzystaj metodę sortowania przez zliczanie oraz listy ArrayList.
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Random randVal = new Random();
            for (int wpisz = 0; wpisz < 20; wpisz++)
            {
                list.Add(randVal.Next(1, 51));
            }

            Console.WriteLine("Lista nieposortowana:");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");

            int[] myArr = (int[])list.ToArray(typeof(int));
            int max = myArr.Max();
            int min = myArr.Min();
            int n = myArr.Length;

            int[] output = new int[n];
            int[] count = new int[51];

            for (int i = 0; i < 51; ++i)
                count[i] = 0;

            for (int i = 0; i < n; ++i)
                ++count[myArr[i]];

            for (int i = 1; i <= 50; ++i)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[myArr[i]] - 1] = myArr[i];
                --count[myArr[i]];
            }

            for (int i = 0; i < n; ++i) { 
                myArr[i] = output[i];
            }

            Console.WriteLine("Lista posortowana: ");
            foreach (int item in myArr)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
            
        }
    }
}
