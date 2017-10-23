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
        static List<Namestaj> Namestaj { get; set; } = new List<Namestaj>();

        public static string Adresa { get; private set; }
        public static string Brojziroracuna { get; private set; }
        public static string Email { get; private set; }
        public static string Naziv { get; private set; }
        public static object PIB { get; private set; }
        public static int Id { get; private set; }

        static void Main(string[] args)
        {
            var s1 = new Salon()
            {
                Id = 1,
                Naziv = "SALON1",
                Adresa = "bulevar",
                BrojZiroRacuna = "970-970970970-97",
                Email = "salon@salon.com",
                MaticniBrojRacuna = 01293012390,
                PIB = 88787,
                Telefon = "065-656565",
                Website = "google.com",
                Namestaj = Namestaj.Add
            };


        var tn1 = new TipNamestaja 
            { 
                Id = 1,
                Naziv = "sofica",
                
            };
    var n1 = new Namestaj()
    {
        Id = 1,
        Naziv = "sof",
        Sifra = "SF1",
        Cena = 28,
        TipNamestaja = tn1,
        Kolicina = 2
    };
    Console.WriteLine($"==== Dobrodosli u salon {s1.Naziv}");


    IspisGlavnogMenia();            





    }
        private static void IspisGlavnogMenia()
        {
            int izbor = 0;

            do
            {
                Console.WriteLine("1. Rad sa namestajem");
                Console.WriteLine("1. Rad sa tipom namestaja");
                Console.WriteLine("0. Izlaz iz aplikacije");
                izbor = int.Parse(Console.ReadLine());

                //zavrsi listing

            } while (izbor < 0 || izbor > 2);


            switch (izbor)
            {
                case 1:
                    IspisiMeniNamestaja();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }
        }

        private static void IspisiMeniNamestaja()
    {
        int izbor = 0;

        do
        {
            Console.WriteLine("===Meni namestaj===");
            Console.WriteLine("1. Izlistaj namestaj");
            Console.WriteLine("2. dodaj novi namestaj");
            Console.WriteLine("3. izmeni postojeci namestaj");
            Console.WriteLine("4. obrisi postojeci namestaj");
            Console.WriteLine("0. Povratak u glavni meni");
            izbor = int.Parse(Console.ReadLine());

            } while (izbor <0 || izbor >4);


        switch(izbor)
        {
                case 1:
                    IzlistajNamestaj();
                    break;
                case 0:
                    IspisGlavnogMenia();
                    break;
                case 2:
                    DodajNamestaj();
                    break;
                
            default:
                break;
        }
    }

        private static void IzlistajNamestaj()
        {
            Console.WriteLine("=== Izlistavanje namestaja===");
            for (int i = 0; i < Namestaj.Count; ++i )
            {
                Console.WriteLine($"{ i + 1 }. {Namestaj[i].Naziv}, cena: {Namestaj[i].Cena}");

            }
            IspisiMeniNamestaja();

        }

        private static void DodajNamestaj()
        {
            Console.WriteLine("Dodajte namestaj");
        }
      


    }
}
