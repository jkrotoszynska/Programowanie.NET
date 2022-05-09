using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_dot_net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz klasę First zawierającą abstrakcyjną metodę f i wirtualną r,
            // z tej klasy wyprowadź klasę potomną Second zawierającą ciała metod f i r
            // na podstawie metod f i r klasy bazowej. Rozkład na czynniki pierwsze(Fermata lub klasyczny)
            // RLE(Run Length Encoding)(dokonać kompresji Unnniiiiwwerrrsyyyttttteeeeet Gddddaansssskkii
            void dopisz(ref string str, char pomocna, int licznik)
            {
                if (licznik > 0)
                {
                    str += pomocna;
                }
                if (licznik > 1)
                {
                    str += licznik.ToString();
                }
            }

            string kompresja(string tekst) {
                string rezultat = "";
                int licznik = 0;
                char pomocna = tekst[0];
                for(int i = 0; i < tekst.Length; i++)
                {
                    if(tekst[i] == pomocna)
                    {
                        licznik++;
                    }
                    else
                    {
                        dopisz(ref rezultat, pomocna, licznik);
                        pomocna = tekst[i];
                        licznik = 1;
                    }
                }
                dopisz(ref rezultat, pomocna, licznik);
                return rezultat;
            }

            
            Console.WriteLine(kompresja("Unnnniiiiiwweeerrrekkkkk"));
            Console.WriteLine(kompresja("Unnniiiiwwerrrsyyyttttteeeeet"));
            Console.WriteLine(kompresja("Gddddaansssskkii"));
            Console.ReadKey();
        }   

    }
    public abstract class First
    {
        public abstract void f();
        public virtual String r() {
            return "Zakończono";
        }
    }

    public abstract class Second : First
    {
        public override void f()
        {
            Console.WriteLine("Hello world!!!");
        }

        public override String r()
        {
            return "Zakończono program";
        }
    }
}
