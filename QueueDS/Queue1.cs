namespace QueueDS
{
    public partial class Queue1<T>
    {
        private int _count = 0;
        private int _capacity = 0;
        private int _front = 0;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }
        public T[] Array { get; set; }

        public Queue1()
        {
            _count = 0;
            _front = 0;
            _capacity = 8;
            Array = new T[_capacity]; 
        }
        public Queue1(int size)
        {
            _count = 0;
            _front = 0;
            _capacity = size;
            Array = new T[_capacity];
        }
        public void Enqueue(T value)
        {
            if(Count == Capacity)
            {
                GrowSize();   
            }
            Array[_count] = value;
            _count++;
        }
        public void GrowSize()
        {
            _capacity = _capacity*2;
            T[] temp = new T[_capacity];
            for(int i = 0 ; i < _count ; i++)
            {
                temp[i] = Array[i];
            }
            Array = temp;
        }



    }
}