using System;
namespace InsertionSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10]  {7,9,4,12,56,7,23,11,5,3};
            int length = arr.Length;
            
            int i , j , k , temp , value;
            for(i = 1 ; i < length ; i++)
            {
                value = arr[i];
                for(j = i-1 ; (j >= 0 && value <= arr[j]) ; j--)
                {
                    
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;

                    
                }
            }
            for(k = 0 ; k < length ; k++)
            {
                System.Console.Write(arr[k]+"\t");
            }
            
        }
    }
}
