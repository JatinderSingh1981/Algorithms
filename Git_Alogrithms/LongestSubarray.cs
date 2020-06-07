using System;
using System.Collections.Generic;
using System.Linq;

namespace Git_Alogrithms
{
    public class LongestSubarray
    {
        /*
			Longest Subarray

			Given an array of integers, what is the length of the longest subarray containing no more than 2 distinct values
			such that the distinct values differ by no more than 1

			Example 1
			array = [0,1,2,1,2,3]
			The largest such subarray has length 4. [1,2,1,2]

			Example 2
			array = [1,1,1,3,3,2,2]
			The largest such subarray has length 4. [3,3,2,2].
			The values 1 and 3 differ by more than 1 so subarray [1,1,1,3,3] is not valie
		*/

        public static int longestSubarray(List<int> arr)
        {
            int subArrayCount = 0;
            int maxSubArrayValue = 0;
            int valueJ = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                //Console.WriteLine("Value at i == " + i + " of " + arr[i]);
                subArrayCount = 0;
                for (int j = i + 1; j < arr.Count(); j++)
                {
                    //Console.WriteLine("Value of i == " + arr[i] + " Value of j == " + j + " value of subArrayCount == " + subArrayCount);

                    //Save the current value of j. We will need this to move i ahead.
                    //Remember we don't need to iterate the array part which we already have iterated
                    valueJ = j;
                    if (arr[i] == arr[j] || (arr[i] + 1 == arr[j]) || (arr[i] - 1 == arr[j]))
                    {
                        //We need to increment the value by 2 for the first time because remember our
                        //1st element is in array[i] and 2nd element is in array[j]
                        if (subArrayCount == 0)
                            subArrayCount = 2;
                        else
                            subArrayCount++;


                    }
                    else
                    {
                        break;
                    }
                }
                //If we have not reached the end of the subarray then move the outer array ahead else we are done. We don't need to re-iterate the arrays
                if (valueJ != arr.Count() - 1)
                    i = valueJ - 1;
                //Console.WriteLine("***********");
                //Console.WriteLine("Value at i == " + i);//+ " of " + arr[i]);

                //If subArrayCount has exceeded the maxSubArrayValue we already have, then set the value in the maxSubArrayValue variable
                if (subArrayCount > maxSubArrayValue)
                {
                    maxSubArrayValue = subArrayCount;
                    //Console.WriteLine("***********");

                }
            }
            return maxSubArrayValue;
        }
    }
}
