using System;

namespace BubbleSort
{
    class Program
    {
        public static void Main ()
        {   
            Random random = new Random();
            
            int length = random.Next(5, 100);

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
            BubbleSort(myArray);

            foreach(int i in myArray)
            {
                Console.Write(i + ", ");
            }
        }

        public static void BubbleSort (int[] array)
        {
            int arrayLength = array.Length;

            for(int i=0; i<arrayLength-1; i++)
            {
                for(int j=0; j<arrayLength-i-1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }
        }
    }
}