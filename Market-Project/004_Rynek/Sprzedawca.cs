using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Rynek
{
    public class Sprzedawca : IObserwator
    {
        public List<Gra> gry = new List<Gra>();
        public double inflacja { get; set; }
        public double zysk { get; set; }

        public Sprzedawca(double _zysk,double _inflacja)
        {
            zysk = _zysk;
            inflacja = _inflacja;
        }
        public void aktualizowac(double inflacja)
        {
            this.inflacja = inflacja;
        }
        /*
        public void startSymulacji(params Gra[] gry)
        {
            this.gry.AddRange(gry);
        }
        */
        public override string ToString()
        {
            return base.ToString() + $"Zysk: {zysk};Inflacja: {inflacja}";
        }
    }
}
