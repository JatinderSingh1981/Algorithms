using System;
using System.Collections.Generic;
using System.Text;

namespace Git_Alogrithms
{
    public class WorstLosingStreak
    {
        /*
			Worst Losing Streak
			Given an array of daily prices, return the loss incurred by the greatest possible losing streak.
			A losing streak happens when you buy at one date and sell at a later date and the price you sell at is lower
			than the price you bought at. Return 0 if there are no losing streaks.

			1. Example
			price = [7,4,2,9]

			The greatest loss is incurred when you buy at a price of 7 and sell at a price of 2.
            Return the difference 5

			2. Example
			price = [2,4,6,8]
			The price went up everyday. Return 0
	*/
        public static int worstLosingStreak(List<int> nums)
        {
            int losingStreakNumber = 0;
            int differenceValue = 0;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    differenceValue = Math.Abs(nums[i]) - Math.Abs(nums[j]);
                    Console.WriteLine(Math.Abs(nums[i]) - Math.Abs(nums[j]));
                    Console.WriteLine(nums[i] - nums[j]);
                    if (differenceValue > losingStreakNumber)
                    {
                        losingStreakNumber = differenceValue;
                    }
                }
            }
            return losingStreakNumber;
        }
    }
}
