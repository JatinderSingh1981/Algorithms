using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Git_Alogrithms
{
    public class NiceTeams
    {
        /*

		    A coach of school chess club wants to start a entoring program for newer players. Each player has an integer rating representing skill level.
		    The coach would like to pair up students whose rating differ by no less than a given minimum.
		    What is the maximum number of pairs that can be formed?

		    Example:
		    rating = [1,2,3,4,5,6], minDiff = 4

		    There are n=6 players. 2 pairs of players have a difference of 4 or more, those with rating (1,5) and (2,6)

	    */

        public static int niceTeams(List<int> teams, int minDiff)
        {
            int pairCount = 0;
            teams= teams.OrderByDescending(x=>x).ToList();

            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine("Next I Element at == " + teams.ElementAt(i));
                Console.WriteLine("Team total count == " + teams.Count());

                for (int j = i + 1; j < teams.Count; j++)
                {
                    int diff = Math.Abs(teams[i]) - Math.Abs(teams[j]);
                    Console.WriteLine(diff);
                    if (diff >= minDiff)
                    {
                        pairCount += 1;
                        Console.WriteLine("Removing J Element at == " + teams.ElementAt(j));
                        Console.WriteLine("Removing I Element at == " + teams.ElementAt(i));
                        teams.RemoveAt(j);
                        teams.RemoveAt(i);

                        i = i - 1;
                        break;
                    }

                }

            }

            return pairCount;
        }
    }
}
