using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DelegateAndLinq
{
    public class FilteringNumbers
    {
        [Fact]
        public void CanFilterOutEvenNumbers()
        {
            var numberFilter = new NumberFilter();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> results = numberFilter.FilterOutEvens(numbers);

            Assert.Equal(1, results[0]);
            Assert.Equal(3, results[1]);
            Assert.Equal(5, results[2]);
            Assert.Equal(7, results[3]);
            Assert.Equal(9, results[4]);
        }

        [Fact]
        public void CanFilterOutOddNumbers()
        {
            var numberFilter = new NumberFilter();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> results = numberFilter.FilterOutOdds(numbers);

            Assert.Equal(2, results[0]);
            Assert.Equal(4, results[1]);
            Assert.Equal(6, results[2]);
            Assert.Equal(8, results[3]);
        }
    }
}
