using SF_17_2016.Model;
using SF_17_2016.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_17_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Salon();
            s1.Naziv = "SALON1";

            Console.WriteLine("Dobrodosli u salon" + s1.Naziv);
            Console.WriteLine("1. Izlistaj sav namestaj");
            Console.ReadLine();


        }
        
    }
}
