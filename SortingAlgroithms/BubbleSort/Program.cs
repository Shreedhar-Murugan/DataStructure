using System;
namespace BubbleSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10]  {7,9,4,12,56,7,23,11,5,3};
            int length = arr.Length;
            
            int i , j , k , temp;
            for(i = 0 ; i < length-1 ; i++)
            {
                for(j = 0 ; j < length-1-i ; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            for(k = 0 ; k < length ; k++)
            {
                System.Console.Write(arr[k]+"\t");
            }
            
        }
    }
}
