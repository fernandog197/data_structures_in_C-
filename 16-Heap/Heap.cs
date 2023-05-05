namespace Heap
{
    class Heap
    {
        private int capacity;
        private int size;
        private int[] items;

        public Heap (int capacity)
        {
            this.capacity = capacity;
            this.items = new int[capacity];
        }

        #region Helper Methods

        private int GetleftChildIndex (int parentIndex) { return 2 * parentIndex+1; }
        private int GetRightChildIndex (int parentIndex) { return 2 * parentIndex+2; }
        private int GetParentIndex (int childIndex) { return (childIndex-1)/2; }

        private bool HasLeftChild (int index) { return GetleftChildIndex(index) < size; }
        private bool HasRightChild (int index) { return GetRightChildIndex(index) < size; }
        private bool HasParent (int index) { return GetParentIndex(index) >= 0; }

        private int LeftChild (int index) { return this.items[GetleftChildIndex(index)]; }
        private int RightChild (int index) { return this.items[GetRightChildIndex(index)]; }
        private int Parent (int index) { return this.items[GetParentIndex(index)]; }

        private void Swap (int indexOne, int indexTwo)
        {
            int temp = this.items[indexOne];
            this.items[indexOne] = this.items[indexTwo];
            this.items[indexTwo] = temp;
        }

        private void ensureExtraCapacity ()
        {
            if(this.size == this.capacity)
            {
                Array.Resize(ref this.items, capacity*2);
                this.capacity *= 2;
            }
        }

        #endregion

        public int Peek ()
        {
            if(size == 0)
            {
                Console.WriteLine("Su Heap se encuentra vacio");
                return 0;
            }

            return this.items[0];
        }

        public void Transverse ()
        {
            for(int i=0; i<size; i++)
            {
                Console.Write("[{0}], ", this.items[i]);
            }
            Console.WriteLine();
        }

        public bool isFull ()
        {
            return this.size >= capacity;
        }

        public void Insertion (int value)
        {
            ensureExtraCapacity();
            this.items[size] = value;
            this.size++;
            heapifyUp();
        }

        public int PullMin ()
        {
            if(size == 0)
            {
                Console.WriteLine("Su Heap se encuentra vacio");
                return 0;
            }

            int item = this.items[0];
            items[0] = items[size-1];
            this.size--;
            heapifyDown();

            return item;
        }

        public void heapifyUp ()
        {
            int index = this.size - 1;

            while(HasParent(index) && Parent(index) > this.items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }

        public void heapifyDown ()
        {
            int index = 0;
            
            while(HasLeftChild(index))
            {
                int smallerChildIndex = GetleftChildIndex(index);

                if(HasRightChild(index) && RightChild(index) < LeftChild(index) )
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if(this.items[index] < this.items[smallerChildIndex])
                {   
                    break;
                }
                else
                {
                    Swap(index, smallerChildIndex);
                }

                index = smallerChildIndex;
            }
        }
    }
}