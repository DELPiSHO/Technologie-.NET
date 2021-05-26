using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Faktura_VAT;

namespace Faktura_VAT_Tests
{
    class OsobaTest
    {
        public Sprzedawca _sut;
        public Klient _sut2;
        [SetUp]
        public void SetUp()
        {
            _sut  = new Sprzedawca() { Nazwa_Firmy = "Valve", Adres = "Perk", NIP = 0123456789, KontoBankowe =111111111111111};
            _sut2 = new Klient() { Nazwa_Firmy = "EpicGames", Adres = "Jugg", NIP = 9876543210, Email = "zhek@mail.ru" };
        }
        [Test]
        public void TestCzyWszystkoJestOk()
        {
            Assert.Pass();
        }
        [Test]
        public void OsobaIstnieje()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void NazwaFirmySprzedawcy()
        {
            Assert.That(_sut.Nazwa_Firmy, Is.EqualTo("Valve"));
        }
        [Test]
        public void SprawdzamyNipSprzedawcy()
        {
            Assert.That(_sut.NIP, Is.EqualTo(0123456789));
        }
        [Test]
        public void SprawdzamyAdresSprzedawcy()
        {
            Assert.That(_sut.Adres, Is.EqualTo("Perk"));
        }
        [Test]
        public void NazwaFirmyKlienta()
        {
            Assert.That(_sut2.Nazwa_Firmy, Is.EqualTo("EpicGames"));
        }
        [Test]
        public void AdresKlienta()
        {
            Assert.That(_sut2.Adres, Is.EqualTo("Jugg"));
        }
        [Test]
        public void NumerNipKlienta()
        {
            Assert.That(_sut2.NIP, Is.EqualTo(9876543210));
        }
        [Test]
        public void EmailKlienta()
        {
            Assert.That(_sut2.Email, Is.EqualTo("zhek@mail.ru"));
        }
        [Test]
        public void CzyEmailExceptionDziala()
        {
            Assert.Throws<ArgumentException>(() => _sut2.Email = "zhek@gmail.com");
        }
        [Test]
        public void CzyKontoBankoweZapisanePoprawnie()
        {
            Assert.That(_sut.KontoBankowe, Is.EqualTo(111111111111111));
        }
        [Test]
        public void CzyKontoBankoweExceptionDziala()
        {
            Assert.Throws<ArgumentException>(() => _sut.KontoBankowe = 1111);
        }
    }
}
