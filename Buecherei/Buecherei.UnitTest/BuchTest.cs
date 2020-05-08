using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buecherei.UnitTest
{
    [TestClass]
    public class BuchTest
    {
        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstNichtVerliehenNichtUeberDerAusleihfristUndNichtInDerReparatur_ReturnsTrue()
        {
            var buch = new Buch();
            buch.istAusgeliehen = false;
            buch.InReparatur = false;
            DateTime dateTime = DateTime.Now.AddDays(15);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsTrue(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstNichtVerliehenNochNichtUeberDerAusleihfristUndNichtInDerReparatur_ReturnsTrue()
        {
            var buch = new Buch();
            buch.istAusgeliehen = false;
            buch.InReparatur = false;
            DateTime dateTime = DateTime.Now.AddDays(30);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsTrue(kannAusgeliehenWerden);
        }        
        
        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstNichtVerliehenNichtInDerReparaturAberUeberDerAusleihfristUnd_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = false;
            buch.InReparatur = false;
            DateTime dateTime = DateTime.Now.AddDays(31);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstNichtVerliehenNichtUeberDerAusleihfristAberInDerReparatur_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = false;
            buch.InReparatur = true;
            DateTime dateTime = DateTime.Now.AddDays(15);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }


        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstNichtVerliehenNochNichtUeberDerAusleihfristAberInDerReparatur_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = false;
            buch.InReparatur = true;
            DateTime dateTime = DateTime.Now.AddDays(30);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstNichtVerliehenAberUeberDerAusleihfristUndInDerReparatur_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = false;
            buch.InReparatur = true;
            DateTime dateTime = DateTime.Now.AddDays(31);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstVerliehenAberNichtUeberDerAusleihfristOderInDerReparatur_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = true;
            buch.InReparatur = false;
            DateTime dateTime = DateTime.Now.AddDays(15);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstVerliehenAberNochNichtUeberDerAusleihfristOderInDerReparatur_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = true;
            buch.InReparatur = false;
            DateTime dateTime = DateTime.Now.AddDays(30);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstVerliehenUeberDerAusleihfristAberInDerReparatur_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = true;
            buch.InReparatur = false;
            DateTime dateTime = DateTime.Now.AddDays(31);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstVerliehenInDerReparaturAberNichtUeberDerAusleihfrist_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = true;
            buch.InReparatur = true;
            DateTime dateTime = DateTime.Now.AddDays(15);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstVerliehenInDerReparaturAberNochNichtUeberDerAusleihfrist_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = true;
            buch.InReparatur = true;
            DateTime dateTime = DateTime.Now.AddDays(30);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_BuchIstVerliehenInDerReparaturUndUeberDerAusleihfrist_ReturnsFalse()
        {
            var buch = new Buch();
            buch.istAusgeliehen = true;
            buch.InReparatur = true;
            DateTime dateTime = DateTime.Now.AddDays(31);

            bool kannAusgeliehenWerden = buch.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void AusleihenBis_BuchStatusAendertSichZuIstAusgeliehen_ReturnsTrue()
        {
            var buch = new Buch();
            DateTime dateTime = DateTime.Now.AddDays(30);

            buch.AusleihenBis(dateTime);

            Assert.IsTrue(buch.istAusgeliehen);
        }

        [TestMethod]
        public void AusleihenBis_BuchArgumentWirdZumAusgeliehenBis_ReturnsTrue()
        {
            var buch = new Buch();
            DateTime dateTime = DateTime.Now.AddDays(30);

            buch.AusleihenBis(dateTime);

            Assert.AreEqual(buch.ausgeliehenBis, dateTime);
        }
    }
}
