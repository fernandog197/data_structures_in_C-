namespace QuickSort
{
    class Program
    {
        public static void Main ()
        {
            Random random = new Random();
            
            int length = random.Next(5, 50);

            int [] myArray = new int[length];

            for(int i=0; i<length; i++)
            {
                myArray[i] = random.Next(-100, 100);
            }

            foreach(int i in myArray)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            QuickSort(myArray, 0, length-1);

            foreach(int i in myArray)
            {
                Console.Write(i + ", ");
            }
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}