using System;
using System.Collections.Generic;
using System.Text;

namespace Faktura_VAT
{
    public class Koszyk
    {
        public List<Gra> Gry { get; set; }
        public Koszyk(params Gra[] gry)
        {
            Gry = new List<Gra>(gry);
        }
        public decimal DoZaplaty()
        {
            decimal suma = 0;
            foreach (Gra gra in Gry)
            {
                suma += gra.Cena_brutto;
            }
            return suma;
        }
        public int IloscGier()
        {
            int suma = 0;
            foreach (Gra gra in Gry)
            {
                suma += gra.Ilosc;
            }
            return suma;
        }
        public decimal PodatekVatWSumie()
        {
            decimal suma = 0;
            foreach (Gra gra in Gry)
            {
                suma += gra.Kwota_VAT;
            }
            return suma;
        }
        public decimal Cena_Netto_W_Sumie()
        {
            decimal suma = 0;
            foreach (Gra gra in Gry)
            {
                suma += gra.Cena_netto_pozycji;
            }
            return suma;
        }
        public int IleGierKupiono()
        {
            int suma = 0;
            foreach (Gra gra in Gry)
            {
                suma += 1;
            }
            return suma;
        }
    }
}
