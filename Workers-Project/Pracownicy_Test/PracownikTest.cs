using System;
using System.Collections.Generic;
using System.Text;
using Pracownicy;
using NUnit.Framework;

namespace Pracownicy_Test
{
    public class PracownikTest
    {
        public PracownikBiurowy _pracownikBiurowy;
        public PracownikFizyczny _pracownikFizyczny;
        public Rejestr _rejestr;
        public Pracownik[] _pracownicy;
        public Adres _adres;

        [SetUp]
        public void SetUp()
        {
            _adres = new Adres("Gdansk", "Wita Stwosza", "58", "112"); 
            _rejestr   = new Rejestr(new WalidacjaStanowiska());
            _pracownikBiurowy  = Korporacja.DostacEgzemplaz().DodajPracownikaBiurowego("Eugeniusz", "Denisow", 22, 2, _adres, 75, 10);
            _pracownikFizyczny = Korporacja.DostacEgzemplaz().DodajPracownikaFizycznego("Jura", "Kowalski", 27, 9, _adres, 99);
        }
        
        [Test]
        public void getIQ()
        {
            Assert.That(_pracownikBiurowy.IQ, Is.EqualTo(75));
        }
        [Test]
        public void IQExcetionToLow()
        {
            Assert.Throws<Exception>(() => _pracownikBiurowy.IQ = 70);
        }

        [Test]
        public void IQExcetionToHigh()
        {
            Assert.Throws<Exception>(() => _pracownikBiurowy.IQ = 160);
        }

        [Test]
        public void getCity()
        {
            Assert.That(_pracownikBiurowy.Adres.NazwaMiasta, Is.EqualTo("Gdansk"));
        }

        [Test]
        public void getSilaFizyczna()
        {
            Assert.That(_pracownikFizyczny.SilaFizyczna, Is.EqualTo(99));
        }

        [Test]
        public void SilaFizycznaException()
        {
            Assert.Throws<Exception>(() => _pracownikFizyczny.SilaFizyczna = 101);
        }
    }
}
