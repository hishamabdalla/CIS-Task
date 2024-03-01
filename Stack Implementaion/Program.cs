namespace Stack_Implementaion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Display();
            Console.WriteLine("------------------");

            Console.WriteLine(stack.Pop());
            Console.WriteLine("------------------");

            stack.Display();
            Console.WriteLine("------------------");

            Console.WriteLine(stack.Search(6));
            Console.WriteLine("------------------");

            stack.Peek();
            Console.WriteLine("------------------");

        }
    }
}
