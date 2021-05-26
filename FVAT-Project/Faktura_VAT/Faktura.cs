using System;
using System.Collections.Generic;
using System.Text;

namespace Faktura_VAT
{
    public class Faktura
    {
        public Koszyk Koszyk { get; set; }
        public Klient Klient { get; set; }
        public Sprzedawca Sprzedawca { get; set; }
        public string NumerFaktury;
        public DateTime DataWystawieniaDok { get; set; }
        public DateTime DataSprzedazy { get; set; }
        public DateTime DataZaplaty { get; set; }

        public Faktura(Koszyk koszyk,Klient klient,Sprzedawca sprzedawca,DateTime dataWystawieniaDok,DateTime dataSprzedazy,DateTime dataZaplaty,string numerFaktury)
        {
            Koszyk = koszyk;
            Klient = klient;
            Sprzedawca = sprzedawca;
            DataWystawieniaDok = dataWystawieniaDok;
            DataSprzedazy = dataSprzedazy;
            DataZaplaty = dataZaplaty;
            NumerFaktury = numerFaktury;
        }
    }
}
