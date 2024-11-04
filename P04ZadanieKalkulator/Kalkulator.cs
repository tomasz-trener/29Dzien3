using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieKalkulator
{
    internal class Kalkulator
    {
        public double Policz(int a)
        {
            throw new NotImplementedException();
        }

        private double wykonajDzialanie(int a, int b, char znak)
        {
            double wynik;
            if (znak == '+')
                wynik = a + b;
            else if (znak == '-')
                wynik = a - b;
            else if (znak == '*')
                wynik = a * b;
            else if (znak == '/')
            {
                if (b == 0)
                    return Double.NaN;
                wynik = Convert.ToDouble(a) / b;
            }
            else
            {
                throw new Exception("Niepoperawny operator");
            }

            return wynik;
        }

        public double WykonajDzialanie(int a, int b , char znak)
        {
            return wykonajDzialanie(a, b, znak);    
        }

        public double WykonajDzialanie(string rownanie)
        {
            // rozdzielenie rowniania na skladowe 
            string op = rownanie.Substring(1, 1);
            int liczba1 = Convert.ToInt32(rownanie.Substring(0, 1));
            int liczba2 = Convert.ToInt32(rownanie.Substring(2));

            return wykonajDzialanie(liczba1,liczba2,Convert.ToChar(op));
        }
    }
}
