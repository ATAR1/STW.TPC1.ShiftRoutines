using Microsoft.VisualStudio.TestTools.UnitTesting;
using STW.TPC1.ShiftRoutines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STW.TPC1.ShiftRoutines.Tests
{
    [TestClass()]
    public class TimeIntervalTests
    {
        [TestMethod()]
        public void TimeIntervalTest()
        {
            TimeInterval ti = new TimeInterval(8, 20);
            Assert.AreEqual(TimeSpan.FromHours(8), ti.StartTime);
            Assert.IsTrue(new TimeSpan(19, 59, 59) <= ti.EndTime && TimeSpan.FromHours(20) > ti.EndTime);
        }
    }
}