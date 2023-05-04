namespace HashSeparateChaining
{
    class Program
    {
        private static int size = 7;
        private static LinkedList[] list;
        public static void Main ()
        {
            int n = 0;
            list = new LinkedList[size];

            for(n=0; n<size; n++)
            {
                list[n] = new LinkedList();
            }

            Print();
            Console.WriteLine("-----");

            Insertion(57, "Hola");
            Insertion(45, "Manzana");
            Insertion(42, "Pera");
            Insertion(83, "Azul");
            Insertion(30, "Rojo");
            Insertion(94, "C#");
            Insertion(73, "C++");
            Insertion(97, "Saludos");

            Print();
            Console.WriteLine("-----");
        }

        public static void Print ()
        {
            int n = 0;
            
            for(n=0; n<size; n++)
            {
                Console.Write("({0})", n);
                list[n].Transversa();
                Console.WriteLine();
            }
        }

        public static int HashFunction (int key)
        {
            int index = 0;

            index = key % size;

            return index;
        }

        public static void Insertion (int key, string value)
        {
            int index = HashFunction(key);

            list[index].Add(key, value);
        }
    }
}