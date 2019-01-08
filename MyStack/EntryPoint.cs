using System;

namespace Stack
{
    class EntryPoint
    {
        static void Main()
        {
            try
            {
                MyStack<int> stack = new MyStack<int>();
                stack.Pop();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                var i = stack.Pop();
                Console.WriteLine("pop: " + i);
                Console.WriteLine("Head: " + stack.GetHead());
                Console.ReadLine();
            }
            catch (Exception error)
            {
                Console.Write("Error: " + error.Message);
            }
        }
    }
}
