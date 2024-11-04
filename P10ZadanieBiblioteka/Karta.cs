using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieBiblioteka
{
    internal class Karta
    {
        public string NrKarty { get; set; }
        public string Tytul { get; set; }
        public int Wydanie { get; set; }
        public Karta Nastepne { get; set; }
        public Karta Poprzednie { get; set; }
        public List<Autor> Autorzy { get; set; }
        public List<Sygnatura> Sygnatury { get; set; }
    }
}
