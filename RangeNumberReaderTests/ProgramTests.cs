using Microsoft.VisualStudio.TestTools.UnitTesting;
using RangeNumberReader;
using System;
using System.Collections.Generic;
using System.Text;

namespace RangeNumberReader.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void FetchNumberOfReadingsTest()
        {
            List<int> listOfNumbers = new List<int> {3,3,5,4,10 };

            int numberOfReadings = Program.FetchNumberOfReadings(listOfNumbers, 4, 5);

            Assert.AreEqual(numberOfReadings, 2);
        }

        [TestMethod]
        public void ConvertAnalogReadingToAmperesTest()
        {

            int analogReading = 1146;

            int amperes = Program.ConvertAnalogReadingToAmperes(analogReading);

            Assert.AreEqual(amperes, 3);

        }

    }
}