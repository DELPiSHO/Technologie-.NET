using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Rynek
{
    public interface IPrzedmiot
    {
        void dolacz(IObserwator obserwator);
        void dolacz(params IObserwator[] obserwatorzy);
        void odlacz(IObserwator obserwator);
        void notyfikacja(double inflacja);
    }
}
