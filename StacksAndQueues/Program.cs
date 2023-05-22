namespace StacksAndQueues
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

            PeackAndPopStack<int> stack = new PeackAndPopStack<int>();

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

            Console.ReadLine();
        }
    }
}