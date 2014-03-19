using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Library;

namespace UnitTests.Tests
{
    [TestClass]
    public class MathsTests
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Traitement à exécuter avant TOUS des tests (équivalent constructeur)
            // ex: Créer la base de données

            // context contient des informations sur la classe de test
        }

        [ClassCleanup]
        public static void ClassCleanup()
        { 
            // Traitement à exécuter après la fin de TOUS les tests
            // ex: Supprimer la base de données
        }

        [TestInitialize]
        public void TestInitialize()
        {
            // Traitement à exécuter avant de lancer CHAQUE test
            // ex: Remettre un compteur à 0 entre chaque test
            // ex: Créer une nouvelle instance de webservice
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Traitement à exécuter à la fin de CHAQUE test
            // ex: Remettre un compteur à 0 entre chaque test
            // ex: Créer une nouvelle instance de webservice
        }

        [TestMethod]
        public void SumTest()
        {
            // Teste si 5 + 3 = 8
            double somme = Maths.Sum(5, 3);
            Assert.AreEqual(8, somme);

            // Teste si 10 + 11 = 23
            somme = Maths.Sum(10, 11);
            Assert.AreEqual(21, somme);

            // Teste sur 24 + 3 < 28
            somme = Maths.Sum(24, 3);
            Assert.IsTrue(somme < 28);
        }

        [TestMethod]
        public void PowTest()
        {
            // Teste si 2 ^ 2 = 4
            double result = Maths.Pow(2, 2);
            Assert.AreEqual(result, 4);
        }

        //[TestMethod]
        //public void SumFailTest()
        //{
        //    double somme = Maths.Sum(24, 3);
        //    Assert.AreEqual(28,somme);
        //}

        [TestMethod]
        public void DivideTest()
        {
            // Teste si 10 / 2 = 5
            double result = Maths.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivideExceptionTest()
        {
            // Test que l'exception de type ArgumentOutOfRangeException est bien levée
           Maths.Divide(10, 0);
        }
    }
}