using System;
using System.Collections.Generic;
namespace QueueDS
{
    public partial class Queue1<T>
    {
        public void Display()
        {
            for(int i = _front ; i < _count ; i++)
            {
                System.Console.WriteLine(Array[i]);
            }
        }
        public T Dequeue()
        {
            T temp = default(T);
            temp = Array[_front];
            if(_front == _count-1)
            {
                System.Console.WriteLine("No Element in the Array");
                return temp;
            }
            else
            {
                temp = Array[_front];
                _front++;
                return temp;
            }
        }
        public void Contains(T value)
        {
            bool flag = false;
            for(int i = _front ; i < _count ; i++)
            {
                if(value.Equals(Array[i]))
                {
                    flag = true;
                }
            }
            if(flag)
            {
                System.Console.WriteLine("The Element contains in the Array");
            }
            else
            {
                System.Console.WriteLine("The Element not contains in the Array");
            }
        }
        public void Peek()
        {
            System.Console.WriteLine(Array[_front++]);
        }
    }
}