using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieBiblioteka
{
    internal class Wypozyczenie
    {
        public DateTime DataWypozyczenia { get; set; }
        public DateTime PrzewidywanaDataZwrotu { get; set; }
        public DateTime RzeczywistaDataZwrotu { get; set; }
        public string Uwagi { get; set; }
        public Czytelnik Czytelnik { get; set; }
        public Sygnatura Sygnatura { get; set; }

        public Wypozyczenie Przedluzenie { get; set; }
    }
}
