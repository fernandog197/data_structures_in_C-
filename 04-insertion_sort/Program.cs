using System;

namespace InsertionSort
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
            InsertionSort(myArray);

            foreach(int i in myArray)
            {
                Console.Write(i + ", ");
            }
        }

        public static void InsertionSort (int[] array)
        {
            int length = array.Length;

            for(int i=1; i<length; i++)
            {
                for(int j=i; j>0; j--)
                {
                    if(array[j]<array[j-1])
                    {
                        int aux = array[j];
                        array[j] = array[j-1];
                        array[j-1] = aux;
                    }
                }
            }
        }
    }
}