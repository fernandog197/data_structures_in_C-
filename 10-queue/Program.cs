namespace Queue
{
    class Program
    {
        public static void Main ()
        {
            Queue cola = new Queue();

            cola.Enqueue(3);
            cola.Enqueue(6);
            cola.Enqueue(87);
            cola.Enqueue(2);
            cola.Enqueue(0);
            cola.Enqueue(54);
            cola.Enqueue(37);

            cola.Transverse();
            cola.Peek();

            cola.Dequeue();
            cola.Transverse();
            cola.Peek();
        }
    }
}