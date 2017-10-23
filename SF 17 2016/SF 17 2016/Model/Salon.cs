using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_17_2016.Model
{
    public class Salon
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int PIB { get; set; }
        public int MaticniBrojRacuna { get; set; }
        public string BrojZiroRacuna { get; set; }
        public bool Obrisan { get; set; }
        internal Action<Namestaj> Namestaj { get; set; }
    }
}
