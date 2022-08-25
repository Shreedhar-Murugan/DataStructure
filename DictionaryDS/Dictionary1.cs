using System.Collections.Generic;
namespace DictionaryDS
{
    public partial class Dictionary1<TKey,TValue>
    {
        
        private  int _count = 0;
        private int _capacity = 0;
        public int Count { get {return _count ;} }
        public int Capacity { get {return _capacity ;} }
        private KeyValuePair<TKey ,TValue>[]  Array { get; set; }


        public Dictionary1()
        {
            _count = 0;
            _capacity =8;
            Array = new KeyValuePair<TKey , TValue>[_capacity];
            

        }
        public Dictionary1(int size)
        {
            _count = 0;
            _capacity = size;
            Array = new KeyValuePair<TKey, TValue>[_capacity];
        }
        public void Add( TKey key , TValue value)
        {
            int flag = 0;
            for(int i = 0 ; i < _count ; i++)
            {
                int valid = Comparer<TKey>.Default.Compare(Array[i].Key , key);
                if(valid == 0)
                {
                    System.Console.WriteLine("Duplicate key");
                    flag = 1;
                }    
            }
            if(flag == 0)
            {
            if(Count == Capacity)
                    {
                        GrowSize(); 
                    }
                    KeyValuePair<TKey , TValue> object1 = new KeyValuePair<TKey, TValue>();
                    object1.Key = key;
                    object1.Value = value;
                    Array[_count] = object1;
                    _count++;
            }
            
        }
        public void GrowSize()
        {
            _capacity = _capacity*2;
            KeyValuePair<TKey, TValue>[] temp = new KeyValuePair<TKey, TValue>[_capacity];
            for(int i = 0 ; i<_count ; i++)
            {
                temp[i] = Array[i];
            }
            Array = temp;
        }
        

    }
}
        
    
