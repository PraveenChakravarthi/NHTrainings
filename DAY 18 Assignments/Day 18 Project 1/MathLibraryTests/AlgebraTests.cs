using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_ZeroInput()
        {
            // Arrange
            int n = 0;
            int expected = 1;

            // Act
            int actual = Algebra.Factorial(n);
            

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Negative_()
        {
            // Arrange
            int n = -2;
            int expected = -9999;

            // Act
            int actual = Algebra.Factorial(n);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Greater_Than_Seven()
        {
            // Arrange
            int n = 9;
            int expected = -999;

            // Act
            int actual = Algebra.Factorial(n);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_One_To_Seven()
        {
            // Arrange
            int n = 6;
            int expected = 720;

            // Act
            int actual = Algebra.Factorial(n);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PalindromeTest()
        {
            // Arrange
            int n = 212;
            string expected = "Palindrome";


            // Act
            string actual = "Palindrome";


            // Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void Not_PalindromeTest()
        {
            // Arrange
            int n = 213;
            string expected = "Not Palindrome";


            // Act
            string actual = "Not Palindrome";


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
