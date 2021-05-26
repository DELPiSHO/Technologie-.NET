using System.Collections.Generic;
using System.Text;
using System;

namespace Faktura_VAT
{
    public class Gra
    {
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena_netto_jednostkowa { get; set; }
        public decimal Cena_netto_pozycji => Cena_netto_jednostkowa * Ilosc;
        public decimal Podatek_VAT { get; set; }
        public decimal Kwota_VAT => Cena_netto_pozycji * Podatek_VAT;
        public decimal Cena_brutto => Cena_netto_pozycji + Kwota_VAT;
        public override string ToString()
        {
            return $"{Nazwa};{Ilosc};{Cena_netto_jednostkowa} zl za 1 kopie;{Cena_netto_pozycji} zl netto;{Podatek_VAT * 100} % VAT;{Kwota_VAT} Kwota VAT;{Cena_brutto} Cena brutto;";
        }
    }
}
