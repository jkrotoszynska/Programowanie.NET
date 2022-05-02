using System;
using System.Text;

namespace _5a_dot_net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz program, który będzie realizował tzw. szyfr Cezara (modyfikacja o 1) działający na znakach wprowadzanych bezpośrednio z klawiatury.
            // Naciśnięcie klawisza odpowiadającego literze a ma powodować pojawianie się litery o podany przez użytkownika klucz.
            // Możesz ograniczyć się do przekodowywania tylko małych liter z alfabetu łacińskiego. (q lub escape kończy działanie)
            void Zadanie1()
            {
                Console.Write("Podaj tekst do zaszyfrowania: ");
                string tekst = Console.ReadLine();
                byte[] arr = Encoding.ASCII.GetBytes(tekst.ToLower());

                //foreach (byte znak in arr)
                //{
                //    Console.Write("{0} ", (char)znak);
                //}
                Console.Write("Kodowanie: ");
                for(int i = 0; i < arr.Length; i++)
                {
                    // poprawić aby zamieniało na same litery? 
                    arr[i] = (byte)(((arr[i] - 95) % 27) + 97);
                }
                
                foreach(byte znak in arr)
                {
                    Console.Write("{0}", (char)znak);
                }

                Console.WriteLine(" ");
                Console.WriteLine("Aby wyjść naciśnij Q lub Escape");
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if(keyinfo.Key == ConsoleKey.Q || keyinfo.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine(" ");
            }

            // Napisz program rozwiązujący równania kwadratowe, w którym parametry A, B i C będą wprowadzane przez użytkownika z klawiatury.
            void Zadanie2()
            {
                Console.Write("Podaj A: ");
                string a = Console.ReadLine();
                int A = int.Parse(a);

                Console.Write("Podaj B: ");
                string b = Console.ReadLine();
                int B = int.Parse(b);

                Console.Write("Podaj C: ");
                string c = Console.ReadLine();
                int C = int.Parse(c); 

                Console.WriteLine(A + "x^2 + " + B + "x + " + C);
                double delta = (B * B) - (4 * A * C);
                Console.WriteLine("Delta: " + delta);

                if(delta > 0)
                {
                    double x1 = ((-1 * B) - Math.Sqrt(delta)) / (2 * A);
                    double x2 = ((-1 * B) + Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine("Funkcja posiada dwa miejsca zerowe: " + x1 +" i " + x2);

                }
                else if(delta == 0)
                {
                    int x = (-1 * B) / (2 * A);
                    Console.WriteLine("Funkcja posiada jedno miejsce zerowe: " + x);
                }
                else
                {
                    Console.WriteLine("Brak miejsc zerowych");
                }
            }

            // Napisz program, który umożliwi użytkownikowi wprowadzenie wiersza tekstu zawierającego liczby całkowite oddzielone znakiem separatora
            // (np. przecinkiem), a więc przykładowego ciągu 1,5,24,8,150,2. Program powinien następnie wyświetlić liczy pierwsze (sito Eratostenesa)
            // (wyszukiwanie liczby najmniejszej – dowolna metodą)
            void Zadanie3()
            {
                Console.Write("Wprowadź ciąg liczb, dzieląc je przecinkami: ");
                string tekst = Console.ReadLine();
                string[] arrPom = tekst.Split(',');
                int[] arr = new int[arrPom.Length];

                for (int i = 0; i < arrPom.Length; i++)
                {
                        arr[i] = Convert.ToInt32(arrPom[i]);
                }

                bool czyPierwsza = true;
                for (int k = 0; k < arr.Length; k++)
                {
                    for (int j = 2; j < arr[k]; j++)
                    {

                        if (arr[k] % j == 0)
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
                        Console.Write(arr[k] + " ");
                    }
                }

            }

            Zadanie1();
            Zadanie2();
            Zadanie3();
            Console.ReadKey();
        }
    }
}
