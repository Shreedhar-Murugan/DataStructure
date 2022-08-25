using System;
namespace SelectionSort
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
            
            int i , j , k , temp , minValue , minIndex;
            for(i = 0 ; i < length ; i++)
            {
                minValue = arr[i];
                minIndex = i;
                for(j = i+1 ; j < length ; j++)
                {    
                    if(minValue > arr[j])
                    {
                        minValue = arr[j];
                        minIndex = j;
                    }     
                }
                if(minValue < arr[i])
                {
                    temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
            for(k = 0 ; k < length ; k++)
            {
                System.Console.Write(arr[k]+"\t");
            }
            
        }
    }
}
