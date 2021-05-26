using System;
using System.Collections.Generic;

namespace Pracownicy
{
    class Program
    {
        public static void Main(string[] args)
        {
            var _rejestr = new Rejestr();

            List<Pracownik> poMiastam = new List<Pracownik>();
            List<Pracownik> posortowaniPracownicy = new List<Pracownik>();

            var _adres = new Adres("Lublin", "Randomowa", "23", "123");
            var _adres2 = new Adres("Wołkowysk", "Zenitczykow", "14", "1");
            var _adres3 = new Adres("Wołkowysk", "Pankowej", "54B", "14");
            var _adres4 = new Adres("Strzyżewice", "Bystrzyca Nowa", "111111", "3");
            var _adres5 = new Adres("Simferopol", "Pobedy", "23", "1");
            var _adres6 = new Adres("Wołkowysk", "Gorbatowa", "23", "46");

            var pracownikBiurowy1 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Eugeniusz", "Denisow", 22, 2, _adres, 75, 10);
            var pracownikBiurowy2 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Władysław", "Randomowy", 21, 1, _adres2, 74, 110);
            var pracownikBiurowy3 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Anastazja", "Randomowa", 18, 10, _adres3, 135, 123);
            var pracownikBiurowy4 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Teresa", "Nierandomowa", 47, 26, _adres3, 150, 1);

            var pracownikFizyczny1 = Korporacja.DostacEgzemplaz().DodajPracownikaFizycznego("Jura", "Kowalski", 27, 9, _adres5, 99);
            var pracownikFizyczny2 = Korporacja.DostacEgzemplaz().DodajPracownikaFizycznego("Władysław", "Kiman", 30, 3, _adres6, 70);

            var handlarz1 = Korporacja.DostacEgzemplaz().DodajHandlarza("Paweł", "Milko", 23, 4, _adres6, Handlarz.Efektywnosc.HIGH, 5);
            var handlarz2 = Korporacja.DostacEgzemplaz().DodajHandlarza("Wiktoria", "Classified", 21, 3, _adres4, Handlarz.Efektywnosc.MEDIUM, 19);
            var testHandlarz = Korporacja.DostacEgzemplaz().DodajHandlarza("Test", "Testowicz", 66, 40, _adres4, Handlarz.Efektywnosc.LOW, 77);

            var _pracownicy = new Pracownik[9] { pracownikBiurowy1, pracownikBiurowy2,pracownikBiurowy3,pracownikBiurowy4,pracownikFizyczny1,pracownikFizyczny2,handlarz1,handlarz2,testHandlarz };

            _rejestr.DodajPracownikow(pracownikBiurowy1, pracownikBiurowy2, pracownikBiurowy3, pracownikBiurowy4, pracownikFizyczny1, pracownikFizyczny2, handlarz1, handlarz2, testHandlarz);

            Console.WriteLine("Lista wszystkich pracowników => \n");

            foreach (var pracownik in _pracownicy)
            {
                Console.WriteLine(pracownik.ToString());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Lista Pracownikow w podanym mieście => \n");

            poMiastam = _rejestr.PracownicyPoWybranymMiescie("Wołkowysk");

            foreach (var miasto in poMiastam)
            {
                Console.WriteLine(miasto);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Posortowana Lista Pracowników wedlug doswiadczenia,wieku i nazwiska => \n");

            posortowaniPracownicy = _rejestr.ListaWszyskichPracownikow();

            foreach (var pracownik in posortowaniPracownicy)
            {
                Console.WriteLine(pracownik);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------"); 
        }
    }
}
