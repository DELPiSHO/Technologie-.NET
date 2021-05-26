using System;
using System.Collections.Generic;
using System.Text;

namespace Pracownicy
{
    public class PracownikFizyczny : Pracownik
    {
        public int _silaFizyczna;
        public int SilaFizyczna
        {
            get => _silaFizyczna;
            set
            {
                if (value <= 1)
                    throw new Exception("Siła fizyczna nie może być mniejsza niż 1");
                else if (value > 100)
                    throw new Exception("Siła fizyczna nie może być większa niż 100");
                else
                    _silaFizyczna = value;
            }
        }
        public PracownikFizyczny(int pracownikID,string imie,string nazwisko,int wiek,int doswiadczenie,Adres adres,int silaFizyczna)
            : base(pracownikID, imie, nazwisko, wiek, doswiadczenie, adres)
        {
            SilaFizyczna = silaFizyczna;
        }
        public override int PracownikValue()
        {
            return (Doswiadczenie * SilaFizyczna) / Wiek; 
        }

        public override string ToString()
        {
            return base.ToString() + $"Siła Fizyczna: {SilaFizyczna}\n"; 
        }
    }
}
