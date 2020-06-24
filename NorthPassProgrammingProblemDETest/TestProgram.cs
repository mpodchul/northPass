using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NorthPassProgrammingProblemDE;

namespace NorthPassProgrammingProblemDETest
{
    [TestClass]
    public class TestProgram
    {
        [TestMethod]
        public void TestProblem()
        {
            Assert.AreEqual((Program.findItems(100, 3, "5 75 25") == "Items: 2 3" ? "Pass" : "Fail"),"Pass");
            Assert.AreEqual((Program.findItems(200, 7, "150 24 79 50 88 345 3") == "Items: 1 4" ? "Pass" : "Fail"),"Pass");
            Assert.AreEqual((Program.findItems(8, 8, "2 1 9 4 4 56 90 3") == "Items: 4 5" ? "Pass" : "Fail"),"Pass");
        }
    }
}
