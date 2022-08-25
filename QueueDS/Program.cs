using System;
namespace QueueDS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue1<int> numbers = new Queue1<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(4);
            numbers.Enqueue(6);
            numbers.Enqueue(3);
            numbers.Enqueue(9);
            numbers.Enqueue(12);
            numbers.Dequeue();
            numbers.Display();
            numbers.Contains(34);
            numbers.Peek();
        }
    }
}
