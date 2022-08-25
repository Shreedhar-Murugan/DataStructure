using System;
using System.Collections.Generic;
namespace StackDS
{
    public partial class Stack<T>
    {
        public void Display()
        {
            for(int i = 0 ; i < _count ; i++)
            {
                System.Console.WriteLine(Array[i]);
            }
        }
        public void Peek()
        {
            System.Console.WriteLine(Array[_count-1]);
        }
        public T Pop()
        {
            T temp = default(T);
            if(_count >= 0)
            {
            temp = Array[_count-1];
            _count--;
            return temp;
            }
            else
            {
                System.Console.WriteLine("Stack Under Flow");
            return temp;
            }
        }
        public void Contains(T value)
        {
            bool flag = false;
            for(int i = 0 ; i < _count ; i++)
            {
                
                if(value.Equals(Array[i]))
                {
                    flag = true;
                }
            }
            if(flag)
            {
                System.Console.WriteLine("The Element Contains in the Array");
            }
            else
            {
                System.Console.WriteLine("The Element not Contains in the Array");
            }
        }
         public void  Clear()
        {
            for(int i = _count ; i > 0 ; i--)
            {
            Pop();
            }
        }
    }
}