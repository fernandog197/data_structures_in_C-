namespace Queue
{
    public class Queue
    {
        //ATRIBUTES
        private Nodo anchor;
        private Nodo? auxNodo;

        //CONSTRUCTOR
        public Queue ()
        {
            this.anchor = new Nodo();
            this.anchor.Next = null;
            this.auxNodo = null;
        }

        //METHODS
        public void Enqueue (int data)
        {
            if(this.anchor.Next == null)
            {
                Nodo newNodo = new Nodo(data);
                this.anchor.Next = newNodo;
                newNodo.Next = null;

                return;
            }

            this.auxNodo = this.anchor.Next;
            Nodo newNodo01 = new Nodo(data);
            this.anchor.Next = newNodo01;
            newNodo01.Next = this.auxNodo;
        }

        public Nodo Dequeue ()
        {
            if(this.anchor.Next == null)
            {
                Console.WriteLine("Esta Queue no contiene ningun elemento.");
                return null;
            }

            this.auxNodo = this.anchor.Next;
            Nodo previous = new Nodo();

            while(this.auxNodo.Next != null)
            {
                previous = this.auxNodo;
                this.auxNodo = this.auxNodo.Next;
            }

            previous.Next = null;
            
            Console.WriteLine();
            Console.WriteLine("El elemento eliminado tiene el siguiente valor: " + auxNodo.Data);

            return auxNodo;
        }
        
        public void Peek ()
        {
            if(this.anchor.Next ==null)
            {
                Console.WriteLine("Esta Queue no contiene ningun elemento.");
                return;
            }

            this.auxNodo = this.anchor.Next;

            while(this.auxNodo.Next != null)
            {
                this.auxNodo = this.auxNodo.Next;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El proximo elemento es: " + this.auxNodo.Data);
        }

        public void Transverse ()
        {
            if(this.anchor.Next == null)
            {
                Console.WriteLine("Esta Queue no contiene elementos.");
                return;
            }

            this.auxNodo = this.anchor;
            Console.WriteLine();

            while(this.auxNodo.Next != null)
            {
                this.auxNodo = this.auxNodo.Next;
                Console.Write(this.auxNodo.Data + ", ");
            }
        }
    }
}