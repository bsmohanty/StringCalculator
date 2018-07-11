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
    }
}
