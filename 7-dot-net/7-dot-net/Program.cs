using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_dot_net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz  program, który w wierszu poleceń będzie przyjmował nazwę katalogu oraz nazwę pliku, będzie tworzył katalog i plik,
            // a w pliku umieści posortowaną tablicę 10-elementową liczb całkowitych algorytmem quicksort, wartości tablicy pobierze z pliku
            void Zadanie1() {
                Console.Write("Podaj nazwę katalogu: ");
                string katalog  = Console.ReadLine();
                Console.Write("Podaj nazwę pliku: ");
                string plik = Console.ReadLine();

                Console.WriteLine(" ");
            }

            

            // Napisz program usuwający plik lub katalog o nazwie przekazanej z wiersza poleceń.
            // Program powinien zapytać użytkownika o potwierdzenie chęci wykonania tej operacji
            void Zadanie2() {
                Console.WriteLine("Co chcesz usunąć? katalog/plik");
                string odpowiedz = Console.ReadLine();
                odpowiedz = odpowiedz.ToLower();
                Console.WriteLine("Podaj nazwę wybranego {0}u", odpowiedz);
                string nazwa = Console.ReadLine();

                string tn;

                if (odpowiedz == "katalog")
                {
                    Console.WriteLine("Czy chcesz usunąć katalog o nazwie {0}? tak/nie", nazwa);
                    tn = Console.ReadLine();
                    if(tn == "tak")
                    {

                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }else if(odpowiedz == "plik"){
                    Console.WriteLine("Czy chcesz usunąć plik o nazwie {0}? tak/nie", nazwa);
                    tn = Console.ReadLine();
                    if (tn == "tak")
                    {

                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Błąd!");
                }
                Console.WriteLine(" ");
            }

            // Napisz program wyświetlający sumaryczną wielkość plików zawartych w katalogu o nazwie przekazanej z wiersza poleceń.
            void Zadanie3() {
                Console.Write("Podaj nazwe katalogu");
                string katalog = Console.ReadLine();
            }

            Zadanie1();
            Zadanie2();
            Zadanie3();
        }
    }
}
