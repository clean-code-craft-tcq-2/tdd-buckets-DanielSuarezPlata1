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
        public void ConvertAnalogReading12BitsToAmpsTest()
        {
            int sizeOfReading = 12;

            int analogReading = 1146;

            int amps = Program.ConvertAnalogReadingToAmps(analogReading, sizeOfReading);

            Assert.AreEqual(amps, 3);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Reading exceeds the maximum value")]
        public void ConvertAnalogReading12BitsToAmps_ExceedMaximumReadingTest()
        {
            int sizeOfReading = 12;

            int analogReading = 4095;

            int amps = Program.ConvertAnalogReadingToAmps(analogReading, sizeOfReading);
        }

        [TestMethod]
        public void ConvertAnalogReading10BitsToAmps_PositiveCurrentTest()
        {
            int sizeOfReading = 10;

            int analogReading = 1022;

            int amps = Program.ConvertAnalogReadingToAmps(analogReading, sizeOfReading);

            Assert.AreEqual(amps, 15);

        }

        [TestMethod]
        public void ConvertAnalogReading10BitsToAmps_AbsoluteCurrentTest()
        {
            int sizeOfReading = 10;

            int analogReading = 0;

            int amps = Program.ConvertAnalogReadingToAmps(analogReading, sizeOfReading);

            Assert.AreEqual(amps, 15);

        }


    }
}