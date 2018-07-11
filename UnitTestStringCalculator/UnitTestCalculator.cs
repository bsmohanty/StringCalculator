using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace UnitTestStringCalculator
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void TestEmptyString()
        {
            Calculator calculator = new Calculator();
            var input = "";
            var expectedOutput = 0;
            var output = calculator.Add(input);
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestUnknowAmountOfNumbers()
        {
            Calculator calculator = new Calculator();
            var input = "1\n2,3,1\n2,3,1\n2,3,1\n2,3,1\n2,3";
            var expectedOutput = false;
            var output = calculator.IsValidLength(input);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
