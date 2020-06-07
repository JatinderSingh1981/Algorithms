using System;
using System.Linq;
using Xunit;
using Git_Alogrithms;
using System.Collections.Generic;

namespace Git_Algorithms_Tests
{
    public class WorstLosingStreak_Tests
    {
        [Theory]
        [InlineData(new int[] { 7, 4, 2, 9 })]
        public void TestWorstLosingStreak(int[] losingStreakArray)
        {
            var result = WorstLosingStreak.worstLosingStreak(losingStreakArray.ToList());

            Assert.Equal(result, 5);
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8 })]
        [InlineData(new int[] { 2, 4, 6, 8, 10, 12 })]
        [InlineData(new int[] { 14, 20, 30, 50, 100, 200, 700, 900, 1200 })]
        public void TestWorstLosingStreak2(int[] losingStreakArray)
        {
            var result = WorstLosingStreak.worstLosingStreak(losingStreakArray.ToList());

            Assert.Equal(result, 0);
        }
        [Theory]
        [InlineData(new int[] { 1, 8, 4, 2, 10, 3, 2 })]
        [InlineData(new int[] { 1, 9, 3, 1, 10, 3, 2 })]
        public void TestWorstLosingStreak3(int[] losingStreakArray)
        {
            var result = WorstLosingStreak.worstLosingStreak(losingStreakArray.ToList());

            Assert.Equal(result, 8);
        }
        [Theory]
        [InlineData(new int[] { 745, 543, 621, 410, 81, 28, 830, 753, 438, 711, 228, 631, 328, 952, 215, 256, 407, 959, 351, 718, 699, -28, 494, 764, 151, 579, 782, 704,
            976, 22, 216, -175, 626, 838, 744, 530, 303, 365, -18, -7, 178, 163, -5, 628, 662, 757, -154, 324, 720, 844, 259, 842, 902, 489, 412, 282, 28, 131, -73, 494,
            618, 912, 534, 603, 865, -246, 937, 182, 833, 675, -84, 781, -156, 845, 697, 646, 335, 821, -58, 334, 15, 307, 311, 311, 413, 547, 433, -166, 877, -129 })]
        public void TestWorstLosingStreak4(int[] losingStreakArray)
        {
            var result = WorstLosingStreak.worstLosingStreak(losingStreakArray.ToList());

            Assert.Equal(result, 971);
        }
    }
}
