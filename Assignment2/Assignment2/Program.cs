namespace Assignments2
{
    class SailsList
    {
        public static void Main()
        {
            Console.WriteLine("rrr");
            int N =Convert.ToInt32(Console.ReadLine());
            int[] data;
            int size=0,capacity;
            void Add(int newElement)
            {
                if (size == capacity)
                {
                    Resize();
                }
                data[size] = newElement;
                size++;
            }
            void DeleteAt(int index)
            {
                
                for (int i = index; i < size - 1; i++)
                {
                    data[i] = data[i + 1];
                }

                data[size - 1] = default(int);
                size--;
            }
            void Resize()
            {
                int [] resized = new int [capacity * 2];
                for (int i = 0; i < capacity; i++)
                {
                    resized[i] = data[i];
                }
                data = resized;
                capacity = capacity * 2;
            }
            void InsertAt(int newElement, int index)
            {
                if (size == capacity)
                {
                    Resize();
                }
                for (int i = size; i > index; i--)
                {
                    data[i] = data[i - 1];
                }     
                data[index] = newElement;
                size++;
            }
            void Clear()
            {
                data = new int[capacity];
                size = 0;
            }
            bool Contains(int value)
            {
                for (int i = 0; i < size; i++)
                {
                    int currentValue = data[i];
                    if (currentValue.Equals(value))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}