namespace GenericTree
{
    public class Nodo
    {
        private string? data;
        private Nodo? son;
        private Nodo? brother;

        public string Data { get => this.data; set => this.data = value; }
        public Nodo Son { get => this.son; set => this.son = value; }
        public Nodo Brother { get => this.brother; set => this.brother = value; }

        public Nodo ()
        {
            this.data = "";
            this.son = null;
            this.brother = null;
        }

        public Nodo (string data)
        {
            this.data = data;
            this.son = null;
            this.brother = null;
        }
    }
}