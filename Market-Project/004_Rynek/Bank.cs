using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Rynek
{
    public class Bank : IPrzedmiot
    {
        Random rnd = new Random();

        public double inflacja { get; set; }
        public double dochod { get; set; }
        public double ostatniDochod { get; set; }

        public List<IObserwator> obserwatorzy = new List<IObserwator>;

        public Bank(double _inflacja,double _dochod,double _ostatniDochod)
        {
            inflacja = _inflacja;
            dochod = _dochod;
            ostatniDochod = _ostatniDochod;
        }

        public void dolacz(IObserwator obserwator)
        {
            obserwatorzy.Add(obserwator);
        }
        public void dolacz(params IObserwator[] obserwatorzy)
        {
            this.obserwatorzy.AddRange(obserwatorzy);
        }

        public void notify(double inflacja)
        {
            foreach (IObserwator obserwator in obserwatorzy)
            {
                obserwator.aktualizowac(inflacja);
            }
        }
        /*
        public void zmienicInflacje()
        {
             rnd = ???
        }
        */

    }
}
