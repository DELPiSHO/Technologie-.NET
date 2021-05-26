using System;
using System.Collections.Generic;
using System.Text;

namespace Pracownicy
{
    public class WalidacjaStanowiska: IPracownikValidator
    {
        public HashSet<int> _pozycjeStanowiskaBiurowego = new HashSet<int>();
        public void PrzedDodaniem(Pracownik pracownik)
        {
            if (pracownik is PracownikBiurowy pracownikBiurowy)
            {
                if (_pozycjeStanowiskaBiurowego.Contains(pracownikBiurowy.PracownikBiurowyID))
                {
                    throw new Exception("Ta pozycja w biurze jest już zajęta.");
                }
            }
        }

        public void PoDodaniu(Pracownik pracownik)
        {
            if (pracownik is PracownikBiurowy pracownikBiurowy)
            {
                _pozycjeStanowiskaBiurowego.Add(pracownikBiurowy.PracownikBiurowyID);
            }
        }

        public void PoUsunieciu(Pracownik pracownik)
        {
            if (pracownik is PracownikBiurowy pracownikBiurowy)
            {
                _pozycjeStanowiskaBiurowego.Remove(pracownikBiurowy.PracownikBiurowyID);
            }
        }
    }
}
