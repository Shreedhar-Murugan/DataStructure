using System;
namespace DictionaryDS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary1<int , string> dictionary = new Dictionary1<int, string>();
            dictionary.Add(1,"Shreedhar");
            dictionary.Add(2,"Sathish");
            dictionary.Add(3,"Yavin");
            dictionary.Add(4,"Naveen");
            dictionary.Add(5,"Albayaz");
            dictionary.Display();
            dictionary.ConatainsKey(20);
            dictionary.ConatainsValue("Shreedha");
            dictionary[2] = "Yavin";
            System.Console.WriteLine(dictionary[3]);
            dictionary.Remove(1);
            dictionary.Display();
        }
    }  
}