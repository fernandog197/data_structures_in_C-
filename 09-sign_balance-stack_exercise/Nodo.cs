namespace SingBalance
{
    public class Nodo
    {
        private char data;
        private Nodo next = null;

        public char Data { get => this.data; set => this.data = value; }
        public Nodo Next { get => this.next; set => this.next = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", Data);
        }
    }
}