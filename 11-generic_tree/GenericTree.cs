namespace GenericTree
{
    public class GenericTree
    {
        //ATTRIBUTES
        private Nodo root;
        private Nodo auxNodo;
        private int i;

        //CONSTRUCTOR
        public GenericTree ()
        {
            this.root = new Nodo();
            this.auxNodo = new Nodo();
            this.i = 0;
        }

        //METHODS
        public Nodo Insertion (string data, Nodo targetNodo)
        {
            if(targetNodo == null)
            {
                this.root.Data = data;

                return this.root;
            }

            if(targetNodo.Son == null)
            {
                Nodo newNodo01 = new Nodo(data);

                targetNodo.Son = newNodo01;

                return newNodo01;
            }
            else
            {
                this.auxNodo = targetNodo.Son;

                while(auxNodo.Brother != null)
                {
                    auxNodo = auxNodo.Brother;
                }

                Nodo newNodo = new Nodo(data);
                auxNodo.Brother = newNodo;

                return newNodo;
            }
        }

        public void PreOrderTransverse (Nodo targetNodo)
        {
            if(targetNodo == null)
            {
                return;
            }

            for(int n=0; n<this.i; n++)
            {   
                Console.Write("|->");
                Console.Write("  ");
            }

            Console.WriteLine(targetNodo.Data);

            if(targetNodo.Son != null)
            {
                this.i++;
                PreOrderTransverse(targetNodo.Son);
                this.i--;
            }

            if(targetNodo.Brother != null)
            {
                PreOrderTransverse(targetNodo.Brother);
            }
        }

        public void PostOrderTransverse (Nodo targetNodo)
        {
            if(targetNodo == null)
            {
                return;
            }

            if(targetNodo.Brother != null)
            {
                PreOrderTransverse(targetNodo.Brother);
            }

            if(targetNodo.Son != null)
            {
                this.i++;
                PreOrderTransverse(targetNodo.Son);
                this.i--;
            }

            for(int n=0; n<this.i; n++)
            {   
                Console.Write("|->");
                Console.Write("  ");
            }

            Console.WriteLine(targetNodo.Data);
        }

        public Nodo Search (string data, Nodo targetNodo)
        {
            Nodo foundNodo = null;

            if(targetNodo == null)
            {
                return foundNodo;
            }

            if(targetNodo.Data.CompareTo(data) == 0)
            {
                foundNodo = targetNodo;
                return foundNodo;
            }

            if(targetNodo.Son != null)
            {
                foundNodo = Search(data, targetNodo.Son);

                if(foundNodo != null)
                {
                    return foundNodo;
                }
            }

            if(targetNodo.Brother != null)
            {
                foundNodo = Search(data, targetNodo.Brother);

                if(foundNodo != null)
                {
                    return foundNodo;
                }
            }

            return foundNodo;
        }
    }
}