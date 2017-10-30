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

        static List<TipNamestaja> TipNamestaja { get; set; } = new List<TipNamestaja>();


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
                
            };


            var tn1 = new TipNamestaja 
            { 
                Id = 1,
                Naziv = "sofica"
                
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
            var tn2 = new TipNamestaja
            {
                Id = 2,
                Naziv = "novitip"
            };
            Namestaj.Add(n1);


    Console.WriteLine($"==== Dobrodosli u salon {s1.Naziv}");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    IspisGlavnogMenia();            
            
    }
        private static void IspisGlavnogMenia()
        {
            int izbor = 0;

            do
            {
                Console.WriteLine("1. Rad sa namestajem");
                Console.WriteLine("3. Rad sa korisnicima");
                Console.WriteLine("4. Rad sa prodajama");
                Console.WriteLine("4. Rad sa akcijama");
                Console.WriteLine("0. Izlaz iz aplikacije");
                izbor = int.Parse(Console.ReadLine());

                //zavrsi listing

            } while (izbor < 0 || izbor > 2);


            switch (izbor)
            {
                case 1:
                    IspisiMeniNamestaja();
                    break;
                case 2:
                    IspisiMeniKorisnika();
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
                case 3:
                    IzmeniNamestaj();
                    break;
                case 4:
                    Izbrisi();
                    break;
                
            default:
                break;
        }
    }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private static void IzlistajNamestaj()
        {
            Console.WriteLine("=== Izlistavanje namestaja===");
            for (int i = 0; i < Namestaj.Count; ++i )
            {
                if(!Namestaj[i].Obrisan)
                {
                    Console.WriteLine($"{ i + 1 }. {Namestaj[i].Naziv}, cena: {Namestaj[i].Cena}, tip namestaja: {Namestaj[i].TipNamestaja.Naziv}");
                }

            }
            IspisiMeniNamestaja();

        }

        private static void DodajNamestaj()
        {

            Console.WriteLine("Dodavanje namestaja");
            var NoviNamestaj = new Namestaj();
            NoviNamestaj.Id = Namestaj.Count + 1;
            //NoviNamestaj.Id = NoviNamestaj.GetHashCode();
            Console.WriteLine("Naziv: ");
            NoviNamestaj.Naziv = Console.ReadLine();
            Console.WriteLine("Cena: ");
            NoviNamestaj.Cena = double.Parse(Console.ReadLine());
            Console.WriteLine("Sifra: ");
            NoviNamestaj.Sifra = Console.ReadLine();
            string nazivTipaNamestaja = "";
            TipNamestaja trazeniTipNamestaja = null;

            do
            {
                Console.WriteLine("Tip Namestaja: ");
                string nazivTipaNamestaj = Console.ReadLine();

                foreach (var tipNamestaja in TipNamestaja)
                {
                    if(tipNamestaja.Naziv == nazivTipaNamestaja)
                    {
                        trazeniTipNamestaja = tipNamestaja;
                    }
                }
            } while (trazeniTipNamestaja != null);
            NoviNamestaj.TipNamestaja = trazeniTipNamestaja;

            Console.WriteLine("Kolicina: ");
            NoviNamestaj.Kolicina = int.Parse(Console.ReadLine());

            Namestaj.Add(NoviNamestaj);
            
        }

        private static void IzmeniNamestaj()
        {
            Namestaj TrazeniNamestaj = null;
            string nazivTrazenogNamestaja = "";

            do
            {
                Console.WriteLine("unesi naziv: ");
                nazivTrazenogNamestaja = Console.ReadLine();
                foreach (var namestaj in Namestaj)
                { 
                    if(namestaj.Naziv == nazivTrazenogNamestaja)
                    {
                        TrazeniNamestaj = namestaj;
                    }
                }
           

            } while (TrazeniNamestaj == null);

            Console.WriteLine("Unesi novi naziv");
            TrazeniNamestaj.Naziv = Console.ReadLine();

            Console.WriteLine("unesi novu cenu ");
            TrazeniNamestaj.Cena = double.Parse(Console.ReadLine());

            //implementiraj izmenu tipa sadrzaja 
        }

        private static void Izbrisi()
        {
            Namestaj TrazeniNamestaj = null;
            string nazivTrazenogNamestaja = "";

            do
            {
                Console.WriteLine("unesi naziv: ");
                nazivTrazenogNamestaja = Console.ReadLine();
                foreach (var namestaj in Namestaj)
                {
                    if (namestaj.Naziv == nazivTrazenogNamestaja)
                    {
                        namestaj.Obrisan = true;
                    }
                }

            } while (TrazeniNamestaj == null);
        }


        private static void IspisiMeniKorisnika()
        {
            int izbor = 0;

            do
            {
                Console.WriteLine("===Meni namestaj===");
                Console.WriteLine("1. Izlistaj korisnike");
                Console.WriteLine("2. dodaj novog korisnika");
                Console.WriteLine("3. izmeni postojeceg korisnika");
                Console.WriteLine("4. obrisi postojeceg korisnika");
                Console.WriteLine("0. Povratak u glavni meni");
                izbor = int.Parse(Console.ReadLine());

            } while (izbor < 0 || izbor > 4);


            switch (izbor)
            {
                case 1:
                    IzlistajKorisnike();
                    break;
                case 0:
                    IspisGlavnogMenia();
                    break;
                case 2:
                    DodajKorisnika();
                    break;
                case 3:
                    IzmeniKorisnika();
                    break;
                case 4:
                    IzbrisiKorisnika();
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private static void IzlistajKorisnike()
        {
            Console.WriteLine("=== Izlistavanje korisnika===");
            for (int i = 0; i < Korisnik.Count; ++i)
            {
                if (!Korisnik[i].Obrisan)
                {
                    Console.WriteLine($"{ i + 1 }. Ime: {Korisnik[i].Ime}, Prezime: {Korisnik[i].Prezime}");
                }

            }
            IspisiMeniKorisnika();

        }

        private static void DodajKorisnika()
        {

            Console.WriteLine("Dodavanje korisnika");
            var NoviKorisnik = new Korisnik();
            NoviKorisnik.Id = Namestaj.Count + 1;
            //NoviNamestaj.Id = NoviNamestaj.GetHashCode();
            Console.WriteLine("Ime: ");
            NoviKorisnik.Ime = Console.ReadLine();
            Console.WriteLine("Prezime: ");
            NoviKorisnik.Prezime = Console.ReadLine();
            Console.WriteLine("Korisnicko Ime: ");
            NoviKorisnik.KorisnickoIme= Console.ReadLine();
            Console.WriteLine("Lozinka ");
            NoviKorisnik.Lozinka = Console.ReadLine();

            Korisnik.Add(NoviKorisnik);

        }

        private static void IzmeniKorisnika()
        {
            Namestaj TrazeniKorisnik = null;
            string nazivTrazenogKorisnika = "";

            do
            {
                Console.WriteLine("unesi ime: ");
                nazivTrazenogKorisnika = Console.ReadLine();
                foreach (var korisnik in Korisnik)
                {
                    if (korisnik.Ime == nazivTrazenogKorisnika)
                    {
                        TrazeniKorisnik = korisnik;
                    }
                }


            } while (TrazeniKorisnik == null);

            Console.WriteLine("Unesi novi naziv");
            TrazeniKorisnik.Naziv = Console.ReadLine();

            Console.WriteLine("unesi novu cenu ");
            TrazeniKorisnik.Cena = double.Parse(Console.ReadLine());

            //implementiraj izmenu tipa sadrzaja 
        }

        private static void IzbrisiKorisnika()
        {
            Namestaj TrazeniKorisnik = null;
            string nazivTrazenogKorisnika = "";

            do
            {
                Console.WriteLine("unesi naziv: ");
                nazivTrazenogKorisnika = Console.ReadLine();
                foreach (var korisnik in Korisnik)
                {
                    if (korisnik.Ime == nazivTrazenogKorisnika)
                    {
                        korisnik.Obrisan = true;
                    }
                }

            } while (TrazeniKorisnik == null);
        }

    }
}
