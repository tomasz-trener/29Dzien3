using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03KlasaKalkulator
{
    internal class Kalkulator
    {
        // ciało klasy 

        public int Policz(int a, int b)
        {
            // ciało metody 

            int c = a + b;
            return c;
        }

        public int Policz(int a, int b, int c=6)
        {
            // ciało metody 

            int d = a + b + c;
            return c;
        }

        public string Policz2(int a, int b)
        {
            int c = a + b;
            return Convert.ToString(c);
        }

        public void Policz3(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }


    }
}
