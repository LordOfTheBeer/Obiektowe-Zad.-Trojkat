using System;

namespace Trojkat
{ 
    class Trojkat
    {
        int a;
        
        double h;
        public int bok
        {
            set
            {
                a = value;

                h = a * System.Math.Sqrt(3) / 2;
            }
        }
        public double pole()
        {
            return a * h / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat tr;

            tr = new Trojkat();

            tr.bok = 3;

            Console.WriteLine(tr.pole());

            tr.bok = 5;

            Console.WriteLine(tr.pole());

            
        }
    }
}
