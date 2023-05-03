namespace BinaryTree
{
    public class BinaryTree
    {
        //---------//ATTRIBUTES//---------//
        private Nodo root;
        private Nodo auxNodo;
        private int i;

        //---------//CONSTRUCTOR//---------//
        public BinaryTree ()
        {
            this.root = new Nodo();
            this.auxNodo = new Nodo();
        }

        //---------//GETTER & SETTER//---------//
        internal Nodo Root { get => this.root; set => this.root = value; }

        //---------//METHODS//---------//
        public Nodo Insertion (int data, Nodo targetNodo)
        {
            Nodo newNodo;

            if(targetNodo == null)
            {
                newNodo = new Nodo(data);

                return newNodo;
            }

            if(data < targetNodo.Data)
            {
                targetNodo.Left = Insertion(data, targetNodo.Left);
            }

            if(data > targetNodo.Data)
            {
                targetNodo.Right = Insertion(data, targetNodo.Right);
            }

            return targetNodo;
        }
 
        public Nodo MaxValue (Nodo targetNodo)
        {
            Nodo maxNodo;

            if(targetNodo.Right == null)
            {
                maxNodo = targetNodo;
                return maxNodo;
            }

            if(targetNodo.Right != null)
            {
                targetNodo = MaxValue(targetNodo.Right);
            }

            return targetNodo;
        }

        public Nodo MinValue (Nodo targetNodo)
        {
            Nodo minNodo;

            if(targetNodo.Left == null)
            {
                minNodo = targetNodo;
                return minNodo;
            }

            if(targetNodo.Left != null)
            {
                this.auxNodo = MinValue(targetNodo.Left);
            }

            return auxNodo;
        }

        public void PreOrderTransverse (Nodo targetNodo)
        {
            if(targetNodo == null)
            {
                return;
            }

            for(int n=0; n<this.i; n++)
            {
                Console.Write("_  ");
            }

            Console.WriteLine(targetNodo.Data);

            if(targetNodo.Left != null)
            {
                i++;
                Console.Write("I ");
                PreOrderTransverse(targetNodo.Left);
                i--;
            }

            if(targetNodo.Right != null)
            {
                i++;
                Console.Write("R ");
                PreOrderTransverse(targetNodo.Right);
                i--;
            }
        }

        public void InOrderTransverse (Nodo targetNodo)
        {
            if(targetNodo == null)
            {
                return;
            }

            if(targetNodo.Left != null)
            {
                i++;
                Console.Write("I ");
                PreOrderTransverse(targetNodo.Left);
                i--;
            }

            for(int n=0; n<this.i; n++)
            {
                Console.Write("_  ");
            }

            Console.WriteLine(targetNodo.Data);

            if(targetNodo.Right != null)
            {
                i++;
                Console.Write("R ");
                PreOrderTransverse(targetNodo.Right);
                i--;
            }
        }

        public Nodo FindRoot (int value, Nodo targetNodo)
        {
            Nodo foundNodo;

            if(targetNodo.Left == null && targetNodo.Right == null)
            {
                foundNodo = null;
                return foundNodo;
            }

            if(value < targetNodo.Data)
            {
                if(value == targetNodo.Left.Data)
                {
                    foundNodo = targetNodo;
                    return foundNodo;
                }
                else
                {
                    this.auxNodo = FindRoot(value, targetNodo.Left);
                }
            }

            if(value > targetNodo.Data)
            {
                if(value == targetNodo.Right.Data)
                {
                    foundNodo = targetNodo;
                    return foundNodo;
                }
                else
                {
                    this.auxNodo = FindRoot(value, targetNodo.Right);
                }
            }

            return this.auxNodo;
        }

        public Nodo DeleteNodo(int value, Nodo targetNodo)
        {
            if (targetNodo == null)
            {
                return targetNodo;
            }

            if (value < targetNodo.Data)
            {
                targetNodo.Left = DeleteNodo(value, targetNodo.Left);
            }
            else if (value > targetNodo.Data)
            {
                targetNodo.Right = DeleteNodo(value, targetNodo.Right);
            }
            else
            {
                if (targetNodo.Left == null && targetNodo.Right == null)
                {
                    targetNodo = null;
                }

                else if (targetNodo.Left == null)
                {
                    targetNodo = targetNodo.Right;
                }

                else if (targetNodo.Right == null)
                {
                    targetNodo = targetNodo.Left;
                }

                else
                {
                    Nodo sucesor = MinValue(targetNodo.Right);
                    targetNodo.Data = sucesor.Data;
                    targetNodo.Right = DeleteNodo(sucesor.Data, targetNodo.Right);
                }
            }

            return targetNodo;
        }
    }
}