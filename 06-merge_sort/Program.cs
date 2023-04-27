namespace MergeSort
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
            int[] orderArray = MergeSort(myArray);

            foreach(int i in orderArray)
            {
                Console.Write(i + ", ");
            }
        }

        public static int[] MergeSort (int[] array)
        {
            int arrayLength = array.Length;

            if(arrayLength < 2)
            {
                return array;
            }

            int half = arrayLength/2;

            int[] left = new int[half];
            int[] right = new int[arrayLength-half];

            for(int i=0; i<half; i++)
            {
                left[i] = array[i];
            }

            for(int i=half; i<arrayLength; i++)
            {
                right[i-half] = array[i];
            }

            int[] arrayA = MergeSort(left);
            int[] arrayB = MergeSort(right);

            int[] arrayFinal = Merge(arrayA, arrayB);

            return arrayFinal;
        }

        public static int[] Merge (int[] leftArray, int[] rightArray)
        {
            int leftLength = leftArray.Length;
            int rightLength = rightArray.Length;

            int newArrayLength = leftLength + rightLength;
            int[] newArray = new int[newArrayLength];

            int i = 0;
            int lI = 0;
            int rI = 0;

            while(lI < leftLength && rI < rightLength)
            {
                if(leftArray[lI] < rightArray[rI])
                {
                    newArray[i] = leftArray[lI];
                    i++;
                    lI++;
                } else {
                    newArray[i] = rightArray[rI];
                    i++;
                    rI++;
                }
            }

            while(rI < rightLength)
            {
                newArray[i] = rightArray[rI];
                i++;
                rI++;
            }

            while(lI < leftLength)
            {
                newArray[i] = leftArray[lI];
                i++;
                lI++;
            }

            return newArray;
        }
    }
}