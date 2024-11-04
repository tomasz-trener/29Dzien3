using P05ZadanieManagerTekstu.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieManagerTekstu
{
    internal class ManagerTekstu
    {
        private string[] znajdzWyrazyOPodanejDlugosci(int dlugosc, string zdanie)
        {
            HashSet<string> znalezione = new HashSet<string>(); // lista bez powtórzeń  
            foreach (var w in zdanie.Split(' '))
            {
                if(w.Length == dlugosc)
                    znalezione.Add(w);
            }
            return znalezione.ToArray();
        }

        public string ZnajdzNajdluzszyWyraz(string zdanie)
        {
            if (zdanie.Length < 1)
                throw new ZbytKrotkieZdanieException();

            if (string.IsNullOrWhiteSpace(zdanie))
                throw new Exception("Nie mozesz podac samych spacji");

            string[] wyrazy = zdanie.Split(' ');
            string aktualnieNajdluzszy = string.Empty;
            foreach (var w in wyrazy)
                if(w.Length > aktualnieNajdluzszy.Length)
                    aktualnieNajdluzszy = w;

            return aktualnieNajdluzszy;
        }

        public string[] ZnajdzWszystkieNajdluzszeWyrazy(string zdanie)
        {
            if (string.IsNullOrEmpty(zdanie))
                throw new ArgumentException("Zdanie nie moze byc puste ani  zawierac tylko białe znaki");
    
            string najdluzszy = ZnajdzNajdluzszyWyraz(zdanie);
            return znajdzWyrazyOPodanejDlugosci(najdluzszy.Length, zdanie);
        }

    }
}
