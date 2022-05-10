using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_dot_net
{
    // Napisz program który wykuje sortowanie przez wstawianie.
    // Sortowanie 10 elementowej tablicy,

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 10 liczb do posortowania: ");
            int[] myArr = new int[10];
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write("Liczba {0}: ", i + 1);
                myArr[i] = Int32.Parse(Console.ReadLine());

            }

            SortArray(myArr);

            Console.WriteLine("Posortowana tablica: ");
            foreach(int item in myArr)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();

        }

        private static void SortArray(int[] newArr)
        {
            for (int i = 1; i < newArr.Length; ++i)
            {
                int num = newArr[i];
                int j = i - 1;

                while (j >= 0 && newArr[j] > num)
                {
                    newArr[j + 1] = newArr[j];
                    j = j - 1;
                }

                newArr[j + 1] = num;
            }
        }

    }
}
