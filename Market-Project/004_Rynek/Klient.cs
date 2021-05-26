using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Rynek
{
    public class Klient
    {
        public double Dostepne_pieniadze { get; set; }
        public int czyKupuje { get; set; }
        public double inflacja { get; set; }

        public Klient(double _Dostepne_pieniadze, double _inflacja)
        {
            Dostepne_pieniadze = _Dostepne_pieniadze;
            inflacja = _inflacja;
        }

        public void kupic(Gra gra,Sprzedawca sprzedawca,Bank bank)
        {
            czyKupuje = new Random().Next(0, 2);
            if (czyKupuje == 1)
            {
                kupic(gra, sprzedawca, bank);
                Console.WriteLine($"Klient kupił {gra}");
                var oddanePieniadze = gra.kosztRobieniaGry + sprzedawca.zysk;
                Dostepne_pieniadze -= oddanePieniadze;
                sprzedawca.gry.Remove(gra);
            }
        }
        
        public void aktualizowac(double infacja)
        {
            this.inflacja = inflacja;
        }

        public override string ToString()
        {
            return $"Dostepne pieniadze {Dostepne_pieniadze}; czy kupuje(0 lub 1): {czyKupuje}; inflacja: {inflacja}";
        }
    }
}
