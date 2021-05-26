using System;
using System.Collections.Generic;
using System.Text;

namespace Pracownicy
{
    public class Handlarz : Pracownik
    {
        public Efektywnosc efektywnosc { get; set; }
        public decimal Prowizja { get; set; }

        public Handlarz(int pracownikID,string imie,string nazwisko,int wiek,int doswiadczenie,Adres adres,Efektywnosc _efektywnosc,decimal prowizja)
            : base(pracownikID, imie, nazwisko, wiek, doswiadczenie, adres)
        {
            efektywnosc = _efektywnosc;
            Prowizja = prowizja;
        }

        public enum Efektywnosc : int
        {
            LOW = 60,
            MEDIUM = 90,
            HIGH = 120
        }

        public override int PracownikValue()
        {
            return Doswiadczenie * ((int)efektywnosc);
        }

        public override string ToString()
        {
            return base.ToString() + $"Efektywnosc: {Enum.GetName(efektywnosc.GetType(),efektywnosc)};Prowizja: {Prowizja} % \n";
        }
    }
}
