using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_dot_net
{
    class Program
    {
        // Napisz program wyszukujący palindromy w 10 ciągach znakowych (jeden pod drugim), znajdujących się w pliku.
        // Odszukaj je wypisz na standardowe wyjście.  (wykorzystaj StreamReader).
        // Zmienną do której wczytasz słowo, zadeklaruj z użyciem modyfikatora private.
        // Pokaż, że dostęp jest możliwy z użyciem metody danej klasy, a nie bezpośrednio z metody main() innej klasy.
        static void Main(string[] args)
        {
            void zadanie() 
            {
                Console.WriteLine("Podaj nazwę pliku: ");
                string fileName = Console.ReadLine();
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
