using NUnit.Framework;
using System;
using Faktura_VAT;


namespace Faktura_VAT_Tests
{
    public class GryTest
    {
        public Gra _sut;
        public Gra _sut2;
        [SetUp]
        public void SetUp()
        {
            _sut  = new Gra() { Nazwa = "Call of Duty MW 2019", Ilosc = 2, Cena_netto_jednostkowa = 220, Podatek_VAT = 0.23M };
            _sut2 = new Gra() { Nazwa = "The Last of Us 2", Ilosc = 1, Cena_netto_jednostkowa = 250, Podatek_VAT = 0.23M };
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void GraIstnieje()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void GraIstnieje2()
        {
            Assert.That(_sut2, Is.Not.Null);
        }
        [Test]
        public void NazwaGry()
        {
            Assert.That(_sut.Nazwa, Is.EqualTo("Call of Duty MW 2019"));
        }
        [Test]
        public void IloscKupionejGry()
        {
            Assert.That(_sut.Ilosc, Is.EqualTo(2));
        }
        [Test]
        public void Cena_NETTO(){
            Assert.That(_sut.Cena_netto_jednostkowa, Is.EqualTo(220));
        }
        [Test]
        public void KwotaVAT_W_Calosci()
        {
            Assert.That(_sut.Kwota_VAT, Is.EqualTo(101.20M));
        }
        [Test]
        public void Cena_brutto_w_Calosci()
        {
            Assert.That(_sut.Cena_brutto, Is.EqualTo(541.20M));
        }
        [Test]
        public void NazwaDrugiejGry()
        {
            Assert.That(_sut2.Nazwa, Is.EqualTo("The Last of Us 2"));
        }
        [Test]
        public void KwotaVatdlaJednejGry()
        {
            Assert.That(_sut2.Kwota_VAT, Is.EqualTo(57.50M));
        }
        [Test]
        public void CenaBrutto_DrugiejGry()
        {
            Assert.That(_sut2.Cena_brutto, Is.EqualTo(307.50M));
        }
        [Test]
        public void GraToString()
        {
            Assert.That(_sut.ToString, Is.EqualTo("Call of Duty MW 2019;2;220 zl za 1 kopie;440 zl netto;23.00 % VAT;101.20 Kwota VAT;541.20 Cena brutto;"));
        }
    }
}