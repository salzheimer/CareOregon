using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CareOregonTest; 
namespace CareOregonTest_Tests
{
    [TestClass]
    public class Program_Tests
    {
        [TestMethod]
        public void CalculateFibonacci_CanOuput()
        {
            var co =  new CareOregonTest.Program() ;
            var result = co.CalculateFibonacci(3);

            Assert.IsTrue(result > 0, "Result not greater than zero");

        }
        [TestMethod]
        public void CalculateFibonacci_CanOuput_Position_10()
        {
            var co = new CareOregonTest.Program();
            var result = co.CalculateFibonacci(10);

            Assert.IsTrue(result > 0, "Result not greater than zero");
            Assert.AreEqual(89, result, "Result for position 10 is " + result + " and should be 89");
        }
        [TestMethod]
        public void CalculateFibonacci_CanOuput_Positions_40()
        {
            var co = new CareOregonTest.Program();
            var result = co.CalculateFibonacci(40);

            Assert.IsTrue(result > 0, "Result not greater than zero");
            Assert.AreEqual(165580141, result, "Result for position 40 is " + result + " and should be 165580141");
        }
    }
}
