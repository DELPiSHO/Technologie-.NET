using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pracownicy
{
    public class Rejestr
    {
        public Dictionary<int, Pracownik> _pracownicy = new Dictionary<int, Pracownik>();
        public IPracownikValidator[] _walidatory;
        public Rejestr(params IPracownikValidator[] walidatory)
        {
            _walidatory = walidatory;
        }

        public void _walidacjaPracownika(Pracownik pracownik)
        {
            foreach(var walidator in _walidatory)
            {
                walidator.PrzedDodaniem(pracownik);
            }
        }

        public void _poStworzeniuPracownikaWalidator(Pracownik pracownik)
        {
            foreach(var walidator in _walidatory)
            {
                walidator.PoDodaniu(pracownik);
            }
        }

        public void _poUsunieciuPracownikaWalidator(Pracownik pracownik)
        {
            foreach(var walidator in _walidatory)
            {
                walidator.PoUsunieciu(pracownik);
            }
        }
        public void DodajPracownikow(params Pracownik[] pracownicy)
        {
            foreach(var pracownik in pracownicy)
            {
                _walidacjaPracownika(pracownik);
                _pracownicy.Add(pracownik.PracownikID, pracownik);
                _poStworzeniuPracownikaWalidator(pracownik);
            }
        }

        public void UsunPracownika(int pracownikID)
        {
            if (_pracownicy.ContainsKey(pracownikID))
            {
                var pracownik = _pracownicy[pracownikID];
                _pracownicy.Remove(pracownikID);
                _poUsunieciuPracownikaWalidator(pracownik);
            }
            else
            {
                throw new Exception("Nie ma pracownika o takim identyfikatorze");
            }
        }

        public List<Pracownik> ListaWszyskichPracownikow()
        {
            var pracownicy = _pracownicy.Values.ToList();
            pracownicy.Sort();
            return pracownicy;
        }

        public List<Pracownik> PracownicyPoWybranymMiescie(string miasto)
        {
            return _pracownicy.Values.ToList().Where(pracownik => pracownik.Adres.NazwaMiasta.Equals(miasto)).ToList();
        }
        
        public double WartoscPracownika(Pracownik pracownik)
        {
            double wartoscpracownika = pracownik.PracownikValue();
            return wartoscpracownika;
        }      
    }
}
