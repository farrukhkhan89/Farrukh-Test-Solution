using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Analysis
    {
        public static Stats GetStats (List<decimal> list)
        {
            Stats stat = new Stats();
            stat.Min= list.Min();
            stat.Max = list.Max();
            stat.Avg = list.Average();


            return stat;
        }
    }

    public struct Stats 
    {
        public decimal Min;
        public decimal Max;
        public decimal Avg;

    }

}
