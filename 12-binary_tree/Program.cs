namespace BinaryTree
{
    class Program
    {
        public static void Main ()
        {
            BinaryTree arbolBinario = new BinaryTree();

            Nodo root = arbolBinario.Insertion(10, null);

            arbolBinario.Insertion(3, root);
            arbolBinario.Insertion(23, root);
            arbolBinario.Insertion(6, root);
            arbolBinario.Insertion(8, root);
            arbolBinario.Insertion(32, root);
            arbolBinario.Insertion(1, root);
            arbolBinario.Insertion(89, root);
            arbolBinario.Insertion(2, root);
            arbolBinario.Insertion(1, root);
            arbolBinario.Insertion(78, root);
            arbolBinario.Insertion(11, root);
            arbolBinario.Insertion(18, root);
            
            Console.WriteLine("________________________________________");
            arbolBinario.PreOrderTransverse(root);
            Console.WriteLine("________________________________________");

            Console.WriteLine();
            Nodo max = arbolBinario.MaxValue(root);
            Nodo min = arbolBinario.MinValue(root);
            Console.WriteLine("El valor maximo del arbol es: " + max.Data);
            Console.WriteLine("----");
            Console.WriteLine("El valor minimo del arbol es: " + min.Data);
            Console.WriteLine("----");

            Console.WriteLine("________________________________________");
            arbolBinario.InOrderTransverse(root);
            Console.WriteLine("________________________________________");

            Console.WriteLine();
            int foundValue = 6;
            Nodo rootFound = arbolBinario.FindRoot(foundValue, root);
            Console.WriteLine("El valor del root de " + foundValue + " es: " + rootFound.Data);
            Console.WriteLine("----");

            Console.WriteLine();
            int deleteValue = 32;
            Nodo deleteNodo = arbolBinario.DeleteNodo(deleteValue, root);
            Console.WriteLine("Se elimino el nodo de valor " + deleteValue);
            Console.WriteLine("----");

            Console.WriteLine("________________________________________");
            arbolBinario.PreOrderTransverse(root);
            Console.WriteLine("________________________________________");
        }
    }
}