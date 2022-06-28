using NUnit.Framework;
using Domain;
using System.Collections.Generic;

namespace Domain.Tests
{
    public class Tests
    {
        [SetUp]

        [Test]
        public void ToAcronymTest()
        {
            StringUtils util = new StringUtils();
            util.InputString = "a b c";

            Assert.AreEqual( "ABC", util.ToAcronym());
        }

        [Test]
        public void GetStatsTest()
        {
            List<decimal> list = new List<decimal>() { 3, 5, 6, 2, 9 };

            Stats st = Analysis.GetStats(list);
            // for min
            Assert.AreEqual(2, st.Min);
            Assert.AreEqual(9, st.Max);
            Assert.AreEqual(5, st.Avg);

        }

        [Test]
        public void GetDiffTest()
        {List<decimal> list = new List<decimal>() { 3, 5, 6, 2, 9 };

           
            Assert.AreEqual(new List<int>() { 1, 3 }, ListUtils.Diff(new List<int>() { 1, 2, 3 }, new List<int>() { 2 }));
           

        }
    }
}