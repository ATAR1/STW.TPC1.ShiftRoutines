using Microsoft.VisualStudio.TestTools.UnitTesting;
using STW.TPC1.ShiftRoutines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STW.TPC1.ShiftRoutines.Tests
{
    [TestClass()]
    public class ShiftSheldueTests
    {
        [TestMethod()]
        public void GetShiftTest()
        {
            ShiftSheldue sh = new ShiftSheldue();
            var shift = sh.GetShift(new DateTime(2017, 1, 12, 8, 0, 0));
            Assert.AreEqual('A', shift.Letter);
        }

        [TestMethod()]
        public void GetShiftTest2()
        {
            ShiftSheldue sh = new ShiftSheldue();
            var shift = sh.GetShift(new DateTime(2017, 1, 12, 7, 59, 59));
            Assert.AreEqual('D', shift.Letter);
        }

        [TestMethod()]
        public void GetShiftTest3()
        {
            ShiftSheldue sh = new ShiftSheldue();
            var shift = sh.GetShift(new DateTime(2017, 1, 12, 19, 59, 59));
            Assert.AreEqual('A', shift.Letter);
        }

        [TestMethod()]
        public void GetShiftTest4()
        {
            ShiftSheldue sh = new ShiftSheldue();
            var shift = sh.GetShift(new DateTime(2017, 1, 12, 20, 0, 0));
            Assert.AreEqual('B', shift.Letter);
        }

        [TestMethod()]
        public void GetShiftTest5()
        {
            ShiftSheldue sh = new ShiftSheldue();
            var shift = sh.GetShift(new DateTime(2019, 1, 24, 15, 29, 0));
            Assert.AreEqual('D', shift.Letter);
        }
    }
}