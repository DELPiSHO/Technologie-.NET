using System;
using System.Collections.Generic;
using System.Text;

namespace Pracownicy
{
    public class PracownikBiurowy : Pracownik
    {
        public int PracownikBiurowyID { get; }
        public int _iq;
        public int IQ
        {
            get => _iq;
            set
            {
                if (value <= 70)
                    throw new Exception("IQ jest za mały");
                else if (value > 151)
                    throw new Exception("IQ jest za duży");
                else
                    _iq = value;
            }
        }
        public PracownikBiurowy(int pracownikID,string imie,string nazwisko,int wiek,int doswiadczenie,Adres adres,int iq,int pracownikBiudowyID)
            : base(pracownikID, imie, nazwisko, wiek, doswiadczenie, adres)
        {
            IQ = iq;
            PracownikBiurowyID = pracownikBiudowyID;
        }
        public override int PracownikValue()
        {
            return Doswiadczenie * IQ;
        }
        public override string ToString()
        {
            return base.ToString() + $"IQ: {IQ} ; ID Pracownika Biurowego: {PracownikBiurowyID}\n";
        }
    }
}
