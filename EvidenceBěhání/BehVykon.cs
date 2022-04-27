using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceBěhání
{
    class BehVykon
    {
        public string Nazev { get; set; }
        public double Delka { get; set; }
        public DateTime Datum { get; set; }
        public TimeSpan Cas { get; set; }

        public BehVykon(string nazev, double delka, DateTime datum, TimeSpan cas)
        {
            Nazev = nazev;
            Delka = delka;
            Datum = datum;
            Cas = cas;
        }
    }
}