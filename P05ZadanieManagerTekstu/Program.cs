using P05ZadanieManagerTekstu.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieManagerTekstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();
            ManagerTekstu mt = new ManagerTekstu();

            try
            {
                string pierwszyNajdluzszy =
                    mt.ZnajdzNajdluzszyWyraz(zdanie);
                Console.WriteLine($"WPierwszy najdluzszy: {pierwszyNajdluzszy}");

                string[] wyrazy = mt.ZnajdzWszystkieNajdluzszeWyrazy(zdanie);

                Console.WriteLine($"Wszystkie najdluzsze wyrazy: {string.Join(",",wyrazy)}");
            }
            catch (ZbytKrotkieZdanieException)
            {
                Console.WriteLine("Zbyt krótkie zdanie");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Zdanie nie poprawne");
            }
            catch (Exception ex)
            {
                //  Console.WriteLine(ex.Message);
                Console.WriteLine("Podałeś złe zdanie");
            }

            Console.ReadKey();

        }
    }
}
