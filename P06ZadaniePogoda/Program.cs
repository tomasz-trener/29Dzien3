using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody managerPogody = new ManagerPogody();

            try
            {
                double temperatura = managerPogody.PodajTemperature("warszawa", "dCelsjusz");
                Console.WriteLine(temperatura);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nie udało się popbrac temperatury");
            }
            Console.ReadKey();
        }
    }
}
