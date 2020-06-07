using System;
using System.Linq;
using Xunit;
using Git_Alogrithms;
using System.Collections.Generic;

namespace Git_Algorithms_Tests
{
    public class CountingUniversalArrays_Tests
    {
        //int[] arr = { 1, 2, 2, 3, 4, 1 };
        //int[] arr = { 4,4,2,2,4,2 };
        //int[] arr = { 4, 2, 2, 4, 2, 2 };

        [Theory]
        [InlineData(new int[] { 4, 4, 2, 2, 4, 2 }, 2, 4, 4)]
        //[InlineData(new int[] { 1, 2, 1 }, 4, 5)]
        public void TestCountingUniversalArrays(int[] listToSearch, int x, int y, int expectedValue)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var result = CountingUniveralSubarrays.countingUniveralSubarrays(listToSearch, listToSearch.Length, x, y);

            Assert.Equal(result, expectedValue);
        }
    }
}
