namespace SelectionSort
{
    class Program
    {
        public static void Main()
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
            SelectionSort(myArray);

            foreach(int i in myArray)
            {
                Console.Write(i + ", ");
            }
        }

        public static void SelectionSort (int[] array)
        {
            int length = array.Length;

            for(int i=0; i<length; i++)
            {
                int min = array[i];
                int iMin = i;

                for(int j=i+1; j<length; j++)
                {
                    if(array[j] < min)
                    {
                        min = array[j];
                        iMin = j;
                    }
                }

                if(min != array[i])
                {
                    int aux = array[i];
                    array[i] = min;
                    array[iMin] = aux;
                }
            }
        }
    }
}