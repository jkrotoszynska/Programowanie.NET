using System;
using System.IO;


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
                string folderName  = Console.ReadLine();
                Console.Write("Podaj nazwę pliku: ");
                string plik = Console.ReadLine();
                plik += ".txt";

                if (!Directory.Exists(folderName))
                {
                    Directory.CreateDirectory(folderName);
                }

                int[] list = new int[10];
                Random randVal = new Random();
                for (int i = 0; i < 10; i++)
                {
                    list[i] = randVal.Next(1, 51);
                }

                File.WriteAllText(Path.Combine(folderName, plik), list.ToString());

                //QUICKSORT


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
                        Directory.Delete(nazwa);
                    }
                    else
                    {
                        Console.WriteLine("Próba usnięcia katalogu zakończona niepowodzeniem");
                        //Environment.Exit(0);
                    }
                }else if(odpowiedz == "plik"){
                    Console.WriteLine("Czy chcesz usunąć plik o nazwie {0}? tak/nie", nazwa);
                    tn = Console.ReadLine();
                    if (tn == "tak")
                    {
                        File.Delete(nazwa);
                    }
                    else
                    {
                        Console.WriteLine("Próba usnięcia pliku zakończona niepowodzeniem");
                        //Environment.Exit(0);
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
                Console.Write("Podaj nazwe katalogu: ");
                // najlepiej wpisać C:\\
                string folder = Console.ReadLine();
                long suma = 0;

                DirectoryInfo dir = new DirectoryInfo(folder);
                FileInfo[] fileArr = dir.GetFiles();

                Console.WriteLine("Folder o nazwie {0} zawiera: ", dir.Name);
                foreach(FileInfo fi in fileArr)
                {
                    Console.WriteLine("Wielkość pliku {0} wynosi {1}", fi.Name, fi.Length);
                    suma += fi.Length;
                }

                Console.WriteLine("Ich łączna wielkość to: " + suma);
             }

            Zadanie1();
            Zadanie2();
            Zadanie3();
            Console.ReadKey();
        }
    }
}
