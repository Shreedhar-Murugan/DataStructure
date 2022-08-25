using System;
namespace MergeSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[6]  {7,9,4,12,11,3}; 
            int length = arr.Length;
            for(int z = 0 ; z < length ; z++)
            {
                System.Console.Write(arr[z]+"\t");
            }
            System.Console.WriteLine();
            
            int i , j , k , max , min , mid;
            for(i = 0 ; i < length ; i++)
            {
                
                min = arr[i];
                max = arr[length-1];
                mid = (min+max)/2;
                for(j = min ; j < mid ; j++)
                {

                }
                
            }
            for(k = 0 ; k < length ; k++)
            {
                System.Console.Write(arr[k]+"\t");
            }
            
        }
    }
}
