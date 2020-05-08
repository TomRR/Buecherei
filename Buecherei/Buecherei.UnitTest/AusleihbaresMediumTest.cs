using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Buecherei.UnitTest
{
    [TestClass]
    public class AusleihbaresMediumTest
    {
        [TestMethod]
        public void KannAusgeliehenWerden_MediumIstNichtVerliehenUndNichtUeberDerAusleihfrist_ReturnsTrue()
        {
            var medium = new AusleihbaresMedium();
            medium.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(15);

            bool kannAusgeliehenWerden = medium.KannAusgeliehenWerden(dateTime);

            Assert.IsTrue(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_MediumIstNichtVerliehenUndNochNichtUeberDerAusleihfrist_ReturnsTrue()
        {
            var medium = new AusleihbaresMedium();
            medium.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(30);

            bool kannAusgeliehenWerden = medium.KannAusgeliehenWerden(dateTime);

            Assert.IsTrue(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_MediumIstNichtVerliehenAberUeberDerAusleihfrist_ReturnsFalse()
        {
            var medium = new AusleihbaresMedium();
            medium.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(31);

            bool kannAusgeliehenWerden = medium.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_MediumIstVerliehenAberNichtUeberDerAusleihfrist_ReturnsFalse()
        {
            var medium = new AusleihbaresMedium();
            medium.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(15);

            bool kannAusgeliehenWerden = medium.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_MediumIstVerliehenAberNochNichtUeberDerAusleihfrist_ReturnsFalse()
        {
            var medium = new AusleihbaresMedium();
            medium.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(30);

            bool kannAusgeliehenWerden = medium.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_MediumIstVerliehenUndUeberDerAusleihfrist_ReturnsFalse()
        {
            var medium = new AusleihbaresMedium();
            medium.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(31);

            bool kannAusgeliehenWerden = medium.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void AusleihenBis_MediumStatusAendertSichZuIstAusgeliehen_ReturnsTrue()
        {
            var medium = new AusleihbaresMedium();
            DateTime dateTime = DateTime.Now.AddDays(30);

            medium.AusleihenBis(dateTime);

            Assert.IsTrue(medium.istAusgeliehen);
        }

        [TestMethod]
        public void AusleihenBis_MediumArgumentWirdZumAusgeliehenBis_ReturnsTrue()
        {
            var medium = new AusleihbaresMedium();
            DateTime dateTime = DateTime.Now.AddDays(30);

            medium.AusleihenBis(dateTime);

            Assert.AreEqual(medium.ausgeliehenBis, dateTime);
        }
    }
}
