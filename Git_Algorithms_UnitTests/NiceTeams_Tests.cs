using System;
using System.Linq;
using Xunit;
using Git_Alogrithms;
using System.Collections.Generic;

namespace Git_Algorithms_Tests
{
    public class NiceTeams_Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 23, 24, 25 }, 3)]
        [InlineData(new int[] { 25107191, 123232501, 151290765, 183012194, 473251358, 579542802, 689345248, 709552565, 803612259, 862726097, 994391793 }, 440987423)]
        [InlineData(new int[] { 58938146, 219080001, 290589043, 306989605, 318554335, 345194195, 376420327, 509674780, 802573599, 939226418 }, 22586934)]
        public void TestNiceTeams(int[] teams, int minDiff)
        {
            var result = NiceTeams.niceTeams(teams.ToList(), minDiff);

            Assert.Equal(result, 5);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 2, 2, 1, 1 }, 2)]
        public void TestNiceTeams2(int[] teams, int minDiff)
        {
            var result = NiceTeams.niceTeams(teams.ToList(), minDiff);

            Assert.Equal(result, 0);
        }

        [Theory]
        [InlineData(new int[] { 3, 4, 5, 2, 1, 1 }, 3)]
        public void TestNiceTeams3(int[] teams, int minDiff)
        {
            var result = NiceTeams.niceTeams(teams.ToList(), minDiff);

            Assert.Equal(result, 2);
        }
    }
}
