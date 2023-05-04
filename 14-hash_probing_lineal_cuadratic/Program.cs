namespace HashProbingLinearCuadratic
{
    class Program
    {
        private static Cell[] table;
        private static int size;

        public static void Main ()
        {
            int n = 0;
            
            size = 11;
            table = new Cell[size];

            for(n=0; n<size; n++)
            {
                table[n] = new Cell();
            }

            Print();
            Console.WriteLine("------");

            Insertion(23, "Hola");
            Insertion(51, "Manzana");
            Insertion(40, "Pera");
            Insertion(62, "Mango");

            Print();
            Console.WriteLine("------");
        }

        public static void Print ()
        {
            int n = 0;

            for(n=0; n<size; n++)
            {
                Console.WriteLine("{0} [{1}, {2}]", n, table[n].Key, table[n].Data);
            }
        }

        public static int HashFunction (int key, int tryNumber)
        {
            int index = 0;

            //Linear probing
            //index = (key + tryNumber) % size;

            //Quadratic probing
            index = (key + (tryNumber*tryNumber)) % size;

            return index;
        }

        public static void Insertion (int key, string data)
        {
            //Try count
            int i = 0;

            int index = 0;
            bool busy = false;

            while (busy == false)
            {
                index = HashFunction(key, i);

                if(table[index].MyState == state.empty)
                {
                    busy = true;
                    table[index].Key = key;
                    table[index].Data = data;
                    table[index].MyState = state.busy;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}