namespace Heap
{
    class Program
    {
        public static void Main ()
        {
            Heap myHeap = new Heap(13);

            myHeap.Insertion(1);
            myHeap.Insertion(2);
            myHeap.Insertion(3);
            myHeap.Insertion(4);
            myHeap.Insertion(5);
            myHeap.Insertion(6);
            myHeap.Insertion(7);

            myHeap.Transverse();

            Console.WriteLine("Minimo: {0}", myHeap.PullMin());
            myHeap.Transverse();

            Console.WriteLine("Minimo: {0}", myHeap.PullMin());
            myHeap.Transverse();

            Console.WriteLine("Minimo: {0}", myHeap.PullMin());
            myHeap.Transverse();

            Console.WriteLine("Minimo: {0}", myHeap.PullMin());
            myHeap.Transverse();

            Console.WriteLine("Minimo: {0}", myHeap.PullMin());
            myHeap.Transverse();

            Console.WriteLine("Minimo: {0}", myHeap.PullMin());
            myHeap.Transverse();
        }
    }
}