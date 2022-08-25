using System;
namespace BinarySearch
{
    public static class Operations
    {
        public static void MainMenu()
        {
            int[] arr = new int[]{1,2,3,4,5,6,7,8,9,10};
            int firstValue = arr[0];
            int lastValue = arr.Length;
            int middleValue;
            System.Console.WriteLine("Enter the Elements to be search in the array :");
            int number = Convert.ToInt32(Console.ReadLine());
            bool temp = true;
            while(temp)
            {
                middleValue = (firstValue+lastValue)/2;
                if(number == arr[middleValue])
                {
                    System.Console.WriteLine("Your Element is in position "+middleValue);
                    temp = false;
                }
                else if(number > arr[middleValue])

                {
                    firstValue = middleValue+1;
                }
                else
                {
                    lastValue = middleValue-1;
                }

            }
           
        }
    }
}