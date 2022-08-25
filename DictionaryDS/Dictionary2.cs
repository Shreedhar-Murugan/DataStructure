using System.Collections.Generic;
namespace DictionaryDS
{
    public partial class Dictionary1<TKey,TValue>
    {
        public void Display()
        {
            for(int i = 0 ; i < _count ; i++)
            {
                System.Console.WriteLine(Array[i].Key+","+Array[i].Value);
            }
        }
        public void ConatainsKey(TKey input)
        {
            int flag = 0;
            for(int i = 0 ; i < _count ; i++)
            {
                int valid = Comparer<TKey>.Default.Compare(Array[i].Key , input);
                if(valid == 0)
                {
                    flag = 1;
                }    
            }
            if(flag == 1)
            {
                System.Console.WriteLine("The Key Contains in the Array");
            }
            else
            {
                System.Console.WriteLine("The Key not Contains in the Array");
            }
        }
        public void ConatainsValue(TValue input)
        {
            int flag = 0;
            for(int i = 0 ; i < _count ; i++)
            {
                int valid = Comparer<TValue>.Default.Compare(Array[i].Value , input);
                if(valid == 0)
                {
                    flag = 1;
                }    
            }
            if(flag == 1)
            {
                System.Console.WriteLine("The Value Contains in the Array");
            }
            else
            {
                System.Console.WriteLine("The Value not Contains in the Array");
            }

        }
        public void Remove(TKey input)
        {
            for(int i = 0 ; i < _count ; i++)
            {
                int valid = Comparer<TKey>.Default.Compare(Array[i].Key , input);
                if(valid == 0)
                {   
                    for(int j = i ; j < _count ;j++)
                    {
                        Array[j] = Array[j+1];           
                        _count--;
                    }
                }    
            }
            
        }
        public  TValue this[TKey key]
        {
            get
            {
                int flag = 0 ;
                TValue output = default(TValue);
                for(int i = 0 ; i < _count ; i++)
                {
                    if(key.Equals(Array[i].Key))
                    {
                        output = Array[i].Value;
                        flag = 1;
                    }
                    
                }
                if(flag == 0)
                {
                    System.Console.WriteLine("Invalid Key");
                }
                return output;
            }
            set
            {
                int flag = 0;
                for(int i = 0 ; i < _count ; i++)
                {
                    if(key.Equals(Array[i].Key))
                    {
                        Array[i].Value = value;
                        flag = 1;
                    }
                    
                }
                if(flag == 0)
                {
                    System.Console.WriteLine("Invalid Key");
                }

            }
        }
    
        
    }
}