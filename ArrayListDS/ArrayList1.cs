namespace ArrayListDS
{
    public partial class ArrayList1<T>
    {
        private  int _count = 0;
        private int _capacity = 0;
        public int Count { get {return _count ;} }
        public int Capacity { get {return _capacity ;} }
        private T[] Array { get; set; }

        public ArrayList1()
        {
            _count = 0;
            _capacity =8;
            Array = new T[_capacity];

        }
        public ArrayList1(int size )
        {
            _count = 0;
            _capacity = size;
            Array = new T[_capacity];
        }
        public void Add(T value)
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
            for(int i = 0 ; i<_count ; i++)
            {
                temp[i] = Array[i];
            }
            Array = temp;
        }
        

    }
}