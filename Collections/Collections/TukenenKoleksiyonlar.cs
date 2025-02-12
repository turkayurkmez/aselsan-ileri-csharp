using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class TukenenKoleksiyonlar
    {
        private Queue<string> _queue = new Queue<string>(); 
        private Stack<string> _stack = new Stack<string>();

        public void AddToQueue(string item)
        {
            _queue.Enqueue(item);
        }

        public void ProcessQueue()
        {
            while (_queue.Count > 0)
            {
                var item = _queue.Dequeue();
                Console.WriteLine(item);
            }
        }

        public void AddToStack(string item)
        {
            _stack.Push(item);
        }

        public void ProcessStack()
        {
            while (_stack.Count > 0)
            {
                var item = _stack.Pop();
                Console.WriteLine(item);
            }
        }

    }
}
