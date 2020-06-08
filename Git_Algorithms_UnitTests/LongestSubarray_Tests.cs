using System;
using System.Linq;
using Xunit;
using Git_Alogrithms;
using System.Collections.Generic;

namespace Git_Algorithms_Tests
{
    public class LongestSubarray_Tests
    {
        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 0, 1, 2, 1, 2, 3 }, 4)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 3, 2, 2 }, 5)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 3, 3, 2, 2 }, 5)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 2, 2 }, 4)]
        public void TestLongestSubArray(int[] teams, int expectedValue)
        {
            var result = LongestSubarray.longestSubarray(teams.ToList());

            Assert.Equal(result, expectedValue);
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 0, 1, 2, 1, 2, 3 }, 4)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 3, 2, 2 }, 5)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 3, 3, 2, 2 }, 5)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 2, 2 }, 4)]
        public void TestLongestSubArraySimpleAlgo(int[] teams, int expectedValue)
        {
            var result = LongestSubarray.longestSubarraySimpleAlgo(teams.ToList());

            Assert.Equal(result, expectedValue);
        }
    }
}
