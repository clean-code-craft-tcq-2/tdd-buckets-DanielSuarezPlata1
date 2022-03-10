using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace RangeNumberReader
{
    public class Program
    {
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
    }
}
