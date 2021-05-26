using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Rynek
{
    public class Odwiedzajacy: IOdwiedzajacy
    {
        public double infalcja { get; set; }
        public void sprawdzGry(params Gra[] gry)
        {
            foreach(var gra in gry)
            {
                gra.akceptujInflacje(infalcja);
            }
        }
    }
}
