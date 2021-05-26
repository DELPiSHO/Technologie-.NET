using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Pracownicy;

namespace Pracownicy_Test
{
    public class RejestrTest
    {
        public Rejestr _rejestr;
        public Pracownik[] _pracownicy;
        public Adres _adres;
        public Adres _adres2;
        public Adres _adres3;
        public Adres _adres4;
        public Adres _adres5;
        public Adres _adres6;

        [SetUp]
        public void SetUp()
        {
            _adres = new Adres("Lublin", "Randomowa", "23", "123");
            _adres2 = new Adres("Wołkowysk", "Zenitczykow", "14", "1");
            _adres3 = new Adres("Wołkowysk", "Pankowej", "54B", "14");
            _adres4 = new Adres("Strzyżewice", "Bystrzyca Nowa", "111111", "3");
            _adres5 = new Adres("Simferopol", "Pobedy", "23", "1");
            _adres6 = new Adres("Wołkowysk", "Gorbatowa", "23", "46");

            _rejestr = new Rejestr(new WalidacjaStanowiska());
            var pracownikBiurowy1 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Eugeniusz", "Denisow", 22, 2, _adres, 75, 10);
            var pracownikBiurowy2 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Władysław", "Randomowy", 21, 1, _adres2, 74, 110);
            var pracownikBiurowy3 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Anastazja", "Randomowa", 18, 10, _adres3, 135, 123);
            var pracownikBiurowy4 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Teresa", "Nierandomowa", 47, 26, _adres3, 150, 1);
            var pracownikBiurowy5 = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Teresaaa", "Nierandomosdwa", 70, 26, _adres3, 150, 1);


            var pracownikFizyczny1 = Korporacja.DostacEgzemplaz().DodajPracownikaFizycznego("Jura", "Kowalski", 27, 9, _adres5, 99);
            var pracownikFizyczny2 = Korporacja.DostacEgzemplaz().DodajPracownikaFizycznego("Władysław", "Kiman", 30, 3, _adres6, 70);

            var handlarz1          = Korporacja.DostacEgzemplaz().DodajHandlarza("Paweł", "Milko", 23, 4, _adres6, Handlarz.Efektywnosc.HIGH, 5);
            var handlarz2          = Korporacja.DostacEgzemplaz().DodajHandlarza("Wiktoria", "Classified", 21, 3, _adres4, Handlarz.Efektywnosc.MEDIUM, 19);
            var testHandlarz       = Korporacja.DostacEgzemplaz().DodajHandlarza("Test", "Testowicz", 66, 40, _adres4, Handlarz.Efektywnosc.LOW, 77);

            _pracownicy = new Pracownik[10] { pracownikBiurowy1, pracownikBiurowy2, pracownikBiurowy3, pracownikBiurowy4, pracownikFizyczny1, pracownikFizyczny2, handlarz1, handlarz2,testHandlarz,pracownikBiurowy5 };
        }
        [Test]
        public void DodawaniePracownika()
        {
            _rejestr.DodajPracownikow(_pracownicy[0], _pracownicy[1], _pracownicy[2], _pracownicy[3], _pracownicy[4], _pracownicy[5], _pracownicy[6], _pracownicy[7],_pracownicy[8]);
            Assert.That(_rejestr.ListaWszyskichPracownikow().Count, Is.EqualTo(9));
        }

        [Test]
        public void UsunieciePracownika()
        {
            _rejestr.DodajPracownikow(_pracownicy[0], _pracownicy[8]);
            _rejestr.UsunPracownika(_pracownicy[8].PracownikID);
            Assert.That(_rejestr.ListaWszyskichPracownikow().Count, Is.EqualTo(1));
        }

        [Test]
        public void UsunieciePracownikaWyjatek()
        {
            _rejestr.DodajPracownikow(_pracownicy[0], _pracownicy[8]);
            Assert.Throws<Exception>(() => _rejestr.UsunPracownika(10000));
        }

        [Test]
        public void sortowaniePracownikow()
        {
            _rejestr.DodajPracownikow(_pracownicy[0], _pracownicy[1], _pracownicy[2], _pracownicy[3], _pracownicy[4], _pracownicy[5], _pracownicy[6], _pracownicy[7], _pracownicy[8]);
            var pracownicy = _rejestr.ListaWszyskichPracownikow().ToArray();
            Assert.That(pracownicy[0], Is.EqualTo(_pracownicy[8]));
            Assert.That(pracownicy[1], Is.EqualTo(_pracownicy[3]));
            Assert.That(pracownicy[2], Is.EqualTo(_pracownicy[2]));
            Assert.That(pracownicy[3], Is.EqualTo(_pracownicy[4]));
            Assert.That(pracownicy[4], Is.EqualTo(_pracownicy[6]));
            Assert.That(pracownicy[5], Is.EqualTo(_pracownicy[7]));
            Assert.That(pracownicy[6], Is.EqualTo(_pracownicy[5]));
            Assert.That(pracownicy[7], Is.EqualTo(_pracownicy[0]));
            Assert.That(pracownicy[8], Is.EqualTo(_pracownicy[1]));
        }
        
        [Test]
        public void ListaPracownikowWTymSamymMiescie()
        {
            _rejestr.DodajPracownikow(_pracownicy[0], _pracownicy[1], _pracownicy[2], _pracownicy[3], _pracownicy[4], _pracownicy[5], _pracownicy[6], _pracownicy[7], _pracownicy[8]);
            Assert.That(_rejestr.PracownicyPoWybranymMiescie("Wołkowysk").Count, Is.EqualTo(5));
            Assert.That(_rejestr.PracownicyPoWybranymMiescie("Lublin").Count, Is.EqualTo(1));
        }

        [Test]
        public void WartoscPracownikaTest()
        {
            _rejestr.DodajPracownikow(_pracownicy[0], _pracownicy[1], _pracownicy[2], _pracownicy[3], _pracownicy[4], _pracownicy[5], _pracownicy[6], _pracownicy[7], _pracownicy[8]);
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[0]), Is.EqualTo(150));
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[1]), Is.EqualTo(74));
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[2]), Is.EqualTo(1350));
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[3]), Is.EqualTo(3900));
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[4]), Is.EqualTo(33));
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[5]), Is.EqualTo(7));
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[6]), Is.EqualTo(480));
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[7]), Is.EqualTo(270));
            Assert.That(_rejestr.WartoscPracownika(_pracownicy[8]), Is.EqualTo(2400));
        }
        [Test]
        public void DublikatStanowistkaID()
        {
            _rejestr.DodajPracownikow(_pracownicy[3]);
            Assert.Throws<Exception>(() => _rejestr.DodajPracownikow(_pracownicy[9]));
        }
    }
}
