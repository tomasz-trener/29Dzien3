using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Wlasciwosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.Kolor = "czerwony";
            Console.WriteLine(kalkulator.Kolor);

            //juz wczesnij kozrystalismy z wlasciwosci 
            List<string> list = new List<string>();
            int liczbaElementow = list.Count;
            string s = "ala ma kota";
            int dlugosc = s.Length;



            Czlowiek czlowiek = new Czlowiek();
            czlowiek.Nazwisko = "Kowalski";
            czlowiek.Imie = "JAN";
            Console.WriteLine(czlowiek.Imie);
            Console.WriteLine(czlowiek.ImieNazwisko);

            czlowiek.ImieNazwisko = "Adam Nowak";

            ManagerPogody managerPogody = new ManagerPogody();

            managerPogody.SzukanyZnak = "$";

            string s2 = managerPogody.AdresPodstawowy;
            managerPogody.AdresPodstawowy = "xx";
          
            managerPogody.PodajTemperature("Warszawa", Jednostka.Kelvin);
        }
    }
}
