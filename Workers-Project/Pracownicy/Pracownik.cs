using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Pracownicy
{
    public abstract class Pracownik : IComparable<Pracownik>
    {
        public int PracownikID { get; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public int Doswiadczenie { get; set; }
        public Adres Adres { get; set; }

        protected Pracownik(int pracownikID, string imie, string nazwisko, int wiek, int doswiadczenie, Adres adres)
        {
            PracownikID = pracownikID;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Doswiadczenie = doswiadczenie;
            Adres = adres;
        }

    public int CompareTo(Pracownik inny)
        {
            int i = Doswiadczenie.CompareTo(inny.Doswiadczenie);
            if (i > 0)
                return -1;
            if (i < 0)
                return 1;
            i = Wiek.CompareTo(inny.Wiek);
            if (i > 0)
                return 1;
            if (i < 0)
                return -1;
            return Nazwisko.CompareTo(inny.Nazwisko);
        }

        public abstract int PracownikValue();

        public override int GetHashCode()
        {
            return PracownikID;
        }

        public override string ToString()
        {
            return $"Imie: {Imie};Nazwisko: {Nazwisko};Doświadczenie: {Doswiadczenie};Wiek: {Wiek};Wartość Pracownika: {PracownikValue()} ;Miasto: {Adres.NazwaMiasta};";
        }

    }
}
