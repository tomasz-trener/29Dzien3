using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P01TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6; 
            char b = 'a';
            string c = "hej";
            double d = 5.6;
            bool e = false;


            int a2 = a; // przekazanie wartosci 
            a = 7;  
            // pytanie co jest w a2 ?  a2 = 6 (kopia)
            // 

            WebClient wc = new WebClient();
            DateTime dt = new DateTime();
            DateTime dt2 = new DateTime(2024, 11, 04);

            StringBuilder sb = new StringBuilder();
            sb.Append("ala");
            sb.Append("ma");
            sb.Append("kota");
            string s = sb.ToString();

            StringBuilder sb2 = sb; // przekazanie referencji 
            sb.Append("i psa");

            // pytanie co bedzie w sb2  ? w sb2 = "ala ma kota i m psa" 
            
            
            StringBuilder sb3 = new StringBuilder();
            sb3 = sb2;

            new StringBuilder();

            //using (StringBuilder sb4 = new StringBuilder())
            //{
            //    //..
            //   // ..
            //}

            DateTime d3 = dt2; 
            dt2= dt2.AddDays(1);
            Console.WriteLine(d3.ToString());

            Console.ReadKey();

            // string jest wyjątkiem tzn pomimo tego, ze jest klasą to przekrazujemy argument przez kopie 
            string c2 = c;
            c += "Dzien dobry";

            // język C 

            String c3 = "a";

        }
    }
}
