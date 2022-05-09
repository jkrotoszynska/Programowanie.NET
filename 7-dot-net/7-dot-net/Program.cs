using System;
using System.Collections.Generic;
using System.IO;
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
                plik += ".txt";

                //Directory.CreateDirectory(katalog);
                //FileStream fs = new FileStream(plik, FileMode.Create, FileAccess.ReadWrite);
                //for(int i = 0; i < 10; i++)
                //{
                //    fs.WriteByte((byte)i);
                //}
                //fs.Position = 0;
                //for(int j = 0; j < 10; j++)
                //{
                //    Console.Write(fs.ReadByte() + " ");
                //}
                //fs.Close();


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

            //Zadanie1();
            //Zadanie2();
            Zadanie3();
            Console.ReadKey();
        }
    }
}
