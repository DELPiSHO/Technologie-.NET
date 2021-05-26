using NUnit.Framework;
using Pracownicy;

namespace Pracownicy_Test
{
    public class AdresTest
    {
        public Adres adres;
        [SetUp]
        public void Setup()
        {
            adres = new Adres("Gdansk", "Wita Stwosza", "58", "112");
        }

        [Test]
        public void TestPass()
        {
            Assert.Pass();
        }
        [Test]
        public void CheckAdress()
        {
            Assert.That(adres.NazwaMiasta, Is.EqualTo("Gdansk"));
        }
        public void CheckLokal()
        {
            Assert.That(adres.NumerLokalu, Is.EqualTo("112"));
        }
    }
}