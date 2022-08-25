using System;
namespace StackDS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int> ();
            numbers.Push(1);
            numbers.Push(3);
            numbers.Push(5);
            numbers.Push(7);
            numbers.Push(9);
            numbers.Push(11);
            // numbers.Peek();
            // numbers.Pop();
            // numbers.Pop();
            numbers.Display();
            numbers.Contains(14);
            numbers.Clear();
            numbers.Display();
            numbers.Push(11);
            numbers.Display();
            
        }
    }
}
