using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mediatheque.Core.Model;

namespace Mediatheque.CoreTests.ModelTests.ObjetDePretTests
{
    [TestClass]
    public class EmprunteShould
    {
        [TestMethod]
        public void FillEmprunteur()
        {
            //Arrange
            var objetDePret = new ObjetDePret("Scie sauteuse");

            //Act
            objetDePret.Emprunte("bernard");

            //Assert
            Assert.AreEqual("bernard", objetDePret.Emprunteur);
        }

        [TestMethod]
        public void ReturnTrue_IfObjetIsAvailable()
        {
            //Arrange
            var objetDePret = new ObjetDePret("chaise");

            //Act
            bool actual = objetDePret.Emprunte("albert");

            //Assert
            Assert.IsTrue(actual);
            Assert.AreEqual("albert", objetDePret.Emprunteur);
        }

        [TestMethod]
        public void ReturnFalse_IfObjetIsNotAvailable()
        {
            //Arrange
            var objetDePret = new ObjetDePret("chaise");
            objetDePret.Emprunteur = "Alain";

            //Act
            bool actual = objetDePret.Emprunte("albert");

            //Assert
            Assert.IsFalse(actual);
            Assert.AreEqual("Alain", objetDePret.Emprunteur);
        }
    }
}
