using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    internal class ManagerPogody
    {
        public double PodajTemperature(string miasto, string jednostka)
        {
            string adresPodstawowy = "https://www.google.com/search?q=pogoda ";
            string szukanyZnak = "°";
            string znakKoncowy = ">";

            string adres = adresPodstawowy + miasto;

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(adres);

            int indx = dane.IndexOf(szukanyZnak);
            int aktualnaPozycja = indx;

            while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                aktualnaPozycja--;

            string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja - 1);
            return transformujTemperature(jednostka, Convert.ToDouble(wynik));

        }

        private double transformujTemperature(string jednostka, double temp)
        {
            if (jednostka == "Celsjusz")
                return temp;

            if (jednostka == "Farenheit")
                return (temp * 1.8) + 32;

            if (jednostka == "Kelvin")
                return temp + 273.15;

            throw new ArgumentException("Nieznana jednostka");


        }
    }
}
