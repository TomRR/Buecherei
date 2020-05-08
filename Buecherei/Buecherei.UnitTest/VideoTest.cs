using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buecherei.UnitTest
{
    [TestClass]
    public class VideoTest
    {
        [TestMethod]
        public void KannAusgeliehenWerden_MediumIstNichtVerliehenUndNichtUeberDerAusleihfrist_ReturnsTrue()
        {
            var video = new Video();
            video.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(15);
            
            bool kannAusgeliehenWerden = video.KannAusgeliehenWerden(dateTime);

            Assert.IsTrue(kannAusgeliehenWerden);
        }


        [TestMethod]
        public void KannAusgeliehenWerden_VideoIstNichtVerliehenUndNochNichtUeberDerAusleihfrist_ReturnsTrue()
        {
            var video = new Video();
            video.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(30);

            bool kannAusgeliehenWerden = video.KannAusgeliehenWerden(dateTime);

            Assert.IsTrue(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_VideoIstNichtVerliehenAberUeberDerAusleihfrist_ReturnsFalse()
        {
            var video = new Video();
            video.istAusgeliehen = false;
            DateTime dateTime = DateTime.Now.AddDays(31);

            bool kannAusgeliehenWerden = video.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_VideoIstVerliehenAberNichtUeberDerAusleihfrist_ReturnsFalse()
        {
            var video = new Video();
            video.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(15);

            bool kannAusgeliehenWerden = video.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_VideoIstVerliehenAberNochNichtUeberDerAusleihfrist_ReturnsFalse()
        {
            var video = new Video();
            video.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(30);

            bool kannAusgeliehenWerden = video.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void KannAusgeliehenWerden_VideoIstVerliehenUndUeberDerAusleihfrist_ReturnsFalse()
        {
            var video = new Video();
            video.istAusgeliehen = true;
            DateTime dateTime = DateTime.Now.AddDays(31);

            bool kannAusgeliehenWerden = video.KannAusgeliehenWerden(dateTime);

            Assert.IsFalse(kannAusgeliehenWerden);
        }

        [TestMethod]
        public void AusleihenBis_VideoStatusAendertSichZuIstAusgeliehen_ReturnsTrue()
        {
            var video = new Video();
            DateTime dateTime = DateTime.Now.AddDays(30);

            video.AusleihenBis(dateTime);

            Assert.IsTrue(video.istAusgeliehen);
        }

        [TestMethod]
        public void AusleihenBis_VideoArgumentWirdZumAusgeliehenBis_ReturnsTrue()
        {
            var video = new Video();
            DateTime dateTime = DateTime.Now.AddDays(30);

            video.AusleihenBis(dateTime);

            Assert.AreEqual(video.ausgeliehenBis, dateTime);
        }
    }
}
