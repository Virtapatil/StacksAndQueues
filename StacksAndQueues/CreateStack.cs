using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class CreateStack<T>
    {
        private LinkedList<T> stack;

        public CreateStack()
        {
            stack = new LinkedList<T>();
        }

        public void Push(T value)
        {
            stack.AddFirst(value);
        }

        public T Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            T value = stack.First.Value;
            stack.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            return stack.First.Value;
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
    }
}
