using System;

namespace _12_dot_net
{
    // Zad. Napisz implementację algorytmu Newtona-Raphsona w odpowiedniej metodzie klasy zagnieżdżonej,
    // a następnie w innej klasie wywołaj, tą metodę klasy zagnieżdżonej. Oblicz √3, √5, √37
    public class Outside
    {
        public class Inside
        {
            public double NewtonRaphson(double n)
            {
                double dok = 0.0000001;
                double x = n / 2;
                while (Math.Abs(x - (n / x)) > dok)
                {
                    x = (x + (n / x)) / 2;
                    if (x * x == 2)
                    {
                        return x;
                    }
                }
                return x;
            }
        }
        public void wynik()
        {
            Inside ins = new Inside();
            Console.WriteLine("Podaj liczbę, której pierwiastek chcesz uzyskać: ");
            double liczba = double.Parse(Console.ReadLine());
            Console.WriteLine(ins.NewtonRaphson(liczba));
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Outside out1 = new Outside();
            out1.wynik();
            Console.ReadKey();
        }
    }
}
