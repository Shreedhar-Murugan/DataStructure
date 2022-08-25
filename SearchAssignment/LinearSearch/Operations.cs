using System;
namespace LinearSearch
{
    public static class Operations
    {
        public static void MainMenu()
        {
            int[] arr = new int[]{2,3,1,9,5,6};
            int firstValue = 0;
            int length = arr.Length;
            System.Console.WriteLine("Enter the Element to be searched :");
            int number = Convert.ToInt32(Console.ReadLine());
            bool temp = true;
            for(int i = firstValue ; i < length ; i++ )
            {
                if(number == arr[i])
                {
                    System.Console.WriteLine("The element is in the position of "+i);
                    temp = false;
                }
            }
            if(temp)
            {
            System.Console.WriteLine("The given element is not in the array");
            }
                
        }
    }
}