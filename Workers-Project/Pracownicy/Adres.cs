using System;
using System.Collections.Generic;
using System.Text;

namespace Pracownicy
{
    public class Adres
    {
        public string NazwaMiasta { get; set; }
        public string NazwaUlicy { get; set; }
        public string NumerBudynku { get; set; }
        public string NumerLokalu { get; set; } 

        public Adres(string nazwaMiasta, string nazwaUlicy, string numerBudynku, string numerLokalu)
        {
            NazwaMiasta = nazwaMiasta;
            NazwaUlicy = nazwaUlicy;
            NumerBudynku = numerBudynku;
            NumerLokalu = numerLokalu;
        }
    }
}
