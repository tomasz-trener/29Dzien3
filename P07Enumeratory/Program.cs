using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Enumeratory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ManagerPogody managerPogody = new ManagerPogody();

            //try
            //{
            //    double temperatura = managerPogody.PodajTemperature("warszawa", Jednostka.Celsjusz);
            //    Console.WriteLine(temperatura);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Nie udało się popbrac temperatury");
            //}
            //Console.ReadKey();

            ManagerPogody mp = new ManagerPogody();
            Console.WriteLine("Podaj miasto");
            string miasto = Console.ReadLine();

            List<Jednostka> jednostki = Enum.GetValues(typeof(Jednostka)).Cast<Jednostka>().ToList();
            Console.WriteLine("Podaj jednostkę, jedną z: " + string.Join(", ", jednostki));

            string jednostka = Console.ReadLine();
            bool czyPoprawna=  Enum.TryParse(jednostka, out Jednostka jednostkaEnum);
            if (czyPoprawna)
            {
                try
                {
                    double temperatura = mp.PodajTemperature(miasto, jednostkaEnum);
                    Console.WriteLine(temperatura);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Nie udało się popbrac temperatury");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna jednostka");
            }
        }
    }
}
