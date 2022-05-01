using System;

namespace _3_dot_net

///Napisz klasę zawierającą dwa pola: pierwsze typu double i drugie typu char(np. liczba i znak).
//Dopisz pięć przeciążonych konstruktorów: pierwszy przyjmujący jeden argument typu double, drugi przyjmujący jeden argument typu char,
//trzeci przyjmujący dwa argumenty — pierwszy typu double, drugi typu char — i czwarty przyjmujący również dwa argumenty typu typu double.
//Czwarty konstruktor niech liczy NWD Euklidesa. Piąty konstruktor (przyjmuje tablice int) Sito Erastotenesa – liczby pierwsze
{
    public class Konstruktor
    {
        double liczba = 1;
        char znak = 'a';

        // pierwszy przyjmujący jeden argument typu double
        public Konstruktor(double arg1)
        {
            liczba += arg1;
            Console.WriteLine("Konstruktor1: " + liczba);
        }

        // drugi przyjmujący jeden argument typu char
        public Konstruktor(char arg2)
        {
            string ciag = znak.ToString() + arg2.ToString();
            Console.WriteLine("Konstruktor2: " + ciag);
        }

        // trzeci przyjmujący dwa argumenty — pierwszy typu double, drugi typu char
        public Konstruktor(double a, char b)
        {
            liczba += a;
            string ciag = znak.ToString() + b.ToString();
            Console.WriteLine("Konstruktor3: " + liczba + " oraz " + ciag);
        }

        // czwarty przyjmujący również dwa argumenty typu typu double - niech liczy NWD Euklidesa.
        public Konstruktor(double num1, double num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }
            Console.WriteLine("Konstruktor4: " + num1);
        }

        // piąty konstruktor (przyjmuje tablice int) Sito Erastotenesa – liczby pierwsze
        public Konstruktor(int[] arr)
        {
            bool czyPierwsza = true;
            Console.Write("Konstruktor5: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 2; j < arr[i]; j++)
                {

                    if (arr[i] % j == 0)
                    {
                        czyPierwsza = false;
                        break;
                    }
                    else
                    {
                        czyPierwsza = true;
                    }
                }
                if (czyPierwsza == true)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Konstruktor konstruktor1 = new Konstruktor(2.0);
            Konstruktor konstruktor2 = new Konstruktor('b');
            Konstruktor konstruktor3 = new Konstruktor(5.1, 'Z');
            Konstruktor konstruktor4 = new Konstruktor(36.0, 8.0);
            Konstruktor konstruktor5 = new Konstruktor(new int[] { 1, 2, 3, 4, 5, 7, 9, 12, 15, 31, 41, 52, 55 });
            Console.ReadKey();
        }
    }
}