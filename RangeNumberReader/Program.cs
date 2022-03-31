using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace RangeNumberReader
{
    public class Program
    {
        public static float maximumTemperatureAmperes = 10f;
        public static float maximumTemparatureAnalogReading = 4094;

        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            
        }

        public static int FetchNumberOfReadings(List<int> listOfNumbers,int rangeFrom, int rangeTo)
        {
            listOfNumbers = listOfNumbers.OrderBy(x => x).ToList();

            int numberOfReadings = listOfNumbers.Where(x => x >= rangeFrom && x <= rangeTo).Count();

            return numberOfReadings;
        }

        public static int ConvertAnalogReadingToAmperes(int reading)
        {
            if (reading > maximumTemparatureAnalogReading)
                throw new Exception("Reading exceeds the maximum value");

            int amperes = (int)Math.Ceiling(maximumTemperatureAmperes * reading / maximumTemparatureAnalogReading);

            return amperes;
        }
    }
}
