using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            try
            {
                double wynik1 = k.WykonajDzialanie("4+5");
                double wynik2 = k.WykonajDzialanie(4, 5, '+');
                Console.WriteLine($"wynik: {wynik1}, wynik2: {wynik2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem z działaniem");
                //File f = new File();
                //f.App

                File.AppendAllText(@"c:\dane\error\errorlog.txt", ex.Message);
            }
            Console.ReadKey();
      
        }
    }
}
