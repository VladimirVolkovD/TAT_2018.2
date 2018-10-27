using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyStack<int> stack = new MyStack<int>();
                stack.Pop();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                int i = stack.Pop();
                Console.WriteLine("pop: " + i);
                Console.WriteLine("Headr: " + stack.GetHead());
                Console.ReadLine();
            }
            catch (Exception error)
            {
                Console.Write("Error: " + error.Message);
            }
        }
    }
}
