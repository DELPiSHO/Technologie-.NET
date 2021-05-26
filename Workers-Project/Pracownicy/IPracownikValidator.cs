using System;
using System.Collections.Generic;
using System.Text;

namespace Pracownicy
{
    public interface IPracownikValidator
    {
        public void PoUsunieciu(Pracownik pracownik);
        public void PrzedDodaniem(Pracownik pracownik);
        public void PoDodaniu(Pracownik pracownik);
    }
}
