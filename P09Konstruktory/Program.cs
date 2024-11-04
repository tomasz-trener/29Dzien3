using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator("naukowy","czerwony");

            kalkulator.Tryb = "naukowy";

            string wynik = kalkulator.Policz(10,3);

            ManagerPogody mp = new ManagerPogody(Jednostka.Kelvin);

            double tmp1 = mp.PodajTemperature("warszawa");
            double tmp2 = mp.PodajTemperature("kraków");

            Console.ReadKey();

            // podsumoawnie 

            // Klasy mogą składać z: 
            //1) pola -> prywatne cechy obiektu 
            //2) właściwości -> publiczne cechy obiektu 
            //3) metody -> sluzace do realizacji zadań
            //4) konstruktory -> kontrolują sposób tworzenia obiketu 
        }
    }
}
