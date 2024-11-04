using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieBiblioteka
{
    internal class Czytelnik
    {
        public string NrKarty { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public List<Wypozyczenie> Wypozyczenia { get; set; }
    }
}
