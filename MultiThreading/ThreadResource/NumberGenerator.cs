using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadResource
{
    internal class NumberGenerator
    {
        private List<int> numbers = Enumerable.Range(0, 100).ToList();

        private object lockObject = new object();
        public void PrintNumbers()
        {
            Monitor.Enter(lockObject);
            //lock (lockObject)
           // {
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            // }

            Monitor.Exit(lockObject);

          
        }
    }
}
