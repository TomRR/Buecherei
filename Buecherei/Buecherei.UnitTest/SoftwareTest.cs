using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buecherei.UnitTest
{
    [TestClass]
    public class SoftwareTest
    {
        [TestMethod]
        public void KannAusgeliehenWerden_SoftwareIstNichtVerliehenUndNichtUeberDerAusleihfrist_ReturnsTrue()
        {
            var software = new Software();
            software.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(3);

            bool kannAusgeliehenWerden = software.KannAusgeliehenWerden(dateTime);

            Assert.IsTrue(kannAusgeliehenWerden);
        }


        [TestMethod]
        public void KannAusgeliehenWerden_SoftwareIstNichtVerliehenUndNochNichtUeberDerAusleihfrist_ReturnsTrue()
        {
            var software = new Software();
            software.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(7);

            bool kannAusgeliehenWerden = software.KannAusgeliehenWerden(dateTime);

            Assert.IsTrue(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_SoftwareIstNichtVerliehenAberUeberDerAusleihfrist_ReturnsFalse()
        {
            var software = new Software();
            software.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(8);

            bool kannAusgeliehenWerden = software.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_SoftwareIstVerliehenAberNichtUeberDerAusleihfrist_ReturnsFalse()
        {
            var software = new Software();
            software.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(3);

            bool kannAusgeliehenWerden = software.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_SoftwareIstVerliehenAberNochNichtUeberDerAusleihfrist_ReturnsFalse()
        {
            var software = new Software();
            software.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(7);

            bool kannAusgeliehenWerden = software.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_SoftwareIstVerliehenUndUeberDerAusleihfrist_ReturnsFalse()
        {
            var software = new Software();
            software.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(8);

            bool kannAusgeliehenWerden = software.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void AusleihenBis_SoftwareStatusAendertSichZuIstAusgeliehen_ReturnsTrue()
        {
            var software = new Software();
            DateTime dateTime = DateTime.Now.AddDays(7);

            software.AusleihenBis(dateTime);

            Assert.IsTrue(software.istAusgeliehen);
        }

        [TestMethod]
        public void AusleihenBis_SoftwareArgumentWirdZumAusgeliehenBis_ReturnsTrue()
        {
            var software = new Software();
            DateTime dateTime = DateTime.Now.AddDays(7);

            software.AusleihenBis(dateTime);

            Assert.AreEqual(software.ausgeliehenBis, dateTime);
        }
    }
}
