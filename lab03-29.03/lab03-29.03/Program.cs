
using System;
using System.Windows.Forms;

namespace lab03_29._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz przykładowy program, w którym zostaną wygenerowane dwa różne wyjątki (ArithmeticException, Exception).
            // Wyświetl na ekranie systemowe komunikaty, (JAK TO ZROBIĆ)?
            void Zadanie1(){
                try
                {
                    int liczbaA = 50;
                    int liczbaB = 0;
                    int dzielenie = liczbaA / liczbaB;
                }

                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (SystemException e)
                {
                    MessageBox.Show(e.Message);
                }

            }

            //Napisz program, który pobierze od użytkownika tablice 10 liczb całkowitych. Przekaz tablicę do konstruktora,
            //który posortuje tablicę metodą bąbelkową, i zwróci tablicę do metody main().
            //Wykorzystaj konstrukcję try – catch (np. przekroczenie zakresu tablicy).
            void Zadanie2()
            {

            }
        }
    }
}
