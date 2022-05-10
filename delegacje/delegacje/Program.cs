using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegacje
{
    // Napisz program w którym delegat otrzyma 5 liczb całkowitych.
    // Następnie metody które znajda element maksymalny, minimalny, średnią arytmetyczną, medianę.
    // Wszystkie metody dodaj do delegata i uruchom.
    class Program
    {
        public delegate int NewDelegate(int arg1, int arg2, int arg3, int arg4, int arg5);
        static void Main(string[] args)
        {
            NewDelegate newDelegate1 = new NewDelegate(Maksimum);
            int wartoscMax = newDelegate1(5, 4, 11, 98, 5);

            Console.WriteLine("Wartość maksymalna to: " + wartoscMax);

            // -------------------------------

            NewDelegate newDelegate2 = new NewDelegate(Minimum);
            int wartoscMin = newDelegate2(5, 4, 11, 98, 5);

            Console.WriteLine("Wartość minimalna to: " + wartoscMin);

            // -------------------------------

            NewDelegate newDelegate3 = new NewDelegate(SredniaAryt);
            int wartoscSA = newDelegate3(5, 4, 11, 98, 5);

            Console.WriteLine("Średnia arytmetyczna wynosi: " + wartoscSA);
            
            // -------------------------------

            NewDelegate newDelegate4 = new NewDelegate(Mediana);
            int wartoscMed = newDelegate4(5, 4, 11, 98, 5);

            Console.WriteLine("Mediana to: " + wartoscMed);

            // -------------------------------

            Console.ReadKey();
        }

        private static int Maksimum(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int[] myArr = new int[] { arg1, arg2, arg3, arg4, arg5 };
            int max = myArr.Max();
            return max;

        }

        private static int Minimum(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int[] myArr = new int[] { arg1, arg2, arg3, arg4, arg5 };
            int min = myArr.Min();
            return min;
        }

        private static int SredniaAryt(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int[] myArr = new int[] { arg1, arg2, arg3, arg4, arg5 };
            int suma = myArr.Sum();
            int sa = suma / 5;
            return sa;
        }

        private static int Mediana(int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            int[] myArr = new int[] { arg1, arg2, arg3, arg4, arg5 };
            Array.Sort(myArr);
            if(myArr.Length % 2 == 0)
            {
                return (myArr[myArr.Length / 2 - 1] + myArr[myArr.Length / 2]) / 2;
            }
            else
            {
                return myArr[(myArr.Length - 1) / 2];
            }
        } 
    }
}

