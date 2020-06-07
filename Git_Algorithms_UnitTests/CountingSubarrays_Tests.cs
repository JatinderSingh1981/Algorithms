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
        [InlineData(new int[] { 1, 2, 1 }, 1, 1)]
        [InlineData(new int[] { 1, 2, 1 }, 4, 5)]
        public void TestCountingSubarrays(int[] listToSearch, int x, int y)
        {
            var result = CountingSubarrays.countingSubarrays(listToSearch, listToSearch.Length, x, y);

            Assert.Equal(result, 6);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 1 }, 1, 2)]
        public void TestCountingSubarrays2(int[] listToSearch, int x, int y)
        {
            var result = CountingSubarrays.countingSubarrays(listToSearch, listToSearch.Length, x, y);

            Assert.Equal(result, 2);
        }
    }
}
