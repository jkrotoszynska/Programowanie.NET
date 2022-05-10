using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace _9_dot_net
{
    class Program
    {
        public static bool IsPalindrom(string wordToCheck)
        {
            if (String.IsNullOrEmpty(wordToCheck))
                return false;
            wordToCheck = wordToCheck
                          .Replace(" ", "")
                          .ToLower();

            int length = wordToCheck.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (wordToCheck[i] != wordToCheck[length - i - 1])
                    return false;
            }
            return true;
        }

        // Napisz program wyszukujący palindromy w 10 ciągach znakowych (jeden pod drugim), znajdujących się w pliku.
        // Odszukaj je wypisz na standardowe wyjście. Wykorzystaj StreamReader.
        // Zmienną do której wczytasz słowo, zadeklaruj z użyciem modyfikatora private.
        // Pokaż, że dostęp jest możliwy z użyciem metody danej klasy, a nie bezpośrednio z metody main() innej klasy.
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę pliku: ");
            // proszę podać test
            string fileName = Console.ReadLine();
            fileName += ".txt";

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (IsPalindrom(line))
                        {
                            Console.WriteLine(line);
                        }   
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
