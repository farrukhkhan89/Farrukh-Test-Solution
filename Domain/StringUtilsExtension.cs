using System;
using System.Collections.Generic;
using Microsoft.Bot.Builder;

namespace Domain
{
    public static class StringUtilsExtension
    {
        public static string ToAcronym(this StringUtils util)
        {
            string[] str = util.InputString.Split(' ');
            string acronym = string.Empty;

            foreach(string st in str)
            {
                acronym += st[0].ToString().ToUpper() ;
            }

            return acronym;

        }
    }


    public class StringUtils
    {
        public string InputString { get; set; }
    }

}
