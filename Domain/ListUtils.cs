using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ListUtils
    {
        public static List<T> Diff<T>(List<T> list1, List<T> list2)
        {
            List<T> myList=new List<T>();

            foreach(var i in list1)
            {
                if (list2.Contains(i))
                {
                    continue;
                }

                else
                {
                    myList.Add(i);
                }
            }

            return myList;
        }

    }
}
