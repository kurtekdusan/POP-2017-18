using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_17_2016.Model
{
    class ProdajaNamestaja
    {
        public int Id { get; set; }
        public List <Namestaj> NamestajZaProdaju { get; set; }
        public DateTime DatumProdaje { get; set; }
        public string Kupac { get; set; }
        public string Sifra { get; set; }
        public List<DodatneUsluga> DodatneUsluge { get; set; }
        public double PDV { get; set; }
        public double UkupnaCena { get; set; }
    }
}
