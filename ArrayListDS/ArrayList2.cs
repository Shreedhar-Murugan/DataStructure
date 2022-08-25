namespace ArrayListDS
{
    public partial class ArrayList1<T>
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
            System.Console.WriteLine(Array[0]);
        }
        public void Remove(T value)
        {
            for(int i = 0 ; i < _count ; i++)
            {
                
                if(value.Equals(Array[i]))
                {
                    for(int j = i ; j < _count ; j++)
                    {
                        Array[j] = Array[j+1];
                    }
                }    
            }
            _count = _count -1;
        }
        public void RemoveAt(int index)
        {
            for(int i = index+1 ; i <= _count ; i++)
            {
                Array[i-1] = Array[i];
            }
            _count = _count -1;
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
        public void Insert(int index , T value)
        {
            _capacity +=1;
            T[] temp = new T[_capacity];
            _count++;
            for(int i = 0 ; i < _count ; i++)
            {
            
                    if(i < index)
                    {
                    temp[i] = Array[i]; 
                    }   
                    if(i == index)  
                    {
                        temp[i] = value;
                    }    
                    if(i > index)
                    {
                    temp[i] = Array[i-1]; 
                    } 

            }
            Array = temp;
        }
         public void  Clear()
        {
            for(int i = _count ; i > 0 ; i--)
            {
            _count--;
            }
        }
        
    }
}