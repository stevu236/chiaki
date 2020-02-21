﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chiaki.Tests.StringExtensions
{
    [TestClass]
    public class FormattedTests
    {
        [TestMethod]
        public void Scenario1()
        {
            // Arrange
            string input = "this is a test {0} with a formatted argument";
            string expected = "this is a test method with a formatted argument";

            // Act
            string actual = input.Formatted("method");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Scenario2()
        {
            // Arrange
            string input = "this is a test {0} with {1} formatted {2}";
            string expected = "this is a test method with multiple formatted arguments";

            // Act
            string actual = input.Formatted("method", "multiple", "arguments");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}