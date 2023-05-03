namespace BinaryTree
{
    public class Nodo
    {
        private int data;
        private Nodo? left;
        private Nodo? right;

        public Nodo ()
        {
            this.data = 0;
            this.left = null;
            this.right = null;
        }

        public Nodo (int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }

        public int Data { get => this.data; set => this.data = value; }
        public Nodo? Left { get => this.left; set => this.left = value; }
        public Nodo? Right { get => this.right; set => this.right = value; }
    }
}