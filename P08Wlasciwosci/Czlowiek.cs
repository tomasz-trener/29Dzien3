using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Wlasciwosci
{
    internal class Czlowiek
    {
        public string Nazwisko { get; set; } // Wlasiwosc 


        private string imie; // pole 

        public string Imie
        {
            get 
            { 
                string s= imie.ToLower();
                return s; 
            }
            set { imie = value; }
        }

        public string ImieNazwisko
        {
            get
            {
                string s1 = imie.ToUpper();
                string s2 = Nazwisko.ToUpper();
                return s1 + " " + s2;
            }
            set
            {
                string[] s= value.Split(' ');
                imie = s[0];
                Nazwisko = s[1];
            }
        }


        public string PrzedstawSie()
        {
            return "Nazywam sie" + imie + " " + Nazwisko;
        }
    }
}
