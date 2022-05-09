using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_dot_net
{
    public interface First
    {
        int a
        {
            get;
            set;
        }
        int b
        {
            get;
            set;
        }
    }

    public class Liczby : First
    {
        private int liczbaA, liczbaB;
        public int a
        {
            get
            {
                return liczbaA;
            }
            set
            {
                liczbaA = value;
            }
        }
        public int b
        {
            get
            {
                return liczbaB;
            }
            set
            {
                liczbaB = value;
            }
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            // Napisz klasę która dziedziczy z interfejsu (który zawiera opis właściwości dwóch liczb oraz definicję metody NWW).
            // Następnie w nowej klasie (metodzie main()) zaimplementuj algorytm NWW.
            // NWW(a, b) = a⋅b / NWD(a, b)

            Liczby dane = new Liczby();
            dane.a = 2;
            dane.b = 5;
            Console.WriteLine("Pierwsza liczba to {0}", dane.a);
            Console.WriteLine("Druga liczba to {0}", dane.b);


            int NWW(int a, int b)
            {
                if (a < b)
                {
                    return NWW(b, a);
                }
                else
                {
                    int k = a;
                    while(k%b != 0)
                    {
                        k += a;
                    } 
                    return k;
                }
            }

            Console.WriteLine("NWW to "+ NWW(dane.a, dane.b));
            Console.ReadKey();
        }
    }
}
