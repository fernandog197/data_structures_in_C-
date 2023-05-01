namespace Queue
{
    public class Nodo
    {
        private int? data;
        private Nodo? next = null;

        public Nodo () 
        {
            this.data = null;
        }

        public Nodo (int data)
        {
            this.data = data;
        }

        public int? Data { get => this.data; set => this.data = value; }
        public Nodo? Next { get => this.next; set => this.next = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", Data);
        }
    }
}