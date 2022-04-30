using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02_15._03
{
    class Program
    {
        double x;
        char y;

        public Program(double x, char y)
        {
            this.x = x;
            this.y = y;
        }

        public void MetodaDane(double x)
        {
            Console.Write("x = " + x);
        }

        public void MetodaDane(char y)
        {
            Console.Write("y = " + y);
        }

        public void MetodaDane(double x, char y)
        {
            Console.Write("x = " + x);
            Console.Write("y = " + y);
        }

        public static void MetodaDane(double x, double x1)
        {
            while (x != x1)
            {
                if (x > x1)
                {
                    x = x - x1;
                }
                else
                {
                    x1 = x1 - x;
                }
            }
            Console.WriteLine(x);
        }

       /* public void MetodaDane(int[] Array)
        {

        }*/

        static void Main(string[] args)
        {/*
            Program program1 = new Program(50.5, 'a');
            Program program2 = new Program(60.6, 'b');*/

            Program program4 = new Program(50.5, 10.1);
        }
    }
}
