using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_17_2016.Model
{
    class Namestaj
    {
        public int Id { get; set; }
        public bool Obrisan {get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public double Cena { get; set; }
        public int Kolicina { get; set; }
        public TipNamestaja TipNamestaja { get; set; }
        public Akcija Akcija { get; set; }
    }
}
