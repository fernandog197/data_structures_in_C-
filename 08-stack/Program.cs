namespace Stack
{
    class Program
    {
        public static void Main ()
        {
            Stack pila = new Stack();

            pila.Push(2);
            pila.Push(5);
            pila.Push(14);
            pila.Push(3);
            pila.Push(56);
            pila.Push(43);
            pila.Push(6);
            pila.Push(8);

            pila.Transversa();

            pila.Pop();

            pila.Transversa();

            pila.Peek();
        }   
    }
}