using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace RangeNumberReader
{
    public class Program
    {
        public static float maximumTemperatureAmps = 10f;
        public static float maximumTemparatureAnalogReading = 4094;

        static Dictionary<int, MaximumTemperature> maximumTemperatures = new Dictionary<int, MaximumTemperature>
        {
            { 12, new MaximumTemperature {amps = 10f, analogReading = 4094, minValue = 0} },
            { 10, new MaximumTemperature {amps = 15f, analogReading = 1022, minValue = 511} }
        };

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

        public static int ConvertAnalogReadingToAmps(int reading, int sizeOfReading)
        {
            if (reading > maximumTemparatureAnalogReading)
                throw new Exception("Reading exceeds the maximum value");

            if (reading < maximumTemperatures[sizeOfReading].minValue)
                reading = maximumTemperatures[sizeOfReading].analogReading - reading;

            int amps = (int)Math.Abs(Math.Ceiling(maximumTemperatures[sizeOfReading].amps * reading / maximumTemperatures[sizeOfReading].analogReading));

            return amps;
        }
    }
}
