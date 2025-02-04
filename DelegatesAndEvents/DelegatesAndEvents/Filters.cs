using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Filters
    {
        //public delegate bool Criteria(int number);
        public static   int[] Filter(int[] array, Func<int,bool> criteria)
        {
            List<int> result = new List<int>();
            foreach (var number in array)
            {
                if (criteria(number))
                {
                    result.Add(number);
                }
            }

            return result.ToArray();
        }


    }
}
