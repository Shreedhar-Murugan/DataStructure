using System;
namespace GenericClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            Template<int> temp = new Template<int>();
            temp.Value = 100;
            temp.Array = new int[] {10,20,30,40,50};
            temp.Name = "Shreedhar";
        }
    }
}
