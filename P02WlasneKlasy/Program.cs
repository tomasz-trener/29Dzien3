using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator(); // Tworzymy nowy obiekt typu Kalkulator 
                                            // i przypisujemy go do nowo zadeklarowanej 
                                            // zmiennej o nazwie k, typu Kalkulator 



            Kalkulator k2;  // Deklarujemy zmienną o nazwie 'k2'
                            // , która jest typu Kalkulator 
                            // Nie moge teraz pracować na k2 
                            // ta zmienna jset gotowa na to aby 
                            // do niej przypisać nowy (lub stary) 
                            // obiekt typu Kalkulator 


            k2 = new Kalkulator(); // tworzymy nowy obiekt typu kalkulator
                                   // i przypiujemy go do zmiennej k2 

            new Kalkulator(); // tworzymy nowy obiekt w pamieci 
                              // ale nie mamy do niego uchwytu 

            Kalkulator k3 = k2;  // istniejący obiekt w pamieci do, którego
                                 // mamy uchwyt przez k2, przypisujemy 
                                 // do nowo zadeklarowanej zmiennej o nazwie k3, 
                                 // ,która jest typu Kalkulator 
                                 // efekt: 2 zmienne, wksazujące na ten sam obiekt 

            StringBuilder sb = new StringBuilder();
            sb.Append("xx");

            StringBuilder sb2;
           // sb2 = new StringBuilder();
           // sb2.Append("yy");
        }
    }
}
