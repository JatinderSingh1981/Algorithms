using System;
using System.Linq;
using Xunit;
using Git_Alogrithms;
using System.Collections.Generic;

namespace Git_Algorithms
{
    public class CountingSubarrays_Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 1 }, 1, 1, 6)]
        [InlineData(new int[] { 1, 2, 1 }, 4, 5, 6)]
        [InlineData(new int[] { 1, 2, 1 }, 1, 2, 2)]
        public void TestCountingSubarrays(int[] listToSearch, int x, int y, int expectedValue)
        {
            var result = CountingSubarrays.countingSubarrays(listToSearch, listToSearch.Length, x, y);

            Assert.Equal(result, expectedValue);
        }
    }
}
