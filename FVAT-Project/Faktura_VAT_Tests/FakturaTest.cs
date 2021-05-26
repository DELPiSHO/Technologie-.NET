using System;
using System.Collections.Generic;
using System.Text;
using Faktura_VAT;
using NUnit.Framework;

namespace Faktura_VAT_Tests
{
    class FakturaTest
    {
        public Faktura _faktura;
        public Gra _gra;
        public Gra _gra2;
        public Gra _gra3;
        public Sprzedawca _sprzedawca;
        public Klient _klient;
        public Koszyk _koszyk;

        [SetUp]
        public void SetUp()
        {
            _gra = new Gra() { Nazwa = "Call of Duty MW 2019", Ilosc = 2, Cena_netto_jednostkowa = 220, Podatek_VAT = 0.23M };
            _gra2 = new Gra() { Nazwa = "The Last of Us 2", Ilosc = 1, Cena_netto_jednostkowa = 250, Podatek_VAT = 0.23M };
            _gra3 = new Gra() { Nazwa = "Dota2", Ilosc = 3, Cena_netto_jednostkowa = 10, Podatek_VAT = 0.23M };
            _koszyk = new Koszyk(_gra, _gra2,_gra3);
            _sprzedawca = new Sprzedawca() { Nazwa_Firmy = "Valve", Adres = "Perk", NIP = 0123456789, KontoBankowe = 111111111111111 };
            _klient = new Klient() { Nazwa_Firmy = "EpicGames", Adres = "Jugg", NIP = 9876543210, Email = "zhek@mail.ru" };
            _faktura = new Faktura(_koszyk, _klient, _sprzedawca, DateTime.Now.Date, DateTime.Now.Date, DateTime.Now.Date,"2020/11/01");
        }
        [Test]
        public void TestFaktura()
        {
            Assert.Pass();
        }
        [Test]
        public void GraIstnieje()
        {
            Assert.That(_faktura, Is.Not.Null);
        }
        [Test]
        public void FakturaSuma()
        {
            Assert.That(_faktura.Koszyk.DoZaplaty, Is.EqualTo(885.6M));
        }
        [Test]
        public void numerFaktury()
        {
            Assert.That(_faktura.NumerFaktury, Is.EqualTo("2020/11/01"));
        }
        [Test]
        public void NiepoprawnyEmail()
        {
            Assert.Throws<ArgumentException>(() => _faktura.Klient.Email = "zhek@gggg.com");
        }
        [Test]
        public void DataSprzedazy()
        {
            Assert.That(_faktura.DataSprzedazy, Is.EqualTo(DateTime.Now.Date));
        }
        [Test]
        public void IloscWKoszyku()
        {
            Assert.That(_faktura.Koszyk.IloscGier, Is.EqualTo(6));
        }
        [Test]
        public void PodatekVATSuma()
        {
            Assert.That(_faktura.Koszyk.PodatekVatWSumie, Is.EqualTo(165.6M));
        }
        [Test]
        public void Cena_Netto_W_Sumie()
        {
            Assert.That(_faktura.Koszyk.Cena_Netto_W_Sumie, Is.EqualTo(720M));
        }
        [Test]
        public void KontoBankoweExceptionFaktura()
        {
            Assert.Throws<ArgumentException>(() => _faktura.Sprzedawca.KontoBankowe = 23123);
        }
        [Test]
        public void Cena_netto_Pozycji()
        {
            Assert.That(_gra.Cena_netto_pozycji, Is.EqualTo(440M));
        }
        [Test]
        public void IleGierKupionoNiePowtarzajacych()
        {
            Assert.That(_faktura.Koszyk.IleGierKupiono, Is.EqualTo(3));
        }
    }
}
