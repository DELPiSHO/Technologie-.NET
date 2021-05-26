using System;
using System.Collections.Generic;
using System.Text;

namespace Pracownicy
{
    public class Korporacja
    {
        private static Korporacja korporacja;
        private int _pracownikID;

        private Korporacja(int pracownikID)
        {
            _pracownikID = pracownikID;
        }

        public static Korporacja DostacEgzemplaz()
        {
            return korporacja ??= new Korporacja(0);
        }

        public PracownikBiurowy DodajPracownikaBiurowego(string imie,string nazwisko,int wiek,int doswiadczenie,Adres adres,int iq,int PracownikBiurowyID)
        {
            _pracownikID++;
            return new PracownikBiurowy(_pracownikID, imie, nazwisko, wiek, doswiadczenie, adres, iq, PracownikBiurowyID);
        }

        public PracownikFizyczny DodajPracownikaFizycznego(string imie,string nazwisko,int wiek,int doswiadczenie,Adres adres,int silaFizyczna)
        {
            _pracownikID++;
            return new PracownikFizyczny(_pracownikID, imie, nazwisko, wiek, doswiadczenie, adres, silaFizyczna);
        }

        public Handlarz DodajHandlarza(string imie,string nazwisko,int wiek,int doswiadczenie,Adres adres, Handlarz.Efektywnosc efektywnosc,int prowizja)
        {
            _pracownikID++;
            return new Handlarz(_pracownikID, imie, nazwisko, wiek, doswiadczenie, adres, efektywnosc, prowizja);
        }
    }
}
