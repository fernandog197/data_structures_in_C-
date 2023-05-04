namespace ReHash
{
    class HashTable
    {
        private Cell[] table;
        private int size;
        private int inserted;

        public HashTable (int size)
        {
            int n = 0;
            this.size = size;
            this.table = new Cell[this.size];

            for(n=0; n<size; n++)
            {
                table[n] = new Cell();
            }
        }

        public int HashFunction (int key, int tryNumber)
        {
            int index = 0;

            //Linear probing
            //index = (key + tryNumber) % size;

            //Quadratic probing
            index = (key + (tryNumber*tryNumber)) % size;

            return index;
        }

        public void Print ()
        {
            int n = 0;

            for (n=0; n<size; n++)
            {
                Console.WriteLine("{0} [{1}, {2}]", n, table[n].Key, table[n].Data);
            }
        }

        public void Insertion (int key, string data)
        {
            int i = 0;

            int index = 0;
            bool busy = false;

            while(busy == false)
            {
                index = HashFunction(key, i);

                if(table[index].MyState == state.empty)
                {
                    busy = true;
                    table[index].Key = key;
                    table[index].Data = data;
                    table[index].MyState = state.busy;
                    this.inserted++;
                }
                else
                {
                    i++;
                }
            }
            
            double comparison = (double)this.size*0.7;
            //Verificamos si es necesario hacer el ReHash
            if(this.inserted >= comparison)
            {
                Console.WriteLine("|----- Es necesario hacer un ReHash, {0} de {1} ocupados -----|", this.inserted, this.size);
                ReHash();
            }
        }

        public int ClosePrime (int value)
        {
            int prime = 0;
            bool divide = false;
            int n = 0;

            while (prime == 0)
            {
                divide = false;
                
                for(n = 2; n < value; n++)
                {
                    if(value % n == 0)
                    {
                        divide = true;
                        value++;
                        break;
                    }
                }

                if(divide == false)
                {
                    prime = value;
                }
            }

            return prime;
        }

        public void ReHash ()
        {
            //Calculamos el nuevo tamaño
            int newSize = ClosePrime(this.size*2);
            int oldSize = this.size;
            int n = 0;
            int key = 0;
            string value = "";

            int i = 0;
            int index = 0;
            bool busy = false;

            Console.WriteLine("Ahora la tabla sera de {0} espacios.", newSize);

            //Creamos la nueva tabla
            Cell[] newTable = new Cell[newSize];

            for(n=0; n<newSize; n++)
            {
                newTable[n] = new Cell();
            }

            //Actualizamos el valor del Size dentro de los atrubutos de la tabla
            this.size = newSize;
            this.inserted = 0;

            //Recorremos la tabla y vamosinsertando los elementos de la tabla anterior en la nueva.
            for(n=0; n<oldSize; n++)
            {
                if(table[n].MyState == state.busy)
                {
                    key = table[n].Key;
                    value = table[n].Data;

                    busy = false;

                    while(busy == false)
                    {
                        index = HashFunction(key, i);

                        if(newTable[n].MyState == state.empty)
                        {
                            busy = true;
                            newTable[n].Key = key;
                            newTable[n].Data = value;
                            newTable[n].MyState = state.busy;
                            this.inserted++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
            }

            table = (Cell[]) newTable.Clone();
        }
    }
}