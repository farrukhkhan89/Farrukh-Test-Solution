using Domain;
using System;
using System.Collections.Generic;

namespace TestApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringUtils util = new StringUtils();
            //util.InputString = "a b c";
            Analysis.GetStats(new List<decimal>() { 3, 5, 6, 2, 9 });

            //util.ToAcronym();
            //List<decimal> d = new List<decimal>() { 4, 5, 6, 7 };
            //Analysis.GetStats(new List<decimal>() { 4, 5, 6, 7 });

            ListUtils.Diff(new List<int>() { 1, 2, 3 }, new List<int>() { 2 });
        }
    }
}
