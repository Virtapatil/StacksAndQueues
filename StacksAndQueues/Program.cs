﻿namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CreateStack<int> stack = new CreateStack<int>();

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            Console.WriteLine("Current stack:");
            while (!stack.IsEmpty())
            {
                int value = stack.Pop();
                Console.WriteLine(value);
            }

            Console.ReadLine();*/

            /*PeackAndPopStack<int> stack = new PeackAndPopStack<int>();

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            Console.WriteLine("Peeking at the top of the stack: " + stack.Peek());

            Console.WriteLine("Popping elements from the stack:");
            while (!stack.IsEmpty())
            {
                int value = stack.Pop();
                Console.WriteLine(value);
            }

            Console.ReadLine();*/

            StacksAndQueues<int> queue = new StacksAndQueues<int>();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine("Current queue:");
            while (!queue.IsEmpty())
            {
                int value = queue.Dequeue();
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}