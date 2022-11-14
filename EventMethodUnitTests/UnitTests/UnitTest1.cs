using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace EventMethodUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EventInfo discount = new EventInfo(1, "Test", 20.00);
            double unitPrice = discount.CostEngine("d");
            Assert.AreEqual(unitPrice, 18);
        }

        [TestMethod]
        public void TestMethod2()
        {
            EventInfo employee = new EventInfo(1, "Test", 20.00);
            double unitPrice = employee.CostEngine("e");
            Assert.AreEqual(unitPrice, 15);
        }

        [TestMethod]
        public void Testmethod3()
        {
            EventInfo late = new EventInfo(1, "Test", 20.00);
            double unitPrice = late.CostEngine("l");
            Assert.AreEqual(unitPrice, 22);
        }

        [TestMethod]
        public void TestMethod4()
        {
            EventInfo free = new EventInfo(1, "Test", 20.00);
            double unitPrice = free.CostEngine("f");
            Assert.AreEqual(unitPrice, 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            EventInfo doNothing =  new EventInfo(1, "Test", 20.00);
            double unitPrice = doNothing.CostEngine("DoNothing");
            Assert.AreEqual(unitPrice, 20.00);
        }
    }
}