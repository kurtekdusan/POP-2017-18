using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_17_2016.Model
{
    class Akcija
    {
        public int Id { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Zavrsetak { get; set; }
        public decimal Popust { get; set; }
        public bool Obrisan { get; set; }
        public double ProcenatPopusta { get; set; }
    }
}
