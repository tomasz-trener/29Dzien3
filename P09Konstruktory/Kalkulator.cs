using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Konstruktory
{
    internal class Kalkulator
    {
        private string kolor;

        private string _tryb; // konwencja nazewnictwa pół prywatnych 

        private int cena;

        //public Kalkulator()
        //{
        //    _tryb = "naukowy";
        //}
        public Kalkulator(string tryb,string kolor)
        {
            _tryb = tryb;
            this.kolor = kolor;
        }

        public string Tryb
        {
            get { return _tryb; }
            set { _tryb = value; }
        }

        public string Policz(double a, double b)
        {
            if(_tryb == "naukowy")
            {
                return string.Format("{0:0000}", a / b);    
            }
            if (_tryb == "normalny")
            {
                return string.Format("{0:00}", a / b);
            }

            throw new Exception("Tryb kalkulatora nieznany");
        }
    }
}
