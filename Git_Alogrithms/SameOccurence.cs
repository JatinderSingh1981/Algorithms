using System;

namespace Git_Alogrithms
{
    public class CountingSubarrays
    {
        /*
		Count subarrays with equal number of occurrences of two given elements
		Given an array and two integers say, x and y, find the number of subarrays in which the number of occurrences of x is equal to number of occurrences of y.
		Examples:

		Input : arr[] = {1, 2, 1},
				x = 1, y = 2
		Output : 2
		The possible sub-arrays have same equal number
		of occurrences of x and y are:
		1) {1, 2}, x and y have same occurrence(1).
		2) {2, 1}, x and y have same occurrence(1).

		Input : arr[] = {1, 2, 1},
				x = 4, y = 6
		Output : 6
		The possible sub-arrays have same equal number of
		occurrences of x and y are:
		1) {1}, x and y have same occurrence(0).
		2) {2}, x and y have same occurrence(0).
		3) {1}, x and y have same occurrence(0).
		1) {1, 2}, x and y have same occurrence(0).
		2) {2, 1}, x and y have same occurrence(0).
		3) {1, 2, 1}, x and y have same occurrence(0).

		Input : arr[] = {1, 2, 1},
				x = 1, y = 1
		Output : 6
		The possible sub-arrays have same equal number
		of occurrences of x and y are:
		1) {1}, x and y have same occurrence(1).
		2) {2}, x and y have same occurrence(0).
		3) {1}, x and y have same occurrence(1).
		1) {1, 2}, x and y have same occurrence(1).
		2) {2, 1}, x and y have same occurrence(1).
		3) {1, 2, 1}, x and y have same occurrences (2).
	*/

        public static int countingSubarrays(int[] arr, int n, int x, int y)
        {
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int countX = 0, countY = 0;
				// Check for each subarray for the required condition
				for (int j = i; j < n; j++)
                {
                    if (arr[j] == x)
						countX += 1;
                    if (arr[j] == y)
						countY += 1;

                    //The comparison at this particular point will make sure that all subarrays are iterated properly here
                    if (countX == countY)
                        result += 1;
                }
                Console.WriteLine(result);
            }
            return (result);
        }
    }
}
