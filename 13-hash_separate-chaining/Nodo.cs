namespace HashSeparateChaining
{
    public class Nodo
    {
        //ATTRIBUTES
        private int key;
        private string? data;
        private Nodo? next;

        public int Key { get => this.key; set => this.key = value; }
        public string? Data { get => this.data; set => this.data = value; }
        public Nodo? Next { get => this.next; set => this.next = value; }

        public Nodo ()
        {
            this.next = null;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", Key, Data);
        }
    }
}