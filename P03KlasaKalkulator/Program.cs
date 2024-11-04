using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03KlasaKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            int a = 4;
            int w = k.Policz(a, 5);

            Console.WriteLine(w);

            string s = k.Policz2(4, 5);

            k.Policz3(4, 5);
        }
    }
}
