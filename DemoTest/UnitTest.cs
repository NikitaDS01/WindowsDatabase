using Microsoft.VisualStudio.TestTools.UnitTesting;
using SF2022User22Lib;
using System;

namespace DemoTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_ArrayDurations_Longer()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40,
            };
            Calculations test = new Calculations();
            Assert.ThrowsException<Exception>(() => test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                30
                ));
        }
        [TestMethod]
        public void Test_ArrayStartTimes_Longer()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10
            };
            Calculations test = new Calculations();
            Assert.ThrowsException<Exception>(() => test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                30
                ));
        }
        [TestMethod]
        public void Test_ConsultationTime_Zero()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            Assert.ThrowsException<Exception>(() => test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                0
                ));
        }
        [TestMethod]
        public void Test_ConsultationTime_More_EndWorkingTime()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            Assert.ThrowsException<Exception>(() => test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                700
                ));
        }
        [TestMethod]
        public void Test_IntervalWorkingTime_NotEquals()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            Assert.ThrowsException<Exception>(() => test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(18, 0, 0),
                new TimeSpan(8, 0, 0),
                30
                ));
        }
        [TestMethod]
        public void Test_Result()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            Assert.AreEqual(14, test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                30
                ).Length);
        }
        [TestMethod]
        public void Test_IntervalWorkingTime_Equals()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            Assert.ThrowsException<Exception>(() => test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(18, 0, 0),
                new TimeSpan(18, 0, 0),
                30
                ));
        }
        [TestMethod]
        public void Test_InstanceType()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            Assert.IsInstanceOfType(test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                30
                ), typeof(string[]));
        }
        [TestMethod]
        public void Test_IsNotNull()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            Assert.IsNotNull(test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                30
                ));
        }
        [TestMethod]
        public void Test_LenghtIsNotZero()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            Assert.IsTrue(test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                30
                ).Length!=0);
        }
    }
}
