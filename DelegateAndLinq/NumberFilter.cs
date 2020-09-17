using System;
using System.Collections.Generic;

namespace DelegateAndLinq
{
    public class NumberFilter
    {
        public delegate bool FilterMethod(int x);
        public List<int> FilterOutEvens(List<int> numbers)
        {
            //  return Filter(numbers, IsOdd); //Send in the function that fits FilterMethods signature
            //return Filter(numbers, delegate (int x) { return x % 2 != 0; }); //Anonymous Functions
            return Filter(numbers, (x) => x % 2 != 0); //Lambda that returns a bool
        }

        public List<int> FilterOutOdds(List<int> numbers)
        {
            //  return Filter(numbers, IsEven);
            //return Filter(numbers, delegate (int x) { return x % 2 == 0; }); //Anonymous Functions
            return Filter(numbers, (x) => x % 2 == 0);
        }

        private static List<int> Filter(List<int> numbers, FilterMethod m)
        {
            var results = new List<int>();
            foreach (var num in numbers)
            {
                if (m(num)) //Don't need to call invoke since it is a default methods
                {
                    results.Add(num);
                }
            }
            return results;
        }

        //private static bool IsOdd(int num)
        //{
        //    return num % 2 != 0;
        //}

        //private static bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //}
    }
}