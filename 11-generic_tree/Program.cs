namespace GenericTree
{
    class Program
    {
        public static void Main ()
        {
            GenericTree tree = new GenericTree();

            Nodo root = tree.Insertion("root", null);

            tree.Insertion("b", root);
            tree.Insertion("c", root);

            Nodo n = tree.Insertion("d", root);
            tree.Insertion("e", n);

            n = tree.Insertion("f", root);
            tree.Insertion("g", n);

            n = tree.Insertion("h", n);
            tree.Insertion("i", n);
            tree.Insertion("j", n);

            n = tree.Insertion("k", root);
            tree.Insertion("l", n);
            tree.Insertion("m", n);
            tree.Insertion("n", n);

            Console.WriteLine("Transversa Pre Order");
            tree.PreOrderTransverse(root);
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine("Transversa Post Order");
            tree.PostOrderTransverse(root);

            Console.WriteLine();
            string value;
            Console.WriteLine("Ingrese el valor que desea encontrar:");
            value = Console.ReadLine();
            Nodo found = tree.Search(value, root);

            Console.WriteLine();
            if(found == null)
            {
                Console.WriteLine("No se puedo encontrar el nodo");
            }
            else
            {
                Console.WriteLine("Nodo encontrado! = " + found.Data);
            }
        }
    }
}