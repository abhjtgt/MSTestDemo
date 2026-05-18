using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathDemo;

namespace MathDemoCode.Tests
{
    [TestClass]
    public class MathDemoCodeTests
    {
        [TestMethod]
        public void Sum_Int_ReturnsExpected()
        {
            Assert.AreEqual(5, MathWorks.Sum(2, 3));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_Double_ByZero_ThrowsDivideByZeroException()
        {
            MathWorks.Divide(1.0, 0.0);
        }
    }
}
