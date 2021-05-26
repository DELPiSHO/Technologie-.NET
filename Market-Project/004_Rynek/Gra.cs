using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Rynek
{
    public class Gra : IKomponent
    {
        public string nazwaGry { get; set; }
        public double kosztRobieniaGry { get; set; }

        public Gra(string _nazwaGry,double _kosztRobieniaGry)
        {
            nazwaGry = _nazwaGry;
            kosztRobieniaGry = _kosztRobieniaGry;
        }

        public void akceptowac(IOdwiedzajacy odwiedzajacy)
        {
            odwiedzajacy.sprawdzGry(this);
        }

        public void akceptujInflacje(double inflacja)
        {
            kosztRobieniaGry *= inflacja;
        }

        public override string ToString()
        {
            return $"Nazwa gry: {nazwaGry}; Koszt robienia gry: {kosztRobieniaGry}";
        }
    }
}
