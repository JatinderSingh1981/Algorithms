using System;
using System.Collections.Generic;
using System.Text;

namespace Git_Alogrithms
{
    public class CountingUniveralSubarrays
    {
        /*
		    Counting Univeral Subarrays
		    A subarray is a group of contigous elements in an array.
            For instance, all subarrays of [1,2,3,4] as {[1],[2],[3],[4],[1,2],[2,3],[3,4],[1,2,3],[2,3,4],[1,2,3,4]}

		    In this challenge, you will be given an array comprised of 'x's and 'y's.
            A subarray of such an array is called "universal" if it matches the following conditions.

		    1. The 'x's and 'y's are grouped consecutively e.g. [1,2],[2,1],[1,1,2,2],[2,2,1,1],[1,1,1,2,2,2] etc
		    2. The numbder of 'x's in the subarray is equal to the number of 'y's in the subarray.

		    You must determine the total number of "universal" subarrays in the given array.

		    In an example, consider the array [1,1,2,2,1,2].
            The 4 subarrays matching the 2 conditions include { [1,1,2,2], [1,2], [2,1], [1,2] }.
		    Note that [1,2] appears twice, from indexes 1,2 and 4,5.
		    The other subarrays [1,1,2], [1,2,2], [2,2,1] etc match the first condition but not the 2nd one.
		    Similarly subarray [1,1,2,2,1,2] matches the 2nd condition but fail the first condition

	    */
        public static int countingUniveralSubarrays(int[] arr, int n, int x, int y)
        {
            int result = 0;

            // Check for each subarray for the required condition
            for (int i = 0; i < n; i++)
            {
                int totalX = 0, totalY = 0;
                int contCountX = 0; int contCountY = 0;
                for (int j = i; j < n; j++)
                {

                    //This will count total number of x variables and y variables
                    if (arr[j] == x)
                        totalX += 1;
                    else if (arr[j] == y)
                        totalY += 1;

                    //This will count consecutive x variables and y variables
                    if ((contCountX == 0 || (j > i && arr[j] == arr[j - 1])) && arr[j] == x)
                    {
                        contCountX += 1;
                    }

                    if ((contCountY == 0 || (j > i && arr[j] == arr[j - 1])) && arr[j] == y)
                    {
                        contCountY += 1;
                    }

                    //The comparison here makes sure that all subarrays are iterated properly here
                    //if(j>i && arr[j]!=arr[j-1] && ctX==ctY)
                    if (totalX == totalY && contCountX == totalX && contCountY == totalY)
                        result += 1;
                }

                Console.WriteLine("i == " + i);
                Console.WriteLine($"contCount{x} == " + contCountX + $" contCount{y} == " + contCountY);
                Console.WriteLine($"total{x} == " + totalX + $" total{y} == " + totalY);
                Console.WriteLine("result == " + result + " \n");
                //return result;
            }
            return (result);
        }
    }
}
