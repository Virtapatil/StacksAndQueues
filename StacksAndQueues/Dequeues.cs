using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class LinkedListQueue<T>
    {
        private LinkedList<T> queue;

        public LinkedListQueue()
        {
            queue = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            queue.AddLast(value);
        }

        public T Dequeue()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("The queue is empty.");

            T value = queue.First.Value;
            queue.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("The queue is empty.");

            return queue.First.Value;
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }
    }
}
