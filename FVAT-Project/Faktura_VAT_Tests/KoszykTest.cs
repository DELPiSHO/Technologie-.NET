using System;
using System.Collections.Generic;
using System.Text;
using Faktura_VAT;
using NUnit.Framework;

namespace Faktura_VAT_Tests
{
    class KoszykTest
    {
        public Gra _sut;
        public Gra _sut2;
        public Koszyk _kosz;
        [SetUp]
        public void SetUp()
        {
            _sut = new Gra() { Nazwa = "Call of Duty MW 2019", Ilosc = 2, Cena_netto_jednostkowa = 220, Podatek_VAT = 0.23M };
            _sut2 = new Gra() { Nazwa = "The Last of Us 2", Ilosc = 1, Cena_netto_jednostkowa = 250, Podatek_VAT = 0.23M };
            _kosz = new Koszyk(_sut, _sut2);
        }
        [Test]
        public void Test3()
        {
            Assert.Pass();
        }
        [Test]
        public void KoszykIstnieje()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void CzyWszystkieGryWidzi()
        {
            Assert.That(_sut.Ilosc, Is.EqualTo(2));
        }
        [Test]
        public void DoZaplatyTest()
        {
            Assert.That(_kosz.DoZaplaty, Is.EqualTo(848.70M));
        }
    }
}
