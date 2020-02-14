using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolynomialApp;
namespace PolynomialTest
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        public void PolynomialDegree_Returns_One()
        {
            // Arrange
            Polynomial polyA = new Polynomial(2,4);

            // Act
            var actual = polyA;

            // Assert
            Assert.AreEqual(1, actual.Degree);
        }

        [TestMethod]
        public void PolynomialShow_Returns_String()
        {
            // Arrange
            Polynomial polyA = new Polynomial(2,4);
            string expected = $"2 + 4X";

            // Act
            var actual = polyA.Show();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
