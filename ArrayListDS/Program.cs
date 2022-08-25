using System;
namespace ArrayListDS
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList1<object> arr = new ArrayList1<object>();
            arr.Add(1);
            arr.Add("Shreedhar");
            arr.Add(9940499143);
            arr.Add(75.5);
            arr.Display();
            arr.Remove(1);
            arr.Display();
            arr.RemoveAt(3);
             arr.Display();
            arr.Peek();
            arr.Insert(1 ,"Hello");
            arr.Clear();
            arr.Display();
            arr.Add(2);
            arr.Display();
            


            
        }
    }
}
