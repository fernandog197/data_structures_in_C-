namespace SingBalance
{
    public class Stack
    {
        private Nodo anchor;
        private Nodo auxNodo;
        private int count;

        public Stack()
        {
            this.anchor = new Nodo();
            anchor.Next = null;
            this.count = 0;
        }

        public void Transversa ()
        {
            if(anchor.Next == null)
            {
                Console.WriteLine("El Stack se encuentra vacio");
                return;
            }

            this.auxNodo = this.anchor;
            Console.WriteLine();

            while(this.auxNodo.Next != null)
            {
                this.auxNodo = this.auxNodo.Next;
                Console.Write(this.auxNodo.Data + ", ");
            }

            Console.WriteLine("Su Stack tiene un total de: " + this.count + " elementos.");
            Console.WriteLine();
        }

        public void Push (char sign)
        {
            if(this.anchor.Next == null)
            {
                Nodo newNodo = new Nodo();
                newNodo.Data = sign;

                this.anchor.Next = newNodo;
                newNodo.Next = null;
                this.count++;

                return;
            }

            this.auxNodo = this.anchor.Next;
            
            Nodo newNodo01 = new Nodo();
            newNodo01.Data = sign;

            this.anchor.Next = newNodo01;
            newNodo01.Next = this.auxNodo;

            this.count++;
        }

        public Nodo Pop ()
        {
            if(this.anchor.Next == null)
            {
                Console.WriteLine("Este Stack no tiene ningun elemento.");
                return null;
            }

            this.auxNodo = this.anchor.Next;
            this.anchor.Next = this.auxNodo.Next;

            Console.WriteLine("Se elimino el nodo de valor: " + auxNodo.Data);

            this.count--;

            return auxNodo;
        }

        public Nodo Peek ()
        {   
            this.auxNodo = this.anchor.Next;
            Console.WriteLine("El valor del elemento Top List es: " + auxNodo.Data);
            return auxNodo;
        }

        public bool IsEmpty ()
        {
            if(this.anchor.Next != null)
            {
                return false;
            }

            return true;
        }
    }
}